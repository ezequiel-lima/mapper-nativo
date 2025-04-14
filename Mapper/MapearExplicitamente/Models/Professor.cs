using Mapper.MapearImplicitamente.Request;

namespace Mapper.MapearExplicitamente.Models
{
    public class Professor
    {
        public string Nome { get; set; } 
        public string Email { get; set; } 
        public string Disciplina { get; set; } 
        public int CargaHoraria { get; set; }         
        public bool Ativo { get; set; }     
    }
}
