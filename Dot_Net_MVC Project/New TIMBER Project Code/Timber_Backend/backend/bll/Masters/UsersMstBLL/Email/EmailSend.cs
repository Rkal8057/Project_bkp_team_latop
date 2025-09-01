using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
// using System.Net;
// using System.Net.Mail;
using MailKit.Net.Smtp;
using MailKit.Net.Imap;
using MimeKit;
using MailKit.Security;
using DB.Login;
using DB.Login.Tables;
using System.Web;

namespace UsersMstBLL.Email
{
    public class EmailSend
    {

        public static bool SendEmail(string email, string subject, string body, string MsgOtporUrn, System_Records compDetails)
        {

            Console.WriteLine("email checkpoint 1");

            string fromMail = compDetails.comp_email_for_otp;
            string fromPassword = compDetails.comp_otp_email_pass;
            string apiBaseUrl = compDetails.comp_api_baseurl;

            // string fromMail = "shivkms.verify@gmail.com";
            // string fromPassword = "uffw mhxr ptbl zdiz";

            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress(compDetails.company_name, fromMail));
            message.To.Add(new MailboxAddress("Recipient's Name", email)); // Modify this line
            message.To.Add(new MailboxAddress("Recipient's Name", "mukeshsolution@gmail.com")); 
            message.To.Add(new MailboxAddress("Recipient's Name", "sameekshachoudhary333@gmail.com")); // Modify this line
                                                                           // message.To.Add(new MailboxAddress("Recipient's Name", "abhinav@aggarwalabhinav.com")); // Modify this line
                                                                           //message.To.Add(new MailboxAddress("Recipient's Name", "verification@shivkms.com")); // Modify this line

            message.MessageId = Guid.NewGuid().ToString() + "@" + compDetails.comp_email_server;
            message.Subject = subject;

            Console.WriteLine("email checkpoint 2");
            //string otp = GenerateOTP();


            var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "EmailTemplate.html");
            var templateContent = File.ReadAllText(templatePath);
            templateContent = templateContent.Replace("{{Subject}}", subject)
                                         .Replace("{{CurrDate}}", DateTime.Now.ToString("dd/MM/yyyy"))
                                         .Replace("{{MsgOtporUrn}}", MsgOtporUrn)
                                         .Replace("{{EmailMsg}}", body)
                                         .Replace("{{CompLogoUrl}}", apiBaseUrl + compDetails.company_logo)
                                         .Replace("{{CompName}}", compDetails.company_name)
                                         .Replace("{{CompAddress}}", compDetails.company_address)
                                         .Replace("{{CompEmail}}", compDetails.email_sender);

            var bodyBuilder = new BodyBuilder
            {
                HtmlBody = templateContent
            };

            message.Body = bodyBuilder.ToMessageBody();
            //message.IsBodyHtml = true;
            int port = compDetails.comp_email_port ?? 465;


            Console.WriteLine("email checkpoint 3");
            // Set up the SMTP client

            using var client = new SmtpClient();
            client.ServerCertificateValidationCallback = (s, c, h, e) => true;
            client.CheckCertificateRevocation = false;

            if(compDetails.comp_email_security=="TLS")
            {
                client.Connect(compDetails.comp_email_server, port, SecureSocketOptions.StartTls);
            }else{
                client.Connect(compDetails.comp_email_server, port, SecureSocketOptions.SslOnConnect);
            }

            
            client.Authenticate(fromMail, fromPassword);

            try
            {               
                client.Send(message);
                Console.WriteLine("Email sent successfully!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
                return false;
            }

            Console.WriteLine("email checkpoint 4");
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

            // Generate a random 4-digit OTP
            int otpValue = random.Next(1000, 9999);

            // Convert the OTP to a string
            string otp = otpValue.ToString();

            return otp;
        }
    }
}