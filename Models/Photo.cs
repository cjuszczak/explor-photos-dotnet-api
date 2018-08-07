using System;

namespace explorphotosdotnetapi.Models
{
    public class Photo
    {
        public int photoId { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public string fileName { get; set; }
        public string camera { get; set; }
        public string lens { get; set; }
        public DateTime uploaded { get; set; }
    }
}
