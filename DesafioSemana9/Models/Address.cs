using System.ComponentModel.DataAnnotations;

namespace DesafioSemana9.Models;

public class Address
{
    [Key]
    [Required]
    public int Id { get; set; }
    public string Neighborhood { get; set; }

    public string City { get; set; }

    public string AdditionalInfo { get; set; }

    public string State { get; set; }

    public string Street { get; set; }

    public int Number { get; set; }
    public int ClientId { get; set; }
    public virtual Client Client { get; set; }
}
