using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Spatial;

namespace Sayvin.Models
{
    public class ClientModel
    {

        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }

        public string Email { get; set; }

        [Display(Name = "Name", Description = "")]
        [Required(ErrorMessage = " ")]
        public string ClientName { get; set; }

        [Display(Name = "Last Name", Description = "")]
        [Required(ErrorMessage = " ")]
        public string ClientLastName { get; set; }

        [Required(ErrorMessage = " ")]
        public DateTime Birth { get; set; }

        [Required(ErrorMessage = " ")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = " ")]
        public string Country { get; set; }

        [Required(ErrorMessage = " ")]
        public string State { get; set; }

        [Required(ErrorMessage = " ")]
        public string City { get; set; }

        [Required(ErrorMessage = " ")]
        public string Address { get; set; }

        [Display(Name = "Address 2 (other data)", Description = "")]
        [Required(ErrorMessage = " ")]
        public string Address2 { get; set; }

        [Required(ErrorMessage = " ")]
        public string Phone { get; set; }

        [Required(ErrorMessage = " ")]
        public string Passport { get; set; }

        public DbGeography Location { get; set; }
    }

    public enum Gender
    {
        female = 0,
        male = 1,
        Other = 2,
    }
}
