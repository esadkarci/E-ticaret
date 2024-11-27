﻿using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Dtos.ProductmageDtos
{
    public class UpdateProductmageDto
    {
        public string ProductImageID { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string ProductID { get; set; }
        public Product Product { get; set; }
    }
}
