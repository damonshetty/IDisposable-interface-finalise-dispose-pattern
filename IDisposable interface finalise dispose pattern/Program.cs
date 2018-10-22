using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposable_interface_finalise_dispose_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class cls1 : IDisposable
    {
        ~cls1()
        {

        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
