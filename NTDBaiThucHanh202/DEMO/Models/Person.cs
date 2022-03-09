using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DEMO.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public string ID { get; set; }
        public string PersonName { get; set; }
        public string Address { get; set; }
    }
}