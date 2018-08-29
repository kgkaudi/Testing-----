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

namespace Testing_____
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

        private void addition_Click(object sender, RoutedEventArgs e)
        {
            double num1, num2, result;
            try
            {
                num1 = double.Parse(number1.Text);
                num2 = double.Parse(number2.Text);
                result = num1 + num2;
                Result.Text = result.ToString();
            }
            catch
            {
                if(number1.Text == "")
                {
                    Result.Text = "Please enter number 1";
                }

                if (number2.Text == "")
                {
                    Result.Text = "Please enter number 2";
                }

                if ((number2.Text == "")&& (number1.Text == ""))
                {
                    Result.Text = "Please enter numbers";
                }
            }
        }

        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1, num2, result;
                num1 = double.Parse(number1.Text);
                num2 = double.Parse(number2.Text);
                result = num1 - num2;
                Result.Text = result.ToString();
            }
            catch
            {
                if (number1.Text == "")
                {
                    Result.Text = "Please enter number 1";
                }

                if (number2.Text == "")
                {
                    Result.Text = "Please enter number 2";
                }

                if ((number2.Text == "") && (number1.Text == ""))
                {
                    Result.Text = "Please enter numbers";
                }
            }
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1, num2, result;
                num1 = double.Parse(number1.Text);
                num2 = double.Parse(number2.Text);
                result = num1 * num2;
                Result.Text = result.ToString();
            }
            catch
            {
                if (number1.Text == "")
                {
                    Result.Text = "Please enter number 1";
                }

                if (number2.Text == "")
                {
                    Result.Text = "Please enter number 2";
                }

                if ((number2.Text == "") && (number1.Text == ""))
                {
                    Result.Text = "Please enter numbers";
                }
            }
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1, num2, result;
                num1 = double.Parse(number1.Text);
                num2 = double.Parse(number2.Text);
                result = num1 / num2;
                Result.Text = result.ToString();
            }
            catch
            {
                if (number1.Text == "")
                {
                    Result.Text = "Please enter number 1";
                }

                if (number2.Text == "")
                {
                    Result.Text = "Please enter number 2";
                }

                if ((number2.Text == "") && (number1.Text == ""))
                {
                    Result.Text = "Please enter numbers";
                }
            }
        }

        private void Remainer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1, num2, result;
                num1 = double.Parse(number1.Text);
                num2 = double.Parse(number2.Text);
                result = num1 % num2;
                Result.Text = result.ToString();
            }
            catch
            {
                if (number1.Text == "")
                {
                    Result.Text = "Please enter number 1";
                }

                if (number2.Text == "")
                {
                    Result.Text = "Please enter number 2";
                }

                if ((number2.Text == "") && (number1.Text == ""))
                {
                    Result.Text = "Please enter numbers";
                }
            }
        }

        private void Sin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1, result;
                num1 = double.Parse(number1.Text);
                double Deg = Math.PI / 180;
                double sin = Math.Round(Math.Sin(num1 * Deg), 4);
                result = sin;
                Result.Text = result.ToString();
            }
            catch
            {
                if (number1.Text == "")
                {
                    Result.Text = "Please enter number 1";
                }

                if (number2.Text == "")
                {
                    Result.Text = "Please enter number 2";
                }

                if ((number2.Text == "") && (number1.Text == ""))
                {
                    Result.Text = "Please enter numbers";
                }
            }
        }

        private void Cos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1, result;
                num1 = double.Parse(number1.Text);
                double Deg = Math.PI / 180;
                double cos = Math.Round(Math.Cos(num1 * Deg), 4);
                result = cos;
                Result.Text = result.ToString();
            }
            catch
            {
                if (number1.Text == "")
                {
                    Result.Text = "Please enter number 1";
                }

                if (number2.Text == "")
                {
                    Result.Text = "Please enter number 2";
                }

                if ((number2.Text == "") && (number1.Text == ""))
                {
                    Result.Text = "Please enter numbers";
                }
            }
        }

        private void Power2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1, num2, result;
                num1 = double.Parse(number1.Text);
                num2 = double.Parse(number2.Text);
                result = Math.Pow(num1, num2); ;
                Result.Text = result.ToString();
            }
            catch
            {
                if (number1.Text == "")
                {
                    Result.Text = "Please enter number 1";
                }

                if (number2.Text == "")
                {
                    Result.Text = "Please enter number 2";
                }

                if ((number2.Text == "") && (number1.Text == ""))
                {
                    Result.Text = "Please enter numbers";
                }
            }
        }

        private void RootSquare_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1, num2, result;
                num1 = double.Parse(number1.Text);
                num2 = double.Parse(number2.Text);
                result = Math.Pow(num1, 1.0 / num2); ;
                Result.Text = result.ToString();
            }
            catch
            {
                if (number1.Text == "")
                {
                    Result.Text = "Please enter number 1";
                }

                if (number2.Text == "")
                {
                    Result.Text = "Please enter number 2";
                }

                if ((number2.Text == "") && (number1.Text == ""))
                {
                    Result.Text = "Please enter numbers";
                }
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            number1.Text = "";
            number2.Text = "";
            Result.Text = "";
        }

        private void Absolute_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1, result;
                num1 = double.Parse(number1.Text);
                result = Math.Abs(num1); ;
                Result.Text = result.ToString();
            }
            catch
            {
                if (number1.Text == "")
                {
                    Result.Text = "Please enter number 1";
                }

                if (number2.Text == "")
                {
                    Result.Text = "Please enter number 2";
                }

                if ((number2.Text == "") && (number1.Text == ""))
                {
                    Result.Text = "Please enter numbers";
                }
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
