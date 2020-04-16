using System.Collections.Generic;
using Abp.Domain.Entities.Auditing;

namespace lacmus.WebApp.Model
{
    public class LacmusProject: FullAuditedEntity<long>
    {
        public string Description { get; set; }

        public List<LacmusImage> LacmusImages { get; set; }
    }
}