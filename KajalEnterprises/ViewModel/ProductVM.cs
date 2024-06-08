﻿using KajalEnterprises.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KajalEnterprises.ViewModel
{
    public class ProductVM
    {
        public Product Product {  get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}
