using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstWebsite.Models
{
    public class Context : DbContext
    {
        public virtual DbSet<ReshapeContact> ReshapeContacts { get; set; }

    }
}