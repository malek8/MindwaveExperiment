using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindwave.Controller
{
    public class BrainWaves
    {
        public float Alpha1 { get; internal set; }
        public float Alpha2 { get; internal set; }
        public float Delta { get; internal set; }
        public float Theta { get; internal set; }
        public float Beta1 { get; internal set; }
        public float Beta2 { get; internal set; }
        public float Gamma1 { get; internal set; }
        public float Gamma2 { get; internal set; }
        public float Raw { get; internal set; }
        public float Attention { get; internal set; }
        public float Meditation { get; internal set; }
        public float Signal { get; internal set; }
    }
}
