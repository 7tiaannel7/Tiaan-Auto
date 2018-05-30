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

    public void GenerateButton_Click(object sender, EventArgs e)
    {
      var amountOfRectangles = UserInputNumericDropdown.Value;
      AmountChosenLabel.Text = "You chose " + amountOfRectangles + " rectangles!";
      AmountChosenLabel.Visible = true;
 
      InputRectangles input = new InputRectangles();
      input.DeterminInputRectangles(amountOfRectangles);
    }


    public void canvas_Paint(object sender, PaintEventArgs e)
    {
      Graphics gObject = canvas.CreateGraphics();
      
 
      Pen blackPen = new Pen(Color.Black, 1);

      gObject.DrawRectangle(blackPen, 0, 239, 90, 61);
      gObject.DrawRectangle(blackPen, 90, 174, 76, 126);
      gObject.DrawRectangle(blackPen, 166, 67, 32, 233);

      //gObject.DrawRectangles();
    }
  }

   class InputRectangles
  {

    public void DeterminInputRectangles(decimal amountOfRectangles)
    {
      int x = 0;
      int canvasWidth = 400;
      int canvasHight = 300;

      var rectangles = new List<Rectangle>();

      for (int i = 0; i < amountOfRectangles; i++)
      {
        var random = new Random();
        var width = Math.Round(random.NextDouble() * (canvasWidth) + 5);
        var height = Math.Round(random.NextDouble() * (canvasHight) + 1);
        var y = canvasHight - height;

        rectangles.Add(new Rectangle
        {
          X = x,
          Y = (int)y,
          Width = (int)width,
          Height = (int)height
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
  }

}
