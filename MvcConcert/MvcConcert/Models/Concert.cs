using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcConcert.Models
{
    public class Concert
    {
        public int Id { get; set; }

        [StringLength(150)]
        [Required]
        public string Nom { get; set; }
        
        [StringLength(100)]
        [Required]
        public string Salle { get; set; }

        [Display(Name = "Event Date")]
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        internal static object Single()
        {
            throw new NotImplementedException();
        }
    }
}