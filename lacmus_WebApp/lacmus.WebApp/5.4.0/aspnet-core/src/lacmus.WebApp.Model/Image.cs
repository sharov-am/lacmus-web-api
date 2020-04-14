using System.Collections.Generic;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Values;

namespace lacmus.WebApp.Model
{
    
    public class ImageAnnotation: FullAuditedEntity<long>
    {
        public string FileName { get; set; }
        
        public string Folder { get; set; }
        
        
        public  ImageSize ImageSize { get; set; }

        public int Segmented { get; set; }

        public ImageSource Source { get; set; }

        public PascalVocBoundingBox BoundingBox { get; set; }
    }
}