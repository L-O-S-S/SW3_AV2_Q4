using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExLogin.Data
{
    public class IESDbInitializer
    {
        public static void Initialize(IESContext context)
        {

            context.Database.EnsureCreated();

            context.SaveChanges();
        }
    }
}
