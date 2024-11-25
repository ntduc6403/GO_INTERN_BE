using System.ComponentModel.DataAnnotations;

namespace GOLDEN_OWL_SOLUTIONS.Models
{
    public class Scores
    {
        [Key]
        public string sbd { get; set; } 

        public double? toan { get; set; }
        public double? ngu_van { get; set; }
        public double? ngoai_ngu { get; set; }
        public double? vat_li { get; set; }
        public double? hoa_hoc { get; set; }
        public double? sinh_hoc { get; set; }
        public double? lich_su { get; set; }
        public double? dia_li { get; set; }
        public double? gdcd { get; set; }
        public string?  ma_ngoai_ngu { get; set; }
    }
}
