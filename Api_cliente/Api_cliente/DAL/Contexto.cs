using ClienteApp.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace Api_cliente.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Clientes> Clientes { get; set; }

}

