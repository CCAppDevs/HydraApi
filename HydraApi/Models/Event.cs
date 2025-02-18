using System.Net;

namespace HydraApi.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Description { get; set; }
        public EventType Type { get; set; }
        // ref property for categories
        public int CategoryId { get; set; }
        public DateTime Timestamp { get; set; }
        public string HostAddress { get; set; }
    }
}
