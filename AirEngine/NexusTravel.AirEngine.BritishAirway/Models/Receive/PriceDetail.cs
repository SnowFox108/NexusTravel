namespace NexusTravel.AirEngine.BritishAirway.Models.Receive
{
    public class PriceDetail
    {
        public TotalAmount TotalAmount { get; set; }
        public SimpleCurrencyPrice BaseAmount { get; set; }
        public Taxes Taxes { get; set; }
    }
}
