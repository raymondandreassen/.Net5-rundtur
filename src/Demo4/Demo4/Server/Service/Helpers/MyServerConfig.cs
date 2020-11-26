using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo4.Server.Service.Helpers
{
    public class MyServerConfig
    {
        public string TheKey{ get; set; }
        public string TheInfo { get; set; }
        public int TheSize { get; set; } = 10000;
        public MyServerDetails Details { get; set; } = new MyServerDetails();
    }

    public class MyServerDetails
    {
        public string Detail1 { get; set; }
        public string Detail2 { get; set; }
    }
}
