using System.ComponentModel.DataAnnotations;
using MetadataExtensionsDemo.Web.Models;
using MetadataExtensionsDemo.Web.Resources;
using ModelMetadataExtensions;

namespace ModelMetadataDemo.Web.Models
{
    [ClassLevelValidation]
    [MetadataConventions(ResourceType = typeof(Resource))]
    public class Character
    {
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "LastNameLabel")]
        [Required]
        public string LastName { get; set; }

        public int HitPoints { get; set; }

        [Display(Name = "The Level (from DisplayAttribute)")]
        public int Level { get; set; }

        public int ArmorClass { get; set; }
    }
}