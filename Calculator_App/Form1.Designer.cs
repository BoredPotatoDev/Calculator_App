
namespace Calculator_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DisplayBox = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.ClearEntry = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Sign = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.Multiplcation = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.DecimalPoint = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayBox
            // 
            this.DisplayBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisplayBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplayBox.ForeColor = System.Drawing.Color.White;
            this.DisplayBox.Location = new System.Drawing.Point(13, 25);
            this.DisplayBox.Multiline = true;
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(334, 56);
            this.DisplayBox.TabIndex = 0;
            this.DisplayBox.Tag = "";
            this.DisplayBox.Text = "0";
            this.DisplayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Gray;
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(182, 104);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(79, 68);
            this.delete.TabIndex = 1;
            this.delete.Text = "⌫";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // ClearEntry
            // 
            this.ClearEntry.BackColor = System.Drawing.Color.Gray;
            this.ClearEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearEntry.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearEntry.ForeColor = System.Drawing.Color.White;
            this.ClearEntry.Location = new System.Drawing.Point(12, 104);
            this.ClearEntry.Name = "ClearEntry";
            this.ClearEntry.Size = new System.Drawing.Size(79, 68);
            this.ClearEntry.TabIndex = 2;
            this.ClearEntry.Text = "CE";
            this.ClearEntry.UseVisualStyleBackColor = false;
            this.ClearEntry.Click += new System.EventHandler(this.ClearEntry_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Gray;
            this.Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(98, 103);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(79, 68);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Sign
            // 
            this.Sign.BackColor = System.Drawing.Color.Gray;
            this.Sign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Sign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sign.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sign.ForeColor = System.Drawing.Color.White;
            this.Sign.Location = new System.Drawing.Point(183, 399);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(79, 68);
            this.Sign.TabIndex = 4;
            this.Sign.Text = "±";
            this.Sign.UseVisualStyleBackColor = false;
            this.Sign.Click += new System.EventHandler(this.Sign_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(13, 177);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 68);
            this.button5.TabIndex = 5;
            this.button5.Text = "7";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.NumClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(98, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 68);
            this.button6.TabIndex = 6;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.NumClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(183, 177);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(79, 68);
            this.button7.TabIndex = 7;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.NumClick);
            // 
            // Addition
            // 
            this.Addition.BackColor = System.Drawing.Color.Gray;
            this.Addition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Addition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Addition.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Addition.ForeColor = System.Drawing.Color.White;
            this.Addition.Location = new System.Drawing.Point(268, 104);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(79, 68);
            this.Addition.TabIndex = 8;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = false;
            this.Addition.Click += new System.EventHandler(this.OperationClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(12, 251);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(79, 68);
            this.button9.TabIndex = 9;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.NumClick);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(98, 251);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(79, 68);
            this.button10.TabIndex = 10;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.NumClick);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Black;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(183, 251);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(79, 68);
            this.button11.TabIndex = 11;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.NumClick);
            // 
            // Subtraction
            // 
            this.Subtraction.BackColor = System.Drawing.Color.Gray;
            this.Subtraction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Subtraction.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Subtraction.ForeColor = System.Drawing.Color.White;
            this.Subtraction.Location = new System.Drawing.Point(268, 177);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(79, 68);
            this.Subtraction.TabIndex = 12;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = false;
            this.Subtraction.Click += new System.EventHandler(this.OperationClick);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Black;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(13, 325);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(79, 68);
            this.button13.TabIndex = 13;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.NumClick);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Black;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(98, 325);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(79, 68);
            this.button14.TabIndex = 14;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.NumClick);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Black;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(183, 325);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(79, 68);
            this.button15.TabIndex = 15;
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.NumClick);
            // 
            // Multiplcation
            // 
            this.Multiplcation.BackColor = System.Drawing.Color.Gray;
            this.Multiplcation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Multiplcation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Multiplcation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Multiplcation.ForeColor = System.Drawing.Color.White;
            this.Multiplcation.Location = new System.Drawing.Point(267, 251);
            this.Multiplcation.Name = "Multiplcation";
            this.Multiplcation.Size = new System.Drawing.Size(79, 68);
            this.Multiplcation.TabIndex = 16;
            this.Multiplcation.Text = "*";
            this.Multiplcation.UseVisualStyleBackColor = false;
            this.Multiplcation.Click += new System.EventHandler(this.OperationClick);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Black;
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(98, 399);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(79, 68);
            this.button17.TabIndex = 17;
            this.button17.Text = "0";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.NumClick);
            // 
            // DecimalPoint
            // 
            this.DecimalPoint.BackColor = System.Drawing.Color.Gray;
            this.DecimalPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DecimalPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DecimalPoint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecimalPoint.ForeColor = System.Drawing.Color.White;
            this.DecimalPoint.Location = new System.Drawing.Point(13, 398);
            this.DecimalPoint.Name = "DecimalPoint";
            this.DecimalPoint.Size = new System.Drawing.Size(79, 68);
            this.DecimalPoint.TabIndex = 18;
            this.DecimalPoint.Text = ".";
            this.DecimalPoint.UseVisualStyleBackColor = false;
            this.DecimalPoint.Click += new System.EventHandler(this.DecimalPoint_Click);
            // 
            // Equals
            // 
            this.Equals.BackColor = System.Drawing.Color.Gray;
            this.Equals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Equals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Equals.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Equals.ForeColor = System.Drawing.Color.White;
            this.Equals.Location = new System.Drawing.Point(267, 399);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(79, 68);
            this.Equals.TabIndex = 19;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = false;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.Color.Gray;
            this.Division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Division.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Division.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Division.ForeColor = System.Drawing.Color.White;
            this.Division.Location = new System.Drawing.Point(267, 325);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(79, 68);
            this.Division.TabIndex = 20;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.OperationClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(358, 479);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.DecimalPoint);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.Multiplcation);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ClearEntry);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.DisplayBox);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearEntry;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Sign;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button Multiplcation;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button DecimalPoint;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.TextBox DisplayBox;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Button delete;
    }
}

