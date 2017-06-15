using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Contoso.Models;

namespace EFCodeFirst
{
    public class ContosoContext:DbContext
    {
        public virtual DbSet<People> Peoples { get; set; }
        public virtual DbSet<Courses> Course { get; set; }
        public virtual DbSet<Departments> Department { get; set; }
    }
}