using FilezillaLog.Entities;
using FilezillaLog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilezillaLog.Services
{
    public class FileLogService
    {
        FileLogRepository repo = new FileLogRepository();
        public IEnumerable<LogEntryEntity> GetAllLogEntries()
        {
            return repo.GetAllLogEntries();
        }
    }
}