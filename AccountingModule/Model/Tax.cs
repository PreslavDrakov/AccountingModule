using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingModule.Model
{
    public class Tax
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "The field Name is required!")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field Description is required!")]
        [StringLength(255)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please select computation!")]
        public int ComputationValue { get; set; }

        [Required]
        public bool IsActive { get; set; } = false;

        [Required(ErrorMessage = "Please select type!")]
        public int TypeValue { get; set; }

        [Required(ErrorMessage = "Please select scope!")]
        public int ScopeValue { get; set; }

        [Required(ErrorMessage = "The field Description is required!")]
        public double Amount { get; set; }

        [NotMapped]
        public TaxComputationEnum Computation
        {
            get => (TaxComputationEnum)ComputationValue;
            set => ComputationValue = (int)value;
        }

        [NotMapped]
        public TaxTypeEnum Type
        {
            get => (TaxTypeEnum)TypeValue;
            set => TypeValue = (int)value;
        }

        [NotMapped]
        public TaxScopeEnum Scope
        {
            get => (TaxScopeEnum)ScopeValue;
            set => ScopeValue = (int)value;
        }
    }
}
