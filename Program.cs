using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;

namespace Assignment9Queadcopters
{
    class Program
    {
       





        static void Main(string[] args)
        {
            QuadcopterIRRFBluetooth Quad = new QuadcopterIRRFBluetooth();
            QuadcopterIRRF Quad1 = new QuadcopterIRRF();
            QuadcopterIR Quad2 = new QuadcopterIR();
            QuadcopterRF Quad3 = new QuadcopterRF();
            while (true)
            {
                Quad.rand_SNR();
                Console.WriteLine("{0}",Quad.GetType().Name);
                Quad.return_current_coordinates();
                Quad.select_comm_method();
                Thread.Sleep(3);


                Quad1.rand_SNR();
                Console.WriteLine("\n{0}", Quad1.GetType().Name);
                Quad1.return_current_coordinates();
                Quad1.select_comm_method();

                Thread.Sleep(3);

                Quad2.rand_SNR();
                Console.WriteLine("\n{0}", Quad2.GetType().Name);
                Quad2.return_current_coordinates();
                Quad2.select_comm_method();
                Thread.Sleep(3);


                Quad3.rand_SNR();
                Console.WriteLine("\n{0}", Quad3.GetType().Name);
                Quad3.return_current_coordinates();
                Quad3.select_comm_method();
                Thread.Sleep(3);




                Thread.Sleep(500);
                Console.Clear();

            }



        }
    }
}
