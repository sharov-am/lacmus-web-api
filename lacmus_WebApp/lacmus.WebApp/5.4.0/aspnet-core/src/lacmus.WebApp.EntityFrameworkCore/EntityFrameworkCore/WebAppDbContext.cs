using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using lacmus.WebApp.Authorization.Roles;
using lacmus.WebApp.Authorization.Users;
using lacmus.WebApp.Model;
using lacmus.WebApp.MultiTenancy;

namespace lacmus.WebApp.EntityFrameworkCore
{
    public class WebAppDbContext : AbpZeroDbContext<Tenant, Role, User, WebAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<LacmusImage> LacmusImages { get; set; }

        public DbSet<ImageAnnotation> ImageAnnotations { get; set; }

        public DbSet<LacmusProject> LacmusProjects { get; set; }
       
        public DbSet<ImageSource> ImageSources { get; set; }

        public DbSet<PascalVocBoundingBox> PascalVocBoundingBoxes { get; set; }

        public DbSet<DetectedObject> DetectedObjects { get; set; }


        public WebAppDbContext(DbContextOptions<WebAppDbContext> options)
            : base(options)
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=LA;Username=lacmus_test;Password=asddsa");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LacmusImage>()
                .HasOne<LacmusProject>(img => img.LacmusProject)
                .WithMany(prj => prj.LacmusImages)
                .HasForeignKey(img => img.LacmusProjectId);

            modelBuilder.Entity<LacmusImage>()
                .HasOne<ImageAnnotation>(ann => ann.ImageAnnotation)
                .WithOne(img => img.LacmusImage)
                .HasForeignKey<ImageAnnotation>(ann => ann.LacmusImageId);


            modelBuilder.Entity<ImageAnnotation>()
                .HasOne<ImageSource>(ann => ann.Source)
                .WithMany(src => src.LacmusImages)
                .HasForeignKey(ann=>ann.ImageSourceId);




            modelBuilder.Entity<ImageAnnotation>()
                .HasMany<DetectedObject>(ann => ann.DetectedObjects)
                .WithOne(dobj => dobj.ImageAnnotation)
                .HasForeignKey(dobj => dobj.ImageAnnotationId);


            modelBuilder.Entity<ImageAnnotation>()
                .OwnsOne<ImageSize>(ann => ann.ImageSize);


            modelBuilder.Entity<DetectedObject>()
                .HasOne<PascalVocBoundingBox>(dobj => dobj.BoundingBox)
                .WithOne(bb => bb.DetectedObject)
                .HasForeignKey<PascalVocBoundingBox>(bb => bb.DetectedObjectId);

            
            

        }
    }
}
