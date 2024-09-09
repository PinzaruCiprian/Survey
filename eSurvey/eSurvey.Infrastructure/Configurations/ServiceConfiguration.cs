using eSurvey.Domain.Entities.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace eSurvey.Infrastructure.Configurations
{
     public class ServiceConfiguration : IEntityTypeConfiguration<ServiceTable>
     {
          public void Configure(EntityTypeBuilder<ServiceTable> item)
          {
               //Table Name Configuration
               item.ToTable("ServiceTable");

               //Primary Key Configuration
               item.HasKey(i => i.Id)
                    .HasName("Service_Id");

               //Foreign Keys and Relationship Configuration
               item.HasMany(c => c.Templates)
                    .WithOne()
                    .HasForeignKey(c => c.ServiceId);

               //Properties Configuration
               item.Property(i => i.Id)
                    .ValueGeneratedOnAdd();
          }
     }
}