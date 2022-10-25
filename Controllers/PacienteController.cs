using Checkpoint03_Enterprise.Models;
using Microsoft.AspNetCore.Mvc;

namespace Checkpoint03_Enterprise.Controllers
{
    [ApiController]
    [Route("/api/pacienteController")]
    public class PacienteController : ControllerBase
    {
        private readonly ILogger<PacienteController> _logger;
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteController(IPacienteRepository pacienteRepostitory, ILogger<PacienteController> logger)
        {
            _pacienteRepository = pacienteRepostitory;
            _logger = logger;
        }

        [HttpGet]
        public JsonResult ListarPacientes()
        {
            return new JsonResult(_pacienteRepository.Listar());
        }

        [HttpGet("{id}")]
        public ActionResult<PacienteModel> ObterPaciente(int id)
        {
            PacienteModel paciente = _pacienteRepository.ObterPorId(id);

            if (paciente == null)
            {
                _logger.LogInformation($"Paciente não encontrado [{id}]");
                return NotFound();
            }

            return Ok(paciente);
        }

        [HttpPost]
        public ActionResult<PacienteModel> Cadastrar(PacienteModel paciente)
        {
            _pacienteRepository.Cadastrar(paciente);

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult<PacienteModel> Atualizar(int id, PacienteModel paciente)
        {
            PacienteModel pacienteExists = _pacienteRepository.ObterPorId(id);

            if (pacienteExists == null)
            {
                return NotFound();
            }

            paciente.Id = id;

            _pacienteRepository.Atualizar(paciente);

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<PacienteModel> Remover(int id)
        {
            PacienteModel paciente = _pacienteRepository.ObterPorId(id);

            if (paciente == null)
            {
                return NotFound();
            }

            _pacienteRepository.Remover(paciente);

            return NoContent();
        }
    }
}
