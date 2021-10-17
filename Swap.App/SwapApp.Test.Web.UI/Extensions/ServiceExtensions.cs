using AlGulumVerGulum.DAL.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlGulumVerGulum.Test.Web.UI.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddDi(this IServiceCollection services)
        {
            services.AddDbContext<AlGulumDbContext>();
        }
        public static void UseAppConfig(this IApplicationBuilder app)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }

}
