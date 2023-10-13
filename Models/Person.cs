using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data;
using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations.Schema;

namespace C_Website.Models
{
    public class Person
    {
        /*        public DateTime CleaningDate { get; set; } = DateTime.Now; // default value current date*/
        [Key] public int Id { get; set; }
        /*public int PersonId { get; set; } // primary key*/

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")] 
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Number coming is required")]
        [Display(Name = "Number Coming")]
        public string? numberC { get; set; }
        [Required(ErrorMessage = "phone is required")]
        [Display(Name = "Phone")]
        public string? Phone { get; set; }
       
        public Person(string firstName, string lastName, string numberC, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            this.numberC = numberC;
            Phone = phone;
        }
    }
}
