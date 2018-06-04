using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Tiaan_Rectangles
{
  public class OutputRectangles
  {
    private const string InputRectsFile = "InputRectangles.json";
    private const string OutputRectsFile = "OutputRectangles.json";

    public void DeterminOutputRectangles(Panel canvasOutput)
    {
      var originalRects = ReadInputFile();
      var solution = new List<Rectangle>();

  while (originalRects.Count != 0)
      {
        var leftMostSet = GetMostLeftSetOfRectangles(originalRects);
        var newHorisontalRect = GetNewRectangleFromSet(leftMostSet);
        solution.Add(newHorisontalRect);
        RemoveRectArea(newHorisontalRect, originalRects);
      }
      GetMostLeftSetOfRectangles(originalRects);
      DrawOutputRects(solution, canvasOutput);
      WriteOutputFile(solution);
    }

    private static void RemoveRectArea(Rectangle horisontalRect, List<Rectangle> originalRects)
    {
      //ToDo: This method will remove the newly identified rectangle from the original set. 
    }

    private static Rectangle GetNewRectangleFromSet(List<Rectangle> leftMostSet)
    {
      //ToDo: Calculates and returns the new horisontal rectangle with the lowest height that is part of the left most set. 
      //removing error for now by returning something. 
      return Rectangle.Empty;
    }

    private static List<Rectangle> GetMostLeftSetOfRectangles(List<Rectangle> originalRects)
    {
      var shortestHeight = originalRects.Min(rect => rect.Height);
      var shortestRect = originalRects.First(x => x.Height == shortestHeight);
      //ToDo: Returns the left most set of rectangles. So the rectangles that are all connected. 

      return originalRects;
    }

    private static List<Rectangle> ReadInputFile()
    {
      List<Rectangle> rects;

      using (var r = new StreamReader(InputRectsFile))
      {
        var json = r.ReadToEnd();
        rects = JsonConvert.DeserializeObject<List<Rectangle>>(json);
      }
      return rects;
    }

    private static void DrawOutputRects(List<Rectangle> rectangleCoordinates, Panel canvas)
    {
      var draw = new Drawing();
      draw.DrawRectangles(rectangleCoordinates, canvas);
    }

    private static void WriteOutputFile(List<Rectangle> solution)
    {
      File.WriteAllText(OutputRectsFile, JsonConvert.SerializeObject(solution));
      using (StreamWriter file = File.CreateText(OutputRectsFile))
      {
        JsonSerializer serializer = new JsonSerializer();
        serializer.Serialize(file, solution);
      }
    }
  }
}
