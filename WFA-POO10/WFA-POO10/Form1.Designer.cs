
namespace WFA_POO10
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
            this.lblDesc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radTerP = new System.Windows.Forms.RadioButton();
            this.radTerG = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.Location = new System.Drawing.Point(12, 233);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(74, 19);
            this.lblDesc.TabIndex = 26;
            this.lblDesc.Text = "Descrição: ";
            this.lblDesc.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Area";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(154, 147);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 24;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            this.btnCalcular.MouseEnter += new System.EventHandler(this.btnCalcular_MouseEnter);
            this.btnCalcular.MouseLeave += new System.EventHandler(this.LimparDesc);
            // 
            // txtRes
            // 
            this.txtRes.Enabled = false;
            this.txtRes.Location = new System.Drawing.Point(110, 191);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(66, 23);
            this.txtRes.TabIndex = 23;
            this.txtRes.Text = "--";
            this.txtRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(75, 101);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(60, 23);
            this.txtBase.TabIndex = 22;
            this.txtBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBase.MouseEnter += new System.EventHandler(this.txtBase_MouseEnter);
            this.txtBase.MouseLeave += new System.EventHandler(this.LimparDesc);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(239, 101);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(60, 23);
            this.txtAltura.TabIndex = 21;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAltura.MouseEnter += new System.EventHandler(this.txtAltura_MouseEnter);
            this.txtAltura.MouseLeave += new System.EventHandler(this.LimparDesc);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Altura";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(90, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Área do retângulo (terreno)";
            // 
            // radTerP
            // 
            this.radTerP.AutoSize = true;
            this.radTerP.Enabled = false;
            this.radTerP.Location = new System.Drawing.Point(214, 182);
            this.radTerP.Name = "radTerP";
            this.radTerP.Size = new System.Drawing.Size(114, 19);
            this.radTerP.TabIndex = 27;
            this.radTerP.TabStop = true;
            this.radTerP.Text = "Terreno Pequeno";
            this.radTerP.UseVisualStyleBackColor = true;
            // 
            // radTerG
            // 
            this.radTerG.AutoSize = true;
            this.radTerG.Enabled = false;
            this.radTerG.Location = new System.Drawing.Point(214, 207);
            this.radTerG.Name = "radTerG";
            this.radTerG.Size = new System.Drawing.Size(105, 19);
            this.radTerG.TabIndex = 28;
            this.radTerG.TabStop = true;
            this.radTerG.Text = "Terreno Grande";
            this.radTerG.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.radTerG);
            this.Controls.Add(this.radTerP);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtBase);
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

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radTerP;
        private System.Windows.Forms.RadioButton radTerG;
    }
}

