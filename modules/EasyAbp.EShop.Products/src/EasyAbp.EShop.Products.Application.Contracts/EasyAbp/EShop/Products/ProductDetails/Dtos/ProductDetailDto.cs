﻿using System;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.EShop.Products.ProductDetails.Dtos
{
    [Serializable]
    public class ProductDetailDto : ExtensibleEntityDto<Guid>
    {
        public Guid? StoreId { get; set; }

        public string Description { get; set; }
    }
}