using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace EasyStudingServices
{
    public static class LogService
    {
        public static void UpdateLogFile(Exception ex)
        {
            var date = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
            var res = date + " --- " + ex.Message;

            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
                res += ex.Message;
            }

            File.AppendAllText("log.txt", res);
        }
    }
}
