using System;
using System.ComponentModel.DataAnnotations;

namespace ContactsAddressManagement.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        [MaxLength(20)]
        public string CellphoneNumber { get; set; }
        public virtual ContactAddress ContactAddress { get; set; }
    }
}
