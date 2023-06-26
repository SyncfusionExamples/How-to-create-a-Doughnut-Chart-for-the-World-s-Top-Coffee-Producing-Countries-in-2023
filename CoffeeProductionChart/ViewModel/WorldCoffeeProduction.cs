using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CoffeeProductionChart
{
    public class WorldCoffeeProduction : INotifyPropertyChanged
    {
        List<CoffeeProductionModel> productionDetails;
        public List<Brush> PaletteBrushes { get; set; }

        public List<CoffeeProductionModel> ProductionDetails
        {
            get
            {
                return productionDetails;
            }
            set
            {
                productionDetails = value;
                NotifyPropertyChanged(nameof(ProductionDetails));
            }
        }

        private string country;
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
                NotifyPropertyChanged(nameof(Country));
            }
        }

        private double production;
        public double Production
        {
            get
            {
                return production;
            }
            set
            {
                production = value;
                NotifyPropertyChanged(nameof(Production));
            }
        }

        private double percentage;
        public double Percentage
        {
            get
            {
                return percentage;
            }
            set
            {
                percentage = value;
                NotifyPropertyChanged(nameof(Percentage));
            }

        }

        private int selectedIndex = 0;
        public int SelectedIndex
        {
            get
            {
                return selectedIndex;
            }
            set
            {
                selectedIndex = value;
                UpdateIndex(value);
                NotifyPropertyChanged(nameof(SelectedIndex));
            }
        }

        private double groupTo = 7;
        public double GroupTo
        {
            get { return groupTo; }
            set { groupTo = value; }
        }

        public WorldCoffeeProduction()
        {
            ProductionDetails = new List<CoffeeProductionModel>(ReadCSV());
            PaletteBrushes = new List<Brush>
            {
                new SolidColorBrush(Color.FromArgb("#02daf7")),
                new SolidColorBrush(Color.FromArgb("#8ebf24")),
                new SolidColorBrush(Color.FromArgb("#60789b")),
                new SolidColorBrush(Color.FromArgb("#E14A4A")),
                new SolidColorBrush(Color.FromArgb("#f48945")),
                new SolidColorBrush(Color.FromArgb("#91979E"))
            };
        }

        public IEnumerable<CoffeeProductionModel> ReadCSV()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream("CoffeeProductionChart.Resources.Raw.coffeproductionbycountry.csv");

            string? line;
            List<string> lines = new List<string>();

            using StreamReader reader = new StreamReader(inputStream);
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }

            return lines.Select(line =>
            {
                string[] data = line.Split(',');
                return new CoffeeProductionModel(Convert.ToDouble(data[0]), data[1], Convert.ToDouble(data[2]), Convert.ToDouble(data[3]));
            });
        }

        private void UpdateIndex(int value)
        {
            if (value >= 0 && value < ProductionDetails.Count)
            {
                var model = ProductionDetails[value];
                if (model != null && model.Country != null)
                {
                    if (model.Production < GroupTo)
                    {
                        Production = 0;
                        Percentage = 0;
                        Country = "";
                        foreach (var item in productionDetails)
                        {
                            if (GroupTo > item.Production)
                            {
                                Country = "Others";
                                Production += item.Production;
                                Percentage += item.MarketShare;
                            }
                        }
                    }
                    else
                    {
                        Country = model.Country;
                        Production = model.Production;
                        Percentage = model.MarketShare;
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
