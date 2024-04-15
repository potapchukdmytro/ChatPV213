using Microsoft.EntityFrameworkCore;
using Server.Entities;

namespace Server
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("workstation id=ChatPV213.mssql.somee.com;packet size=4096;user id=sweetdie_SQLLogin_2;pwd=q1fmmrgev5;data source=ChatPV213.mssql.somee.com;persist security info=False;initial catalog=ChatPV213;TrustServerCertificate=True");
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ChatEntity> Chats { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChatEntity>()
                .HasMany(c => c.Users)
                .WithMany(c => c.Chats);
        }
    }

}
