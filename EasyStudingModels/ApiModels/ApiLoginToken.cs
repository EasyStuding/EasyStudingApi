using System;
using System.Collections.Generic;
using System.Text;

namespace EasyStudingModels.ApiModels
{
    public class ApiLoginToken
    {
        public long Id { get; set; }

        public string Login { get; set; }

        public string Role { get; set; }

        public string Token { get; set; }
    }
}
