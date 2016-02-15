using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using DiplomaDataModel.CourseOption.CustomValidation;

namespace DiplomaDataModel.CourseOption
{
    public class Choice
    {
        [HiddenInput(DisplayValue = false)]
        public int ChoiceId { get; set; }

        [HiddenInput(DisplayValue = false)]
        [ForeignKey("YearTerm")]
        public int? YearTermId { get; set; }
        [ForeignKey("YearTermId")]
        public YearTerm YearTerm { get; set; }

        [Display(Name = "Student Number: ")]
        [StartWith("A00", ErrorMessage = "Student ID needs to start with A00")]
        [MaxLength(9, ErrorMessage = "Max Legnth 9 Characters")]
        public string StudentId { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name: ")]
        public string StudentFirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name: ")]
        public string StudentLastName { get; set; }

        [UIHint("FirstChoiceDropDown")]
        [Required(ErrorMessage = "First Choice is required.")]
        [Display(Name = "First Choice: ")]
        [ForeignKey("FirstOption")]
        public int? FirstChoiceOptionId { get; set; }
        [ForeignKey("FirstChoiceOptionId")]
        public Option FirstOption { get; set; }

        [UIHint("SecondChoiceDropDown")]
        [Required(ErrorMessage = "Second Choice is required.")]
        [Display(Name = "Second Choice: ")]
        [ForeignKey("SecondOption")]
        public int? SecondChoiceOptionId { get; set; }
        [ForeignKey("SecondChoiceOptionId")]
        public Option SecondOption { get; set; }

        [UIHint("ThirdChoiceDropDown")]
        [Required(ErrorMessage = "Third Choice is required.")]
        [Display(Name = "Third Choice: ")]
        [ForeignKey("ThirdOption")]
        public int? ThirdChoiceOptionId { get; set; }
        [ForeignKey("ThirdChoiceOptionId")]
        public Option ThirdOption { get; set; }

        [UIHint("FourthChoiceDropDown")]
        [Required(ErrorMessage = "Fourth Choice is required.")]
        [Display(Name = "Fourth Choice: ")]
        [ForeignKey("FourthOption")]
        public int? FourthChoiceOptionId { get; set; }
        [ForeignKey("FourthChoiceOptionId")]
        public Option FourthOption { get; set; }

        [HiddenInput(DisplayValue = false)]
        public DateTime SelectionDate { get; set; }

        public ICollection<Option> Options { get; set; }
        public ICollection<YearTerm> YearTerms { get; set; }
    }
}
