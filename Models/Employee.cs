using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDSQLServer.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor, campo obrgatorio.")]
        public string FirtName { get; set; }
        [Required(ErrorMessage = "Por favor, campo obrgatorio.")]
        public string LastName { get; set; }
        [MaxLength(5)]
        public string EmpCode { get; set; }
        public string Position { get; set; }
    }
}
