using Microsoft.EntityFrameworkCore;
using UcmData.Client.Models;

namespace UcmData.Client.Data
{
    public class DbContextUcm:DbContext
    {
        public DbSet<cdr> cdrs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connecttionString = "Data Source=DESKTOP-H8JK0LS;Initial Catalog=UcmDb;User Id=sa;Password=abcd123!";
            optionsBuilder.UseSqlServer(connecttionString);
        }
    }
}
