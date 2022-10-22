namespace Checkpoint03_Enterprise.Models
{
    public class PacienteRepository : IPacienteRepository
    {

        private readonly PacienteApiDbContext _context;

        public PacienteRepository(PacienteApiDbContext context)
        {
            _context = context;
        }

        public void Atualizar(PacienteModel paciente)
        {
            PacienteModel pacienteDb = ObterPorId(paciente.Id);
            if (pacienteDb == null) throw new Exception("Paciente não encontrado");

            pacienteDb.Name = paciente.Name;
            pacienteDb.Email = paciente.Email;
            pacienteDb.StreetName = paciente.StreetName;
            pacienteDb.StreetNumber = paciente.StreetNumber;
            pacienteDb.Neighborhood = paciente.Neighborhood;
            pacienteDb.City = paciente.City;
            pacienteDb.Country = paciente.Country;

            _context.SaveChanges();
        }

        public void Cadastrar(PacienteModel paciente)
        {
            _context.Pacientes.Add(paciente);
            _context.SaveChanges();
        }

        public IEnumerable<PacienteModel> Listar()
        {
            return _context.Pacientes.OrderBy(p => p.Id);
        }

        public PacienteModel? ObterPorId(long id)
        {
            return _context.Pacientes.FirstOrDefault(p => p.Id == id);
        }

        public void Remover(PacienteModel paciente)
        {
            _context.Pacientes.Remove(paciente);

            _context.SaveChanges();
        }
    }
}
