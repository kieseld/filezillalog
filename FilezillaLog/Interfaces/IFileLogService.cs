using FilezillaLog.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilezillaLog.Interfaces
{
    public interface IFileLogService
    {
        IEnumerable<LogEntryEntity> GetAllLogEntries();
    }
}
