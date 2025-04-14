using Mapper.MapearExplicitamente.Models;
using Mapper.MapearExplicitamente.Request;
using Mapper.MapearImplicitamente.Models;
using Mapper.MapearImplicitamente.Request;

#region Mapear Implicitamente 

var request = new CreateEstudanteRequest 
{ 
    Nome = "João", 
    Email = "joao@email.com", 
    Ra = 12345678909 
};

Estudante estudante = request;

Console.WriteLine($"{estudante.Nome}, {estudante.Email}, {estudante.Ra}");

#endregion

#region Mapear Explicitamente 

var segundoRequest = new CreateProfessorRequest
{
    Nome = "João da Silva",
    Email = "joao.silva@escola.edu.br",
    Disciplina = "Matemática",
    CargaHoraria = 20,
    Ativo = true
};

var professor = (Professor)segundoRequest;

Console.WriteLine($"{professor.Nome}, {professor.Email}, {professor.Disciplina}");

#endregion