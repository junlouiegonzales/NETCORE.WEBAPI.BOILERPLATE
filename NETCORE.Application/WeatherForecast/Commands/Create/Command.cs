using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using NETCORE.Domain.Entities;
using NETCORE.Domain.Enums;
using NETCORE.Persistence.Context;

namespace NETCORE.Application.WeatherForecast.Commands.Create
{
    public class Command : IRequest<Response>
    {
        public WeatherType Type { get; set; }
        public int Temperature { get; set; }
        public string Wind { get; set; }
        public string Precipitation { get; set; }
    }

    public class CommandHandler : IRequestHandler<Command, Response>
    {
        private readonly NetCoreDbContext dbContext;
        private readonly IMapper mapper;

        public CommandHandler(NetCoreDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
        {
            var newItem = mapper.Map<Weather>(request);
            dbContext.Weathers.Add(newItem);
            await dbContext.SaveChangesAsync();
            return new SuccessResponse<bool>(true);
        }
    }
}