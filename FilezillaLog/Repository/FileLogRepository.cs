using FilezillaLog.Entities;
using FilezillaLog.Helpers;
using FilezillaLog.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FilezillaLog.Repository
{
    public class FileLogRepository : IFileLogService
    {
        ConfigurationHelper config = new ConfigurationHelper();
        public IEnumerable<LogEntryEntity> GetAllLogEntries()
        {
            IList<LogEntryEntity> logs = new List<LogEntryEntity>();

            string path = config.AppSetting("logPath");

            foreach (string file in Directory.GetFiles(path))
            {
                foreach (string line in File.ReadLines(file))
                {
                    string[] delimiters = {"(", ") ", " - ", ")> "};
                    string[] s = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    if (s.Length > 1)
                    {
                        string[] date = s[1].Split(new string[] { "/", ":", " " }, StringSplitOptions.RemoveEmptyEntries);
                        logs.Add(new LogEntryEntity
                        {
                            ConnectionId = s[0],
                            Date = new DateTime(
                                int.Parse(date[2]),
                                int.Parse(date[0]),
                                int.Parse(date[1]),
                                int.Parse(date[3]),
                                int.Parse(date[4]),
                                int.Parse(date[5])),
                            IpAddress = s[3],
                            Username = s[2],
                            StatusMessage = s[4]
                        });
                    }
                }
            }

            return logs;
        }
    }
}