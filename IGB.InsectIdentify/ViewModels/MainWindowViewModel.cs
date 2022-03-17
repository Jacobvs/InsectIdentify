using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ReactiveUI;

namespace IGB.InsectIdentify.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to InsectIdentify!";
        
        public MainWindowViewModel()
        {
            DemoButtonCommand = ReactiveCommand.Create(() =>
            {
                // Code here will be executed when the button is clicked.
            });
        }

        public ICommand DemoButtonCommand { get; }
    }
}