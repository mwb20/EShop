﻿namespace EasyAbp.EShop.Products.Settings
{
    public static class ProductsSettings
    {
        public const string GroupName = "EasyAbp.EShop.Products";

        /* Add constants for setting names. Example:
         * public const string MySettingName = GroupName + ".MySettingName";
         */

        public class ProductView
        {
            private const string ProductViewGroupName = GroupName + ".GroupName"; 
            
            public const string CacheDurationSeconds = ProductViewGroupName + ".CacheDuration";
        }
    }
}