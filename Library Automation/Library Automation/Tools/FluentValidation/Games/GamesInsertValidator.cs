using FluentValidation;
using Library_Automation.Objects.Games;
using Library_Automation.Objects.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation.Tools.FluentValidation
{
    public class GamesInsertValidator : AbstractValidator<InsertGames>
    {
        public GamesInsertValidator() { 
            RuleFor(b => b.GamesName)
                .NotEmpty().MaximumLength(200).WithMessage("Kitap Adını Boş Bırakamazsınız.");

            RuleFor(x => x.PublisherName)
                .NotEmpty().MaximumLength(200).WithMessage("Yayınevi alanını boş bırakamazsınız.");
        }
    }
}
