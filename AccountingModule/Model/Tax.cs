using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingModule.Model
{
    public class Tax
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        public int ComputationValue { get; set; }

        [Required]
        public bool IsActive { get; set; } = false;

        [Required]
        public int TypeValue { get; set; }

        [Required]
        public int ScopeValue { get; set; }

        [Required]
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
