namespace Tiaan_Rectangles
{
  partial class MainApplication
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.GenerateButton = new System.Windows.Forms.Button();
      this.InstructionLabel = new System.Windows.Forms.Label();
      this.UserInputNumericDropdown = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.AmountChosenLabel = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.UserInputNumericDropdown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.SuspendLayout();
      // 
      // GenerateButton
      // 
      this.GenerateButton.Location = new System.Drawing.Point(388, 54);
      this.GenerateButton.Name = "GenerateButton";
      this.GenerateButton.Size = new System.Drawing.Size(82, 20);
      this.GenerateButton.TabIndex = 0;
      this.GenerateButton.Text = "Generate";
      this.GenerateButton.UseVisualStyleBackColor = true;
      this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
      // 
      // InstructionLabel
      // 
      this.InstructionLabel.AutoSize = true;
      this.InstructionLabel.Location = new System.Drawing.Point(34, 57);
      this.InstructionLabel.Name = "InstructionLabel";
      this.InstructionLabel.Size = new System.Drawing.Size(205, 13);
      this.InstructionLabel.TabIndex = 4;
      this.InstructionLabel.Text = "Please enter a number between 3 and 30:";
      // 
      // UserInputNumericDropdown
      // 
      this.UserInputNumericDropdown.Location = new System.Drawing.Point(245, 54);
      this.UserInputNumericDropdown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
      this.UserInputNumericDropdown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
      this.UserInputNumericDropdown.Name = "UserInputNumericDropdown";
      this.UserInputNumericDropdown.Size = new System.Drawing.Size(120, 20);
      this.UserInputNumericDropdown.TabIndex = 5;
      this.UserInputNumericDropdown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(476, 101);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(0, 13);
      this.label2.TabIndex = 7;
      // 
      // AmountChosenLabel
      // 
      this.AmountChosenLabel.AutoSize = true;
      this.AmountChosenLabel.Location = new System.Drawing.Point(507, 101);
      this.AmountChosenLabel.Name = "AmountChosenLabel";
      this.AmountChosenLabel.Size = new System.Drawing.Size(43, 13);
      this.AmountChosenLabel.TabIndex = 8;
      this.AmountChosenLabel.Text = "Amount";
      this.AmountChosenLabel.Visible = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(37, 191);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(400, 300);
      this.pictureBox1.TabIndex = 9;
      this.pictureBox1.TabStop = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Location = new System.Drawing.Point(479, 191);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(400, 300);
      this.pictureBox2.TabIndex = 10;
      this.pictureBox2.TabStop = false;
      // 
      // MainApplication
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1012, 580);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.AmountChosenLabel);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.UserInputNumericDropdown);
      this.Controls.Add(this.InstructionLabel);
      this.Controls.Add(this.GenerateButton);
      this.Name = "MainApplication";
      this.Text = "Tiaan Nel - Rectangles";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.UserInputNumericDropdown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button GenerateButton;
    private System.Windows.Forms.Label InstructionLabel;
    private System.Windows.Forms.NumericUpDown UserInputNumericDropdown;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label AmountChosenLabel;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
  }
}

