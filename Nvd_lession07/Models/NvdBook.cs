using Nvd_Lession07_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nvd_Lession07_1.Models
{
    public class NvdBook
    {
        [Key]
        public int NvdId { get; set; }
        public string NvdBookId { get; set; }
        public string NvdTitle { get; set; }
        public string NvdAuthor { get; set; }
        public int NvdYear { get; set; }
        public string NvdPulisher { get; set; }
        public int NvdCategoryId { get; set; }
        // Thuộc tính quan hệ
        public virtual NvdCategory NvdCategory { get; set; }
    }
}