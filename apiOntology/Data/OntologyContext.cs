using System;
using apiOntology.Models;
using Microsoft.EntityFrameworkCore;

namespace apiOntology.Data
{
    public class OntologyContext: DbContext
    {

        public OntologyContext(DbContextOptions<OntologyContext> options) : base(options)
        {

        }
        public DbSet<Code> Codes { get; set;}

    }
}
