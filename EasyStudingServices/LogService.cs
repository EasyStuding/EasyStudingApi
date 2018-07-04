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

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot", DateTime.Now.ToString("dd_MM_yy") + "_log.txt");

            File.AppendAllText(path, res + Environment.NewLine);
        }
    }
}
