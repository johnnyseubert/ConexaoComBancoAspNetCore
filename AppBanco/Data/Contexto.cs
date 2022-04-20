using AppBanco.Models;
using Microsoft.EntityFrameworkCore;

namespace AppBanco.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }
        //para adicionar uma migration utilizar o comando

        // Add-Migration NOME_DA_MIGRATION -Context Nome do Contexto/Arquivo Exemplo
        //Add-Migration Criacao-Inicial -Context Contexto
    }
}
