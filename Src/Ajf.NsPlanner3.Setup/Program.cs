using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JCI.ITC.MsiBuilder;

namespace Ajf.NsPlanner3.Setup
{
    class Program
    {
        static void Main(string[] args)
        {
            new MsiBuilder().BuildMsi();
        }
    }
}
