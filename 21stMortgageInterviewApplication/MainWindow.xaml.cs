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
using System.Diagnostics;

namespace _21stMortgageInterviewApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ReadWriteTB_TextChanged(object sender, RoutedEventArgs e)
        {
            ReadOnlyTB.Text = ReadWriteTB.Text;

        }

        private void largestValueButton(object sender, RoutedEventArgs e)
        {
            
            string[] input = ReadOnlyTB.Text.Split(',');


            int[] intArray = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                intArray[i] = int.Parse(input[i]);
            }

            Array.Sort(intArray);
            var maxNum = intArray[intArray.Length - 1];

            if (maxNum > 0)
            {
                //For testing, set fontsize/font diffrent for green
                ResultTB.FontFamily = new FontFamily("Comic Sans MS");
                ResultTB.FontSize = 24;
                colorResultTB.Background = Brushes.Green;
                colorResultTB.Text = "Green";
                ResultTB.Text = maxNum.ToString();
            }
            else if(maxNum < 0)
            {
                colorResultTB.Background = Brushes.Red;
                colorResultTB.Text = "Red";
                ResultTB.FontFamily = new FontFamily("Arial");
                ResultTB.FontSize = 16;
                ResultTB.Text = maxNum.ToString();
            }

            else
            {
                colorResultTB.Foreground = Brushes.Black;
                colorResultTB.Text = "0";
                ResultTB.Text = maxNum.ToString();
            }
            
            
        }


        private void sumOfOddButton(object sender, RoutedEventArgs e)
        {
            var sum = 0;
            string[] input = ReadOnlyTB.Text.Split(',');
            int[] intArray = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                intArray[i] = int.Parse(input[i]);
            }

            for (int j = 0; j < intArray.Length; j++)
            {
                if (Math.Abs(intArray[j]) % 2 == 1)
                {
                    
                    sum += intArray[j];
                }

            }

            if (sum > 0)
            {
                ResultTB.FontFamily = new FontFamily("Comic Sans MS");
                ResultTB.FontSize = 24;
                colorResultTB.Background = Brushes.Green;
                colorResultTB.Text = "Green";
                ResultTB.Text = sum.ToString();
            }
            else if (sum < 0)
            {
                colorResultTB.Background = Brushes.Red;
                colorResultTB.Text = "Red";
                ResultTB.FontFamily = new FontFamily("Arial");
                ResultTB.FontSize = 16;
                ResultTB.Text = sum.ToString();
            }

            else
            {
                colorResultTB.Foreground = Brushes.Black;
                colorResultTB.Text = "0";
                ResultTB.Text = sum.ToString();
            }
        }

        private void sumOfEvenButton(object sender, RoutedEventArgs e)
        {
            var sum = 0;
            string[] input = ReadOnlyTB.Text.Split(',');
            int[] intArray = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                intArray[i] = int.Parse(input[i]);
            }
            
            for (int j = 0; j < intArray.Length; j++)
            {
                if (intArray[j] % 2 == 0)
                {
                    
                    sum += intArray[j];
                }

            }

            if (sum > 0)
            {
                ResultTB.FontFamily = new FontFamily("Comic Sans MS");
                ResultTB.FontSize = 24;
                colorResultTB.Background = Brushes.Green;
                colorResultTB.Text = "Green";
                ResultTB.Text = sum.ToString();
            }
            else if (sum < 0)
            {
                colorResultTB.Background = Brushes.Red;
                colorResultTB.Text = "Red";
                ResultTB.FontFamily = new FontFamily("Arial");
                ResultTB.FontSize = 16;
                ResultTB.Text = sum.ToString();
            }

            else
            {
                colorResultTB.Foreground = Brushes.Black;
                colorResultTB.Text = "0";
                ResultTB.Text = sum.ToString();
            }
        }

        private void colorResultTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }


}
