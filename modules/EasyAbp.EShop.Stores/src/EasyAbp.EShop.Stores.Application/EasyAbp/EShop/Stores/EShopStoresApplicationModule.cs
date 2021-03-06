﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.Users;

namespace EasyAbp.EShop.Stores
{
    [DependsOn(
        typeof(EShopStoresDomainModule),
        typeof(EShopStoresApplicationSharedModule),
        typeof(EShopStoresApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpUsersAbstractionModule),
        typeof(AbpAutoMapperModule)
    )]
    public class EShopStoresApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<EShopStoresApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<EShopStoresApplicationModule>(validate: true);
            });
        }
    }
}
