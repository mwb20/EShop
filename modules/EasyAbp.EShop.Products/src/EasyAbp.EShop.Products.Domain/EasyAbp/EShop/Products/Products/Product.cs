using System;
using System.Collections.Generic;
using EasyAbp.EShop.Stores.Stores;
using JetBrains.Annotations;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace EasyAbp.EShop.Products.Products
{
    public class Product : FullAuditedAggregateRoot<Guid>, IMultiTenant, IMultiStore
    {
        public virtual Guid? TenantId { get; protected set; }
        
        public virtual Guid StoreId { get; protected set; }
        
        public virtual Guid ProductTypeId { get; protected set; }
        
        [NotNull]
        public virtual string DisplayName { get; protected set; }
        
        public virtual InventoryStrategy InventoryStrategy { get; protected set; }
        
        [CanBeNull]
        public virtual string MediaResources { get; protected set; }
        
        public virtual int DisplayOrder { get; protected set; }

        public virtual bool IsPublished { get; protected set; }
        
        public virtual ProductDetail ProductDetail { get; protected set; }
        
        public virtual ICollection<ProductAttribute> ProductAttributes { get; protected set; }
        
        public virtual ICollection<ProductSku> ProductSkus { get; protected set; }

        protected Product()
        {
            ProductAttributes = new List<ProductAttribute>();
            ProductSkus = new List<ProductSku>();
        }

        public Product(
            Guid id,
            Guid? tenantId,
            Guid storeId,
            Guid productTypeId,
            string displayName,
            InventoryStrategy inventoryStrategy,
            bool isPublished,
            string mediaResources,
            int displayOrder
        ) :base(id)
        {
            TenantId = tenantId;
            StoreId = storeId;
            ProductTypeId = productTypeId;
            DisplayName = displayName;
            InventoryStrategy = inventoryStrategy;
            IsPublished = isPublished;
            MediaResources = mediaResources;
            DisplayOrder = displayOrder;
            ProductAttributes = new List<ProductAttribute>();
            ProductSkus = new List<ProductSku>();
        }
    }
}
