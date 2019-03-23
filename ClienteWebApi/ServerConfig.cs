using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteWebApi
{
    public class ServerConfig
    {
        public MongoDbConfig MongoDB { get; set; } = new MongoDbConfig();
    }
}
