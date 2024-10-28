using System.ComponentModel.DataAnnotations;

namespace ClientesApp.UI.Models;

public class Clientes
{
    [Key]
    public int ClienteId { get; set; }
    [Required(ErrorMessage = "Coloque la cedula.")]
    public string Cedula { get; set; }
    [Required(ErrorMessage = "Coloque su nombre completo.")]
    public string Nombres { get; set; }
    [Required(ErrorMessage = "Coloque el numero de telefono.")]
    public int Telefono { get; set; }

}