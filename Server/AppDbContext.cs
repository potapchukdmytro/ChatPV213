using Microsoft.EntityFrameworkCore;

namespace Server
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("workstation id=ChatPV213.mssql.somee.com;packet size=4096;user id=sweetdie_SQLLogin_2;pwd=q1fmmrgev5;data source=ChatPV213.mssql.somee.com;persist security info=False;initial catalog=ChatPV213;TrustServerCertificate=True");
        }
    }

}
