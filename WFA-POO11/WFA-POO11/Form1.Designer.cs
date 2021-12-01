
namespace WFA_POO11
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
            this.radMaior = new System.Windows.Forms.RadioButton();
            this.radMedio = new System.Windows.Forms.RadioButton();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radMenor = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radMaior
            // 
            this.radMaior.AutoSize = true;
            this.radMaior.Enabled = false;
            this.radMaior.Location = new System.Drawing.Point(239, 220);
            this.radMaior.Name = "radMaior";
            this.radMaior.Size = new System.Drawing.Size(104, 19);
            this.radMaior.TabIndex = 39;
            this.radMaior.TabStop = true;
            this.radMaior.Text = "Acima do peso";
            this.radMaior.UseVisualStyleBackColor = true;
            // 
            // radMedio
            // 
            this.radMedio.AutoSize = true;
            this.radMedio.Enabled = false;
            this.radMedio.Location = new System.Drawing.Point(239, 195);
            this.radMedio.Name = "radMedio";
            this.radMedio.Size = new System.Drawing.Size(78, 19);
            this.radMedio.TabIndex = 38;
            this.radMedio.TabStop = true;
            this.radMedio.Text = "Peso ideal";
            this.radMedio.UseVisualStyleBackColor = true;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.Location = new System.Drawing.Point(12, 233);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(74, 19);
            this.lblDesc.TabIndex = 37;
            this.lblDesc.Text = "Descrição: ";
            this.lblDesc.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "IMC";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(155, 140);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 35;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            this.btnCalcular.MouseEnter += new System.EventHandler(this.btnCalcular_MouseEnter);
            this.btnCalcular.MouseLeave += new System.EventHandler(this.LimpDesc);
            // 
            // txtRes
            // 
            this.txtRes.Enabled = false;
            this.txtRes.Location = new System.Drawing.Point(110, 191);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(66, 23);
            this.txtRes.TabIndex = 34;
            this.txtRes.Text = "--";
            this.txtRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(75, 101);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(60, 23);
            this.txtPeso.TabIndex = 33;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPeso.MouseEnter += new System.EventHandler(this.txtPeso_MouseEnter);
            this.txtPeso.MouseLeave += new System.EventHandler(this.LimpDesc);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(239, 101);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(60, 23);
            this.txtAltura.TabIndex = 32;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAltura.MouseEnter += new System.EventHandler(this.txtAltura_MouseEnter);
            this.txtAltura.MouseLeave += new System.EventHandler(this.LimpDesc);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Altura";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(120, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Relação Peso-Altura";
            // 
            // radMenor
            // 
            this.radMenor.AutoSize = true;
            this.radMenor.Enabled = false;
            this.radMenor.Location = new System.Drawing.Point(239, 170);
            this.radMenor.Name = "radMenor";
            this.radMenor.Size = new System.Drawing.Size(107, 19);
            this.radMenor.TabIndex = 40;
            this.radMenor.TabStop = true;
            this.radMenor.Text = "Abaixo do peso";
            this.radMenor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.radMenor);
            this.Controls.Add(this.radMaior);
            this.Controls.Add(this.radMedio);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radMaior;
        private System.Windows.Forms.RadioButton radMedio;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radMenor;
    }
}

