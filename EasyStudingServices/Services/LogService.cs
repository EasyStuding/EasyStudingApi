using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using EasyStudingModels;

namespace EasyStudingServices.Services
{
    public static class LogService
    {
        private static readonly List<string> _notWrittenExceptions
            = new List<string>();
        
        private static object _lock = new object();

        public static void UpdateLogFile(Exception ex)
        {
            var date = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
            var methodPath = ex.TargetSite.DeclaringType.FullName;
            var res = date + " --- " + methodPath + " --- " + ex.Message;

            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
                res += ex.Message;
            }

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           Defines.FileFolders.FolderPathes[Defines.FileFolders.LOGS_FOLDER], DateTime.Now.ToString("dd_MM_yy") + "_log.txt");
            lock (_lock)
            {
                try
                {
                    if (_notWrittenExceptions.Count > 0)
                    {
                        while (_notWrittenExceptions.Count > 0)
                        {
                            File.AppendAllText(path, _notWrittenExceptions.Last() + Environment.NewLine);
                            _notWrittenExceptions.Remove(_notWrittenExceptions.Last());
                        }
                    }

                    File.AppendAllText(path, res + Environment.NewLine);
                }
                catch
                {
                    _notWrittenExceptions.Add(res + Environment.NewLine);
                }
            }
        }
    }
}
