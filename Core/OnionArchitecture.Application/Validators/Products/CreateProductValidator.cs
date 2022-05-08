using FluentValidation;
using OnionArchitecture.Application.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().NotNull().WithMessage("Lütfen ürün adını boş geçmeyiniz.")
                .MaximumLength(150).MinimumLength(5).WithMessage("Lütfen ürün adını 5 ile 150 karakter arasında giriniz.");

            RuleFor(x => x.Stock)
                .NotEmpty().NotNull().WithMessage("Lütfen stok bilgisini boş geçmeyiniz.")
                .Must(x => x >= 0).WithMessage("Stok bilgisi negatif olmaz.");

            RuleFor(x => x.Price)
                .NotEmpty().NotNull().WithMessage("Lütfen fiyat bilgisini boş geçmeyiniz.")
                .Must(x => x >= 0).WithMessage("Fiyat bilgisi negatif olmaz.");
        }
    }
}
