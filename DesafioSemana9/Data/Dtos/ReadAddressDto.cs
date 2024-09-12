﻿using DesafioSemana9.Models;

namespace DesafioSemana9.Data.Dtos;

public class ReadAddressDto
{
    public int Id { get; set; }
    public string Neighborhood { get; set; }

    public string City { get; set; }

    public string AdditionalInfo { get; set; }

    public string State { get; set; }

    public string Street { get; set; }

    public int Number { get; set; }
}
