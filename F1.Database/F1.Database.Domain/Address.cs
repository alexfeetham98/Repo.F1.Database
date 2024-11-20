namespace F1.Database.Domain
{
    public class Address
    {
        public string BuildingName { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }

        public Address(string buildingName, string address1, string city, string region, string postCode, string country)
        {
            BuildingName = buildingName;
            Address1 = address1;
            City = city;
            Region = region;
            PostCode = postCode;
            Country = country;
        }
    }
}