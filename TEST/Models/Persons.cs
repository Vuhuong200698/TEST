using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TEST.Models
{
    public class Persons
    {
        [Key]
        public int PersonID { get; set; }

        [Required(ErrorMessage = "Hãy Nhập Tên")]
        public String PsName { get; set; }

        [Required(ErrorMessage = "Hãy Nhập Năm Sinh")]
        public int NamSinh { get; set; }

        [Required(ErrorMessage = "Hãy Nhập Địa Chỉ")]
        public String Address { get; set; }
    }
}