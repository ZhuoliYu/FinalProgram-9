using FinalProgram_9.Models;
using Microsoft.AspNetCore.Identity;

namespace FinalProgram_9
{//inherit identity user
    public class ApplicationUser : IdentityUser
    {
        public int Reputation { get; set; }
        public virtual List<Question> Questions { get; set; }
    }
}
