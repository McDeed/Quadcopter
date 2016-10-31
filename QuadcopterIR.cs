using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Assignment9Queadcopters
{

    class QuadcopterIR : Random, IQuadcopter
    {
        public bool Bluetooth { get; set; }

        public bool IR { get; set; }

        public bool RF { get; set; }
        
        public float SNR_Bluetooth { get; set; }
 
        public float SNR_RF { get; set; }
        
        public float SNR_IR { get; set; }


        Random rand = new Random(DateTime.Now.Millisecond);

        public void rand_SNR()
        {
            SNR_IR = (float)(rand.Next(20));
            SNR_Bluetooth = (float)(rand.Next(20));
            SNR_RF = (float)(rand.Next(20));
            //throw new NotImplementedException();
        }

        public int[] return_current_coordinates()
        {
            {
                int[] coords = new int[3];
                Random rand = new Random(DateTime.Now.Millisecond);
                for (int i = 0; i < 3; i++)
                {
                    coords[i] = rand.Next(50);
                    
                    
                }


                Console.WriteLine("The coordinates(x,y,z) are {0},{1},{2}", coords[0], coords[1], coords[2]);

                return coords;


            }
            //throw new NotImplementedException();
        }

        public void select_comm_method()
        {
            IR = true;
            Console.WriteLine("Quadcopter IR is now using IR communication");
            //throw new NotImplementedException();
        }
    }
}
