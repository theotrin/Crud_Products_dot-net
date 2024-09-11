﻿using DesafioSemana9.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioSemana9.Data;

public class ProductContext : DbContext
{
    public ProductContext(DbContextOptions<ProductContext> options) : base(options)
    {

    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Address> Addresses { get; set; }

}
