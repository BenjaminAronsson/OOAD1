using System;
namespace OOAD_labb1
{
    public class ChangeBrandAction: IAction
    {
        private Computer pc;
        private Computer.ProcessorBrand brand;
        private Computer.ProcessorBrand oldBrand;

        public ChangeBrandAction(Computer computer, Computer.ProcessorBrand newBrand)
        {
            pc = computer;
            brand = newBrand;
        }

        public void Execute()
        {
            oldBrand = pc.Brand;
            pc.Brand = brand;
        }

        public void Undo()
        {
            pc.Brand = oldBrand;
        }
    }
}
