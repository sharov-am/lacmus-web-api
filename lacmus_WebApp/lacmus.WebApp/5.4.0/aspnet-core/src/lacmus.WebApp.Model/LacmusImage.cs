using Abp.Domain.Entities.Auditing;

namespace lacmus.WebApp.Model
{
    public class LacmusImage : FullAuditedEntity<long>
    {
        public string FileName { get; set; }

        private string Hash { get; set; }

        private ImageAnnotation Annotation { get; set; }

    }
}