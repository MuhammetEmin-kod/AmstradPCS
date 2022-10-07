namespace UIArayuzForm
{
    partial class MdiAnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiAnaForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_gx = new System.Windows.Forms.Button();
            this.imgMenu = new System.Windows.Forms.ImageList(this.components);
            this.btn_nc = new System.Windows.Forms.Button();
            this.btn_pcw = new System.Windows.Forms.Button();
            this.btn_Nws = new System.Windows.Forms.Button();
            this.btn_cpc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Resm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_gx);
            this.panel1.Controls.Add(this.btn_nc);
            this.panel1.Controls.Add(this.btn_pcw);
            this.panel1.Controls.Add(this.btn_Nws);
            this.panel1.Controls.Add(this.btn_cpc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1641, 191);
            this.panel1.TabIndex = 0;
            // 
            // btn_gx
            // 
            this.btn_gx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gx.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_gx.ImageIndex = 2;
            this.btn_gx.ImageList = this.imgMenu;
            this.btn_gx.Location = new System.Drawing.Point(1062, 12);
            this.btn_gx.Name = "btn_gx";
            this.btn_gx.Size = new System.Drawing.Size(241, 144);
            this.btn_gx.TabIndex = 3;
            this.btn_gx.Text = "Amstrad GX";
            this.btn_gx.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_gx.UseVisualStyleBackColor = true;
            this.btn_gx.Click += new System.EventHandler(this.btn_gx_Click);
            // 
            // imgMenu
            // 
            this.imgMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMenu.Images.SetKeyName(0, "amd_cpc.jpg");
            this.imgMenu.Images.SetKeyName(1, "Amd_PCW.jpg");
            this.imgMenu.Images.SetKeyName(2, "Amstrad-GX4000.jpg");
            this.imgMenu.Images.SetKeyName(3, "Amstrad-nc100.jpg");
            this.imgMenu.Images.SetKeyName(4, "news.png");
            // 
            // btn_nc
            // 
            this.btn_nc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_nc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_nc.ImageIndex = 3;
            this.btn_nc.ImageList = this.imgMenu;
            this.btn_nc.Location = new System.Drawing.Point(724, 12);
            this.btn_nc.Name = "btn_nc";
            this.btn_nc.Size = new System.Drawing.Size(241, 144);
            this.btn_nc.TabIndex = 2;
            this.btn_nc.Text = "Amstrad NC";
            this.btn_nc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nc.UseVisualStyleBackColor = true;
            this.btn_nc.Click += new System.EventHandler(this.btn_ng_Click);
            // 
            // btn_pcw
            // 
            this.btn_pcw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pcw.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pcw.ImageIndex = 1;
            this.btn_pcw.ImageList = this.imgMenu;
            this.btn_pcw.Location = new System.Drawing.Point(376, 12);
            this.btn_pcw.Name = "btn_pcw";
            this.btn_pcw.Size = new System.Drawing.Size(241, 144);
            this.btn_pcw.TabIndex = 1;
            this.btn_pcw.Text = "Amstrad PCW";
            this.btn_pcw.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pcw.UseVisualStyleBackColor = true;
            this.btn_pcw.Click += new System.EventHandler(this.btn_pcw_Click);
            // 
            // btn_Nws
            // 
            this.btn_Nws.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Nws.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Nws.ImageIndex = 4;
            this.btn_Nws.ImageList = this.imgMenu;
            this.btn_Nws.Location = new System.Drawing.Point(1388, 12);
            this.btn_Nws.Name = "btn_Nws";
            this.btn_Nws.Size = new System.Drawing.Size(241, 144);
            this.btn_Nws.TabIndex = 4;
            this.btn_Nws.Text = "NEWS";
            this.btn_Nws.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Nws.UseVisualStyleBackColor = true;
            this.btn_Nws.Click += new System.EventHandler(this.btn_Nws_Click);
            // 
            // btn_cpc
            // 
            this.btn_cpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cpc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cpc.ImageIndex = 0;
            this.btn_cpc.ImageList = this.imgMenu;
            this.btn_cpc.Location = new System.Drawing.Point(12, 12);
            this.btn_cpc.Name = "btn_cpc";
            this.btn_cpc.Size = new System.Drawing.Size(241, 144);
            this.btn_cpc.TabIndex = 0;
            this.btn_cpc.Text = "Amstrad CPC";
            this.btn_cpc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cpc.UseVisualStyleBackColor = true;
            this.btn_cpc.Click += new System.EventHandler(this.btn_cpc_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btn_Resm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1641, 777);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_Resm
            // 
            this.btn_Resm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Resm.BackgroundImage")));
            this.btn_Resm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Resm.FlatAppearance.BorderSize = 0;
            this.btn_Resm.Location = new System.Drawing.Point(0, 0);
            this.btn_Resm.Name = "btn_Resm";
            this.btn_Resm.Size = new System.Drawing.Size(1641, 777);
            this.btn_Resm.TabIndex = 0;
            this.btn_Resm.UseVisualStyleBackColor = true;
            // 
            // MdiAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 968);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MdiAnaForm";
            this.Text = "NewsP";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_gx;
        private System.Windows.Forms.Button btn_nc;
        private System.Windows.Forms.Button btn_pcw;
        private System.Windows.Forms.Button btn_Nws;
        private System.Windows.Forms.Button btn_cpc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imgMenu;
        private System.Windows.Forms.Button btn_Resm;
    }
}