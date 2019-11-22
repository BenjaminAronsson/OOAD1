using System;
namespace OOAD_labb1
{
    public class ChangeGpuAction: IAction
    {
        private Computer pc;
        private String gpu;
        private String oldGpu;


        public ChangeGpuAction(Computer computer, String gpu)
        {
            pc = computer;
            this.gpu = gpu;
        }

        public void Execute()
        {
            oldGpu = pc.GPU;
            pc.GPU = gpu;
        }

        public void Undo()
        {
            pc.GPU = oldGpu;
        }
    }
}
