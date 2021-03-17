
namespace ExecCalc
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textValor2 = new System.Windows.Forms.TextBox();
            this.textValor1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.rbDiv = new System.Windows.Forms.RadioButton();
            this.rbResto = new System.Windows.Forms.RadioButton();
            this.rbMulti = new System.Windows.Forms.RadioButton();
            this.rbMenos = new System.Windows.Forms.RadioButton();
            this.rbSoma = new System.Windows.Forms.RadioButton();
            this.textResu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(35, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(35, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textValor2
            // 
            this.textValor2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textValor2.ForeColor = System.Drawing.SystemColors.Window;
            this.textValor2.Location = new System.Drawing.Point(35, 219);
            this.textValor2.Name = "textValor2";
            this.textValor2.Size = new System.Drawing.Size(274, 31);
            this.textValor2.TabIndex = 2;
            // 
            // textValor1
            // 
            this.textValor1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textValor1.ForeColor = System.Drawing.SystemColors.Window;
            this.textValor1.Location = new System.Drawing.Point(35, 104);
            this.textValor1.Name = "textValor1";
            this.textValor1.Size = new System.Drawing.Size(274, 31);
            this.textValor1.TabIndex = 3;
            this.textValor1.TextChanged += new System.EventHandler(this.textValor1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCalc);
            this.groupBox1.Controls.Add(this.rbDiv);
            this.groupBox1.Controls.Add(this.rbResto);
            this.groupBox1.Controls.Add(this.rbMulti);
            this.groupBox1.Controls.Add(this.rbMenos);
            this.groupBox1.Controls.Add(this.rbSoma);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(35, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 270);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione uma operação";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Black;
            this.btnCalc.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnCalc.Location = new System.Drawing.Point(0, 246);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 24);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "=";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // rbDiv
            // 
            this.rbDiv.AutoSize = true;
            this.rbDiv.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbDiv.Location = new System.Drawing.Point(138, 177);
            this.rbDiv.Name = "rbDiv";
            this.rbDiv.Size = new System.Drawing.Size(42, 26);
            this.rbDiv.TabIndex = 5;
            this.rbDiv.TabStop = true;
            this.rbDiv.Text = "/";
            this.rbDiv.UseVisualStyleBackColor = true;
            this.rbDiv.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rbResto
            // 
            this.rbResto.AutoSize = true;
            this.rbResto.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbResto.Location = new System.Drawing.Point(179, 223);
            this.rbResto.Name = "rbResto";
            this.rbResto.Size = new System.Drawing.Size(42, 26);
            this.rbResto.TabIndex = 4;
            this.rbResto.TabStop = true;
            this.rbResto.Text = "%";
            this.rbResto.UseVisualStyleBackColor = true;
            // 
            // rbMulti
            // 
            this.rbMulti.AutoSize = true;
            this.rbMulti.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbMulti.Location = new System.Drawing.Point(101, 126);
            this.rbMulti.Name = "rbMulti";
            this.rbMulti.Size = new System.Drawing.Size(42, 26);
            this.rbMulti.TabIndex = 3;
            this.rbMulti.TabStop = true;
            this.rbMulti.Text = "*";
            this.rbMulti.UseVisualStyleBackColor = true;
            // 
            // rbMenos
            // 
            this.rbMenos.AutoSize = true;
            this.rbMenos.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbMenos.Location = new System.Drawing.Point(54, 84);
            this.rbMenos.Name = "rbMenos";
            this.rbMenos.Size = new System.Drawing.Size(42, 26);
            this.rbMenos.TabIndex = 2;
            this.rbMenos.TabStop = true;
            this.rbMenos.Text = "-";
            this.rbMenos.UseVisualStyleBackColor = true;
            this.rbMenos.CheckedChanged += new System.EventHandler(this.rbMenos_CheckedChanged);
            // 
            // rbSoma
            // 
            this.rbSoma.AutoSize = true;
            this.rbSoma.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbSoma.ImageKey = "(nenhum)";
            this.rbSoma.Location = new System.Drawing.Point(6, 39);
            this.rbSoma.Name = "rbSoma";
            this.rbSoma.Size = new System.Drawing.Size(42, 26);
            this.rbSoma.TabIndex = 1;
            this.rbSoma.TabStop = true;
            this.rbSoma.Text = "+";
            this.rbSoma.UseVisualStyleBackColor = true;
            this.rbSoma.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textResu
            // 
            this.textResu.BackColor = System.Drawing.SystemColors.WindowText;
            this.textResu.ForeColor = System.Drawing.SystemColors.Window;
            this.textResu.Location = new System.Drawing.Point(115, 575);
            this.textResu.Name = "textResu";
            this.textResu.Size = new System.Drawing.Size(100, 31);
            this.textResu.TabIndex = 5;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 618);
            this.Controls.Add(this.textResu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textValor1);
            this.Controls.Add(this.textValor2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mangekyou Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textValor2;
        private System.Windows.Forms.TextBox textValor1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDiv;
        private System.Windows.Forms.RadioButton rbResto;
        private System.Windows.Forms.RadioButton rbMulti;
        private System.Windows.Forms.RadioButton rbMenos;
        private System.Windows.Forms.RadioButton rbSoma;
        private System.Windows.Forms.TextBox textResu;
        private System.Windows.Forms.Button btnCalc;
    }
}

