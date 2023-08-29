using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Library_User_Trainer
{
    /// <summary>
    /// Interaction logic for MainReplaceBookWindow.xaml
    /// </summary>
    public partial class MainReplaceBookWindow : Window
    {
        private DispatcherTimer timer;
        private int m, s;

        private string[] randomArray;
        private string[] sortedRandomArray;
        private string[] userArray;
        public MainReplaceBookWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Tick += Timer_Tick;
            m = 0;
            s = 0;
            timer.Start();

            // Generate random Dewey Decimal System values
            int arraySize = 9; // Adjust the array size as needed
            randomArray = GenerateRandomDeweyDecimalValues(arraySize);

            // Populate the random array ListBox
            foreach (string value in randomArray)
            {
                randomArrayListBox.Items.Add(value);
            }

            // Sort the random array in ascending order
            sortedRandomArray = randomArray.OrderBy(value => value).ToArray();
        }

        private string[] GenerateRandomDeweyDecimalValues(int size)
        {
            Random random = new Random();
            string[] array = new string[size];

            for (int i = 0; i < size; i++)
            {
                int firstThreeDigits = random.Next(0, 1000);
                int middleDigits = random.Next(0, 100);
                string name = GenerateRandomName();
                array[i] = $"{firstThreeDigits:D3}.{middleDigits:D2} {name}";
            }

            return array;
        }

        private string GenerateRandomName()
        {
            Random random = new Random();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] name = new char[3];

            for (int i = 0; i < 3; i++)
            {
                name[i] = alphabet[random.Next(alphabet.Length)];
            }

            return new string(name);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            s = s + 1;
            if (s == 60)
            {
                m = m + 1;
                s = 0;
            }
            if (m == 5)
            {
                m = 0;
                s = 0;
                timer.Stop();
                MessageBox.Show("sorry you ran out of time, please try again later ");
                this.Close();
                OptionsWindow optionsWindow = new OptionsWindow();
                optionsWindow.Show();
            }
            TimeLabel.Content = "Time: " + m + ":" + s;
        }

       

        private void userInputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           

        }

        private void CompareArraysButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(userInputTextBox.Text))
            {
                string[] userInputValues = userInputTextBox.Text.Split();
                userArray = userInputValues;

                bool arraysMatch = CompareArrays(sortedRandomArray, userArray);

                if (arraysMatch)
                {
                    MessageBox.Show("WELL DONE IT IS CORRECT!");
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("sorry it is incorrect please try again later");
                    this.Close();
                    
                    
                }
                OptionsWindow optionsWindow = new OptionsWindow();
                optionsWindow.Show();
                optionsWindow.Show();
            }
            else
            {
                MessageBox.Show("Please enter values.");
                
            }

        }

        private bool CompareArrays(string[] array1, string[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
    }

