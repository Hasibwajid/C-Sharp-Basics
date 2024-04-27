using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [StringLength(255)]
        public string PhoneNumber { get; set; }
        [Required]
        public string JobTitle { get; set; }
        public DateTime HireDate { get; set; }
    }
}