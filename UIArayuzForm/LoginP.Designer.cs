namespace UIArayuzForm
{
    partial class LoginP
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
            this.btn_img = new System.Windows.Forms.Button();
            this.btn_Regst = new System.Windows.Forms.Button();
            this.btn_Log = new System.Windows.Forms.Button();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_Usrnm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_img
            // 
      
            this.btn_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_img.FlatAppearance.BorderSize = 0;
            this.btn_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_img.Location = new System.Drawing.Point(81, 70);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(639, 143);
            this.btn_img.TabIndex = 11;
            this.btn_img.UseVisualStyleBackColor = true;
            // 
            // btn_Regst
            // 
            this.btn_Regst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Regst.Location = new System.Drawing.Point(620, 345);
            this.btn_Regst.Name = "btn_Regst";
            this.btn_Regst.Size = new System.Drawing.Size(100, 35);
            this.btn_Regst.TabIndex = 10;
            this.btn_Regst.Text = "Register";
            this.btn_Regst.UseVisualStyleBackColor = true;
            this.btn_Regst.Click += new System.EventHandler(this.btn_Regst_Click);
            // 
            // btn_Log
            // 
            this.btn_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Log.Location = new System.Drawing.Point(620, 304);
            this.btn_Log.Name = "btn_Log";
            this.btn_Log.Size = new System.Drawing.Size(100, 35);
            this.btn_Log.TabIndex = 9;
            this.btn_Log.Text = "Login";
            this.btn_Log.UseVisualStyleBackColor = true;
            this.btn_Log.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(620, 257);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(100, 20);
            this.txt_Pass.TabIndex = 7;
            // 
            // txt_Usrnm
            // 
            this.txt_Usrnm.Location = new System.Drawing.Point(620, 227);
            this.txt_Usrnm.Name = "txt_Usrnm";
            this.txt_Usrnm.Size = new System.Drawing.Size(100, 20);
            this.txt_Usrnm.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(500, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Passoword:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(508, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_img);
            this.Controls.Add(this.btn_Regst);
            this.Controls.Add(this.btn_Log);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Usrnm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_img;
        private System.Windows.Forms.Button btn_Regst;
        private System.Windows.Forms.Button btn_Log;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_Usrnm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

