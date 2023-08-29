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
    /// Interaction logic for ReplaceBooksWindow.xaml
    /// </summary>
    public partial class ReplaceBooksWindow : Window
    {
        public ReplaceBooksWindow()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            MainReplaceBookWindow mainReplaceBookWindow = new MainReplaceBookWindow();
            mainReplaceBookWindow.Show();
            this.Close();
        }
    }
}
