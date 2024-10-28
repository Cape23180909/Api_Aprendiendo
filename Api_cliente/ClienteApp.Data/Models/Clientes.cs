using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteApp.Data.Models;

public class Clientes
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Manin")]
    public string Name { get; set; }
}