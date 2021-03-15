using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ServiceCharge.Web.Utillity
{
    public static class Utils
    {
        public static string GetDisplayName(this Enum value)
        {
            var type = value.GetType();
            var property = type.GetField(value.ToString());
            var attribute = property.GetCustomAttribute<DisplayAttribute>();

            if (attribute == null)
            {
                return value.ToString();
            }
            else
            {
                return attribute.Name;
            }
        }
    }
}