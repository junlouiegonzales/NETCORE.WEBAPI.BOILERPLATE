using FluentValidation;

namespace NETCORE.Application.WeatherForecast.Commands.Create
{
    public class CommandValidator : AbstractValidator<Command>
    {
        public CommandValidator()
        {
            RuleFor(t => t.Type).NotEmpty();
            RuleFor(t => t.Temperature).NotEmpty();
            RuleFor(t => t.Wind).NotEmpty();
            RuleFor(t => t.Precipitation).NotEmpty();
        }
    }
}