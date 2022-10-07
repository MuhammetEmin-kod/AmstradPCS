namespace UIArayuzForm
{
    partial class RegisterP
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
            this.txt_Nm = new System.Windows.Forms.TextBox();
            this.txt_Srnm = new System.Windows.Forms.TextBox();
            this.txt_UsrNm = new System.Windows.Forms.TextBox();
            this.txt_Pasw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Rrgtr = new System.Windows.Forms.Button();
            this.btn_Cncl = new System.Windows.Forms.Button();
            this.msk_Phone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txt_Nm
            // 
            this.txt_Nm.Location = new System.Drawing.Point(147, 42);
            this.txt_Nm.Name = "txt_Nm";
            this.txt_Nm.Size = new System.Drawing.Size(100, 20);
            this.txt_Nm.TabIndex = 0;
            // 
            // txt_Srnm
            // 
            this.txt_Srnm.Location = new System.Drawing.Point(147, 79);
            this.txt_Srnm.Name = "txt_Srnm";
            this.txt_Srnm.Size = new System.Drawing.Size(100, 20);
            this.txt_Srnm.TabIndex = 1;
            // 
            // txt_UsrNm
            // 
            this.txt_UsrNm.Location = new System.Drawing.Point(147, 151);
            this.txt_UsrNm.Name = "txt_UsrNm";
            this.txt_UsrNm.Size = new System.Drawing.Size(100, 20);
            this.txt_UsrNm.TabIndex = 3;
            // 
            // txt_Pasw
            // 
            this.txt_Pasw.Location = new System.Drawing.Point(147, 185);
            this.txt_Pasw.Name = "txt_Pasw";
            this.txt_Pasw.Size = new System.Drawing.Size(100, 20);
            this.txt_Pasw.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(67, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(61, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password:";
            // 
            // btn_Rrgtr
            // 
            this.btn_Rrgtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Rrgtr.Location = new System.Drawing.Point(147, 212);
            this.btn_Rrgtr.Name = "btn_Rrgtr";
            this.btn_Rrgtr.Size = new System.Drawing.Size(100, 33);
            this.btn_Rrgtr.TabIndex = 5;
            this.btn_Rrgtr.Text = "Register";
            this.btn_Rrgtr.UseVisualStyleBackColor = true;
            this.btn_Rrgtr.Click += new System.EventHandler(this.btn_Rrgtr_Click);
            // 
            // btn_Cncl
            // 
            this.btn_Cncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cncl.Location = new System.Drawing.Point(147, 251);
            this.btn_Cncl.Name = "btn_Cncl";
            this.btn_Cncl.Size = new System.Drawing.Size(100, 33);
            this.btn_Cncl.TabIndex = 6;
            this.btn_Cncl.Text = "Cancel";
            this.btn_Cncl.UseVisualStyleBackColor = true;
            this.btn_Cncl.Click += new System.EventHandler(this.btn_Cncl_Click);
            // 
            // msk_Phone
            // 
            this.msk_Phone.Location = new System.Drawing.Point(147, 114);
            this.msk_Phone.Mask = "0(999) 000-0000";
            this.msk_Phone.Name = "msk_Phone";
            this.msk_Phone.Size = new System.Drawing.Size(100, 20);
            this.msk_Phone.TabIndex = 2;
            // 
            // RegisterP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 352);
            this.Controls.Add(this.msk_Phone);
            this.Controls.Add(this.btn_Cncl);
            this.Controls.Add(this.btn_Rrgtr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Pasw);
            this.Controls.Add(this.txt_UsrNm);
            this.Controls.Add(this.txt_Srnm);
            this.Controls.Add(this.txt_Nm);
            this.Name = "RegisterP";
            this.Text = "RegisterP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nm;
        private System.Windows.Forms.TextBox txt_Srnm;
        private System.Windows.Forms.TextBox txt_UsrNm;
        private System.Windows.Forms.TextBox txt_Pasw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Rrgtr;
        private System.Windows.Forms.Button btn_Cncl;
        private System.Windows.Forms.MaskedTextBox msk_Phone;
    }
}