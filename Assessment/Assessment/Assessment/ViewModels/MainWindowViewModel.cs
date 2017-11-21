using Assessment.ViewsModels;
using System.Windows.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Assessment.Commands;
using UserInterface;

namespace Assessment.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public string ButtonForm { get; private set; }
        public ICommand ButtonFormCommand { get; private set; }

        public MainWindowViewModel()
        {
            ButtonForm = "I want to send a message";
            ButtonFormCommand = new RelayCommand(BFormClick);
        }

        private void BFormClick()
        {
           Form1 f = new Form1();
           f.Show();
           
        }
    }
}
