﻿using FilezillaLog.Entities;
using FilezillaLog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FilezillaLog.Controllers.API_Controllers
{
    public class LogController : ApiController
    {
        FileLogService logService = new FileLogService();
        // GET api/log
        public IEnumerable<LogEntryEntity> Get(string beginDate, string endDate)
        {
            DateTime begin = DateTime.Parse(beginDate);
            DateTime end = DateTime.Parse(endDate);
            return logService.GetAllLogEntries().Where(a => a.Date >= begin && a.Date <= end);
        }

        public IEnumerable<LogEntryEntity> Get()
        {
            return logService.GetAllLogEntries();
        }

        // GET api/log/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/log
        public void Post([FromBody]string value)
        {
        }

        // PUT api/log/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/log/5
        public void Delete(int id)
        {
        }
    }
}
