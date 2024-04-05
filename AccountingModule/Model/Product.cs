using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingModule.Model
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public int TypeValue { get; set; }

        public double? SalesPrice { get; set; }

        public double? CostPrice { get; set; }

        [Required]
        public bool CanBeSold { get; set; }

        [Required]
        public bool CanBePurchased { get; set; }
        
        [Required]
        [ForeignKey("CustomerTax")]
        public int CustomerTaxesID { get; set; }

        [Required]
        [ForeignKey("VendorTax")]
        public int VendorTaxesID { get; set; }

        public virtual Tax? CustomerTax { get; set; }
        public virtual Tax? VendorTax { get; set; }
        
        [NotMapped]
        public ProductTypesEnum Type
        {
            get => (ProductTypesEnum)TypeValue;
            set => TypeValue = (int)value;
        }
    }
}
