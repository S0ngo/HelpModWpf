using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using Adani.common.HelpModWPF.WinApi;
using System.Linq;

namespace Adani.common.HelpModWPF
{
    internal class MainWiindowViewModel : INotifyPropertyChanged
    {
        private string _baseDirectory;
        public event PropertyChangedEventHandler PropertyChanged;
        private HotKey _hotkey;
        
        public MainWiindowViewModel()
        {
            var MainWindow = new Window();
            //var StartHelp  = new StartHelp();

            //BaseDirectory = StartHelp.ReadProgrammName();
            _hotkey = new HotKey(ModifierKeys.None | ModifierKeys.None, Keys.F1, MainWindow);
            _hotkey.HotKeyPressed += (k) => _baseDirectory = "фтагн";
            
        }

        public string BaseDirectory
        {
            get { return _baseDirectory; }
            set { _baseDirectory = value;
                OnNotifyP(this, new PropertyChangedEventArgs(nameof(BaseDirectory)));
            }
        }

        private void OnNotifyP(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(sender, e);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("фтагн");
        }

    }
}
