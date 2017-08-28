using System;
using System.Windows.Input;

namespace PrivateData
{
    public class RelayCommands : ICommand
    {
        private Action _Action;

        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public RelayCommands(Action action)
        {
            _Action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _Action();
        }


    }
}
