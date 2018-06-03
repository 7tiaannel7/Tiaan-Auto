using System;
using System.Collections.Generic;
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
 
      var input = new InputRectangles();
      input.DeterminInputRectangles(amountOfRectangles, canvasInput);
    }
  }
}
