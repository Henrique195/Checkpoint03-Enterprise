using Microsoft.EntityFrameworkCore;

namespace Checkpoint03_Enterprise.Models
{
    public class PacienteApiDbContext : DbContext
    {
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public PacienteApiDbContext(DbContextOptions<PacienteApiDbContext> options) : base(options)
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        {

        }

        public DbSet<PacienteModel> Pacientes { get; set; }

    }
}
