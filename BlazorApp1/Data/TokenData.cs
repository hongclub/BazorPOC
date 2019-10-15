using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TokenData
    {
        [Required]
        [MaxLength(50)]
        public string data { get; set; }

        [Required]
        public string tokenScheme { get; set; }
    }
}
