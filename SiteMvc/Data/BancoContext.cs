using Microsoft.EntityFrameworkCore;
using SiteMvc.Models;
using System;
using System.Collections.Generic;

namespace SiteMvc.Data
{
    public class BancoContext : DbContext
    {
        //Dbcontext eh a representacao da sessao com o banco
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { 
        }
        public DbSet<ContactModel> Contacts {  get; set; }
    }

}
