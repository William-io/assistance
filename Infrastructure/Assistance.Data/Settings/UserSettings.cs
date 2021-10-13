using Assistance.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assistance.Data.Settings
{
    public class UserSettings : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(120).HasColumnType("varchar(120)").IsRequired();
            builder.Property(x => x.LastName).HasColumnType("varchar(120)").IsRequired();
            builder.Property(x => x.Age);
            builder.Property(x => x.Email).HasColumnType("varchar(120)").IsRequired();
            builder.Property(x => x.Cpf).HasColumnType("varchar(20)").IsRequired();
            builder.Property(x => x.Password).HasColumnType("varchar(8)").IsRequired();
            builder.Property(x => x.City).HasColumnType("varchar(40)");
            builder.Property(x => x.State).HasColumnType("varchar(10)");
            builder.Property(x => x.Genre).HasColumnType("varchar(10)");
            builder.Property(x => x.Description).HasColumnType("varchar(120)").IsRequired();
            builder.Property(x => x.Date);


            builder.HasData(new User
            {   Id = 1,         
                Name = "William",
                LastName = "Vilela",
                Age = 34,
                Email = "capuletos@live.com",
                Cpf = "05505505511",
                Password = "1010",
                City = "Fortaleza",
                State = "CE",
                Genre = "Masculino",
                Description = "Dor na cabeça",
                Date = DateTime.Now
            });


        }
    }
}
