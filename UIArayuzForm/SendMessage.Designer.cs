namespace UIArayuzForm
{
    partial class SendMessage
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
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.btn_sndms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(132, 80);
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(326, 20);
            this.txt_msg.TabIndex = 0;
            // 
            // btn_sndms
            // 
            this.btn_sndms.Location = new System.Drawing.Point(291, 106);
            this.btn_sndms.Name = "btn_sndms";
            this.btn_sndms.Size = new System.Drawing.Size(167, 34);
            this.btn_sndms.TabIndex = 1;
            this.btn_sndms.Text = "Send Message";
            this.btn_sndms.UseVisualStyleBackColor = true;
            this.btn_sndms.Click += new System.EventHandler(this.btn_sndms_Click);
            // 
            // SendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 378);
            this.Controls.Add(this.btn_sndms);
            this.Controls.Add(this.txt_msg);
            this.Name = "SendMessage";
            this.Text = "SendMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.Button btn_sndms;
    }
}