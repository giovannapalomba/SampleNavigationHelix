using HelixToolkit.SharpDX.Core;
using HelixToolkit.WinUI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using SampleNavigationHelix.ViewModels;
using SharpDX;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SampleNavigationHelix.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HelixPageView : Page
    {
        public HelixPageView()
        {

            this.InitializeComponent();

            ViewModel =MainWindowViewModel.HelixViewModel;

            viewport.FixedRotationPoint = new Vector3(0, 0, 200);

            viewport.Camera = new PerspectiveCamera()
            {
                LookDirection = new Vector3(-2000, 2000, -2000),
                Position = new Vector3(2000, -2000, 2000),
                UpDirection = new Vector3(0, 0, 1),
                FieldOfView = 45,
                FarPlaneDistance = double.PositiveInfinity,
                NearPlaneDistance = 0.1f
            };

            viewport.EffectsManager = new DefaultEffectsManager();
        }


        public HelixViewModel ViewModel { get; set; }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            // viewport.Dispose(); // System.Runtime.InteropServices.COMException
            //viewport.Detach();
            //viewport.DataContext = null;
            //viewport.RenderHost.Dispose();


            //GC.Collect(2, GCCollectionMode.Forced);
            //GC.Collect(2, GCCollectionMode.Forced);
            //GC.WaitForFullGCComplete();
        }
    }
}
