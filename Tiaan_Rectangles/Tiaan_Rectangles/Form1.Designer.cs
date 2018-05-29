namespace Tiaan_Rectangles
{
  partial class Form1
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
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.userInputNumericDropdown = new System.Windows.Forms.NumericUpDown();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label2 = new System.Windows.Forms.Label();
      this.AmountChosenlbl = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.userInputNumericDropdown)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(388, 54);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(82, 20);
      this.button1.TabIndex = 0;
      this.button1.Text = "Generate";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Location = new System.Drawing.Point(15, 164);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(489, 325);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Horizontal";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(34, 57);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(205, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Please enter a number between 3 and 30:";
      // 
      // userInputNumericDropdown
      // 
      this.userInputNumericDropdown.Location = new System.Drawing.Point(245, 54);
      this.userInputNumericDropdown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
      this.userInputNumericDropdown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
      this.userInputNumericDropdown.Name = "userInputNumericDropdown";
      this.userInputNumericDropdown.Size = new System.Drawing.Size(120, 20);
      this.userInputNumericDropdown.TabIndex = 5;
      this.userInputNumericDropdown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // groupBox2
      // 
      this.groupBox2.Location = new System.Drawing.Point(510, 164);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(489, 325);
      this.groupBox2.TabIndex = 6;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Vertical";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(476, 101);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(0, 13);
      this.label2.TabIndex = 7;
      // 
      // AmountChosenlbl
      // 
      this.AmountChosenlbl.AutoSize = true;
      this.AmountChosenlbl.Location = new System.Drawing.Point(507, 101);
      this.AmountChosenlbl.Name = "AmountChosenlbl";
      this.AmountChosenlbl.Size = new System.Drawing.Size(43, 13);
      this.AmountChosenlbl.TabIndex = 8;
      this.AmountChosenlbl.Text = "Amount";
      this.AmountChosenlbl.Visible = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1012, 580);
      this.Controls.Add(this.AmountChosenlbl);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.userInputNumericDropdown);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Tiaan Nel - Rectangles";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.userInputNumericDropdown)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown userInputNumericDropdown;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label AmountChosenlbl;
  }
}

