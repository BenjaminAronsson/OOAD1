
using System;
using System.Collections.Generic;

namespace OOAD_labb1
{
    class MainClass
    {
        private static Computer myPc;

        public static void Main(string[] args)
        {
            Computer.Builder builder = new Computer.Builder();

             myPc = builder.WithBrand(Computer.ProcessorBrand.INTEL)
                .WithGpu("GTX2080")
                .WithClockSpeed(4400)
                .WithColor("green")
                .WithNumberOfFans(4)
                .WithRam(16)
                .Build();

            CommandManager manager = CommandManager.GetInstance();

            List<IAction> actionList = new List<IAction>();

            Display myDisplay = Display.GetInstance();
            myDisplay.Pc = myPc;

            //add observer
            manager.AddObserver(myDisplay);

            //test
            actionList.Add(new ChangeColorAction(myPc, "yellow"));
            actionList.Add(new ChangeColorAction(myPc, "red"));
            actionList.Add(new ChangeBrandAction(myPc, Computer.ProcessorBrand.AMD));
            actionList.Add(new ChangeGpuAction(myPc, "1080TI"));
            manager.Execute(actionList);
            Console.Clear();


            Console.WriteLine("this is my pc");
            Console.WriteLine(myPc);

            do
            {
                myDisplay.DisplayMenu();

                string input = Console.ReadLine();
                Console.WriteLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine(myPc);
                        break;
                    case "2":
                        Console.WriteLine("what is your new gpu name");
                        string gpu = Console.ReadLine();
                        actionList.Add(new ChangeGpuAction(myPc, gpu));
                        manager.Execute(actionList);
                        break;
                    case "3":
                        Console.WriteLine("what is your new color");
                        string color = Console.ReadLine();
                        actionList.Add(new ChangeColorAction(myPc, color));
                        manager.Execute(actionList);
                        break;
                    case "4":
                        Console.WriteLine("what is your new cooler name");
                        string cooler = Console.ReadLine();
                        actionList.Add(new ChangeCoolerAction(myPc, cooler));
                        manager.Execute(actionList);
                        break;
                    case "5":
                        manager.Redo();
                        break;
                    case "6":
                        manager.Undo();
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        break;
                }
                input = null;

            } while (true);

        
            
        }

        
    }
}
