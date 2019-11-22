using System;
namespace OOAD_labb1
{
    public interface IAction
    {
        //String GetName();

        void Execute();

        void Undo();
    }
}
