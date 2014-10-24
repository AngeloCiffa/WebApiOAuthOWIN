using Microsoft.AspNet.Identity.EntityFramework;

namespace AngularJSAuthentication.API.Data
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext() : base ("AuthContext")
        {
            
        }
    }
}