using Infrastrucutre.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucutre.Helpers.Middlewares;

public class UserSessionValidationMiddleware(RequestDelegate next)
{
    private readonly RequestDelegate _next = next;

    public async Task InvokeAsync(HttpContext context, UserManager<UserEntity> userManger, SignInManager<UserEntity> signInManager)
    {
        if (context.User.Identity!.IsAuthenticated)
        {
            if (!await userManger.Users.AnyAsync(x => x.UserName == context.User.Identity.Name))
            {
                await signInManager.SignOutAsync();
            }
        }

        await _next(context);
    }
}
