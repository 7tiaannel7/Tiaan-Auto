using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Tiaan_Rectangles
{
  public partial class MainApplication : Form
  {
    public MainApplication()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void GenerateButton_Click(object sender, EventArgs e)
    {
      var amountOfRectangles = UserInputNumericDropdown.Value;
      AmountChosenLabel.Text = "You chose " + amountOfRectangles + " rectangles!";
      AmountChosenLabel.Visible = true;

      DeterminInputRectangles(amountOfRectangles);
    }

    public void DeterminInputRectangles(decimal amountOfRectangles)
    {
      int x = 0;
      int canvasWidth = 400;
      int canvasHight = 300;
      int i;

      var rectangles = new List<Rectangle>();

      for (i = 0; i < amountOfRectangles; i++)
      {
        var random = new Random();
        var width = Math.Round(random.NextDouble() * (canvasWidth) + 5);
        var hight = Math.Round(random.NextDouble() * (canvasHight) + 1);
        var y = canvasHight - hight;

        rectangles.Add(new Rectangle
        {
          Name = "Rectangle" + (i + 1),
          X = x,
          Y = (int)y,
          Width = (int)width,
          Hight = (int)hight
        });

        x = (int)(x + width);
      }
      WriteInputFile(rectangles);
    }

    private static void WriteInputFile(List<Rectangle> rectangles)
    {
      const string inputFile = "InputRectangles.json";
      File.WriteAllText(inputFile, JsonConvert.SerializeObject(rectangles));
      using (StreamWriter file = File.CreateText(inputFile))
      {
        JsonSerializer serializer = new JsonSerializer();
        serializer.Serialize(file, rectangles);
      }
    }

    public class Rectangle
    {
      public string Name { get; set; }
      public int X { get; set; }
      public int Y { get; set; }
      public int Width { get; set; }
      public int Hight { get; set; }
    }
  }
}
