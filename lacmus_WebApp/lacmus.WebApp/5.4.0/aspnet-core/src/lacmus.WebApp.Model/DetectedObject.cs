using Abp.Domain.Entities;

namespace lacmus.WebApp.Model
{
    public class DetectedObject : Entity<long>
    {
     
        public string Name { get; set; }

        public string Pose { get; set; }

        public bool Truncated { get; set; }

        public bool IsDifficult { get; set; }

        public PascalVocBoundingBox BoundingBox { get; set; }

        public ImageAnnotation ImageAnnotation { get; set; }

        public long ImageAnnotationId { get; set; }



    }
}