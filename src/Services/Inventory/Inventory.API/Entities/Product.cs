using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.API.Entities
{
    [Table("Product")]
    public class Product
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string LinkImage { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public int IsStatus { get; set; }
        public int IsDiscontinued { get; set; }
        public int IsDelete { get; set; }
        public string SupplierId { get; set; }
        public string CategoryId { get; set; }
        public string BrandId { get; set; }
        public string CongigurationId { get; set; }
        public string PriceId { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public Configuration Configuration { get; set; }
        public ICollection<Device> Devices { get; set; }
        public ICollection<PriceLog> PriceLogs { get; set; }
        public IList<ProductColor> ProductColors { get; set; }
        public IList<ProductSupplier> ProductSuppliers { get; set; }
    }
}