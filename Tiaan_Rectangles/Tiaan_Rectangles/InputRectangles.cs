using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Tiaan_Rectangles
{
  public class InputRectangles
  {
    private const string InputRectsFile = "InputRectangles.json";

    public void DeterminInputRectangles(decimal amountOfRectangles, Panel canvasInput)
    {
      var x = 0;
      const int canvasHeight = 400;
      const int canvasWidth = 500;
      var rectBoundry = Convert.ToInt32(canvasWidth / amountOfRectangles);

      var rectangles = new List<Rectangle>();

      for (var i = 0; i < amountOfRectangles; i++)
      {
        var width = RandomNumber(rectBoundry);
        var height = RandomNumber(canvasHeight);
        var y = canvasHeight - height;

        if(width == 0)
        {
          while (width == 0)
          {
            width = RandomNumber(rectBoundry);
          }
        }

        if (height == 0)
        {
          while (height == 0)
          {
            height = RandomNumber(canvasHeight);
          }
        }
        

        rectangles.Add(new Rectangle
        {
          X = x,
          Y = y,
          Width = width,
          Height = height
        });

        x = x + width;
      }
      WriteInputFile(rectangles);
      ReadInputFile(); 
      DrawInputRects(rectangles, canvasInput);
    }



    private static void WriteInputFile(List<Rectangle> rectangles)
    {
      File.WriteAllText(InputRectsFile, JsonConvert.SerializeObject(rectangles));
      using (StreamWriter file = File.CreateText(InputRectsFile))
      {
        JsonSerializer serializer = new JsonSerializer();
        serializer.Serialize(file, rectangles);
      }
    }

    public static List<Rectangle> ReadInputFile()
    {
        List<Rectangle> rects;

        using (var r = new StreamReader(InputRectsFile))
        {
          var json = r.ReadToEnd();
          rects = JsonConvert.DeserializeObject<List<Rectangle>>(json);
        }
        return rects;
    }

    private static void DrawInputRects(List<Rectangle> rectangleCoordinates, Panel canvas)
    {
      var draw = new Drawing();
      draw.DrawRectangles(rectangleCoordinates, canvas);
    }

    private static readonly Random RandomT = new Random();
    private static readonly object SyncLock = new object();
    public static int RandomNumber(int max)
    {
      lock (SyncLock)
      { 
        // synchronize
        return RandomT.Next(max);
      }
    }
  }
}