﻿using FuncionarioAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FuncionarioAPI.DataContext
{
    public class ApplicationDbContext : DbContext
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        
        public DbSet<FuncionarioModel> Funcionarios { get; set; }
     }

}
