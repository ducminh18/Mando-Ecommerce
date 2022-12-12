using AutoMapper;
using MandoEcommerce.Admin.Manufacturers;
using MandoEcommerce.Admin.ProductCategories;
using MandoEcommerce.Admin.Products;
using MandoEcommerce.Manufacturers;
using MandoEcommerce.ProductCategories;
using MandoEcommerce.Products;

namespace MandoEcommerce.Admin;

public class MandoEcommerceAdminApplicationAutoMapperProfile : Profile
{
    public MandoEcommerceAdminApplicationAutoMapperProfile()
    {
        //Product Category
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();
        CreateMap<CreateUpdateProductCategoryDto, ProductCategory>();

        //Product
        CreateMap<Product, ProductDto>();
        CreateMap<Product, ProductInListDto>();
        CreateMap<CreateUpdateProductDto, Product>();

        CreateMap<Manufacturer, ManufacturerDto>();
        CreateMap<Manufacturer, ManufacturerInListDto>();
        CreateMap<CreateUpdateManufacturerDto, Manufacturer>();
    }
}
