using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AngularJSAuthentication.API.Data
{
    public class AuthRepository : IDisposable
    {
        private readonly AuthContext ctx;
        private readonly UserManager<IdentityUser> userManager;

        public AuthRepository()
        {
            ctx = new AuthContext();
            userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(ctx));
        }

        public async Task<IdentityResult> RegisterUser(UserModel userModel)
        {
            var user = new IdentityUser
                {
                    UserName = userModel.UserName
                };
            var result = await userManager.CreateAsync(user, userModel.Password);

            return result;
        }

        public async Task<IdentityUser> FindUser(string username, string password)
        {
            var user = await userManager.FindAsync(username, password);
            return user;
        }

        public void Dispose()
        {
            ctx.Dispose();
            userManager.Dispose();
        }
    }
}