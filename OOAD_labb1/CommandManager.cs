using System;
using System.Collections;
using System.Collections.Generic;

namespace OOAD_labb1
{
    public class CommandManager
    {
        private Stack<IAction> queueStackNormal;
        private Stack<IAction> queueStackReverse;

        private List<IChannel> channels;

        private static readonly CommandManager instance = new CommandManager();

        public static CommandManager GetInstance()
        {
            return instance;
        }

        private CommandManager()
        {
            queueStackNormal = new Stack<IAction>();
            queueStackReverse = new Stack<IAction>();
            channels = new List<IChannel>();
        }

        //interface
        public void Execute(List<IAction> actionList)
        {
            foreach (var action in actionList)
            {
                action.Execute();
                queueStackNormal.Push(action);
                alertObservers();
            }    
        }

        public void AddObserver(IChannel channel)
        {
            channels.Add(channel);
        }

        public void Undo()
        {
            if (queueStackNormal.Count == 0)
                return;
            IAction action = queueStackNormal.Pop();
            action.Undo();
            queueStackReverse.Push(action);

            alertObservers();
        }

        public void Redo()
        {
            if (queueStackReverse.Count == 0)
                return;
            IAction action = queueStackReverse.Pop();
            action.Execute();
            queueStackNormal.Push(action);

            alertObservers();
        }

        private void alertObservers()
        {
            foreach (var channel in channels)
            {
                channel.Update();
            }
        }
    }
}
