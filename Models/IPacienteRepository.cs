namespace Checkpoint03_Enterprise.Models
{
    public interface IPacienteRepository
    {
        public PacienteModel? ObterPorId(long id);
        public IEnumerable<PacienteModel> Listar();
        public void Cadastrar(PacienteModel paciente);
        public void Atualizar(PacienteModel paciente);
        public void Remover(PacienteModel paciente);
    }
}
