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
using MailKit.Security;

namespace UsersMstBLL.Email
{
    public class EmailSend
    {
        public static void SendEmail(string email, string subject, string body)
        {

            string fromMail = "shivkms.verify@gmail.com";
            string fromPassword = "uffw mhxr ptbl zdiz";

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("SHIVKMS", fromMail));
            message.To.Add(new MailboxAddress("Recipient's Name", email)); // Modify this line
            message.To.Add(new MailboxAddress("Recipient's Name", "mukeshsolution@gmail.com")); // Modify this line
            // message.To.Add(new MailboxAddress("Recipient's Name", "ceo@shivkms.com")); // Modify this line
            // message.To.Add(new MailboxAddress("Recipient's Name", "verification@shivkms.com")); // Modify this line
            
            message.Subject = subject;

            //Console.WriteLine("subject"+subject);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = $"<html><body><div><h3>{body}</h3><br/><h5 style='color:green'>Thanks for registrating</h5></div></body></html>";
            message.Body = bodyBuilder.ToMessageBody();


            try
            {
                using (var client = new SmtpClient())
                {
                    //client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    //client.EnableSsl = true;
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate(fromMail, fromPassword);
                    //client.Host="localhost";
                    
                    client.Send(message);
                    Console.WriteLine("message SENT");

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
            int otpValue = random.Next(10000, 99999);

            // Convert the OTP to a string
            string otp = otpValue.ToString();

            return otp;
        }
    }
}