using System;
using System.Net.Mail;

namespace EasyStudingServices
{
    public class MailService
    {
        private static Tuple<string, string> CREDS =
            new Tuple<string, string>("", "");

        public static void Send(string email, string code)
        {
            try
            {
                var mail = new MailMessage();
                var SmtpServer = new SmtpClient("smtp.mail.ru");

                mail.From = new MailAddress("easy.studing@bk.ru");
                mail.To.Add(email);
                mail.Subject = "Email validation EasyStuding";
                mail.Body = $"EasyStuding code: {code}. Valid for 3 minutes.";

                SmtpServer.Port = 465;
                SmtpServer.Credentials = new System.Net.NetworkCredential(CREDS.Item1, CREDS.Item2);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                LogService.UpdateLogFile(ex);
            }
        }
    }
}
