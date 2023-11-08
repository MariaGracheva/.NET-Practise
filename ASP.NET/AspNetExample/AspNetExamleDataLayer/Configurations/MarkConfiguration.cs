using AspNetExampleDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetExamleDataLayer.Configurations
{
    public class MarkConfiguration : IEntityTypeConfiguration<Mark>
    {
        public void Configure(EntityTypeBuilder<Mark> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Value)
                .IsRequired();

            builder.HasOne(m => m.Student)
                .WithMany(s => s.Marks);

            builder.HasOne(m => m.Course)
               .WithMany(s => s.Marks);



        }
    }
}
