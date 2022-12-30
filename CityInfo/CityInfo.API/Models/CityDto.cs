namespace CityInfo.API.Models
{
    public class CityDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public int NumberPointOfInterest
        {
            get
            {
                return PointsOfInterest.Count;
            }
        }

        public ICollection<PointOfInterestDto> PointsOfInterest { get; set;} = new List<PointOfInterestDto>(); // When working with Collection is a good idea to initalize them as empty instead of null

    }
}
