using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadFootingDesigner.Parameters
{
    public class DesignParameters
    {
        public double UserDefinedMinSpacing { get; set; } = 40;
        public double LeanConcreteThickness { get; set; } = 100;
        public bool RotationX { get; set; } = false;
        public bool RotationY { get; set; } = false;
        public double DepthIncrementStep { get; set; } = 100;
        public double SizeIncrementStep { get; set; } = 100;
        public double BarSpacingStep { get; set; } = 100;

        public bool ShowTopRebarOutside { get; set; } = false;
    }
}
