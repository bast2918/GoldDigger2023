namespace IO
{
    /// <summary>
    /// Holds data from the api response
    /// </summary>
    public class ClassApiResponse
    {
        public int id { get; set; }
        public string metalName { get; set; }
        public decimal priceDkkPerKg { get; set; }
        public decimal priceEurPerKg { get; set; }
        public decimal priceUsdPerKg { get; set; }
    }
}
