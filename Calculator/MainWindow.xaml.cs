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
        double numOne, NumTwo, solution;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumbBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

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
                solution = numOne / NumTwo;
            }
            else if (operators == "multiply")
            {
                solution = numOne * NumTwo;
            }
            else if (operators == "subtract")
            {
                solution = numOne - NumTwo;
            }
            else if (operators == "add")
            {
                solution = numOne + NumTwo;
            }

            string finish = solution.ToString();
            OutputTextBlock.Text = finish;
        }
    }
}
