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

namespace wpfcalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string strX = "", strY = "", op = "";
        double x, y;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ClickNum1(object sender, RoutedEventArgs e)
        {

            Button b = (Button)sender;
            textbox.Text += b.Content.ToString();

            if (textbox.Text.Contains("+") || textbox.Text.Contains("-") || textbox.Text.Contains("*") || textbox.Text.Contains("/") || textbox.Text.Contains("%"))
            {
                strY += b.Content.ToString();
            }
            else
            {
                strX += b.Content.ToString();
            }
        }

        public void ClickOp(object sender, RoutedEventArgs e)
        {

            Button o = (Button)sender;
            textbox.Text += o.Content.ToString();
            op = o.Content.ToString();
        }

        public void ClickEqual(object sender, RoutedEventArgs e)
        {
            Button q = (Button)sender;
            textbox.Text += q.Content.ToString();
            Result();
        }
        public void Clear(object sender, RoutedEventArgs e)
        {
            textbox.Text = "";
            strX = "";
            strY = "";
        }

        public void Result()
        {
            x = Convert.ToDouble(strX);
            y = Convert.ToDouble(strY);
            switch (op)
            {
                case "+":
                    double add = Addition(x, y);
                    textbox.Text += add.ToString();
                    break;
                case "-":
                    double sub = Subtraction(x, y);
                    textbox.Text += sub.ToString();
                    break;
                case "*":
                    double times = Multiplication(x, y);
                    textbox.Text += times.ToString();
                    break;
                case "/":
                    double divide = Division(x, y);
                    textbox.Text += divide.ToString();
                    break;
                case "%":
                    double mod = Modulo(x, y);
                    textbox.Text += mod.ToString();
                    break;
                default:
                    Console.WriteLine("This is not an operator! Please try again.");
                    break;
            }
        }


        public static double Addition(double a, double b)
        {
            return a + b;
        }
        public static double Subtraction(double a, double b)
        {
            return a - b;
        }

        public static double Division(double a, double b)
        {
            return a / b;
        }
        public static double Multiplication(double a, double b)
        {
            return a * b;
        }
        public static double Modulo(double a, double b)
        {
            return a % b;
        }
    }
}


