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

namespace ristinolla
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

        string currentPlayer = "X";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mark(btn0);
        }

        private void Mark(Button btn)
        {
            if (btn.Content == null)
            {
                btn.Content = currentPlayer;
                if (currentPlayer == "X")
                {
                    currentPlayer = "O";
                }
                else
                {
                    currentPlayer = "X";
                }
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Mark(btn1);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Mark(btn2);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Mark(btn3);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Mark(btn4);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            Mark(btn5);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            Mark(btn6);
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            Mark(btn7);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            Mark(btn8);
        }
    }
}
