using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nvd_lession07.Models
{
    public class NvdCategory
    {
        [Key]
        public int NvdId { get; set; }
        public string NvdCategoryName { get; set; }
        //Thuộc tính quan hệ
        public virtual ICollection<NvdBook> NvdBooks { get; set; }
    }
}