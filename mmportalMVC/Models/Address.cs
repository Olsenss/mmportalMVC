using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mmportalMVC.Models
{
    public class Address
    {
        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int idAddress { get; set; }
        public string StreetName { get; set; }
        public string HomeNo { get; set; }

        public string PostalCode { get; set; }
        public string FloorNo { get; set; }

        public string City{ get; set; }

        public string Apartment { get; set; }
    }
}