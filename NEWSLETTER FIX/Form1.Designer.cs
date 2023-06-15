namespace NEWSLETTER_FIX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pblogoo = new PictureBox();
            btnnewsletterr = new Button();
            btnpakett = new Button();
            btnwisataa = new Button();
            btnpenginapann = new Button();
            btnumkmm = new Button();
            pnlsidebarr = new Panel();
            lblnewsletterr = new Label();
            btnbackk = new Button();
            pnlnavbarr = new Panel();
            lblnewsletterrr = new Label();
            pnlmainn = new Panel();
            flpNewsletter = new FlowLayoutPanel();
            pbgambar1 = new PictureBox();
            pbgambar2 = new PictureBox();
            pbgambar3 = new PictureBox();
            btnAddNews = new Button();
            btnsavee = new Button();
            btndeletee = new Button();
            ((System.ComponentModel.ISupportInitialize)pblogoo).BeginInit();
            pnlsidebarr.SuspendLayout();
            pnlnavbarr.SuspendLayout();
            pnlmainn.SuspendLayout();
            flpNewsletter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbgambar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbgambar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbgambar3).BeginInit();
            SuspendLayout();
            // 
            // pblogoo
            // 
            pblogoo.Image = (Image)resources.GetObject("pblogoo.Image");
            pblogoo.Location = new Point(54, 20);
            pblogoo.Margin = new Padding(2);
            pblogoo.Name = "pblogoo";
            pblogoo.Size = new Size(38, 21);
            pblogoo.SizeMode = PictureBoxSizeMode.StretchImage;
            pblogoo.TabIndex = 0;
            pblogoo.TabStop = false;
            // 
            // btnnewsletterr
            // 
            btnnewsletterr.Cursor = Cursors.Hand;
            btnnewsletterr.FlatAppearance.BorderSize = 0;
            btnnewsletterr.FlatStyle = FlatStyle.Flat;
            btnnewsletterr.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnnewsletterr.Location = new Point(0, 70);
            btnnewsletterr.Margin = new Padding(2);
            btnnewsletterr.Name = "btnnewsletterr";
            btnnewsletterr.Size = new Size(148, 22);
            btnnewsletterr.TabIndex = 0;
            btnnewsletterr.Text = "Newsletter";
            btnnewsletterr.UseVisualStyleBackColor = true;
            // 
            // btnpakett
            // 
            btnpakett.Cursor = Cursors.Hand;
            btnpakett.FlatAppearance.BorderSize = 0;
            btnpakett.FlatStyle = FlatStyle.Flat;
            btnpakett.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnpakett.Location = new Point(0, 94);
            btnpakett.Margin = new Padding(2);
            btnpakett.Name = "btnpakett";
            btnpakett.Size = new Size(148, 22);
            btnpakett.TabIndex = 1;
            btnpakett.Text = "Paket";
            btnpakett.UseVisualStyleBackColor = true;
            // 
            // btnwisataa
            // 
            btnwisataa.Cursor = Cursors.Hand;
            btnwisataa.FlatAppearance.BorderSize = 0;
            btnwisataa.FlatStyle = FlatStyle.Flat;
            btnwisataa.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnwisataa.Location = new Point(0, 119);
            btnwisataa.Margin = new Padding(2);
            btnwisataa.Name = "btnwisataa";
            btnwisataa.Size = new Size(148, 22);
            btnwisataa.TabIndex = 2;
            btnwisataa.Text = "Wisata";
            btnwisataa.UseVisualStyleBackColor = true;
            // 
            // btnpenginapann
            // 
            btnpenginapann.Cursor = Cursors.Hand;
            btnpenginapann.FlatAppearance.BorderSize = 0;
            btnpenginapann.FlatStyle = FlatStyle.Flat;
            btnpenginapann.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnpenginapann.Location = new Point(0, 169);
            btnpenginapann.Margin = new Padding(2);
            btnpenginapann.Name = "btnpenginapann";
            btnpenginapann.Size = new Size(148, 22);
            btnpenginapann.TabIndex = 4;
            btnpenginapann.Text = "Penginapan";
            btnpenginapann.UseVisualStyleBackColor = true;
            // 
            // btnumkmm
            // 
            btnumkmm.Cursor = Cursors.Hand;
            btnumkmm.FlatAppearance.BorderSize = 0;
            btnumkmm.FlatStyle = FlatStyle.Flat;
            btnumkmm.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnumkmm.Location = new Point(0, 144);
            btnumkmm.Margin = new Padding(2);
            btnumkmm.Name = "btnumkmm";
            btnumkmm.Size = new Size(148, 22);
            btnumkmm.TabIndex = 3;
            btnumkmm.Text = "UMKM";
            btnumkmm.UseVisualStyleBackColor = true;
            // 
            // pnlsidebarr
            // 
            pnlsidebarr.BackColor = Color.White;
            pnlsidebarr.Controls.Add(btnumkmm);
            pnlsidebarr.Controls.Add(btnpenginapann);
            pnlsidebarr.Controls.Add(btnwisataa);
            pnlsidebarr.Controls.Add(btnpakett);
            pnlsidebarr.Controls.Add(btnnewsletterr);
            pnlsidebarr.Controls.Add(pblogoo);
            pnlsidebarr.Dock = DockStyle.Left;
            pnlsidebarr.Location = new Point(0, 0);
            pnlsidebarr.Margin = new Padding(3, 2, 3, 2);
            pnlsidebarr.Name = "pnlsidebarr";
            pnlsidebarr.Size = new Size(148, 411);
            pnlsidebarr.TabIndex = 1;
            // 
            // lblnewsletterr
            // 
            lblnewsletterr.Anchor = AnchorStyles.None;
            lblnewsletterr.AutoSize = true;
            lblnewsletterr.FlatStyle = FlatStyle.Flat;
            lblnewsletterr.Font = new Font("Poppins ExtraBold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            lblnewsletterr.ForeColor = Color.White;
            lblnewsletterr.Location = new Point(280, 7);
            lblnewsletterr.Margin = new Padding(0);
            lblnewsletterr.Name = "lblnewsletterr";
            lblnewsletterr.Size = new Size(117, 31);
            lblnewsletterr.TabIndex = 0;
            lblnewsletterr.Text = "Newsletter";
            // 
            // btnbackk
            // 
            btnbackk.BackColor = Color.Transparent;
            btnbackk.Cursor = Cursors.Hand;
            btnbackk.FlatAppearance.BorderSize = 0;
            btnbackk.FlatStyle = FlatStyle.Flat;
            btnbackk.Image = (Image)resources.GetObject("btnbackk.Image");
            btnbackk.ImageAlign = ContentAlignment.MiddleLeft;
            btnbackk.Location = new Point(10, 8);
            btnbackk.Margin = new Padding(2);
            btnbackk.Name = "btnbackk";
            btnbackk.Size = new Size(24, 27);
            btnbackk.TabIndex = 5;
            btnbackk.Text = " ";
            btnbackk.UseVisualStyleBackColor = false;
            btnbackk.Click += button8_Click;
            // 
            // pnlnavbarr
            // 
            pnlnavbarr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlnavbarr.BackColor = Color.FromArgb(55, 163, 165);
            pnlnavbarr.BackgroundImage = (Image)resources.GetObject("pnlnavbarr.BackgroundImage");
            pnlnavbarr.Controls.Add(btnbackk);
            pnlnavbarr.Controls.Add(lblnewsletterr);
            pnlnavbarr.Location = new Point(151, 0);
            pnlnavbarr.Margin = new Padding(3, 2, 3, 2);
            pnlnavbarr.Name = "pnlnavbarr";
            pnlnavbarr.Size = new Size(689, 44);
            pnlnavbarr.TabIndex = 12;
            // 
            // lblnewsletterrr
            // 
            lblnewsletterrr.AutoSize = true;
            lblnewsletterrr.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblnewsletterrr.Location = new Point(14, 27);
            lblnewsletterrr.Name = "lblnewsletterrr";
            lblnewsletterrr.Size = new Size(70, 22);
            lblnewsletterrr.TabIndex = 3;
            lblnewsletterrr.Text = "Newsletter";
            // 
            // pnlmainn
            // 
            pnlmainn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlmainn.AutoScroll = true;
            pnlmainn.AutoScrollMinSize = new Size(787, 1688);
            pnlmainn.BackColor = Color.White;
            pnlmainn.Controls.Add(flpNewsletter);
            pnlmainn.Controls.Add(btnsavee);
            pnlmainn.Controls.Add(btndeletee);
            pnlmainn.Controls.Add(lblnewsletterrr);
            pnlmainn.Location = new Point(151, 44);
            pnlmainn.Margin = new Padding(3, 2, 3, 2);
            pnlmainn.Name = "pnlmainn";
            pnlmainn.Size = new Size(689, 368);
            pnlmainn.TabIndex = 3;
            pnlmainn.Paint += panel3_Paint;
            // 
            // flpNewsletter
            // 
            flpNewsletter.AutoScroll = true;
            flpNewsletter.Controls.Add(pbgambar1);
            flpNewsletter.Controls.Add(pbgambar2);
            flpNewsletter.Controls.Add(pbgambar3);
            flpNewsletter.Controls.Add(btnAddNews);
            flpNewsletter.Location = new Point(18, 47);
            flpNewsletter.Name = "flpNewsletter";
            flpNewsletter.Size = new Size(618, 128);
            flpNewsletter.TabIndex = 13;
            // 
            // pbgambar1
            // 
            pbgambar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbgambar1.BackgroundImageLayout = ImageLayout.Stretch;
            pbgambar1.Location = new Point(3, 2);
            pbgambar1.Margin = new Padding(3, 2, 3, 2);
            pbgambar1.Name = "pbgambar1";
            pbgambar1.Size = new Size(196, 56);
            pbgambar1.TabIndex = 8;
            pbgambar1.TabStop = false;
            pbgambar1.Click += pictureBox2_Click;
            // 
            // pbgambar2
            // 
            pbgambar2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbgambar2.BackgroundImageLayout = ImageLayout.Stretch;
            pbgambar2.Location = new Point(205, 2);
            pbgambar2.Margin = new Padding(3, 2, 3, 2);
            pbgambar2.Name = "pbgambar2";
            pbgambar2.Size = new Size(196, 56);
            pbgambar2.TabIndex = 9;
            pbgambar2.TabStop = false;
            // 
            // pbgambar3
            // 
            pbgambar3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbgambar3.BackgroundImageLayout = ImageLayout.Stretch;
            pbgambar3.Location = new Point(407, 2);
            pbgambar3.Margin = new Padding(3, 2, 3, 2);
            pbgambar3.Name = "pbgambar3";
            pbgambar3.Size = new Size(196, 56);
            pbgambar3.TabIndex = 10;
            pbgambar3.TabStop = false;
            // 
            // btnAddNews
            // 
            btnAddNews.BackgroundImage = (Image)resources.GetObject("btnAddNews.BackgroundImage");
            btnAddNews.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNews.Font = new Font("Poppins Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNews.Location = new Point(3, 62);
            btnAddNews.Margin = new Padding(3, 2, 3, 2);
            btnAddNews.Name = "btnAddNews";
            btnAddNews.Size = new Size(196, 56);
            btnAddNews.TabIndex = 12;
            btnAddNews.Text = " ";
            btnAddNews.UseVisualStyleBackColor = true;
            btnAddNews.Click += button9_Click;
            // 
            // btnsavee
            // 
            btnsavee.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnsavee.BackColor = Color.FromArgb(5, 163, 165);
            btnsavee.Cursor = Cursors.Hand;
            btnsavee.Font = new Font("Poppins Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnsavee.ForeColor = Color.White;
            btnsavee.Location = new Point(501, 400);
            btnsavee.Margin = new Padding(3, 2, 3, 2);
            btnsavee.Name = "btnsavee";
            btnsavee.Size = new Size(149, 32);
            btnsavee.TabIndex = 6;
            btnsavee.Text = "Save";
            btnsavee.UseVisualStyleBackColor = false;
            // 
            // btndeletee
            // 
            btndeletee.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btndeletee.Cursor = Cursors.Hand;
            btndeletee.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btndeletee.Location = new Point(236, 400);
            btndeletee.Margin = new Padding(3, 2, 3, 2);
            btndeletee.Name = "btndeletee";
            btndeletee.Size = new Size(210, 32);
            btndeletee.TabIndex = 5;
            btndeletee.Text = "Delete";
            btndeletee.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 411);
            Controls.Add(pnlmainn);
            Controls.Add(pnlnavbarr);
            Controls.Add(pnlsidebarr);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(858, 450);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pblogoo).EndInit();
            pnlsidebarr.ResumeLayout(false);
            pnlnavbarr.ResumeLayout(false);
            pnlnavbarr.PerformLayout();
            pnlmainn.ResumeLayout(false);
            pnlmainn.PerformLayout();
            flpNewsletter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbgambar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbgambar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbgambar3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pblogoo;
        private Button btnnewsletterr;
        private Button btnpakett;
        private Button btnwisataa;
        private Button btnpenginapann;
        private Button btnumkmm;
        private Panel pnlsidebarr;
        private Label lblnewsletterr;
        private Button btnbackk;
        private Panel pnlnavbarr;
        private Label lblnewsletterrr;
        private Panel pnlmainn;
        private Button btndeletee;
        private Button btnsavee;
        private PictureBox pbgambar3;
        private PictureBox pbgambar2;
        private PictureBox pbgambar1;
        private Button btnAddNews;
        private FlowLayoutPanel flpNewsletter;
    }
}