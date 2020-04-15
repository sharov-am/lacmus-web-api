using Abp.Domain.Entities;

namespace lacmus.WebApp.Model
{
    public class DetectedObject : Entity<long>
    {
     
        public string Name { get; set; }

        public string Pose { get; set; }

        public bool Truncated { get; set; }

        public Difficult Difficult { get; set; }


        public PascalVocBoundingBox BoundingBox { get; set; }


    }
}