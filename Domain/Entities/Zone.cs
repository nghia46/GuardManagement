using Domain.Enums;

namespace Domain.Entities
{
    public class Zone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public ZoneStatus Status { get; set; }
    }
}
