using System.Windows.Input;

namespace ASC.UI.Helpers
{
    public class RelayCommand : ICommand
    {
        private readonly Action execute;

        public event EventHandler? CanExecuteChanged;

        public RelayCommand(Action execute)
        {
            this.execute = execute;
        }


        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object? parameter)
        {
            this.execute();
        }
    }
}
