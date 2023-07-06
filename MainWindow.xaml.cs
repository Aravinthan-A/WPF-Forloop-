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

namespace ForLoop
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int ini = Convert.ToInt32(txtini.Text);
            int inc = Convert.ToInt32(txtinc.Text);
            int end = Convert.ToInt32(txtend.Text);
            if (ini > 1000 || inc > 100 || end > 1000)
            {
                MessageBoxResult result = MessageBox.Show("Input Digits are Invalid", "INVALID", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    txtini.Clear();
                    txtinc.Clear();
                    txtend.Clear();
                }
            }


            for (int i = ini; i < end; i= i + inc)
            {
                lblresult.Content = lblresult.Content + "," + i.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int val = Convert.ToInt32(txtval.Text);
            int dec = Convert.ToInt32(txtdec.Text);
            int rec = Convert.ToInt32(txtrec.Text);
            if (val > 1000 || dec > 100 || rec > 100)
            {
                MessageBoxResult result = MessageBox.Show("Input Digits are Invalid", "INVALID", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    txtval.Clear();
                    txtdec.Clear();
                    txtrec.Clear();
                }
            }

                for (int j = val; j > rec; j= j- dec)
                {
                    lblend.Content = lblend.Content + "," + j.ToString();
                }
            }
        }
    }
 
