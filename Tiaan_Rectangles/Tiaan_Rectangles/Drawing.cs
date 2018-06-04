using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiaan_Rectangles
{
  public class Drawing
  {

    public  void DrawRectangles(List<Rectangle> rectangleCoordinates, Panel canvas)
    {
      canvas.Refresh();
      var gObject = canvas.CreateGraphics();
      var colorPen = new Pen(Color.Red, 2);

      foreach (var rect in rectangleCoordinates)
      {
        gObject.DrawRectangle(colorPen, rect.X, rect.Y, rect.Width, rect.Height);
      }

    }
  }
}