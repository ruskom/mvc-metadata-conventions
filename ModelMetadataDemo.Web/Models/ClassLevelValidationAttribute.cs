using System;
using System.ComponentModel.DataAnnotations;

namespace MetadataExtensionsDemo.Web.Models
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ClassLevelValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return true;
        }
    }
}
