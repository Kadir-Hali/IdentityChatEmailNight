using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityChatEmailNight.Context
{
    public class EmailContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Initial Catalog=EmailChatNightDb; Integrated Security=true; Trust Server Certificate=true");
        }
    }
}
