﻿namespace MultiShop.Catalog.Dtos.ProductDtos
{
    public class GetByIdProductDto
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProdudctImageUrl { get; set; }
        public string ProdudctDescribtion { get; set; }
        public string CategoryID { get; set; }
    }
}
