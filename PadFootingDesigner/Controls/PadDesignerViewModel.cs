using PadFootingDesigner.Parameters.MaterialParameters;
using PadFootingDesigner.Parameters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PadFootingDesigner.Commands;
using System.Windows;
using System.Collections.ObjectModel;
using PadFootingDesigner.Model;
using PadFootingDesigner.Design;
using PadFootingDesigner.Windows;
using PadFootingDesigner.Controls.MaterialsControl;

namespace PadFootingDesigner.Controls
{
    public class PadDesignerViewModel : INotifyPropertyChanged
    {
        private InputParameters inputParam;
        private DesignParameters designParam;
        private PadFootingModel padFootingModel;
        private PadFootingDesign padDesign;


        public PadDesignerViewModel()
        {
            inputParam = new InputParameters();
            designParam = new DesignParameters();

            padFootingModel = new PadFootingModel();
            AssignInputParamsToPadFootingModel();

            padDesign = new PadFootingDesign(padFootingModel, inputParam, designParam);


            CancelCommand = new RelayCommand((parameter) => Application.Current.Shutdown());
            DesignCommand = new RelayCommand((parameter) => padDesign.Design());
            ConcreteCommand = new RelayCommand((parameter) => OpenConcreteSelectionWindow());

            //materialsSteel = new ObservableCollection<SteelMaterial>
            //{
            //    new SteelMaterial{ MaterialName="bsdcsod", ModulusOfElasticity=48888, UnitWeight=84},
            //    new SteelMaterial{ MaterialName="dfefes", ModulusOfElasticity=15776, UnitWeight=51},
            //    new SteelMaterial{ MaterialName="wefwew", ModulusOfElasticity=78564, UnitWeight=90}

            //};
        }

        private void AssignInputParamsToPadFootingModel()
        {
            padFootingModel.FootingLabel = inputParam.FootingLabel;
            padFootingModel.Depth = inputParam.Depth;
            padFootingModel.TaperHeight = inputParam.TaperHeight;
            padFootingModel.ConcreteCover = inputParam.ConcreteCover;
            padFootingModel.Lx = inputParam.Lx;
            padFootingModel.Ly = inputParam.Ly;
            padFootingModel.EccentricityX = inputParam.EccentricityX;
            padFootingModel.EccentricityY = inputParam.EccentricityY;
            //Concrete, Steel, RebarList not assigned yet
            padFootingModel.Soil = inputParam.Soil;

            padFootingModel.UserDefinedMinSpacing = designParam.UserDefinedMinSpacing;
            padFootingModel.LeanConcreteThickness = designParam.LeanConcreteThickness;
            padFootingModel.RotationX = designParam.RotationX;
            padFootingModel.RotationY = designParam.RotationY;
            padFootingModel.DepthIncrementStep = designParam.DepthIncrementStep;
            padFootingModel.SizeIncrementStep = designParam.SizeIncrementStep;
            padFootingModel.BarSpacingStep = designParam.BarSpacingStep;
            padFootingModel.ShowTopRebarOutside = designParam.ShowTopRebarOutside;
        }

        //public ObservableCollection<SteelMaterial> materialsSteel { get; private set; }

        public ObservableCollection<PadFootingDesignChecks> Checkings
        {
            get { return padDesign.Checkings; }
        }

        public string FootingLabel
        {
            get { return padFootingModel.FootingLabel; }
            set 
            {
                if (padFootingModel.FootingLabel != value)
                {
                    padFootingModel.FootingLabel = value;
                    OnPropertyChanged("FootingLabel");
                    OnPropertyChanged("DesignOutput");

                }
            }
        }

        public double Depth
        {
            get { return padFootingModel.Depth; }
            set
            {
                if (padFootingModel.Depth != value)
                {
                    padFootingModel.Depth = value;
                    OnPropertyChanged("Depth");
                }
            }
        }

        public double TaperHeight
        {
            get { return padFootingModel.TaperHeight; }
            set
            {
                if (padFootingModel.TaperHeight != value)
                {
                    padFootingModel.TaperHeight = value;
                    OnPropertyChanged("TaperHeight");
                }
            }
        }

        public double ConcreteCover
        {
            get { return padFootingModel.ConcreteCover; }
            set
            {
                if (padFootingModel.ConcreteCover != value)
                {
                    padFootingModel.ConcreteCover = value;
                    OnPropertyChanged("ConcreteCover");
                }
            }
        }

        public double Lx
        {
            get { return padFootingModel.Lx; }
            set
            {
                if (padFootingModel.Lx != value)
                {
                    padFootingModel.Lx = value;
                    OnPropertyChanged("Lx");
                }
            }
        }

        public double Ly
        {
            get { return padFootingModel.Ly; }
            set
            {
                if (padFootingModel.Ly != value)
                {
                    padFootingModel.Ly = value;
                    OnPropertyChanged("Ly");
                }
            }
        }

        public double EccentricityX
        {
            get { return padFootingModel.EccentricityX; }
            set
            {
                if (padFootingModel.EccentricityX != value)
                {
                    padFootingModel.EccentricityX = value;
                    OnPropertyChanged("EccentricityX");
                }
            }
        }

        public double EccentricityY
        {
            get { return padFootingModel.EccentricityY; }
            set
            {
                if (padFootingModel.EccentricityY != value)
                {
                    padFootingModel.EccentricityY = value;
                    OnPropertyChanged("EccentricityY");
                }
            }
        }

        public double UltimateStressOfSoil
        {
            get { return padFootingModel.Soil.UltimateStressOfSoil; }
            set
            {
                if (padFootingModel.Soil.UltimateStressOfSoil != value)
                {
                    padFootingModel.Soil.UltimateStressOfSoil = value;
                    OnPropertyChanged("UltimateStressOfSoil");
                }
            }
        }

        public double SoilUnitWeight
        {
            get { return padFootingModel.Soil.SoilUnitWeight; }
            set
            {
                if (padFootingModel.Soil.SoilUnitWeight != value)
                {
                    padFootingModel.Soil.SoilUnitWeight = value;
                    OnPropertyChanged("SoilUnitWeight");
                }
            }
        }

        public double FillHeight
        {
            get { return padFootingModel.Soil.FillHeight; }
            set
            {
                if (padFootingModel.Soil.FillHeight != value)
                {
                    padFootingModel.Soil.FillHeight = value;
                    OnPropertyChanged("FillHeight");
                }
            }
        }

        public double BearingCapacity
        {
            get { return padFootingModel.Soil.BearingCapacity; }
            set
            {
                if (padFootingModel.Soil.BearingCapacity != value)
                {
                    padFootingModel.Soil.BearingCapacity = value;
                    OnPropertyChanged("BearingCapacity");
                }
            }
        }

        public double UltimateStrengthFactor
        {
            get { return padFootingModel.Soil.UltimateStrengthFactor; }
            set
            {
                if (padFootingModel.Soil.UltimateStrengthFactor != value)
                {
                    padFootingModel.Soil.UltimateStrengthFactor = value;
                    OnPropertyChanged("UltimateStrengthFactor");
                }
            }
        }

        public PadFootingDesign DesignResults
        {
            get { return padFootingModel.DesignResults; }
            private set
            {
                OnPropertyChanged("DesignResults");
            }
        }


        private bool _isOption6Selected = false;
        public bool IsOption6Checked
        {
            get { return _isOption6Selected; }
            set
            {
                if (_isOption6Selected != value)
                {
                    _isOption6Selected = value;

                    if (_isOption6Selected)
                    {
                        padFootingModel.EccentricityX = 0 + (padFootingModel.Lx - 500) / 2;
                        OnPropertyChanged("EccentricityX");
                    }
                }
            }
        }

        private bool _isOption5Selected = true;
        public bool IsOption5Checked
        {
            get { return _isOption5Selected; }
            set
            {
                if (_isOption5Selected != value)
                {
                    _isOption5Selected = value;

                    if (_isOption5Selected)
                    {
                        padFootingModel.EccentricityX = 0;
                        OnPropertyChanged("EccentricityX");
                    }
                }
            }
        }











        public string DesignOutput
        {
            get
            {
                return padFootingModel.FootingLabel;
            }
        }

        //public double FillHeight
        //{
        //    get
        //    {
        //        return padFootingModel.Soil.FillHeight;
        //    }
        //}

        public ICommand CancelCommand { get; set; }
        public ICommand DesignCommand { get; set; }
        public ICommand ConcreteCommand { get; set; }
        //havent add relaycommand yet


        private void OpenConcreteSelectionWindow()
        {
            ConcreteSelectionWindow concreteWindow = new ConcreteSelectionWindow()
            {
                DataContext = new ConcreteSelectionViewModel()
            };
            concreteWindow.Show();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
