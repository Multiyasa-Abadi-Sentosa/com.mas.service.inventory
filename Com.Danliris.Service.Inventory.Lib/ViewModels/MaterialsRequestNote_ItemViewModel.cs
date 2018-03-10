﻿using Com.Danliris.Service.Inventory.Lib.Helpers;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Com.Danliris.Service.Inventory.Lib.ViewModels
{
    public class MaterialsRequestNote_ItemViewModel : BasicViewModel, IValidatableObject
    {
        public ProductionOrderViewModel ProductionOrder { get; set; }
        public ProductViewModel Product { get; set; }
        public double? Length { get; set; }
        public string Grade { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new System.NotImplementedException();
        }
    }
}
