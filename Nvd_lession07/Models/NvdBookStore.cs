using Nvd_Lession07_.Models;
using Nvd_Lession07_1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Nvd_lession07.Models
{
    public class NvdBookStore : DbContext
    {
        public NvdBookStore() : base() { }
        // Khai báo các thuộc tính tương ứng với các bảng trong csdl
        public DbSet<NvdCategory> NvdCategories { get; set; }
        public DbSet<NvdBook> NvdBooks { get; set; }
    }

}