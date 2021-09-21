using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;

namespace NETCORE.Api.Configurations
{
    public class FluentValidation
    {
        internal static void AddFluentValidation (IMvcBuilder mvcBuilder) 
        {
            mvcBuilder.AddFluentValidation (fv => 
            {
                fv.RegisterValidatorsFromAssemblyContaining<Application.Exceptions.RecordNotFoundException> ();
                fv.ImplicitlyValidateChildProperties = true;
            });
        }
    }
}