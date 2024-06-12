using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Nvd_lession07.Models
{
    public class NvdBookStore:DbContext
    {
        public NvdBookStore():base("NvdBookStoreConnectionString") { }
        //Khai báo các thuộc tính tương ứng với các bảng trong csdl
        public DbSet<NvdCategory> NvdCategories { get; set; }
        public DbSet<NvdBook> NvdBooks { get; set; }
    }
}