using HelixToolkit.WinUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleNavigationHelix.ViewModels
{
    public class HelixViewModel : BaseViewModel
    {

        public ObservableCollection<BoxViewModel> ObjectList { get; set; }

        public HelixViewModel()
        {
            ObjectList = new ObservableCollection<BoxViewModel>();
            ObjectList.Add(new BoxViewModel(0, 300, 0, true));


            SelectedColor = Colors[0];
        }

        public void AddBox ()
        {
            ObjectList.Add(new BoxViewModel(-400, 0, 0, true));
            ObjectList.Add(new BoxViewModel(0, 0, 0, false));
        }


        public List<PhongMaterial> Colors = new List<PhongMaterial>
        {
            PhongMaterials.Orange,
            PhongMaterials.Red,
            PhongMaterials.Green,
            PhongMaterials.Blue,
            PhongMaterials.Violet
        };

        private PhongMaterial _selectedColor;
        public PhongMaterial SelectedColor
        {
            get => _selectedColor;
            set
            {
                if (_selectedColor != value)
                {
                    _selectedColor = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
