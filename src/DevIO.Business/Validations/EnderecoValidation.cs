using DevIO.Business.Models;
using DevIO.Business.Models.Validations.Documentos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Validations
{
    public class EnderecoValidation : AbstractValidator<Endereco>
    {   
        public EnderecoValidation()
        {
            RuleFor(f => f.Logradouro)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido.")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxLenght} caracteres.");

            RuleFor(f => f.Bairro)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido.")
               .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxLenght} caracteres.");

            RuleFor(f => f.Cep)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido.")
               .Length(8).WithMessage("O campo {PropertyName} precisa ter {MaxLenght} caracteres.");

            RuleFor(f => f.Cidade)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido.")
               .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxLenght} caracteres.");

            RuleFor(f => f.Estado)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido.")
               .Length(2, 50).WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxLenght} caracteres.");

            RuleFor(f => f.Numero)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido.")
               .Length(1, 50).WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxLenght} caracteres.");
        }
    }
}
