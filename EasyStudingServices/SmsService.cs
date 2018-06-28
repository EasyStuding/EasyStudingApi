using System;
using System.Collections.Generic;
using System.Text;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace EasyStudingServices
{
    public class SmsService
    {
        private const string FROM_NUMBER = "+15612500495";
        private const string ACCOUNT_SID = "AC7155309318a997f1487d24b5a5a422a7";
        private const string AUTH_TOKEN = "14fea565bf80af8a8385292b0130e357";

        public static void Send(string telephoneNumber, string code)
        {
            try
            {
                TwilioClient.Init(ACCOUNT_SID, AUTH_TOKEN);

                var to = new PhoneNumber(telephoneNumber);
                var message = MessageResource.Create(
                    to,
                    from: new PhoneNumber(FROM_NUMBER),
                    body: $"EasyStuding code: {code}. Valid for 3 minutes.");
            }
            catch(Exception ex)
            {
                LogService.UpdateLogFile(ex);
            }
        }
    }
}
