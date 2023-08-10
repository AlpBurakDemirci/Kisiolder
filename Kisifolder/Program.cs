using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Kisifolder
{
 
    public class Program
    {

        public static void Main(string[] args)
        {
            Management management = new Management();
            management.getinput();
        }

    }

}
