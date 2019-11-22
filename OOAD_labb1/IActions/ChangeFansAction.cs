using System;
namespace OOAD_labb1
{
    public class ChangeFansAction: IAction
    {
        private Computer pc;
        private int fans;
        private int oldFans;


        public ChangeFansAction(Computer computer, int newFans)
        {
            pc = computer;
            fans = newFans;
        }

        public void Execute()
        {
            oldFans = pc.NumberOfFans;
            pc.NumberOfFans = fans;
        }

        public void Undo()
        {
            pc.NumberOfFans = oldFans;
        }
    }
}
