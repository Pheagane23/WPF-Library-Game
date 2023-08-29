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
using System.Windows.Shapes;

namespace Library_User_Trainer
{
    /// <summary>
    /// Interaction logic for FindingCallNumbersWindow.xaml
    /// </summary>
    public partial class FindingCallNumbersWindow : Window
    {
        public FindingCallNumbersWindow()
        {
            InitializeComponent();
        }

        private void Optionsbtn_Click(object sender, RoutedEventArgs e)
        {
            OptionsWindow optionsWindow = new OptionsWindow();
            optionsWindow.Show();
            this.Close();
        }
    }
}
