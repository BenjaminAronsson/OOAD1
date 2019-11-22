using System;
namespace OOAD_labb1
{
    public class Display : IChannel
    {

        private static readonly Display instance = new Display();

        public Computer Pc { get; set; }

        public static Display GetInstance()
        {
            return instance;
        }

        private Display()
        {

        }

        public void DisplayMyPc()
        {
            Console.WriteLine(Pc);
        }

        public void Update()
        {
            DisplayMyPc();
        }

        public void DisplayMenu()
        {
            Console.WriteLine("1. Show my pc");
            Console.WriteLine("2. Change gpu");
            Console.WriteLine("3. Change color");
            Console.WriteLine("4. Change cooler");
            Console.WriteLine("5. Redo");
            Console.WriteLine("6. Undo");
            Console.WriteLine("7. exit");

        }
    }
}
