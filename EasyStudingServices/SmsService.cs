using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace EasyStudingServices
{
    public class SmsService
    {
        private static readonly string FromNumber = MailService.GetStringFromBase64("KzE1NjEyNTAwNDk1");
        private static readonly string AccountSID = MailService.GetStringFromBase64("QUM3MTU1MzA5MzE4YTk5N2YxNDg3ZDI0YjVhNWE0MjJhNw==");
        private static readonly string AuthToken = MailService.GetStringFromBase64("MTRmZWE1NjViZjgwYWY4YTgzODUyOTJiMDEzMGUzNTc=");

        public static void Send(string telephoneNumber, string code)
        {
            try
            {
                TwilioClient.Init(AccountSID, AuthToken);

                var to = new PhoneNumber(telephoneNumber);
                var message = MessageResource.Create(
                    to,
                    from: new PhoneNumber(FromNumber),
                    body: $"EasyStuding code: {code}. Valid for 3 minutes.");
            }
            catch(Exception ex)
            {
                LogService.UpdateLogFile(ex);
            }
        }

        public static void Send(string telephoneNumber, string subject, string body)
        {
            try
            {
                TwilioClient.Init(AccountSID, AuthToken);

                var to = new PhoneNumber(telephoneNumber);
                var message = MessageResource.Create(
                    to,
                    from: new PhoneNumber(FromNumber),
                    body: subject + Environment.NewLine + body);
            }
            catch (Exception ex)
            {
                LogService.UpdateLogFile(ex);
            }
        }
    }
}
