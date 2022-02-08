
namespace Custom_Controls
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
            this.rjToggleButton2 = new Custom_Controls.RJControls.RJToggleButton();
            this.rjToggleButton1 = new Custom_Controls.RJControls.RJToggleButton();
            this.tbDarkTheme = new Custom_Controls.RJControls.RJToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rjToggleButton2
            // 
            this.rjToggleButton2.Location = new System.Drawing.Point(24, 214);
            this.rjToggleButton2.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton2.Name = "rjToggleButton2";
            this.rjToggleButton2.OffBackColor = System.Drawing.Color.DarkGreen;
            this.rjToggleButton2.OffToggleColor = System.Drawing.Color.Red;
            this.rjToggleButton2.OnBackColor = System.Drawing.Color.DarkGreen;
            this.rjToggleButton2.OnToggleColor = System.Drawing.Color.Lime;
            this.rjToggleButton2.Size = new System.Drawing.Size(458, 154);
            this.rjToggleButton2.SolidStyle = false;
            this.rjToggleButton2.TabIndex = 1;
            this.rjToggleButton2.Text = "rjToggleButton2";
            this.rjToggleButton2.UseVisualStyleBackColor = true;
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.Location = new System.Drawing.Point(24, 34);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.DarkGreen;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.Red;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.DarkGreen;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.Lime;
            this.rjToggleButton1.Size = new System.Drawing.Size(458, 154);
            this.rjToggleButton1.TabIndex = 0;
            this.rjToggleButton1.Text = "rjToggleButton1";
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            // 
            // tbDarkTheme
            // 
            this.tbDarkTheme.AutoSize = true;
            this.tbDarkTheme.Location = new System.Drawing.Point(611, 214);
            this.tbDarkTheme.MinimumSize = new System.Drawing.Size(45, 22);
            this.tbDarkTheme.Name = "tbDarkTheme";
            this.tbDarkTheme.OffBackColor = System.Drawing.Color.Gold;
            this.tbDarkTheme.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbDarkTheme.OnBackColor = System.Drawing.Color.Aqua;
            this.tbDarkTheme.OnToggleColor = System.Drawing.Color.Gold;
            this.tbDarkTheme.Size = new System.Drawing.Size(101, 22);
            this.tbDarkTheme.TabIndex = 2;
            this.tbDarkTheme.Text = "rjToggleButton3";
            this.tbDarkTheme.UseVisualStyleBackColor = true;
            this.tbDarkTheme.CheckedChanged += new System.EventHandler(this.rjToggleButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Theme:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDarkTheme);
            this.Controls.Add(this.rjToggleButton2);
            this.Controls.Add(this.rjToggleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJControls.RJToggleButton rjToggleButton1;
        private RJControls.RJToggleButton rjToggleButton2;
        private RJControls.RJToggleButton tbDarkTheme;
        private System.Windows.Forms.Label label1;
    }
}

