using System;
namespace OOAD_labb1
{
    public class ChangeCoolerAction: IAction
    {
        private Computer pc;
        private String cooler;
        private String oldCooler;


        public ChangeCoolerAction(Computer computer, String newCooler)
        {
            pc = computer;
            cooler = newCooler;
        }

        public void Execute()
        {
            oldCooler = pc.CpuCooler;
            pc.CpuCooler = cooler;
        }

        public void Undo()
        {
            pc.CpuCooler = oldCooler;
        }
    }
}
