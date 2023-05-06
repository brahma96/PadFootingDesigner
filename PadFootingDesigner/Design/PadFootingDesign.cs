using PadFootingDesigner.Model;
using PadFootingDesigner.Parameters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadFootingDesigner.Design
{
    public class PadFootingDesign
    {
        private PadFootingModel _padFooting;
        private InputParameters _inputParam;
        private DesignParameters _designParam;

        public PadFootingDesign(PadFootingModel padFooting, InputParameters inputParameters, DesignParameters designParameters)
        {
            _padFooting = padFooting;
            _inputParam = inputParameters;
            _designParam = designParameters;

            Checkings = new ObservableCollection<PadFootingDesignChecks>()
            {
                new PadFootingDesignChecks(){ Condition="Soil Stress (Net Bearing Cap / Max Soil Stress)", Unit="kN/m2", PassOrFail= 0 }
            };
        }

        //Create properties for the outcome for each checking
        //Create each method for each checking
        //outcome of method must be passed into them respective properties
        //Design() method to run them all at once
        public void Design()
        {
            DesignForSoilStress();

        }

        public void DesignForSoilStress()
        {
            SoilStress -= 15;

            //Checkings.Clear();
            Checkings[0] = new PadFootingDesignChecks() { Condition = "Soil Stress (Net Bearing Cap / Max Soil Stress)", Unit = "kN/m2", PassOrFail = SoilStress };

        }

        public double SoilStress { get; set; } = 550;

        public ObservableCollection<PadFootingDesignChecks> Checkings { get; set; }
    }

    public class PadFootingDesignChecks
    {
        public string Condition { get; set; }
        public string Unit { get; set; }
        public double PassOrFail { get; set; }
    }
}
