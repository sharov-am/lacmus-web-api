using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using JetBrains.Annotations;

namespace lacmus.WebApp.Model
{
    public class SurveySession : FullAuditedEntity<long>
    {
        public string Description { get; set; }

        public List<LacmusImage> LacmusImages { get; set; }
        
        //[ForeignKey(nameof(DeviceId))]
        public List<Device> Device { get; set; }
        //public int? DeviceId { get; set; }
    }
}