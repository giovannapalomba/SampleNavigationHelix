using HelixToolkit.SharpDX.Core;
using HelixToolkit.WinUI;
using Microsoft.UI.Xaml;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleNavigationHelix.CustomUIElement
{
    public class CustomBox3D : BatchedMeshGeometryModel3D
    {

        public  CustomBox3D() 
        {
            this.Material = DiffuseMaterials.White;

            List<BatchedMeshGeometryConfig>  geometryConfigs = new();
            var mesh = new MeshBuilder();
            mesh.AddBox(new Vector3(0, 0, 0), 300, 200, 100, BoxFaces.All);
            geometryConfigs.Add(new BatchedMeshGeometryConfig(mesh.ToMeshGeometry3D(), Matrix.Identity, 0));
            this.BatchedGeometries = geometryConfigs;

            this.BatchedMaterials =new List<Material>() { PhongMaterials.Orange };
        }

        public int PosX { get => (int)GetValue(PosXProperty); set => SetValue(PosXProperty, value); }
        public static DependencyProperty PosXProperty = DependencyProperty.Register(nameof(PosX), typeof(int), typeof(CustomBox3D), new PropertyMetadata(0, TransformChanged));

        public int PosY { get => (int)GetValue(PosYProperty); set => SetValue(PosYProperty, value); }
        public static DependencyProperty PosYProperty = DependencyProperty.Register(nameof(PosY), typeof(int), typeof(CustomBox3D), new PropertyMetadata(0, TransformChanged));

        public int PosZ { get => (int)GetValue(PosZProperty); set => SetValue(PosZProperty, value); }

        public static DependencyProperty PosZProperty = DependencyProperty.Register(nameof(PosZ), typeof(int), typeof(CustomBox3D), new PropertyMetadata(0, TransformChanged));

        private static void TransformChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is CustomBox3D)
            {
                CustomBox3D box = d as CustomBox3D;

                box.HxTransform3D = Matrix.Translation(new Vector3(box.PosX, box.PosY, box.PosZ));
            }
        }
    }
}
