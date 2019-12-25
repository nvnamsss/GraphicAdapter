using GraphicsAdapter.Drawing;
using GraphicsAdapter.Drawing.Graphics.GDIs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GraphicsAdapter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public GDICommonGraphic GDI;
        public MainWindow()
        {
            InitializeComponent();
            Graphics grp = Graphics.FromHwnd(new System.Windows.Interop.WindowInteropHelper(this).Handle);
            GDI = new GDICommonGraphic(grp, System.Drawing.Color.CornflowerBlue, 1);
            GDI.Background = System.Drawing.Color.Red;
        }

        private void cvSurface_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Hi mom");
            var p = e.GetPosition(this);
            Vector2 from = new Vector2((float)p.X, (float)p.Y);

            GDI.DrawRectangle(from, from + new Vector2(25, 25));
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var p = e.GetPosition(this);
            p = cvSurface.PointToScreen(p);
            Vector2 from = new Vector2((float)p.X, (float)p.Y);
            Drawing.Shapes.Rect rect = new Drawing.Shapes.Rect(from, from + new Vector2(25, 25));
            //rect.Draw(GDI);

            //Drawing.Shapes.Line line = new Drawing.Shapes.Line(from, from + new Vector2(25, 25));
            //line.Draw(GDI);

            Drawing.Effects.Highlight highlight = new Drawing.Effects.Highlight(rect);
            //highlight.Draw(GDI);
            Drawing.Effects.Shadow shadow = new Drawing.Effects.Shadow(highlight);
            //shadow.Draw(GDI);

            Drawing.Effects.Border border = new Drawing.Effects.Border(shadow);
            border.Draw(GDI);

            Drawing.Shapes.Star star = new Drawing.Shapes.Star(from, from + new Vector2(25, 25));
            star.Draw(GDI);
        }
    }
}
