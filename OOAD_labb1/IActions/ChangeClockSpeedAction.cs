using System;
namespace OOAD_labb1
{
    public class ChangeClockSpeedActioan: IAction
    {
        private Computer pc;
        private int speed;
        private int oldSpeed;


        public ChangeClockSpeedActioan(Computer computer, int newSpeed)
        {
            pc = computer;
            speed = newSpeed;
        }

        public void Execute()
        {
            oldSpeed = pc.ClockSpeed;
            pc.ClockSpeed = speed;
        }

        public void Undo()
        {
            pc.ClockSpeed = oldSpeed;
        }
    }
}
