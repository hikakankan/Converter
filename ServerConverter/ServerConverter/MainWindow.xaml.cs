using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ServerConverter
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            conversions.Add(@"C:\furuta\repository\TransLiner\TransLinerTS\TransLiner\TLPage.js", @"C:\furuta\repository\TransLiner\TransLinerTS\TransLiner\TLPageServer.js");
            conversions.Add(@"C:\furuta\repository\TransLiner\TransLinerTS\TransLiner\TLRootPage.js", @"C:\furuta\repository\TransLiner\TransLinerTS\TransLiner\TLRootPageServer.js");
            conversions.Add(@"C:\furuta\repository\TransLiner\TransLinerTS\TransLiner\TLPageSettings.js", @"C:\furuta\repository\TransLiner\TransLinerTS\TransLiner\TLPageSettingsServer.js");
        }

        private Conversions conversions = new Conversions();

        private void buttonConvert_Click(object sender, RoutedEventArgs e)
        {
            conversions.Convert();
            System.Windows.MessageBox.Show("終了");
        }
    }
}
