using Abp.Domain.Entities;

namespace lacmus.WebApp.Model
{
    public class PascalVocBoundingBox : Entity<long>
    {
        public int XMin { get; set; }
        
        public int YMin { get; set; }
        
        public int XMax { get; set; }
        
        public int YMax { get; set; }

        public DetectedObject DetectedObject { get; set; }
        
        public long DetectedObjectId { get; set; }

    }
}