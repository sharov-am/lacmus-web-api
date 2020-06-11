using Abp.Domain.Entities.Auditing;

namespace lacmus.WebApp.Model
{
    public class Tag : FullAuditedEntity<int>
    {
        public string Name { get; set; }
    }
}