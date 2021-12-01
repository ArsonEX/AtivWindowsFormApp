
namespace WFA_POO9
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
            this.txtMaior = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDet = new System.Windows.Forms.Button();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.Location = new System.Drawing.Point(12, 233);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(70, 19);
            this.lblDesc.TabIndex = 18;
            this.lblDesc.Text = "Descrição:";
            // 
            // txtMaior
            // 
            this.txtMaior.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaior.Enabled = false;
            this.txtMaior.Location = new System.Drawing.Point(155, 195);
            this.txtMaior.Name = "txtMaior";
            this.txtMaior.Size = new System.Drawing.Size(97, 23);
            this.txtMaior.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(100, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Maior:";
            // 
            // btnDet
            // 
            this.btnDet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDet.Location = new System.Drawing.Point(154, 150);
            this.btnDet.Name = "btnDet";
            this.btnDet.Size = new System.Drawing.Size(75, 23);
            this.btnDet.TabIndex = 15;
            this.btnDet.Text = "Determinar";
            this.btnDet.UseVisualStyleBackColor = true;
            this.btnDet.Click += new System.EventHandler(this.btnDet_Click);
            this.btnDet.MouseEnter += new System.EventHandler(this.btnDet_MouseEnter);
            this.btnDet.MouseLeave += new System.EventHandler(this.LimpDesc);
            // 
            // txtN2
            // 
            this.txtN2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtN2.Location = new System.Drawing.Point(229, 108);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(77, 23);
            this.txtN2.TabIndex = 14;
            this.txtN2.MouseEnter += new System.EventHandler(this.txtN2_MouseEnter);
            this.txtN2.MouseLeave += new System.EventHandler(this.LimpDesc);
            // 
            // txtN1
            // 
            this.txtN1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtN1.Location = new System.Drawing.Point(77, 108);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(77, 23);
            this.txtN1.TabIndex = 13;
            this.txtN1.MouseEnter += new System.EventHandler(this.txtN1_MouseEnter);
            this.txtN1.MouseLeave += new System.EventHandler(this.LimpDesc);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(229, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "2º Número";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(77, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "1º Número";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Maior de 2 números";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtMaior);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDet);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
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
        private System.Windows.Forms.TextBox txtMaior;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDet;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

