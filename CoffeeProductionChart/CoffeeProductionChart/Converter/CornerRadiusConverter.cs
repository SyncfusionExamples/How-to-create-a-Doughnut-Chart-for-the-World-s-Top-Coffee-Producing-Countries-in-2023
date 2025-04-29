using Microsoft.Maui.Controls.PlatformConfiguration;
using System.Globalization;

namespace CoffeeProductionChart
{
    public class CornerRadiusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
#if ANDROID || IOS

                return new CornerRadius((double)value );
#elif WINDOWS || MACCATALYST
                return new CornerRadius((double)value / 2);

#endif
            }

            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }

    public class LegendItem : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           if(value != null)
            {
                CoffeeProductionModel model = value as CoffeeProductionModel;
                
                if (model == null)
                {
                    return "Others";
                }
                else
                {
                    return model.Country.ToString();
                }
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
