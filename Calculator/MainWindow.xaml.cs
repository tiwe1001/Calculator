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

namespace Calculator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string output = "";
        string operators = "";
        double numOne, NumTwo;

        public MainWindow()
        {
            InitializeComponent();

            DivideBtn.Content = "\u00F7";
        }

        private void NumbBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            if (output.Length < 16)
            {

                switch (name)
                {
                    case "OneBtn":
                        output += "1";
                        OutputTextBlock.Text = output;
                        break;
                    case "TwoBtn":
                        output += "2";
                        OutputTextBlock.Text = output;
                        break;
                    case "ThreeBtn":
                        output += "3";
                        OutputTextBlock.Text = output;
                        break;
                    case "FourBtn":
                        output += "4";
                        OutputTextBlock.Text = output;
                        break;
                    case "FiveBtn":
                        output += "5";
                        OutputTextBlock.Text = output;
                        break;
                    case "SixBtn":
                        output += "6";
                        OutputTextBlock.Text = output;
                        break;
                    case "SevenBtn":
                        output += "7";
                        OutputTextBlock.Text = output;
                        break;
                    case "EightBtn":
                        output += "8";
                        OutputTextBlock.Text = output;
                        break;
                    case "NineBtn":
                        output += "9";
                        OutputTextBlock.Text = output;
                        break;
                    case "ZeroBtn":
                        output += "0";
                        OutputTextBlock.Text = output;
                        break;
                    case "dotBtn":
                        if (output.Contains(","))
                        {
                            break;
                        }
                        else
                        {
                            output += ",";
                            OutputTextBlock.Text = output;
                            break;
                        }
                    case "ClearBtn":
                        if (output.Length > 0)
                        {
                            output = output.Substring(0, output.Length - 1);
                            OutputTextBlock.Text = output;
                        }
                        break;
                }
            }
        }

        private void OperationBtn_Click(object sender, RoutedEventArgs e)
        {

                numOne = Double.Parse(output);
                output = "";
                string name = ((Button)sender).Name;
                

                switch (name)
                {
                    case "DivideBtn":
                        operators = "divide";
                        OutputTextBlock.Text = "/";
                        break;
                    case "MultiplyBtn":
                        operators = "multiply";
                        OutputTextBlock.Text = "*";
                        break;
                    case "SubtractBtn":
                        operators = "subtract";
                        OutputTextBlock.Text = "-";
                        break;
                    case "AddBtn":
                        operators = "add";
                        OutputTextBlock.Text = "+";
                        break;
                }
        }

        private void SolutionBtn_Click(object sender, RoutedEventArgs e)
        {
            NumTwo = Double.Parse(output);

            if (operators == "divide")
            {
                numOne = numOne / NumTwo;
                output = numOne.ToString();
            }
            else if (operators == "multiply")
            {
                numOne = numOne * NumTwo;
                output = numOne.ToString();
            }
            else if (operators == "subtract")
            {
                numOne = numOne - NumTwo;
                output = numOne.ToString();
            }
            else if (operators == "add")
            {
                numOne = numOne + NumTwo;
                output = numOne.ToString();
            }

            OutputTextBlock.Text = output;
        }

        private void ClearAllBtn_Click(object sender, RoutedEventArgs e)
        {
            numOne = 0;
            NumTwo = 0;
            output = "";
            operators = "";
            OutputTextBlock.Text = "0";
        }
    }
}
