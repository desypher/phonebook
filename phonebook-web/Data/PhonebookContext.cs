using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using phonebook_data.phonebook_data;

namespace phonebook_web.Data
{
    public class PhonebookContext : DbContext
    {
        public DbSet<phonebookEntities> Phonebooks { get; set; }
        public DbSet<Phonebook> PhonebookModel { get; set; }

        public PhonebookContext(DbContextOptions<PhonebookContext> options) : base(options)
        {

        }

    }
}
