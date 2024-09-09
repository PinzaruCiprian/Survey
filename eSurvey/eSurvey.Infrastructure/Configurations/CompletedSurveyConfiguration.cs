using eSurvey.Domain.Entities.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eSurvey.Infrastructure.Configurations;

public class CompletedSurveyConfiguration: IEntityTypeConfiguration<CompletedSurveysTable>
{
    public void Configure(EntityTypeBuilder<CompletedSurveysTable> item)
    {
        //Table Name Configuration
        item.ToTable("CompletedSurveysTable");

        //Primary Key Configuration
        item.HasKey(i => i.Id)
            .HasName("CompletedSurvey_Id");

        //Foreign Keys and Relationship Configuration

        //Properties Configuration
        item.Property(i => i.Id)
            .ValueGeneratedOnAdd();

        item.Property(i => i.TemplateId)
            .IsRequired()
            .HasColumnName("Template_Id");
        
        item.Property(i => i.UserIDNP)
            .IsRequired()
            .HasColumnName("User_IDNP");
        
        item.Property(i => i.SurveyJson)
            .IsRequired()
            .HasColumnName("Survey_JsonFormat");
    }
}