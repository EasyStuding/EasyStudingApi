using EasyStudingModels;
using EasyStudingRepositories.Extensions;
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace EasyStudingServices
{
    public class SmsService
    {
        public static void Send(string telephoneNumber, string code)
        {
            try
            {
                TwilioClient.Init(AppSettings.TwilioAccountSID, AppSettings.TwilioAuthToken);

                var to = new PhoneNumber(telephoneNumber);
                var message = MessageResource.Create(
                    to,
                    from: new PhoneNumber(AppSettings.TwilioFromNumber),
                    body: $"EasyStuding code: {code}. Valid for {ValidatorExtension.VALID_MINUTES} minutes.");
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
                TwilioClient.Init(AppSettings.TwilioAccountSID, AppSettings.TwilioAuthToken);

                var to = new PhoneNumber(telephoneNumber);
                var message = MessageResource.Create(
                    to,
                    from: new PhoneNumber(AppSettings.TwilioFromNumber),
                    body: subject + Environment.NewLine + body);
            }
            catch (Exception ex)
            {
                LogService.UpdateLogFile(ex);
            }
        }
    }
}
