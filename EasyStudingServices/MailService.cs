using EasyStudingModels;
using EasyStudingRepositories.Extensions;
using System;
using System.Net;
using System.Net.Mail;

namespace EasyStudingServices
{
    public class MailService
    {
        private static Tuple<string, string> Creds =
                    new Tuple<string, string>(Defines.GetDecodedString("YXBpLmVhc3kuc3R1ZGluZ0BnbWFpbC5jb20="),
                        Defines.GetDecodedString("QWRtaW4xMjMh"));

        public static void Send(string email, string code)
        {
            try
            {
                using (var mail = new MailMessage())
                {
                    using (var SmtpServer = new SmtpClient())
                    {
                        mail.From = new MailAddress(Creds.Item1);

                        mail.To.Add(email);

                        mail.Subject = 
                            "EasyStuding - Email validation";

                        mail.Body = 
                            $"EasyStuding code: {code}. Valid for {ValidatorExtension.VALID_MINUTES} minutes.";

                        SmtpServer.Host = "smtp.gmail.com";

                        SmtpServer.Port = 587;

                        SmtpServer.EnableSsl = true;

                        SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;

                        SmtpServer.UseDefaultCredentials = false;

                        SmtpServer.Credentials =
                            new NetworkCredential(Creds.Item1, Creds.Item2);

                        SmtpServer
                            .Send(mail);
                    }
                }
            }
            catch (Exception ex)
            {
                LogService.UpdateLogFile(ex);
            }
        }

        public static void Send(string email, string subject, string body)
        {
            try
            {
                using (var mail = new MailMessage())
                {
                    using (var SmtpServer = new SmtpClient())
                    {
                        mail.From = new MailAddress(Creds.Item1);

                        mail.To.Add(email);

                        mail.Subject = subject;

                        mail.Body = body;

                        SmtpServer.Host = "smtp.gmail.com";

                        SmtpServer.Port = 587;

                        SmtpServer.EnableSsl = true;

                        SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;

                        SmtpServer.UseDefaultCredentials = false;

                        SmtpServer.Credentials =
                            new NetworkCredential(Creds.Item1, Creds.Item2);

                        SmtpServer
                            .Send(mail);
                    }
                }
            }
            catch (Exception ex)
            {
                LogService.UpdateLogFile(ex);
            }
        }
    }
}
