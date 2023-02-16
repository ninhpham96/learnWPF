using System;
using System.Collections.Generic;
using System.IO;
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

namespace LearnWPF_Advanced.WpfTreeView
{
    /// <summary>
    /// Interaction logic for wpfTreeView.xaml
    /// </summary>
    public partial class wpfTreeView : Window
    {
        public wpfTreeView()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            foreach(var drive in Directory.GetLogicalDrives())
            {                
                var item = new TreeViewItem();
                item.Header = drive;
                
                Folderview.Items.Add(item);
            }
        }
    }
}
