using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace LearnWPF_Advanced.WpfTreeView
{
    [ValueConversion(typeof(string),typeof(BitmapImage))]
    class HeaderToImageConverter : IValueConverter
    {
        public static HeaderToImageConverter Instance = new HeaderToImageConverter();
        public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var path = (string)value;
            if (path == null)
                return null;

            var name = wpfTreeView.GetFileFolderName(path);
            string image = "file.png";
            if (string.IsNullOrEmpty(name))
                image = "folder.png";
            else if (new FileInfo(name).Attributes.HasFlag(FileAttributes.Directory))
                image = "folder.png";

            return new BitmapImage(new Uri($"C:\\Users\\phamn\\source\\repos\\learnWPF\\LearnWPF_Advanced\\images\\{image}"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
