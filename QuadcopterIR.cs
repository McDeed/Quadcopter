using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Assignment9Queadcopters
{

    class QuadcopterIR : Quadcopter_Generic
    {
        

        

        public new void select_comm_method()
        {
            IR = true;
            Console.WriteLine("Quadcopter IR is now using IR communication");
        }
    }
}
