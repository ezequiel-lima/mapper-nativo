using Mapper.MapearExplicitamente.Models;

namespace Mapper.MapearExplicitamente.Request
{
    public class CreateProfessorRequest
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Disciplina { get; set; }
        public int CargaHoraria { get; set; }
        public bool Ativo { get; set; }

        public static explicit operator Professor(CreateProfessorRequest createProfessorRequest)
        {
            return new Professor
            {
                Nome = createProfessorRequest.Nome,
                Email = createProfessorRequest.Email,
                Disciplina = createProfessorRequest.Disciplina,
                CargaHoraria = createProfessorRequest.CargaHoraria,
                Ativo = createProfessorRequest.Ativo
            };
        }
    }
}
