using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleNavigationHelix.ViewModels
{
    public class BoxViewModel: BaseViewModel
    {
        private int _posX;
        private int _posY;
        private int _posZ;
        private bool _visible;

        public BoxViewModel(int posX, int posY, int posZ, bool visible) 
        {
            PosX = posX;
            PosY = posY;
            PosZ = posZ;
            Visible = visible;       
        
        }


        public int PosX
        {
            get => _posX;
            set
            {
                if(_posX != value)
                {
                    _posX = value;
                    NotifyPropertyChanged();
                }
            }

        }

        public int PosY
        {
            get => _posY;
            set
            {
                if (_posY != value)
                {
                    _posY = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int PosZ
        {
            get => _posZ;
            set
            {
                if (_posZ != value)
                {
                    _posZ = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool Visible
        {
            get => _visible;
            set
            {
                if (_visible != value)
                {
                    _visible = value;
                    NotifyPropertyChanged();
                }
            }
        }

    }
}
