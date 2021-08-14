using DevIO.Business.Models;
using DevIO.Business.Models.Validations.Documentos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {   
        public ProdutoValidation()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido.")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxLenght} caracteres.");

            RuleFor(f => f.Descricao)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido.")
               .Length(2, 1000).WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxLenght} caracteres.");

            RuleFor(f => f.Valor)
               .GreaterThan(0).WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonValue}");
        }
    }
}
