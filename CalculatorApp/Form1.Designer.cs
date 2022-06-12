namespace CalculatorApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        // this.components = new System.ComponentModel.Container();
        // this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        // this.ClientSize = new System.Drawing.Size(800, 450);
        // this.Text = "Form1";
        
        
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.calculatorDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OneButton
            // 
            this.OneButton.Location = new System.Drawing.Point(21, 299);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(76, 56);
            this.OneButton.TabIndex = 0;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += button1_Click;
            // 
            // TwoButton
            // 
            this.TwoButton.Location = new System.Drawing.Point(103, 299);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(76, 56);
            this.TwoButton.TabIndex = 1;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += button2_Click;
            // 
            // ThreeButton
            // 
            this.ThreeButton.Location = new System.Drawing.Point(185, 299);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(76, 56);
            this.ThreeButton.TabIndex = 2;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += button3_Click;
            // 
            // FourButton
            // 
            this.FourButton.Location = new System.Drawing.Point(21, 237);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(76, 56);
            this.FourButton.TabIndex = 3;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += button4_Click;
            // 
            // FiveButton
            // 
            this.FiveButton.Location = new System.Drawing.Point(103, 237);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(76, 56);
            this.FiveButton.TabIndex = 4;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += button5_Click;
            // 
            // SixButton
            // 
            this.SixButton.Location = new System.Drawing.Point(185, 237);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(76, 56);
            this.SixButton.TabIndex = 5;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += button6_Click;
            // 
            // SevenButton
            // 
            this.SevenButton.Location = new System.Drawing.Point(21, 175);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(76, 56);
            this.SevenButton.TabIndex = 6;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += button7_Click;
            // 
            // EightButton
            // 
            this.EightButton.Location = new System.Drawing.Point(103, 175);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(76, 56);
            this.EightButton.TabIndex = 7;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += button8_Click;
            // 
            // NineButton
            // 
            this.NineButton.Location = new System.Drawing.Point(185, 175);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(76, 56);
            this.NineButton.TabIndex = 8;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += button9_Click;
            // 
            // DecimalButton
            // 
            this.DecimalButton.Location = new System.Drawing.Point(185, 361);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(76, 56);
            this.DecimalButton.TabIndex = 9;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += buttonDecimal_Click;
            // 
            // ZeroButton
            // 
            this.ZeroButton.Location = new System.Drawing.Point(21, 361);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(158, 56);
            this.ZeroButton.TabIndex = 10;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += button0_Click;
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(185, 113);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(76, 56);
            this.MultiplyButton.TabIndex = 11;
            this.MultiplyButton.Text = "X";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += buttonMultiply_Click;
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(267, 113);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(76, 56);
            this.DivideButton.TabIndex = 12;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += buttonDivide_Click;
            // 
            // SubtractButton
            // 
            this.SubtractButton.Location = new System.Drawing.Point(267, 175);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(76, 56);
            this.SubtractButton.TabIndex = 13;
            this.SubtractButton.Text = "-";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += buttonSubtract_Click;
            // 
            // Addition
            // 
            this.AdditionButton.Location = new System.Drawing.Point(267, 237);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(76, 56);
            this.AdditionButton.TabIndex = 14;
            this.AdditionButton.Text = "+";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += buttonAdd_Click;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(21, 113);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(158, 56);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += buttonClear_Click;
            // 
            // EqualsButton
            // 
            this.EqualsButton.Location = new System.Drawing.Point(267, 299);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(76, 118);
            this.EqualsButton.TabIndex = 16;
            this.EqualsButton.Text = "Equals";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += buttonEquals_Click;
            // 
            // calculatorDisplay
            // 
            this.calculatorDisplay.Location = new System.Drawing.Point(21, 12);
            this.calculatorDisplay.Multiline = true;
            this.calculatorDisplay.Name = "calculatorDisplay";
            this.calculatorDisplay.Size = new System.Drawing.Size(322, 95);
            this.calculatorDisplay.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.calculatorDisplay);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AdditionButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private Button OneButton;
    private Button TwoButton;
    private Button ThreeButton;
    private Button FourButton;
    private Button FiveButton;
    private Button SixButton;
    private Button SevenButton;
    private Button EightButton;
    private Button NineButton;
    private Button DecimalButton;
    private Button ZeroButton;
    private Button MultiplyButton;
    private Button DivideButton;
    private Button SubtractButton;
    private Button AdditionButton;
    private Button ClearButton;
    private Button EqualsButton;
    private TextBox calculatorDisplay;
    
    #endregion
}