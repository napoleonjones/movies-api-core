using System;
using System.Collections.Generic;
using System.Text;

namespace data.settings
{
    public abstract class BaseCosmosDbSettings
    {
        public string Url { get; set; }

        public string AccountKey { get; set; }

        public string Database { get; set; }

        public BaseCosmosDbSettings()
        {

        }

        public BaseCosmosDbSettings(string url, string accountKey, string database)
        {
            Url = url;
            AccountKey = accountKey;
            Database = database;
        }
    }
}
