using System;
namespace OOAD_labb1
{
    public class ChangeStorageAction: IAction
    {
        private Computer pc;
        private int storage;
        private int oldStorage;


        public ChangeStorageAction(Computer computer, int storage)
        {
            pc = computer;
            this.storage = storage;
        }

        public void Execute()
        {
            oldStorage = pc.diskStorage;
            pc.diskStorage = storage;
        }

        public void Undo()
        {
            pc.diskStorage = oldStorage;
        }
    }
}
