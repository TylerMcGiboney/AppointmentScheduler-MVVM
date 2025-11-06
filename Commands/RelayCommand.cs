using System;
using System.Windows.Input;

namespace Appointment_Scheduler.Helpers
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        public RelayCommand(Action<object> execute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        }
        public bool CanExecute(Object e)
        {
            return true;
        }

        public void Execute(Object e)
        {
            _execute(e);
        }

        public event EventHandler CanExecuteChanged;

    }
}
