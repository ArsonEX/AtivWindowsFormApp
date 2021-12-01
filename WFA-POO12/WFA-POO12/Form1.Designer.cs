
namespace WFA_POO12
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.radEqui = new System.Windows.Forms.RadioButton();
            this.radIsos = new System.Windows.Forms.RadioButton();
            this.radEsca = new System.Windows.Forms.RadioButton();
            this.chkN = new System.Windows.Forms.CheckBox();
            this.chkS = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radNem = new System.Windows.Forms.RadioButton();
            this.lblDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "LadoA";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(75, 103);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(75, 23);
            this.txtA.TabIndex = 1;
            this.txtA.MouseEnter += new System.EventHandler(this.txtA_MouseEnter);
            this.txtA.MouseLeave += new System.EventHandler(this.LimpDesc);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(156, 103);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(75, 23);
            this.txtB.TabIndex = 2;
            this.txtB.MouseEnter += new System.EventHandler(this.txtB_MouseEnter);
            this.txtB.MouseLeave += new System.EventHandler(this.LimpDesc);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(237, 103);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(75, 23);
            this.txtC.TabIndex = 3;
            this.txtC.MouseEnter += new System.EventHandler(this.txtC_MouseEnter);
            this.txtC.MouseLeave += new System.EventHandler(this.LimpDesc);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "LadoB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "LadoC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(96, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "ABC formação de Triângulo";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(156, 152);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            this.btnCalc.MouseEnter += new System.EventHandler(this.btnCalc_MouseEnter);
            this.btnCalc.MouseLeave += new System.EventHandler(this.LimpDesc);
            // 
            // radEqui
            // 
            this.radEqui.AutoSize = true;
            this.radEqui.Enabled = false;
            this.radEqui.Location = new System.Drawing.Point(237, 174);
            this.radEqui.Name = "radEqui";
            this.radEqui.Size = new System.Drawing.Size(78, 19);
            this.radEqui.TabIndex = 10;
            this.radEqui.TabStop = true;
            this.radEqui.Text = "Equilátero";
            this.radEqui.UseVisualStyleBackColor = true;
            // 
            // radIsos
            // 
            this.radIsos.AutoSize = true;
            this.radIsos.Enabled = false;
            this.radIsos.Location = new System.Drawing.Point(237, 198);
            this.radIsos.Name = "radIsos";
            this.radIsos.Size = new System.Drawing.Size(71, 19);
            this.radIsos.TabIndex = 11;
            this.radIsos.TabStop = true;
            this.radIsos.Text = "Isosceles";
            this.radIsos.UseVisualStyleBackColor = true;
            // 
            // radEsca
            // 
            this.radEsca.AutoSize = true;
            this.radEsca.Enabled = false;
            this.radEsca.Location = new System.Drawing.Point(237, 222);
            this.radEsca.Name = "radEsca";
            this.radEsca.Size = new System.Drawing.Size(71, 19);
            this.radEsca.TabIndex = 12;
            this.radEsca.TabStop = true;
            this.radEsca.Text = "Escaleno";
            this.radEsca.UseVisualStyleBackColor = true;
            // 
            // chkN
            // 
            this.chkN.AutoSize = true;
            this.chkN.Enabled = false;
            this.chkN.Location = new System.Drawing.Point(85, 205);
            this.chkN.Name = "chkN";
            this.chkN.Size = new System.Drawing.Size(48, 19);
            this.chkN.TabIndex = 13;
            this.chkN.Text = "Não";
            this.chkN.UseVisualStyleBackColor = true;
            // 
            // chkS
            // 
            this.chkS.AutoSize = true;
            this.chkS.Enabled = false;
            this.chkS.Location = new System.Drawing.Point(135, 205);
            this.chkS.Name = "chkS";
            this.chkS.Size = new System.Drawing.Size(46, 19);
            this.chkS.TabIndex = 14;
            this.chkS.Text = "Sim";
            this.chkS.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Forma triângulo?";
            // 
            // radNem
            // 
            this.radNem.AutoSize = true;
            this.radNem.Enabled = false;
            this.radNem.Location = new System.Drawing.Point(271, 152);
            this.radNem.Name = "radNem";
            this.radNem.Size = new System.Drawing.Size(101, 19);
            this.radNem.TabIndex = 16;
            this.radNem.TabStop = true;
            this.radNem.Text = "Nenhumzinhu";
            this.radNem.UseVisualStyleBackColor = true;
            this.radNem.Visible = false;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(12, 237);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(61, 15);
            this.lblDesc.TabIndex = 17;
            this.lblDesc.Text = "Descrição:";
            this.lblDesc.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.radNem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkS);
            this.Controls.Add(this.chkN);
            this.Controls.Add(this.radEsca);
            this.Controls.Add(this.radIsos);
            this.Controls.Add(this.radEqui);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.RadioButton radEqui;
        private System.Windows.Forms.RadioButton radIsos;
        private System.Windows.Forms.RadioButton radEsca;
        private System.Windows.Forms.CheckBox chkN;
        private System.Windows.Forms.CheckBox chkS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radNem;
        private System.Windows.Forms.Label lblDesc;
    }
}

