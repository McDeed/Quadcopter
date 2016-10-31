using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9Queadcopters
{
    class QuadcopterRF : Quadcopter_Generic
    {
        

        public new void select_comm_method()
        {
            RF = true;
            Console.WriteLine("Quadcopter RF is now using RF communication");
        }

    }
}
