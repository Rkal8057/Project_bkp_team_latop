

using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;

namespace Rta.Services.EmailService
{
    public class EmailService
    {
        public static bool SendSingleEmail(string email, string subject, string body)
        {

            try
            {
                string fromMail = "";
                string fromPassword = "";

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(fromMail),
                    Subject = subject,
                    Body = @"<!DOCTYPE html>
                            <html lang=""en"">
                            <head>
                                <meta charset=""UTF-8"">
                                <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
                                <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                                <title>Email Template</title>
                            </head>
                            <body style=""font-family: Arial, sans-serif;"">

                                <div style=""background-color: #f4f4f4; padding: 20px; text-align: center;"">
                                    <h1 style=""color: #333;"">Hello there!</h1>
                                    <p style=""color: #555;"">Thank you for using our service. We appreciate your business.</p>
        
                                    <!-- Your custom content goes here -->
                                    <div style=""margin-top: 20px; padding: 10px; background-color: #ddd;"">
                                        <p>This is a sample email template. You can customize it as needed.</p>
                                    </div>

                                    <p style=""color: #777;"">Best regards,<br/>Your Company</p>
                                </div>

                            </body>
                            </html>
                            ",
                    IsBodyHtml = true, // Set to true if using HTML in the email body
                };

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromMail, fromPassword),
                    EnableSsl = true,
                };

                mailMessage.To.Add(email);

                smtpClient.SendMailAsync(mailMessage);

                return true; // Email sent successfully
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
                return false;   
            }
        }

        public static bool SendMultipleEmail(List<string> emails, string subject, string body)
        {
            try
            {
                string fromMail = "thedotnetchannelsender22@gmail.com";
                string fromPassword = "lgioehkvchemfkrw";

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(fromMail),
                    Subject = subject,
                    Body = $"<html><body>{body}</body></html>",
                    IsBodyHtml = true, // Set to true if using HTML in the email body
                };

                foreach (var email in emails)
                {
                    mailMessage.To.Add(email);
                }

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromMail, fromPassword),
                    EnableSsl = true,
                };

                smtpClient.Send(mailMessage);

                return true; // Email sent successfully
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
                return false; // Email sending failed
            }
        }


    }
}
