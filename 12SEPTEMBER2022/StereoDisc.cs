using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12September
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public class StereoDiscAttribute: Attribute
    {
        public string SongName { get; set; }

        public string Language { get; set; }

        public string Lyrics { get; set; }
        public StereoDiscAttribute() {
        
        }
            

        

       
    }
}
