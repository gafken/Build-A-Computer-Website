using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace buildacomputer.Models
{
    public class gpus
    {
        public int gpu_id { get; set; }

        public string gpu_name { get; set; }

        public string gpu_core_name { get; set; }

        public string gpu_directx_version { get; set; }

        public string gpu_opengl_version { get; set; }

        public int manufacturer_id { get; set; }

        public virtual manufacturers manufacturers { get; set; }
        public virtual ICollection<motherboards> motherboards { get; set; }
        public virtual ICollection<video_adapters> video_adapters { get; set; }
    }
}