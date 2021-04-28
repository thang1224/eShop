﻿using eShop.Application.Catalog.DTOS;
using eShop.Application.Catalog.Products.DTOS;
using eShop.Application.Catalog.Products.DTOS.Manage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductEditRequest request);
        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int quantity);
        Task<int> AddViewCount(int productId);

        //Task<List<ProductViewModel>> GetAll();

        Task<PagedViewModel<ProductViewModel>> GetAllPaging(GetProductPagingRequest reqest);
    }
}