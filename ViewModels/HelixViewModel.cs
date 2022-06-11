using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleNavigationHelix.ViewModels
{
    public class HelixViewModel
    {

        public ObservableCollection<BoxViewModel> ObjectList { get; set; }

        public HelixViewModel()
        {
            ObjectList = new ObservableCollection<BoxViewModel>();
            ObjectList.Add(new BoxViewModel(-400, 300, 0, true));
            ObjectList.Add(new BoxViewModel(0, 300, 0, false));
            ObjectList.Add(new BoxViewModel(400, 300, 0, true));
        }

        public void AddBox ()
        {
            ObjectList.Add(new BoxViewModel(-400, 0, 0, true));
            ObjectList.Add(new BoxViewModel(0, 0, 0, false));
        }
    }
}
