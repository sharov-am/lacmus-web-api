using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace lacmus.WebApp.Model
{
    public class LacmusImage : FullAuditedEntity<long>
    {
        public string FileName { get; set; }

        public string Hash { get; set; }

        public ImageAnnotation ImageAnnotation { get; set; }

        public override long? CreatorUserId { get; set; }
        
        [ForeignKey(nameof(SurveySessionId))]
        public SurveySession SurveySession { get; set; }
        public int SurveySessionId { get; set; }

        public Device Device { get; set; }
    }
}