using AspNetApiPractice.Domain.Dtos;
using AspNetApiPractice.Domain.Entities;
using FluentValidation;
using FluentValidation.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Application.Validator
{
    public class ProductValidator :AbstractValidator<ProductDto>
    {

        public ProductValidator()
        {
            RuleFor(X=> X.ProductValue).NotEmpty().Must(p=> p>100).WithMessage("Değer kabul edilenden düşük.");
            RuleFor(x=> x.ProductName).NotEmpty().MaximumLength(100).WithMessage("İsim çok uzun!");
        }

    }
}
