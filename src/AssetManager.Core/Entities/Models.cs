﻿using AssetManager.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManager.Core.Entities
{
    public class AssetModels: Entity
    {
        [Required]
        [Display(Name = "Asset Model Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Manufacturer Name")]
        [ForeignKey("Manufacturer")]
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }

        [Required]
        [Display(Name = "Catagory Name")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Display(Name = "Model Number")]
        public string ModelNumber { get; set; }

        [Display(Name = "Depreciation")]
        [ForeignKey("Depreciation")]
        public int DepreciationId { get; set; }
        public virtual Depreciation Depreciation { get; set; }


        [Display(Name ="EOL")]
        public int Eol { get; set; }

        [Display(Name ="Image")]
        public string Image { get; set; }

        public bool DeprecatedMacAdress { get; set; }

        [Display(Name="Note")]
        public string Notes { get; set; }

        [Display(Name = "Users may request this model")]
        public bool Requestable { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime DeletedAt { get; set; }
   

    }
}
