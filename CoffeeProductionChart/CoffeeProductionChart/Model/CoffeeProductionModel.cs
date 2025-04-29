namespace CoffeeProductionChart
{
    public class CoffeeProductionModel
    {
        public string Country { get; set; }
        public double Production { get; set; }
        public double MarketShare { get; set; }
        public double Index { get; set; }

        public CoffeeProductionModel(double index, string country, double production, double marketShare)
        {
            Index = index;
            Country = country;
            Production = production;
            MarketShare = marketShare;
        }
    }
}
