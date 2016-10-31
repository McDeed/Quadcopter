using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9Queadcopters
{
    class QuadcopterIRRF : QuadcopterIR
    {

        new public void select_comm_method()
        {
            if (SNR_IR >= SNR_RF)
            {
                IR = true;
                RF = false;
                Console.WriteLine("Quadcopter IRRF is now using IR communication");
            }
            else
            {
                RF = true;
                IR = false;
                Console.WriteLine("Quadcopter IRRF is now using RF communication");
            }

        }

    }
}
