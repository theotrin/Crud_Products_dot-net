using System.ComponentModel.DataAnnotations;

namespace DesafioSemana9.Models;

public class Client
{
    [Key]
    [Required]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Profession { get; set; }
    public string Phone { get; set; }
    public int EnderecoId { get; set; }
    public virtual Address Address { get; set; }
}
