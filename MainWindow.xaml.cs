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

namespace hometest1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double zero = 0;
        double one = 1;
        double two = 2;
        double three = 3;
        double four = 4;
        double five = 5;
        double six = 6;
        double seven = 7;
        double eight = 8;
        double nine = 9;
        char select;
        double part1;
        double part2;
        double answer;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            ScreenText.AppendText(""+one);
        }

        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            ScreenText.AppendText("" + two);
        }

        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            ScreenText.AppendText("" + three);
        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            ScreenText.AppendText("" + four);
        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            ScreenText.AppendText("" + five);
        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            ScreenText.AppendText("" + six);
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            ScreenText.AppendText("" + seven);
        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            ScreenText.AppendText("" + eight);
        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            part1 = Convert.ToDouble(ScreenText.Text);
            ScreenText.AppendText("" + nine);
        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            part1 = Convert.ToDouble(ScreenText.Text);
            ScreenText.AppendText("" + zero);
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            part1 = Convert.ToDouble(ScreenText.Text);
            select = '+';
            ScreenText.Clear();
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            part1 = Convert.ToDouble(ScreenText.Text);
            select = '-';
            ScreenText.Clear();
        }

        private void timesButton_Click(object sender, RoutedEventArgs e)
        {
            part1 = Convert.ToDouble(ScreenText.Text);
            select = '*';
            ScreenText.Clear();
        }

        private void divButton_Click(object sender, RoutedEventArgs e)
        {
            part1 = Convert.ToDouble(ScreenText.Text);
            select = '/';
            ScreenText.Clear();
        }

        private void equalsButton_Click(object sender, RoutedEventArgs e)
        {
            part2 = Convert.ToDouble(ScreenText.Text);
            ScreenText.Clear();
            switch(select)
            {
                case '+':
                    answer = part1 + part2;
                    ScreenText.Text = ""+answer;
                    break;
                case '-':
                    answer = part1 - part2;
                    ScreenText.Text = "" + answer;
                    break;
                case '/':
                    answer = part1 / part2;
                    ScreenText.Text = "" + answer;
                    break;
                case '*':
                    answer = part1 * part2;
                    ScreenText.Text = "" + answer;
                    break;
            }
        }
    }
}
