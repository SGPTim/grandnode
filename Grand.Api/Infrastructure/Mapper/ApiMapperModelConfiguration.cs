﻿using AutoMapper;
using Grand.Api.DTOs.Catalog;
using Grand.Api.DTOs.Customers;
using Grand.Core.Domain.Catalog;
using Grand.Core.Domain.Common;
using Grand.Core.Domain.Customers;
using Grand.Core.Infrastructure.Mapper;
using Grand.Services.Common;
using System;
using System.Linq;

namespace Grand.Api.Infrastructure.Mapper
{
    public class ApiMapperModelConfiguration : Profile, IMapperProfile
    {

        public ApiMapperModelConfiguration()
        {
            #region Category

            CreateMap<CategoryDto, Category>()
                .ForMember(dest => dest.SubjectToAcl, mo => mo.Ignore())
                .ForMember(dest => dest.CustomerRoles, mo => mo.Ignore())
                .ForMember(dest => dest.LimitedToStores, mo => mo.Ignore())
                .ForMember(dest => dest.Stores, mo => mo.Ignore())
                .ForMember(dest => dest.CreatedOnUtc, mo => mo.Ignore())
                .ForMember(dest => dest.UpdatedOnUtc, mo => mo.Ignore())
                .ForMember(dest => dest.Locales, mo => mo.Ignore())
                .ForMember(dest => dest.AppliedDiscounts, mo => mo.Ignore())
                .ForMember(dest => dest.GenericAttributes, mo => mo.Ignore());

            CreateMap<Category, CategoryDto>();

            #endregion

            #region Manufacturer

            CreateMap<ManufacturerDto, Manufacturer>()
                .ForMember(dest => dest.SubjectToAcl, mo => mo.Ignore())
                .ForMember(dest => dest.CustomerRoles, mo => mo.Ignore())
                .ForMember(dest => dest.LimitedToStores, mo => mo.Ignore())
                .ForMember(dest => dest.Stores, mo => mo.Ignore())
                .ForMember(dest => dest.CreatedOnUtc, mo => mo.Ignore())
                .ForMember(dest => dest.UpdatedOnUtc, mo => mo.Ignore())
                .ForMember(dest => dest.Locales, mo => mo.Ignore())
                .ForMember(dest => dest.AppliedDiscounts, mo => mo.Ignore())
                .ForMember(dest => dest.GenericAttributes, mo => mo.Ignore());

            CreateMap<Manufacturer, ManufacturerDto>();

            #endregion

            #region CustomerRole

            CreateMap<CustomerRoleDto, CustomerRole>()
                .ForMember(dest => dest.GenericAttributes, mo => mo.Ignore());

            CreateMap<CustomerRole, CustomerRoleDto>();

            #endregion

            #region Product attribute 

            CreateMap<ProductAttributeDto, ProductAttribute>()
                .ForMember(dest => dest.GenericAttributes, mo => mo.Ignore());

            CreateMap<ProductAttribute, ProductAttributeDto>();

            CreateMap<PredefinedProductAttributeValue, PredefinedProductAttributeValueDto>();

            CreateMap<PredefinedProductAttributeValueDto, PredefinedProductAttributeValue>()
                .ForMember(dest => dest.Locales, mo => mo.Ignore());

            #endregion

            #region Specification attribute 

            CreateMap<SpecificationAttributeDto, SpecificationAttribute>()
                .ForMember(dest => dest.GenericAttributes, mo => mo.Ignore());

            CreateMap<SpecificationAttribute, SpecificationAttributeDto>();

            CreateMap<SpecificationAttributeOption, SpecificationAttributeOptionDto>();

            CreateMap<SpecificationAttributeOptionDto, SpecificationAttributeOption>()
                .ForMember(dest => dest.Locales, mo => mo.Ignore());

            #endregion

            #region Customer

            CreateMap<CustomerDto, Customer>()
                .ForMember(dest => dest.Addresses, mo => mo.Ignore())
                .ForMember(dest => dest.CannotLoginUntilDateUtc, mo => mo.Ignore())
                .ForMember(dest => dest.BillingAddress, mo => mo.Ignore())
                .ForMember(dest => dest.CreatedOnUtc, mo => mo.Ignore())
                .ForMember(dest => dest.CustomerRoles, mo => mo.Ignore())
                .ForMember(dest => dest.CustomerTags, mo => mo.Ignore())
                .ForMember(dest => dest.FailedLoginAttempts, mo => mo.Ignore())
                .ForMember(dest => dest.HasContributions, mo => mo.Ignore())
                .ForMember(dest => dest.IsSystemAccount, mo => mo.Ignore())
                .ForMember(dest => dest.LastActivityDateUtc, mo => mo.Ignore())
                .ForMember(dest => dest.LastIpAddress, mo => mo.Ignore())
                .ForMember(dest => dest.LastLoginDateUtc, mo => mo.Ignore())
                .ForMember(dest => dest.LastPurchaseDateUtc, mo => mo.Ignore())
                .ForMember(dest => dest.LastUpdateCartDateUtc, mo => mo.Ignore())
                .ForMember(dest => dest.LastUpdateWishListDateUtc, mo => mo.Ignore())
                .ForMember(dest => dest.Password, mo => mo.Ignore())
                .ForMember(dest => dest.PasswordChangeDateUtc, mo => mo.Ignore())
                .ForMember(dest => dest.PasswordFormatId, mo => mo.Ignore())
                .ForMember(dest => dest.PasswordSalt, mo => mo.Ignore())
                .ForMember(dest => dest.ShippingAddress, mo => mo.Ignore())
                .ForMember(dest => dest.ShoppingCartItems, mo => mo.Ignore())
                .ForMember(dest => dest.SystemName, mo => mo.Ignore())
                .ForMember(dest => dest.UrlReferrer, mo => mo.Ignore())
                .ForMember(dest => dest.CustomerRoles, mo => mo.Ignore())
                .ForMember(dest => dest.GenericAttributes, mo => mo.Ignore());

            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.FirstName, mo => mo.MapFrom(src => src.GetAttribute<string>(SystemCustomerAttributeNames.FirstName, "")))
                .ForMember(dest => dest.LastName, mo => mo.MapFrom(src => src.GetAttribute<string>(SystemCustomerAttributeNames.LastName, "")))
                .ForMember(dest => dest.City, mo => mo.MapFrom(src => src.GetAttribute<string>(SystemCustomerAttributeNames.City, "")))
                .ForMember(dest => dest.Company, mo => mo.MapFrom(src => src.GetAttribute<string>(SystemCustomerAttributeNames.Company, "")))
                .ForMember(dest => dest.DateOfBirth, mo => mo.MapFrom(src => src.GetAttribute<DateTime?>(SystemCustomerAttributeNames.DateOfBirth, "")))
                .ForMember(dest => dest.Fax, mo => mo.MapFrom(src => src.GetAttribute<string>(SystemCustomerAttributeNames.Fax, "")))
                .ForMember(dest => dest.Gender, mo => mo.MapFrom(src => src.GetAttribute<string>(SystemCustomerAttributeNames.Gender, "")))
                .ForMember(dest => dest.Phone, mo => mo.MapFrom(src => src.GetAttribute<string>(SystemCustomerAttributeNames.Phone, "")))
                .ForMember(dest => dest.Signature, mo => mo.MapFrom(src => src.GetAttribute<string>(SystemCustomerAttributeNames.Signature, "")))
                .ForMember(dest => dest.StateProvinceId, mo => mo.MapFrom(src => src.GetAttribute<string>(SystemCustomerAttributeNames.StateProvinceId, "")))
                .ForMember(dest => dest.StreetAddress, mo => mo.MapFrom(src => src.GetAttribute<string>(SystemCustomerAttributeNames.StreetAddress, "")))
                .ForMember(dest => dest.StreetAddress2, mo => mo.MapFrom(src => src.GetAttribute<string>(SystemCustomerAttributeNames.StreetAddress2, "")))
                .ForMember(dest => dest.VatNumber, mo => mo.MapFrom(src => src.GetAttribute<string>(SystemCustomerAttributeNames.VatNumber, "")))
                .ForMember(dest => dest.VatNumberStatusId, mo => mo.MapFrom(src => src.GetAttribute<string>(SystemCustomerAttributeNames.VatNumberStatusId, "")))
                .ForMember(dest => dest.ZipPostalCode, mo => mo.MapFrom(src => src.GetAttribute<string>(SystemCustomerAttributeNames.ZipPostalCode, "")))
                .ForMember(dest => dest.CountryId, mo => mo.MapFrom(src => src.GetAttribute<string>(SystemCustomerAttributeNames.CountryId, "")))
                .ForMember(dest => dest.CustomerRoles, mo => mo.MapFrom(src => src.CustomerRoles.Select(x => x.Id)));

            CreateMap<AddressDto, Address>()
                .ForMember(dest => dest.CustomAttributes, mo => mo.Ignore())
                .ForMember(dest => dest.GenericAttributes, mo => mo.Ignore());

            CreateMap<Address, AddressDto>();

            #endregion

        }

        public int Order => 1;
    }
}
