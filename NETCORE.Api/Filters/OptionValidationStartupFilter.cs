using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using NETCORE.Services;

namespace NETCORE.Api.Filters
{
    public class OptionValidationStartupFilter : IStartupFilter
    {
        readonly IEnumerable<IValidatable> _validatableObjects;
        
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            foreach (var validatableObject in _validatableObjects)
            {
                validatableObject.Validate();
            }
            //dont alter the configuration
            return next;
        }
    }
}