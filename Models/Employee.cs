using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Primeiro nome")]
        public string FirtName { get; set; }
        [Required(ErrorMessage = "Por favor, campo obrgatorio.")]
        [DisplayName("Segundo Nome")]
        public string LastName { get; set; }
        [MaxLength(5)]
        [DisplayName("Codigo")]
        public string EmpCode { get; set; }
        [DisplayName("Cargo")]
        public string Position { get; set; }
    }
}
