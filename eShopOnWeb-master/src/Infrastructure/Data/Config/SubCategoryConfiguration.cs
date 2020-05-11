using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.eShopWeb.ApplicationCore.Entities;

namespace Microsoft.eShopWeb.Infrastructure.Data.Config
{
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasKey(ci => ci.Id);

            builder.Property(ci => ci.Id)
               .UseHiLo("sub_category_hilo")
               .IsRequired();
            
            builder.Property(cb => cb.Title)
           .IsRequired();

            builder.Property(cb => cb.Summary)
                .IsRequired()
                .HasMaxLength(300);
        }
    }
}
