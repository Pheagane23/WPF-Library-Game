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
    /// Interaction logic for OptionsWindow.xaml
    /// </summary>
    public partial class OptionsWindow : Window
    {
        public OptionsWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReplaceBooksWindow replacebooksWindow = new ReplaceBooksWindow();
            replacebooksWindow.Show();
            this.Close();
        }

        private void IdentifyAreaBTN_Click(object sender, RoutedEventArgs e)
        {
            IdentifyAreasWindow identifyAreasWindow = new IdentifyAreasWindow();
            identifyAreasWindow.Show();
            this.Close();
        }

        private void FindingCallNumbersBTN_Click(object sender, RoutedEventArgs e)
        {
            FindingCallNumbersWindow findingCallNumbersWindow = new FindingCallNumbersWindow();
            findingCallNumbersWindow.Show();
            this.Close();
        }
    }
}
