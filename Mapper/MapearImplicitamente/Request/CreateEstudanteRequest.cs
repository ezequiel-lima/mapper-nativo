using Mapper.MapearImplicitamente.Models;

namespace Mapper.MapearImplicitamente.Request
{
    public class CreateEstudanteRequest
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public long Ra { get; set; }

        public static implicit operator Estudante(CreateEstudanteRequest createEstudanteRequest)
        {
            return new Estudante
            {
                Nome = createEstudanteRequest.Nome,
                Email = createEstudanteRequest.Email,
                Ra = createEstudanteRequest.Ra
            };
        }
    }
}
