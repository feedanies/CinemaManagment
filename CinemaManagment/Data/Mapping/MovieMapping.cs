using CinemaManagment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagment.Data.Mapping
{
    public class MovieMapping : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movies");
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Title)
                .IsRequired(true)
                .HasMaxLength(50);

            builder.HasMany(m => m.Tickets)
                .WithOne(t => t.Movie)
                .HasForeignKey(t => t.MovieId);


        }
    }
}
