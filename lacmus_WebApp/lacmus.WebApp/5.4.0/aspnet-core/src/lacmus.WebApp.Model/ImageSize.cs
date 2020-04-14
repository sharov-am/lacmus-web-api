using Abp.Domain.Entities;

namespace lacmus.WebApp.Model
{
    public class ImageSize : Entity<long>
    {
        public int Width { get; set; }
        
        public int Height { get; set; }
        
        public int Depth { get; set; }
    }
}