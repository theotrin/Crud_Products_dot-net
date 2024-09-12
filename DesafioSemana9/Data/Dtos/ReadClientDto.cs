using DesafioSemana9.Models;

namespace DesafioSemana9.Data.Dtos;

public class ReadClientDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Profession { get; set; }
    public string Phone { get; set; }
    public int AddressId { get; set; }
    public virtual ReadAddressDto ReadAddressDto { get; set; }
}
