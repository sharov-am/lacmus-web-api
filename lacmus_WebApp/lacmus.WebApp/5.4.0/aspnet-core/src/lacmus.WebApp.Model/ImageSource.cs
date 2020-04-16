using System.Collections.Generic;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace lacmus.WebApp.Model
{
    public class ImageSource:FullAuditedEntity<long>
    {
        public string Database { get; set; }

        public List<ImageAnnotation> LacmusImages { get; set; }
    }
}