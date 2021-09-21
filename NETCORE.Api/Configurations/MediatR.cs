using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace NETCORE.Api.Configurations
{
    public static class MediatR
    {
        internal static void RegisterMediatR (IServiceCollection services) 
        {
            services.AddMediatR (typeof (Application.Exceptions.RecordNotFoundException).Assembly);
        }
    }
}