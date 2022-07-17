using Mc2.CrudTest.Acceptance.Persistance.Ef.Context;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Acceptance.Persistance.Ef.init
{
    public static class Persistance
    {
        public static void ConfigureEf(this IServiceCollection services)
        {
            services.AddDbContext<AcceptanceContext>();
        }
    }
}
