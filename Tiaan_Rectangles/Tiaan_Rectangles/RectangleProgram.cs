using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


    public void Canvas_Paint(object sender, PaintEventArgs e)
    {
      Graphics gObject = canvasInput.CreateGraphics();
      Pen colorPen = new Pen(Color.Crimson, 2);

      gObject.DrawRectangle(colorPen, 0, 208, 28, 92);
      gObject.DrawRectangle(colorPen, 28, 290, 92, 10);
      gObject.DrawRectangle(colorPen, 120, 201, 87, 99);
      //gObject.DrawRectangle(colorPen, 166, 100, 32, 300);

      //gObject.DrawRectangle(colorPen, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
    }


  }
}
