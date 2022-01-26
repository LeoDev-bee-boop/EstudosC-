namespace Projeto_Dispensa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.butMinimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butMaximize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butClose = new System.Windows.Forms.Button();
            this.dgvDispensa = new System.Windows.Forms.DataGridView();
            this.butAdicionarAlimento = new System.Windows.Forms.Button();
            this.txtTeste = new System.Windows.Forms.TextBox();
            this.butCapturaLinha = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispensa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.butMinimize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.butMaximize);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.butClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 42);
            this.panel1.TabIndex = 0;
            // 
            // butMinimize
            // 
            this.butMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butMinimize.BackColor = System.Drawing.Color.Transparent;
            this.butMinimize.BackgroundImage = global::Projeto_Dispensa.Properties.Resources.minimize;
            this.butMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butMinimize.FlatAppearance.BorderSize = 0;
            this.butMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.butMinimize.Location = new System.Drawing.Point(585, 4);
            this.butMinimize.Name = "butMinimize";
            this.butMinimize.Size = new System.Drawing.Size(42, 33);
            this.butMinimize.TabIndex = 4;
            this.butMinimize.UseVisualStyleBackColor = false;
            this.butMinimize.Click += new System.EventHandler(this.butMinimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(66, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dispensa Inteligênte";
            // 
            // butMaximize
            // 
            this.butMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butMaximize.BackColor = System.Drawing.Color.Transparent;
            this.butMaximize.BackgroundImage = global::Projeto_Dispensa.Properties.Resources.maximize;
            this.butMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butMaximize.FlatAppearance.BorderSize = 0;
            this.butMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMaximize.ForeColor = System.Drawing.Color.Transparent;
            this.butMaximize.Location = new System.Drawing.Point(633, 4);
            this.butMaximize.Name = "butMaximize";
            this.butMaximize.Size = new System.Drawing.Size(42, 33);
            this.butMaximize.TabIndex = 3;
            this.butMaximize.UseVisualStyleBackColor = false;
            this.butMaximize.Click += new System.EventHandler(this.butMaximize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = global::Projeto_Dispensa.Properties.Resources.green_technology;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 35);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // butClose
            // 
            this.butClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butClose.BackColor = System.Drawing.Color.Transparent;
            this.butClose.BackgroundImage = global::Projeto_Dispensa.Properties.Resources.cross;
            this.butClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butClose.FlatAppearance.BorderSize = 0;
            this.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClose.ForeColor = System.Drawing.Color.Transparent;
            this.butClose.Location = new System.Drawing.Point(681, 4);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(42, 33);
            this.butClose.TabIndex = 2;
            this.butClose.UseVisualStyleBackColor = false;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // dgvDispensa
            // 
            this.dgvDispensa.AllowUserToAddRows = false;
            this.dgvDispensa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDispensa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispensa.Location = new System.Drawing.Point(12, 90);
            this.dgvDispensa.Name = "dgvDispensa";
            this.dgvDispensa.RowHeadersVisible = false;
            this.dgvDispensa.Size = new System.Drawing.Size(702, 436);
            this.dgvDispensa.TabIndex = 1;
            // 
            // butAdicionarAlimento
            // 
            this.butAdicionarAlimento.Location = new System.Drawing.Point(597, 49);
            this.butAdicionarAlimento.Name = "butAdicionarAlimento";
            this.butAdicionarAlimento.Size = new System.Drawing.Size(117, 35);
            this.butAdicionarAlimento.TabIndex = 2;
            this.butAdicionarAlimento.Text = "Adicionar Alimento";
            this.butAdicionarAlimento.UseVisualStyleBackColor = true;
            this.butAdicionarAlimento.Click += new System.EventHandler(this.butAdicionarAlimento_Click);
            // 
            // txtTeste
            // 
            this.txtTeste.Location = new System.Drawing.Point(12, 56);
            this.txtTeste.Name = "txtTeste";
            this.txtTeste.Size = new System.Drawing.Size(456, 20);
            this.txtTeste.TabIndex = 3;
            // 
            // butCapturaLinha
            // 
            this.butCapturaLinha.Location = new System.Drawing.Point(474, 48);
            this.butCapturaLinha.Name = "butCapturaLinha";
            this.butCapturaLinha.Size = new System.Drawing.Size(117, 35);
            this.butCapturaLinha.TabIndex = 4;
            this.butCapturaLinha.Text = "Captura linha";
            this.butCapturaLinha.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 538);
            this.Controls.Add(this.butCapturaLinha);
            this.Controls.Add(this.txtTeste);
            this.Controls.Add(this.butAdicionarAlimento);
            this.Controls.Add(this.dgvDispensa);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispensa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butMinimize;
        private System.Windows.Forms.Button butMaximize;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.DataGridView dgvDispensa;
        private System.Windows.Forms.Button butAdicionarAlimento;
        private System.Windows.Forms.TextBox txtTeste;
        private System.Windows.Forms.Button butCapturaLinha;
    }
}

