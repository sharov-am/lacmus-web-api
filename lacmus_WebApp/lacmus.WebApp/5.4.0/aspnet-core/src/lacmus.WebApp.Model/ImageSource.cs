using Abp.Domain.Entities;

namespace lacmus.WebApp.Model
{
    public class ImageSource:Entity<long>
    {
        public string Database { get; set; }
    }
}