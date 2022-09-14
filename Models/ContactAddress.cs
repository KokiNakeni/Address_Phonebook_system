using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactsAddressManagement.Models
{
    public class ContactAddress
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ContactId")]
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}
