using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrudOperationWithEntity.Models;
using System.Data.Entity;

namespace CrudOperationWithEntity.Models
{
    public class EmpContext:DbContext
    {
        public EmpContext():base("conn")
        {

        }
        public DbSet<Emp> emptable { get; set; }    
    }

}