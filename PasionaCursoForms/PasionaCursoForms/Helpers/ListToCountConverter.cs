using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace PasionaCursoForms.Helpers
{
    public class ListToCountConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var list = value as IEnumerable<object>;
                if (list != null)
                {
                    return "Total de resultados: " + list.ToList().Count;
                }
                return "Sin resultados";
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
