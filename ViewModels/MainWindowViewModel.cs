using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleNavigationHelix.ViewModels
{

   
    public class MainWindowViewModel
    {
        public HelixViewModel HelixViewModel { get; set; }
        public MainWindowViewModel ()
        {
            HelixViewModel = new HelixViewModel ();
        }

    }
}
