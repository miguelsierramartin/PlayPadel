using Identity.Domain;
using Identity.Persistence.Database;
using Identity.Service.EventHandlers.Commands;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.EventHandlers
{
    public class UserCreateEventHandler :
        IRequestHandler<UserCreateCommand, IdentityResult>
    {
        private UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext _context;

        public UserCreateEventHandler(
            UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IdentityResult> Handle(UserCreateCommand notification, CancellationToken cancellationToken)
        {
           


           var entry = new ApplicationUser
            {
                FirstName = notification.FirstName,
                LastName = notification.LastName,
                Email = notification.Email,
                UserName = notification.Email
            };

            var result = await _userManager.CreateAsync(entry,notification.Password);
            if (result.Succeeded)
            {
                var userId = entry.Id;
                var userName = entry.UserName;
            }
                await _userManager.AddToRoleAsync(entry, null);
            return await _userManager.CreateAsync(entry, notification.Password);
        }
    }
}