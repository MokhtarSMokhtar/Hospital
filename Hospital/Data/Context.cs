using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data
{
    internal class Context:DbContext
    {

        public Context():base(@"Data Source = 192.168.1.110; Initial Catalog = Hosiptal; User ID = Hosiptal; Password=123;Connect Timeout = 30;")
        {

        }
    }
}
