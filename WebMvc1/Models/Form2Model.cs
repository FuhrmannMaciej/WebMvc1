using System;
using System.ComponentModel.DataAnnotations;

namespace WebMvc1.Models
{
    public class Form2Model
    {
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Display(Name = "Data urodzenia")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Liczba dni od urodzin do dzisiaj")]
        public int NumberOfDaysSinceDate { get
            {
                DateTime now = DateTime.Today;
                return (now.Date - DateOfBirth.Date).Days;
            } }
        [Display(Name = "Czy rok urodzenia był rokiem przestępnym?")]
        public string IsLeapYear { get
            {
                int year = DateOfBirth.Year;
                return DateTime.IsLeapYear(year) ? "Rok " + year + " był rokiem przestępnym." : "Rok " + year + " nie był rokiem przestępnym.";
            } }
    }
}

