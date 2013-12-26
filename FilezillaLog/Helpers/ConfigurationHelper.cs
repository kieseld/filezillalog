using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace FilezillaLog.Helpers
{
    public class ConfigurationHelper
    {
        public string AppSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }

}