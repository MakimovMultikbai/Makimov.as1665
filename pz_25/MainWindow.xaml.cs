using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
using System.Text.RegularExpressions;

namespace pz_25
{
    public partial class MainWindow : Window
    {
        private readonly List<double> nums = new List<double>(10);

        private const string FindNumsMask = "\\d+";

        private const string FindOperationsMask = "[-+/*]";

        public MainWindow()
        {
            InitializeComponent();
        }

        double a, b;
        
        double result;
        private int indexOpertations;
        private bool isFirst = true;

        private void Press7Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "7";
        }

        private void Press8Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "8";
        }

        private void Press9Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "9";
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "+";
            
        }

        private void Press4Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "4";
        }

        private void Press5Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "5";
        }

        private void Press6Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "6";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "-";
            
        }

        private void Press1Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "1";
        }

        private void Press2Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "2";
        }

        private void Press3Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "3";
        }

        private void Umnojit_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "*";
            
        }

        private void Null_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "0";
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            string expression = inputTextBlock.Text;

            inputTextBlock.Text = GetResultCalculated(expression).ToString();
        }

        private void share_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "/";
            
        }

        private double GetResultCalculated(string expression)
        {
            Regex regexNums = new Regex(FindNumsMask);

            Regex regexOperations = new Regex(FindOperationsMask);

            MatchCollection matchesNums = regexNums.Matches(expression);

            MatchCollection matchesOperations = regexOperations.Matches(expression);

            double result = 0;

            double tempFristValue = 0;

            foreach (var i in matchesNums)
            {
                nums.Add(double.Parse(i.ToString()));
            }

            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (isFirst)
                {
                    tempFristValue = nums[i];

                    isFirst = false;
                }

                var tempSecondValue = nums[i + 1];

                var operations = matchesOperations[indexOpertations].ToString();

                result = Calcualated(result, tempFristValue, tempSecondValue, operations);

                tempFristValue = result;

                indexOpertations++;
            }

            return result;
        }

        private static double Calcualated(double result, double tempFristValue, double tempSecondValue, string operations)
        {
            switch (operations)
            {
                case "-":
                    result = tempFristValue - tempSecondValue;
                    break;
                case "+":
                    result = tempFristValue + tempSecondValue;
                    break;
                case "*":
                    result = tempFristValue * tempSecondValue;
                    break;
                case "/":
                    result = tempFristValue / tempSecondValue;
                    break;
            }
            return result;
        }
    }
}