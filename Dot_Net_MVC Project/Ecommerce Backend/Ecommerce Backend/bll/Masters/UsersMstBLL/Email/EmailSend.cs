using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MailKit.Net.Smtp;
using MailKit.Net.Imap;
using MimeKit;

namespace UsersMstBLL.Email
{
    public class EmailSend
    {
        public static void SendEmail(string email, string subject, string body)
        {

            string fromMail = "verification@shivkms.com";
            string fromPassword = "veri@2928";

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("shivkms", fromMail));
            message.To.Add(new MailboxAddress("Recipient's Name", email)); // Modify this line
            message.Subject = subject;

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = $"<html><body>{body}</body></html>";
            message.Body = bodyBuilder.ToMessageBody();


            try
            {
                using (var client = new SmtpClient())
                {
                    client.Connect("mail.shivkms.com", 465, true);
                    client.Authenticate(fromMail, fromPassword);
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
            }
        }


            public static string GetRandomString(int length)
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
        public static string GenerateOTP()
        {
            // Initialize a Random object
            Random random = new Random();

            // Generate a random 5-digit OTP
            int otpValue = random.Next(10000, 100000);

            // Convert the OTP to a string
            string otp = otpValue.ToString();

            return otp;
        }
    }
}