using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Tiaan_Rectangles
{
  internal class InputRectangles
  {
    private const string InputRectsFile = "InputRectangles.json";

    public void DeterminInputRectangles(decimal amountOfRectangles)
    {
      var x = 0;
      int canvasHight = 300;
      int canvasWidth = 400;
      int rectMaxHight = Convert.ToInt32(canvasHight / amountOfRectangles);
      int rectMaxWidth = Convert.ToInt32(canvasWidth / amountOfRectangles);

      
      var rectangles = new List<Rectangle>();

      for (var i = 0; i < amountOfRectangles; i++)
      {
        int width = RandomNumber(rectMaxWidth);
        int height = RandomNumber(rectMaxHight);
        int y = canvasHight - height;

        //validate W & H is not 0

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
      //ReadInputFile();
      DrawInputRects();
    }

    private void DrawInputRects()
    {
      
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

    private static void ReadInputFile()
    {
      string readResult = string.Empty;
      using (StreamReader r = new StreamReader(InputRectsFile))
      {
        var json = r.ReadToEnd();
        var jobj = JObject.Parse(json);
        readResult = jobj.ToString();
      }
    }

    private static readonly Random random1 = new Random();
    private static readonly object syncLock = new object();
    public static int RandomNumber(int max)
    {
      lock (syncLock)
      { // synchronize
        return random1.Next(max);
      }
    }
  }
}