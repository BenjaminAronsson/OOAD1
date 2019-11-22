using System;
namespace OOAD_labb1
{
    public class ChangeRamAction: IAction
    {
        private Computer pc;
        private int ram;
        private int oldRam;


        public ChangeRamAction(Computer computer, int ram)
        {
            pc = computer;
            this.ram = ram;
        }

        public void Execute()
        {
            oldRam = pc.RAMSize;
            pc.RAMSize = ram;
        }

        public void Undo()
        {
            pc.RAMSize = oldRam;
        }
    }
}
