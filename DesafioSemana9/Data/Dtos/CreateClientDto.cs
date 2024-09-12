namespace DesafioSemana9.Data.Dtos;

public class CreateClientDto
{
    public string Name { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Profession { get; set; }
    public string Phone { get; set; }
    public int AddressId { get; set; }
}