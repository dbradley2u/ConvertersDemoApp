﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace ConvertersDemoApp.Converters
{
    // DOCS: https://github.com/Windows-XAML/Template10/wiki/Docs-%7C-Converters
    public class DateTimeOffsetConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            try { return new DateTimeOffset((DateTime)value); }
            catch (Exception) { return default(DateTimeOffset); }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            try { return ((DateTimeOffset)value).DateTime; }
            catch (Exception) { return default(DateTime); }
        }
    }
}
