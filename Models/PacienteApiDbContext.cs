using Microsoft.EntityFrameworkCore;

namespace Checkpoint03_Enterprise.Models
{
    public class PacienteApiDbContext : DbContext
    {
        public PacienteApiDbContext(DbContextOptions<PacienteApiDbContext> options) : base(options)
        {

        }

        public DbSet<PacienteModel> Pacientes { get; set; }

    }
}
