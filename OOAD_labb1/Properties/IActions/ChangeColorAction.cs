using System;
namespace OOAD_labb1
{
    public class ChangeColorAction: IAction
    {
        private Computer pc;
        private String color;
        private String oldColor;


        public ChangeColorAction(Computer computer, String newColor)
        {
            pc = computer;
            color = newColor;
        }

        public void Execute()
        {
            oldColor = pc.Color;
            pc.Color = color;
        }

        public void Undo()
        {
            pc.Color = oldColor;
        }
    }
}
