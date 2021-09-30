using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Application.Games.Commands.CreateGame
{
  public class CreateGameCommandValidator : AbstractValidator<CreateGameCommand>
  {
    public CreateGameCommandValidator()
    {
      RuleFor(command => command.Name)
        .MinimumLength(2)
        .WithMessage("Name must be longer than 2")
        .When(command => command.Name != string.Empty);

      RuleFor(command => command.Price)
        .GreaterThan(0).WithMessage("Price must be greater than 0");
    }
  }
}
