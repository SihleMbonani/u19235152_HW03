using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace u19235152_HW03.Models
{
    public class FileModel
    {
        [Display(Name="FileName")] //Display option
        public string FileName { get; set; }
    }
}