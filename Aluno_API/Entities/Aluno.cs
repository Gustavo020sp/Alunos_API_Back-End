using System.ComponentModel.DataAnnotations;

namespace Aluno_API.Entities
{
    public class Aluno
    {
        public int Id { get; set; }
        [Required]
        public string Nome {  get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int Idade {  get; set; }

        public Aluno()
        {
        }

        public Aluno(int id, string nome, string email, int idade)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Idade = idade;
        }
    }
}
