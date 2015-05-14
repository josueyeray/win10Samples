namespace Win10InkCanvas.ViewModels.Base
{
    using System;
    using System.Windows.Input;

    /// <summary>
    /// Delegate command implementation.
    /// </summary>
    public class DelegateCommand : ICommand
    {
        private Action execute;
        private Func<bool> canExecute;

        /// <summary>
        /// Constructor without canExecute.
        /// </summary>
        /// <param name="execute"></param>
        public DelegateCommand(Action execute) : this(execute, null)
        {
        }

        /// <summary>
        /// Constructor with execute and canExecute
        /// </summary>
        /// <param name="execute"></param>
        /// <param name="canExecute"></param>
        public DelegateCommand(Action execute, Func<bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// Reports can execute conditions has changed.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Execute Can Execute code.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            if (this.canExecute != null)
                return this.canExecute();

            return true;
        }

        /// <summary>
        /// Execute command action.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            this.execute();
        }
    }
}
