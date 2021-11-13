using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace CursoXamarin.Converters {
	public class IsOutofConverter : IValueConverter {
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
			var isOutof = (bool)value;
			return isOutof ? "Out of !" : "Available";
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
			var cadena = (string)value;
			if (cadena.Equals("Out of !"))
				return true;
			return false;
		}
	}
}
