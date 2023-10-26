using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boletoapi.business.Models.Validations
{

    public class BoletoValidation : AbstractValidator<Boleto>
    {
        public BoletoValidation() 
        {
            RuleFor(f => f.NomePagador)
                .NotEmpty().WithMessage("O campo {NomePagador} precisa ser fornecido")
                .Length(2, 100)
                .WithMessage("O campo {NomePagador} precisa ter entre {MinLength} e {MaxLength} caracteres");
         
        }

    }

}
