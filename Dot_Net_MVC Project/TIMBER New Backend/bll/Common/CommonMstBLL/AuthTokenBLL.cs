using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using DB.Login;
using DB.Login.Tables;
using RTA.Common.Models;
//using Newtonsoft.Json;
using System.Text.Json;

namespace RTA.Common
{
    public class AuthTokenBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public AuthTokenBLL(string _DBConnStr)
        {
            DBConnStr=_DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public void DeleteToken(long user_code)
        {
            List<Auth_Token> tokens = DB.Auth_Token.Where(x => x.user_code == user_code).ToList();
            foreach(var x in tokens)
            {
                DB.Auth_Token.Remove(x);
            }
            DB.SaveChanges();
        }

        private void DeleteExpiredTokens()
        {
            DateTime expiredDTTM = System.DateTime.Now.AddDays(-1); 
            List<Auth_Token> tokens = DB.Auth_Token.Where(x => x.creation_dttm<expiredDTTM).ToList();
            foreach(var x in tokens)
            {
                DB.Auth_Token.Remove(x);
            }
            DB.SaveChanges();
        }

        private string GetRandomString(int length)
        {
            string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string s = "";
            using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
            {
                while (s.Length != length)
                {
                    byte[] oneByte = new byte[1];
                    provider.GetBytes(oneByte);
                    char character = (char)oneByte[0];
                    if (valid.Contains(character))
                    {
                        s += character;
                    }
                }
            }
            return s;
        }

        public ModelAuthToken GenerateToken(ModelAuth Auth_token_data_raw)
        {
            ModelAuthToken token = new ModelAuthToken();

            DeleteToken(Auth_token_data_raw.User.user_code);

            Auth_Token at = new Auth_Token()
            {
                crypto_key = GetRandomString(24),
                user_code =Auth_token_data_raw.User.user_code,
                creation_dttm = System.DateTime.Now
            };
            DB.Auth_Token.Add(at);
            DB.SaveChanges();
            token.token_id = at.id;
            Console.WriteLine("model auth token" + JsonSerializer.Serialize(Auth_token_data_raw));
            
            token.token_data=Common.CryptoEngine.Encrypt(JsonSerializer.Serialize(Auth_token_data_raw), at.crypto_key);
             Console.WriteLine("token" + token);
            return token;
        }

        public ModelAuth VerifyToken(ModelAuthToken token)
        {
            ModelAuth modelAuth = new ModelAuth();    

            DeleteExpiredTokens();
            var AuthToken=DB.Auth_Token.Where(x=>x.id==token.token_id).FirstOrDefault();
            if(AuthToken==null)
            {
                modelAuth.status = false;
                throw new Exception("Invalid Token"); 
            }

            string jsonStr = Common.CryptoEngine.Decrypt(token.token_data,AuthToken.crypto_key);
            modelAuth = JsonSerializer.Deserialize<ModelAuth>(jsonStr);
            return modelAuth;
        }
        
    }
}