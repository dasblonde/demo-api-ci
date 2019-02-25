using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class SessionModel
    {
        public string Abstract { get; set; }
        public string[] SpeakerNames { get; set; }
        public string Title { get; set; }
    }
}
