using Microsoft.Maui.Controls.Shapes;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CoffeeProductionChart
{
    public class WorldCoffeeProduction : INotifyPropertyChanged
    {
        List<CoffeeProductionModel> productionDetails;
        public List<Brush> PaletteBrushes { get; set; }
        public List<Brush> SelectionBrushes { get; set; }

        private Geometry? pathData = (Geometry?)(new PathGeometryConverter().ConvertFromInvariantString("M19.033094,24.554602L18.945375,24.725663C18.04797,26.319818 15.337325,27.416999 11.950003,27.416999 8.5618632,27.416999 5.8504002,26.319818 4.9527161,24.725663L4.8807955,24.585451 4.767566,24.626094C2.8604491,25.32885 1.9999998,26.196404 2.0000001,26.773913 1.9999998,28.101935 5.8959999,30.031968 12,30.031968 18.104,30.031968 22,28.101935 22,26.773913 22,26.195465 21.138672,25.326975 19.224853,24.623281z M4.0630004,14.226999L4.0109985,15.855997C4.0109982,18.458001 4.780988,20.458001 6.2969811,21.799995 6.5119779,21.988991 6.6349943,22.262001 6.6349943,22.548988L6.6349943,23.549995C6.6349943,24.208 8.653002,25.417 11.950003,25.417 15.245997,25.417 17.262997,24.208 17.262997,23.549995L17.262997,22.548988C17.262997,22.262001 17.386014,21.988991 17.601011,21.799995 18.738762,20.7935 19.455751,19.416876 19.743137,17.693749L19.763206,17.564347 19.758993,17.481C19.758993,17.157375,19.787742,16.841296,19.842474,16.535934L19.876518,16.367511 19.877987,16.336804C19.883989,16.178895,19.886993,16.018622,19.886993,15.855997L19.886993,14.279001z M14.616277,6.6757202E-06C14.632907,-8.2969666E-05 14.649683,0.00072574615 14.666556,0.0024757385 14.942534,0.022475243 15.149517,0.26246643 15.128519,0.53745651L15.025527,1.9304056C14.914536,3.4253511,14.274588,4.9552951,13.355664,5.9232597L11.424822,7.9581857C10.291321,9.1151748,10.121486,11.249301,10.1019,12.142399L10.100493,12.227 13.921638,12.227 13.928682,12.127211C13.987097,11.378923,14.20033,10.198988,14.934648,9.4488695L16.097608,8.2248297C16.524594,7.775815,16.834583,7.0207901,16.887582,6.3037667L16.949579,5.462739C16.970579,5.1867299 17.216571,4.9777231 17.485561,5.0007238 17.761552,5.0217247 17.968545,5.2607327 17.947546,5.5367417L17.885547,6.377769C17.81455,7.3248,17.407564,8.2968318,16.822584,8.9138525L15.654624,10.143893C15.187139,10.621033,14.999931,11.450787,14.935727,12.084618L14.923342,12.227 19.834991,12.227C20.647907,12.226999,21.352325,12.702272,21.684257,13.389934L21.723118,13.475729 21.735502,13.466633C22.355739,13.03485 23.083437,12.785996 23.861002,12.785996 26.123008,12.785996 27.963012,14.891998 27.963012,17.481 27.963012,20.069002 26.123008,22.175004 23.861002,22.175004 23.308,22.175004 22.861,21.727003 22.861,21.175003 22.861,20.623002 23.308,20.175002 23.861002,20.175002 25.020006,20.175002 25.963007,18.967001 25.963007,17.481 25.963007,15.994999 25.020006,14.785998 23.861002,14.785997 22.955532,14.785998 22.181896,15.523913 21.88676,16.555332L21.865143,16.637073 21.863209,16.676694C21.729286,18.951248,21.031666,20.888352,19.815721,22.372836L19.591511,22.632669 19.727821,22.679109C22.486236,23.648098 24,25.096978 24,26.773913 24,30.18897 17.817,32.032001 12,32.032001 6.1829998,32.032001 -2.3841858E-07,30.18897 0,26.773913 -2.3841858E-07,25.098916 1.5109471,23.651973 4.2637339,22.682195L4.3293769,22.659763 4.3224025,22.652432C2.8072641,20.966475,2.0109958,18.637554,2.0109959,15.855997L2.0109959,14.279001C2.0109958,13.146997,2.9319869,12.226999,4.0630004,12.227L9.0993931,12.227 9.0994842,12.20743C9.1093986,11.236683,9.2808726,8.7177205,10.705881,7.2642112L12.630723,5.2352848C13.385661,4.4393139,13.934616,3.1123629,14.027609,1.8554087L14.130601,0.46345901C14.150286,0.20471859,14.366831,0.0013465881,14.616277,6.6757202E-06z"));

        
        public Geometry PathData
        {
            get
            {
                return pathData;
            }
             set
            {
                pathData = value;
            }
        }

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


        private Brush selectionBrush;
        public Brush SelectionBrush
        {
            get
            {
                return selectionBrush;
            }
            set
            {
                selectionBrush = value;

                NotifyPropertyChanged(nameof(SelectionBrush));
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
                SelectionBrush = SelectionBrushes[SelectedIndex];
                UpdateIndex(value);
                NotifyPropertyChanged(nameof(SelectedIndex));
            }
        }

        private double groupTo = 8;
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
                new SolidColorBrush(Color.FromArgb("#5bdffc")),
                new SolidColorBrush(Color.FromArgb("#2fe0d0")),
                new SolidColorBrush(Color.FromArgb("#baf74d")),
                new SolidColorBrush(Color.FromArgb("#f5d949")),
                new SolidColorBrush(Color.FromArgb("#f2464d")),
                new SolidColorBrush(Color.FromArgb("#c86af7"))
            };

            SelectionBrushes = new List<Brush>
            {
                new SolidColorBrush(Color.FromArgb("#00b1d9")),
                new SolidColorBrush(Color.FromArgb("#05b3a2")),

                new SolidColorBrush(Color.FromArgb("#8ccf15")),
                new SolidColorBrush(Color.FromArgb("#d9b709")),
                new SolidColorBrush(Color.FromArgb("#d40b13")),
                new SolidColorBrush(Color.FromArgb("#9e07e3"))
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
