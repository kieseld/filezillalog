using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilezillaLog.Entities
{
    public class LogEntryEntity
    {
        public string ConnectionId { get; set; }
        public DateTime Date { get; set; }
        public string Username { get; set; }
        public string IpAddress { get; set; }
        public string StatusMessage { get; set; }
    }
}