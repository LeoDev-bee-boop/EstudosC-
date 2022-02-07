
namespace pao_simulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panPrincipal = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAbrirLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.panPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Location = new System.Drawing.Point(12, 127);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.Size = new System.Drawing.Size(450, 387);
            this.dgvPrincipal.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(365, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pessoa responsável pelo pão da semana:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pessoa responsável pelo pão da próxima semana:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 5;
            // 
            // panPrincipal
            // 
            this.panPrincipal.BackColor = System.Drawing.Color.Bisque;
            this.panPrincipal.Controls.Add(this.label3);
            this.panPrincipal.Controls.Add(this.pictureBox1);
            this.panPrincipal.Controls.Add(this.btnClose);
            this.panPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panPrincipal.Name = "panPrincipal";
            this.panPrincipal.Size = new System.Drawing.Size(474, 43);
            this.panPrincipal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(65, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pão simulator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = global::pao_simulator.Properties.Resources.bread;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 43);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(441, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 21);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAbrirLista
            // 
            this.btnAbrirLista.BackColor = System.Drawing.Color.Bisque;
            this.btnAbrirLista.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.btnAbrirLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnAbrirLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.btnAbrirLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirLista.Location = new System.Drawing.Point(12, 98);
            this.btnAbrirLista.Name = "btnAbrirLista";
            this.btnAbrirLista.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirLista.TabIndex = 7;
            this.btnAbrirLista.Text = "Abrir lista";
            this.btnAbrirLista.UseVisualStyleBackColor = false;
            this.btnAbrirLista.Click += new System.EventHandler(this.btnAbrirLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(474, 526);
            this.Controls.Add(this.btnAbrirLista);
            this.Controls.Add(this.panPrincipal);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.panPrincipal.ResumeLayout(false);
            this.panPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAbrirLista;
    }
}

