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
using System.Windows.Shapes;

namespace LearnWPF_Advanced
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

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"This description is :{tbDescription.Text}");
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            ckbWeld.IsChecked = ckbAssembly.IsChecked = ckbPlasma.IsChecked =
                ckbLaser.IsChecked = ckbPurchase.IsChecked = ckbLathe.IsChecked =
                ckbDrill.IsChecked = ckbFold.IsChecked = ckbRoll.IsChecked = 
                ckbSaw.IsChecked = false;
        }
    }
}
