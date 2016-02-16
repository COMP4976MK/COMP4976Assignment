using System.ComponentModel.DataAnnotations;

namespace DiplomaDataModel.CourseOption
{
    public class YearTerm
    {
        
        [Key]
        public int YearTermId { get; set; }

        [UIHint("YearDropDown")]
        public int Year { get; set; }

        [UIHint("TermDropDown")]
        public int Term { get; set; }

        public bool IsDefault { get; set; }
    }
}
