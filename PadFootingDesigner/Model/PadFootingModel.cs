using PadFootingDesigner.Design;
using PadFootingDesigner.Parameters.MaterialParameters;
using PadFootingDesigner.Reinforcement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadFootingDesigner.Model
{
    public class PadFootingModel
    {
        public string FootingLabel { get; set; }

        public double Depth { get; set; }

        public double TaperHeight { get; set; }

        public double ConcreteCover { get; set; }

        public double Lx { get; set; }

        public double Ly { get; set; }

        public double EccentricityX { get; set; }

        public double EccentricityY { get; set; }

        public ConcreteMaterial Concrete { get; set; }

        public SteelMaterial Steel { get; set; }

        public List<Rebar> RebarList { get; set; }

        public SoilMaterial Soil { get; set; }


        public double UserDefinedMinSpacing { get; set; }
        public double LeanConcreteThickness { get; set; }
        public bool RotationX { get; set; }
        public bool RotationY { get; set; }
        public double DepthIncrementStep { get; set; }
        public double SizeIncrementStep { get; set; }
        public double BarSpacingStep { get; set; }

        public bool ShowTopRebarOutside { get; set; }

        public PadFootingDesign DesignResults { get; set; }

    }
}
