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

    public  void DrawShit(List<Rectangle> rectangleCoordinates, Panel canvas)
    {
      canvas.Refresh();
      Graphics gObject = canvas.CreateGraphics();
      Pen colorPen = new Pen(Color.Blue, 2);

      for (var i = 0; i < rectangleCoordinates.Count; i++)
      {
        gObject.DrawRectangle(colorPen, rectangleCoordinates[i].X, rectangleCoordinates[i].Y, rectangleCoordinates[i].Width, rectangleCoordinates[i].Height);
      }

    }
  }
}