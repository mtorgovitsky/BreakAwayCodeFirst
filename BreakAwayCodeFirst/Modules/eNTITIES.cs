using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakAwayCodeFirst.Modules
{
    [Table("Customers")]
    public class Customer : Contact
    {
        [Required]
        public int CustomerTypeID { get; set; }
        public DateTime? InitialDate { get; set; }
        public int? PrimaryDesintation { get; set; }
        public int? SecondaryDestination { get; set; }
        public int? PrimaryActivity { get; set; }
        public int? SecondaryActivity { get; set; }
        public string Notes { get; set; }
        //[Column("RowVersion")]
        //[Timestamp]
        //public byte[] SomeProp { get; set; }
    }

    public class Contact
    {
        public int ContactID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }

    public class Activities
    {
        public int ActivityID { get; set; }
        public string Activity { get; set; }
        public string imagepath { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
