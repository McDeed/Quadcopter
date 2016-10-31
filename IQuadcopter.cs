using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9Queadcopters
{
    interface IQuadcopter
    {
        float SNR_Bluetooth{ get; set; }
        float SNR_RF{ get; set; }
        float SNR_IR { get; set; }
        bool IR{ get; set; }
        bool Bluetooth{ get; set; }
        bool RF { get; set; }
        
        void rand_SNR();
        void select_comm_method();
        int[] return_current_coordinates();

    }

}

