using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingModule.Model
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "The field Name is required!")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select a type!")]
        public int TypeValue { get; set; }

        public double? SalesPrice { get; set; }

        public double? CostPrice { get; set; }

        [Required]
        public bool CanBeSold { get; set; }

        [Required]
        public bool CanBePurchased { get; set; }
        
        [Required(ErrorMessage = "Please select a customer tax!")]
        [ForeignKey("CustomerTax")]
        public int CustomerTaxesID { get; set; }

        [Required(ErrorMessage = "Please select a vendor tax!")]
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
