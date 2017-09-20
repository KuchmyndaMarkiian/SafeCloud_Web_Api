﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PrivateGallery.Common.BindingModels
{
    public class GalleryBindindModel
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        [Microsoft.Build.Framework.Required]
        [StringLength(100,ErrorMessage = "Empty header for creating object",MinimumLength = 1)]
        public string Name { get; set; }
        [Microsoft.Build.Framework.Required]
        [StringLength(100, ErrorMessage = "Empty header for creating object", MinimumLength = 1)]
        public string NewName { get; set; }
        [Microsoft.Build.Framework.Required]
        [StringLength(100, ErrorMessage = "Empty description for creating object", MinimumLength = 1)]
        public string Description { get; set; }
        [Microsoft.Build.Framework.Required]
        public DateTime DateTime { get; set; }
        [Required]
        public AttributeBindingModel Attribute { get; set; }=new AttributeBindingModel();
    }
}
