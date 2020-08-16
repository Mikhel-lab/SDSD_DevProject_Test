using SDSD_DevProject_Test.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SDSD_DevProject_Test.ViewModels
{
	public class IndexViewModel
	{
        [Required]
        [Display(Prompt = "Enter Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Unique transaction Number", Prompt = "Enter unique transaction number")]
        public string TransNumber { get; set; }

        public IEnumerable<UploadImage> Files { get; set; }

        public string href { get; set; }

        public IEnumerable<UploadDoc> UploadNames { get; set; }
    }
}
