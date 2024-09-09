using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using eSurvey.Domain.Entities.Tables;

namespace eSurvey.Infrastructure.Configurations
{
    public class SurveyTemplateConfiguration : IEntityTypeConfiguration<SurveyTemplatesTable>
     {
          public void Configure(EntityTypeBuilder<SurveyTemplatesTable> item)
          {
               //Table Name Configuration
               item.ToTable("SurveyTemplatesTable");

               //Primary Key Configuration
               item.HasKey(i => i.Id)
                    .HasName("SurveyTemplate_Id");

               //Foreign Keys and Relationship Configuration
               item.HasMany(c => c.CompletedSurveys)
                    .WithOne()
                    .HasForeignKey(c => c.TemplateId);
               
               //Properties Configuration
               item.Property(i => i.Id)
                    .ValueGeneratedOnAdd();

               item.Property(i => i.TemplateJson)
                    .IsRequired()
                    .HasColumnName("Survey_JsonFormat");
          }
     }
}