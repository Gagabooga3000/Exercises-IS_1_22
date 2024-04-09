using System;
using System.Threading;

namespace Exercise1
{
    class Program
    {
        static void Main( string[] args )
        {
            Fueltank tank = new Fueltank(10000);
            Console.WriteLine("Amount:" + tank.GetAmount());
            tank.Fill(3200);
            Console.WriteLine("Amount:" + tank.GetAmount());
            tank.Fill(5000);
            Console.WriteLine("Amount:" + tank.GetAmount());


            Engine eng = new Engine();
            Console.WriteLine( "State: " + eng.GetState() );
            Console.WriteLine();

            eng.Start();
            Console.WriteLine( "State: " + eng.GetState() );
            Thread.Sleep( 2000 );
            Console.WriteLine();

            eng.Stop();
            Console.WriteLine( "State: " + eng.GetState() );

            Console.ReadKey();
        }
    }
}
