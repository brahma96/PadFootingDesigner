using PadFootingDesigner.Parameters.MaterialParameters;
using PadFootingDesigner.Reinforcement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadFootingDesigner.Parameters
{
    public class InputParameters
    {
        public InputParameters()
        {

        }
        public string FootingLabel { get; set; } = "PD - 001";

        public double Depth { get; set; } = 400;

        public double TaperHeight { get; set; } = 0;

        public double ConcreteCover { get; set; } = 40;

        public double Lx { get; set; } = 1000;

        public double Ly { get; set; } = 1000;

        public double EccentricityX { get; set; } = 0;

        public double EccentricityY { get; set; } = 0;

        public ConcreteMaterial Concrete { get; set; }

        public SteelMaterial Steel { get; set; }

        public List<Rebar> RebarList { get; set; }

        public SoilMaterial Soil { get; set; } = new SoilMaterial();
    }
}
