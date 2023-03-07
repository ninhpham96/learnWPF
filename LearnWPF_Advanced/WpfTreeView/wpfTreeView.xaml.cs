using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

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

            foreach (string drive in Directory.GetLogicalDrives())
            {
                TreeViewItem item = new TreeViewItem();

                item.Header = drive;
                item.Tag = drive;

                item.Items.Add(null);

                item.Expanded += Folder_Expanded;

                Folderview.Items.Add(item);
            }
        }

        private void Folder_Expanded(object sender, RoutedEventArgs e)
        {
            var item = (TreeViewItem)sender;

            if (item.Items.Count != 1 || item.Items[0] != null)
                return;
            item.Items.Clear();

            var fullpath = (string)item.Tag;
            #region get folder
            var directories = new List<string>();

            try
            {
                var dirs = Directory.GetDirectories(fullpath);
                if (dirs.Length > 0)
                {
                    directories.AddRange(dirs);
                }
            }
            catch { }

            directories.ForEach(
                directorypath =>
                {
                    var subitem = new TreeViewItem();
                    subitem.Header = GetFileFolderName(directorypath);
                    subitem.Tag = directorypath;

                    subitem.Items.Add(null);
                    subitem.Expanded += Folder_Expanded;
                    item.Items.Add(subitem);
                }
                );
            #endregion

            #region get file
            var files = new List<string>();

            try
            {
                var fs = Directory.GetDirectories(fullpath);
                if (fs.Length > 0)
                {
                    files.AddRange(fs);
                }
            }
            catch { }

            directories.ForEach(
                filepath =>
                {
                    var subitem = new TreeViewItem();
                    subitem.Header = GetFileFolderName(filepath);
                    subitem.Tag = filepath;

                    subitem.Items.Add(null);
                    subitem.Expanded += Folder_Expanded;
                    item.Items.Add(subitem);
                }
                );
            #endregion
        }

        private static string GetFileFolderName(string directorypath)
        {
            if (string.IsNullOrEmpty(directorypath))
                return string.Empty;
            var normalPath = directorypath.Replace('/', '\\');
            var lastindex = normalPath.LastIndexOf('\\');
            if (lastindex <= 0)
                return directorypath;
            return directorypath.Substring(lastindex + 1);
        }
    }
}
