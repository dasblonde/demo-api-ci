using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class SpeakersModel
    {
        public string Bio { get; set; }
        public string Company { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
    }
}
