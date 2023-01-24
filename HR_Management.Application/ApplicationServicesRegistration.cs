using HR_Management.Application.Profiles;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application
{
    public static class ApplicationServicesRegistration
    {
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
           
           // services.AddAutoMapper(typeof(Mapping_Profile));
           //روش زیر از اسمبلی فعلی میگرده و هرچی پروفایل مپینگ هست وارد میکند و نیازی نیست مثل روش بالا  تک تک پروفایل هارا اضافه کنیم
           //This Way Is Searching From Assembly To Find All AutoMapper Mapping Profiles 
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
