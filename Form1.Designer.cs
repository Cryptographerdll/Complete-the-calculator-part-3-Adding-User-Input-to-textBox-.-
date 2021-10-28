
namespace BasicCalculatorWindows
{
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonsPannel = new System.Windows.Forms.TableLayoutPanel();
            this.EqualButton = new System.Windows.Forms.Button();
            this.PointButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.ForthButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.PercentageButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CEbutton = new System.Windows.Forms.Button();
            this.DevideButton = new System.Windows.Forms.Button();
            this.ButtonsPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "User Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "please enter an operation and press enter or =";
            // 
            // ButtonsPannel
            // 
            this.ButtonsPannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPannel.ColumnCount = 4;
            this.ButtonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPannel.Controls.Add(this.EqualButton, 2, 4);
            this.ButtonsPannel.Controls.Add(this.PointButton, 1, 4);
            this.ButtonsPannel.Controls.Add(this.ZeroButton, 0, 4);
            this.ButtonsPannel.Controls.Add(this.PlusButton, 3, 3);
            this.ButtonsPannel.Controls.Add(this.ThreeButton, 2, 3);
            this.ButtonsPannel.Controls.Add(this.TwoButton, 1, 3);
            this.ButtonsPannel.Controls.Add(this.OneButton, 0, 3);
            this.ButtonsPannel.Controls.Add(this.MinusButton, 3, 2);
            this.ButtonsPannel.Controls.Add(this.SixButton, 2, 2);
            this.ButtonsPannel.Controls.Add(this.FiveButton, 1, 2);
            this.ButtonsPannel.Controls.Add(this.ForthButton, 0, 2);
            this.ButtonsPannel.Controls.Add(this.MultiplyButton, 3, 1);
            this.ButtonsPannel.Controls.Add(this.nineButton, 2, 1);
            this.ButtonsPannel.Controls.Add(this.EightButton, 1, 1);
            this.ButtonsPannel.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonsPannel.Controls.Add(this.PercentageButton, 3, 0);
            this.ButtonsPannel.Controls.Add(this.RemoveButton, 2, 0);
            this.ButtonsPannel.Controls.Add(this.CEbutton, 0, 0);
            this.ButtonsPannel.Controls.Add(this.DevideButton, 3, 4);
            this.ButtonsPannel.Location = new System.Drawing.Point(12, 74);
            this.ButtonsPannel.Name = "ButtonsPannel";
            this.ButtonsPannel.RowCount = 7;
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ButtonsPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsPannel.Size = new System.Drawing.Size(459, 376);
            this.ButtonsPannel.TabIndex = 2;
            // 
            // EqualButton
            // 
            this.EqualButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualButton.Location = new System.Drawing.Point(231, 279);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(108, 63);
            this.EqualButton.TabIndex = 18;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // PointButton
            // 
            this.PointButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PointButton.Location = new System.Drawing.Point(117, 279);
            this.PointButton.Name = "PointButton";
            this.PointButton.Size = new System.Drawing.Size(108, 63);
            this.PointButton.TabIndex = 17;
            this.PointButton.Text = ".";
            this.PointButton.UseVisualStyleBackColor = true;
            this.PointButton.Click += new System.EventHandler(this.PointButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Location = new System.Drawing.Point(3, 279);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(108, 63);
            this.ZeroButton.TabIndex = 16;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButton.Location = new System.Drawing.Point(345, 210);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(111, 63);
            this.PlusButton.TabIndex = 15;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Location = new System.Drawing.Point(231, 210);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(108, 63);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Location = new System.Drawing.Point(117, 210);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(108, 63);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Location = new System.Drawing.Point(3, 210);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(108, 63);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.Location = new System.Drawing.Point(345, 141);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(111, 63);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Location = new System.Drawing.Point(231, 141);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(108, 63);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Location = new System.Drawing.Point(117, 141);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(108, 63);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // ForthButton
            // 
            this.ForthButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForthButton.Location = new System.Drawing.Point(3, 141);
            this.ForthButton.Name = "ForthButton";
            this.ForthButton.Size = new System.Drawing.Size(108, 63);
            this.ForthButton.TabIndex = 8;
            this.ForthButton.Text = "4";
            this.ForthButton.UseVisualStyleBackColor = true;
            this.ForthButton.Click += new System.EventHandler(this.ForthButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiplyButton.Location = new System.Drawing.Point(345, 72);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(111, 63);
            this.MultiplyButton.TabIndex = 7;
            this.MultiplyButton.Text = "x";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineButton.Location = new System.Drawing.Point(231, 72);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(108, 63);
            this.nineButton.TabIndex = 6;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Location = new System.Drawing.Point(117, 72);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(108, 63);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Location = new System.Drawing.Point(3, 72);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(108, 63);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // PercentageButton
            // 
            this.PercentageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PercentageButton.Location = new System.Drawing.Point(345, 3);
            this.PercentageButton.Name = "PercentageButton";
            this.PercentageButton.Size = new System.Drawing.Size(111, 63);
            this.PercentageButton.TabIndex = 3;
            this.PercentageButton.Text = "%";
            this.PercentageButton.UseVisualStyleBackColor = true;
            this.PercentageButton.Click += new System.EventHandler(this.PercentageButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Location = new System.Drawing.Point(231, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(108, 63);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Del";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CEbutton
            // 
            this.CEbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CEbutton.Location = new System.Drawing.Point(3, 3);
            this.CEbutton.Name = "CEbutton";
            this.CEbutton.Size = new System.Drawing.Size(108, 63);
            this.CEbutton.TabIndex = 0;
            this.CEbutton.Text = "CE";
            this.CEbutton.UseVisualStyleBackColor = true;
            this.CEbutton.Click += new System.EventHandler(this.CEbutton_Click);
            // 
            // DevideButton
            // 
            this.DevideButton.Location = new System.Drawing.Point(345, 279);
            this.DevideButton.Name = "DevideButton";
            this.DevideButton.Size = new System.Drawing.Size(111, 63);
            this.DevideButton.TabIndex = 19;
            this.DevideButton.Text = "/";
            this.DevideButton.UseVisualStyleBackColor = true;
            this.DevideButton.Click += new System.EventHandler(this.DevideButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.EqualButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEbutton;
            this.ClientSize = new System.Drawing.Size(482, 473);
            this.Controls.Add(this.ButtonsPannel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MinimumSize = new System.Drawing.Size(500, 520);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtonsPannel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel ButtonsPannel;
        private System.Windows.Forms.Button CEbutton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button ForthButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button PercentageButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button PointButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button DevideButton;
    }
}

