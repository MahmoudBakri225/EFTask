using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.configuration
{
    internal class TaskEntityTypeConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.Property(t => t.Title).IsRequired();
            builder.ToTable("NewTask");
            builder.Property(t => t.Date).HasColumnName("Deadline");
        }
    }
}
