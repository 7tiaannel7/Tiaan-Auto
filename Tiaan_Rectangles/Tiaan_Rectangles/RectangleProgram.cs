using System;
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
      AmountChosenLabel.Text = @"You chose " + amountOfRectangles + @" rectangles!";
      AmountChosenLabel.Visible = true;
 
      var input = new InputRectangles();
      input.DeterminInputRectangles(amountOfRectangles, canvasInput);

      //Commenting out below as this is incomplete, so the application can still run and not be stuck in a loop. 

      /*
      var output = new OutputRectangles();
      output.DeterminOutputRectangles(canvasOutput);
      */
    }
  }
}
