﻿using System.ComponentModel;
using System.Reflection;

namespace CompanyWebSite.Areas.ManagementSystem.Controllers
{
    public static class EnumHelper
    {
        public static string GetDescription<T>(this T enumItemName)
        {
            var fi = enumItemName.GetType().GetField(enumItemName.ToString());

            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : enumItemName.ToString();
        }
    }
}