﻿using StoreBackend.Models;
using System.Collections.Generic;

namespace StoreBackend.ViewModels
{
    public class ProductOptionViewModel: BaseEntityViewModel
    {
        public int Id { get; set; }
        public double Price { get; set; }

        public IEnumerable<ImageViewModel> Images { get; set; }

        public int ProductId { get; set; }

        public  string ProductOptionDescription { get; set; }

        public ProductOptionViewModel()
        {
            Images = new List<ImageViewModel>();
        }
    }
}
