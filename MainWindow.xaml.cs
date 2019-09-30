using Adani.common.HelpModWPF.WinApi;
using System.Windows;
using System.Windows.Input;


namespace Adani.common.HelpModWPF
{
    public partial class MainWindow : Window
    {

        private HotKey _hotkey;
        OpentHelp OpentHelp;
        string application;

        public MainWindow()
        {
            InitializeComponent();
            //DataContext = new MainWiindowViewModel();
            //var OpentHelp = new OpentHelp();

            _hotkey = new HotKey(ModifierKeys.None | ModifierKeys.None, Keys.F1, this);
            _hotkey.HotKeyPressed += (k) => { OpentHelp = new OpentPDFNameddestHelp(); OpentHelp.OpenFileHelp(); application= OpentHelp.HelpClient.HelpClient(); };
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(application);
            //System.IO.File.Create("D:\\"+ application + ".txt");
        }



    }


}
