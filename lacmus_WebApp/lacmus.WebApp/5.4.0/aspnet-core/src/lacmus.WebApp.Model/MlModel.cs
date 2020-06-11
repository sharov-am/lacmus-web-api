using Abp.Domain.Entities.Auditing;

namespace lacmus.WebApp.Model
{
    public class MlModel:FullAuditedEntity<int>
    {
        public string Name { get; set; } 
        public MLModelType Type { get; set; }
        public uint Version { get; set; }
        public uint ApiVersion { get; set; }
        
    }
}