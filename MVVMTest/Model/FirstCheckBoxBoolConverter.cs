using System;
using System.Globalization;
using System.Windows.Data;

namespace MVVMTest.Model
{
    public class FirstCheckBoxBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var checkBoxValue = (int) value;
            if (checkBoxValue == 0)
                return false;
            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var checkBoxValue = (bool) value;
            if (!checkBoxValue)
                return 0;
            return 1;
        }
    }
}