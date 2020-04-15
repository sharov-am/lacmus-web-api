using System.Collections.Generic;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Values;

namespace lacmus.WebApp.Model
{
    //https://towardsdatascience.com/coco-data-format-for-object-detection-a4c5eaf518c5
    //https://github.com/balezz/lacmus_storage/tree/master/src/main/kotlin/ru/balezz/model
    public class ImageAnnotation: FullAuditedEntity<long>
    {
        public string FileName { get; set; }
        
        public string Folder { get; set; }
        
        
        public  ImageSize ImageSize { get; set; }

        public int Segmented { get; set; }

        public ImageSource Source { get; set; }


        public List<DetectedObject> DetectedObjects { get; set; }
        
    }
}