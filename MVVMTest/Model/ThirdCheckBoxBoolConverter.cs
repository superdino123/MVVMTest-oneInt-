using System;
using System.Globalization;
using System.Windows.Data;

namespace MVVMTest.Model
{
    public class ThirdCheckBoxBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var checkBoxValue = (int) value;
            if (checkBoxValue == 1)
                return false;
            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var checkBoxValue = (bool) value;
            if (!checkBoxValue)
                return 1;
            return 0;
        }
    }
}