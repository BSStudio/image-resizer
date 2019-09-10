namespace BSSImageResizer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbName = new System.Windows.Forms.Label();
            this.cbSelectProjectName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSelectImage = new System.Windows.Forms.Button();
            this.pbSelectedPic = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRoute = new System.Windows.Forms.TextBox();
            this.btGenerate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbSD = new System.Windows.Forms.RadioButton();
            this.rbHD = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generálásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedPic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(12, 23);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(413, 27);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "BSS honlap videó indexkép generátor";
            // 
            // cbSelectProjectName
            // 
            this.cbSelectProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSelectProjectName.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectProjectName.FormattingEnabled = true;
            this.cbSelectProjectName.Location = new System.Drawing.Point(269, 127);
            this.cbSelectProjectName.Name = "cbSelectProjectName";
            this.cbSelectProjectName.Size = new System.Drawing.Size(317, 26);
            this.cbSelectProjectName.TabIndex = 1;
            this.cbSelectProjectName.SelectedIndexChanged += new System.EventHandler(this.cbSelectProjectName_SelectedIndexChanged);
            this.cbSelectProjectName.TextUpdate += new System.EventHandler(this.cbSelectProjectName_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Projekt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elkészített kép:";
            // 
            // btSelectImage
            // 
            this.btSelectImage.BackColor = System.Drawing.Color.LightGray;
            this.btSelectImage.Font = new System.Drawing.Font("Montserrat", 9F);
            this.btSelectImage.Location = new System.Drawing.Point(193, 169);
            this.btSelectImage.Name = "btSelectImage";
            this.btSelectImage.Size = new System.Drawing.Size(90, 28);
            this.btSelectImage.TabIndex = 4;
            this.btSelectImage.Text = "Kiválasztás";
            this.btSelectImage.UseVisualStyleBackColor = false;
            this.btSelectImage.Click += new System.EventHandler(this.btSelectImage_Click);
            // 
            // pbSelectedPic
            // 
            this.pbSelectedPic.Location = new System.Drawing.Point(193, 203);
            this.pbSelectedPic.Name = "pbSelectedPic";
            this.pbSelectedPic.Size = new System.Drawing.Size(489, 275);
            this.pbSelectedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelectedPic.TabIndex = 5;
            this.pbSelectedPic.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Videók elérési útvonala:";
            // 
            // tbRoute
            // 
            this.tbRoute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRoute.Font = new System.Drawing.Font("Montserrat", 10F);
            this.tbRoute.Location = new System.Drawing.Point(193, 70);
            this.tbRoute.Name = "tbRoute";
            this.tbRoute.Size = new System.Drawing.Size(488, 24);
            this.tbRoute.TabIndex = 7;
            this.tbRoute.Text = "W:\\";
            this.tbRoute.TextChanged += new System.EventHandler(this.tbRoute_TextChanged);
            // 
            // btGenerate
            // 
            this.btGenerate.BackColor = System.Drawing.Color.LightGray;
            this.btGenerate.Font = new System.Drawing.Font("Montserrat", 9F);
            this.btGenerate.Location = new System.Drawing.Point(496, 543);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(90, 28);
            this.btGenerate.TabIndex = 8;
            this.btGenerate.Text = "Generálás";
            this.btGenerate.UseVisualStyleBackColor = false;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Montserrat", 9F);
            this.button2.Location = new System.Drawing.Point(592, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Bezárás";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbSD
            // 
            this.rbSD.AutoSize = true;
            this.rbSD.Font = new System.Drawing.Font("Montserrat", 10F);
            this.rbSD.Location = new System.Drawing.Point(283, 103);
            this.rbSD.Name = "rbSD";
            this.rbSD.Size = new System.Drawing.Size(82, 24);
            this.rbSD.TabIndex = 10;
            this.rbSD.Text = "SD 16x9";
            this.rbSD.UseVisualStyleBackColor = true;
            // 
            // rbHD
            // 
            this.rbHD.AutoSize = true;
            this.rbHD.Checked = true;
            this.rbHD.Font = new System.Drawing.Font("Montserrat", 10F);
            this.rbHD.Location = new System.Drawing.Point(193, 103);
            this.rbHD.Name = "rbHD";
            this.rbHD.Size = new System.Drawing.Size(84, 24);
            this.rbHD.TabIndex = 11;
            this.rbHD.TabStop = true;
            this.rbHD.Text = "HD 16x9";
            this.rbHD.UseVisualStyleBackColor = true;
            this.rbHD.CheckedChanged += new System.EventHandler(this.rbHD_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tőfájlnév:";
            // 
            // tbDesc
            // 
            this.tbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDesc.Font = new System.Drawing.Font("Montserrat", 10F);
            this.tbDesc.Location = new System.Drawing.Point(17, 508);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(569, 24);
            this.tbDesc.TabIndex = 14;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc.Location = new System.Drawing.Point(13, 485);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(267, 20);
            this.lbDesc.TabIndex = 13;
            this.lbDesc.Text = "Amit be kell másolj a videó leírásába:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generálásToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // generálásToolStripMenuItem
            // 
            this.generálásToolStripMenuItem.Name = "generálásToolStripMenuItem";
            this.generálásToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.generálásToolStripMenuItem.Text = "Generálás";
            this.generálásToolStripMenuItem.Click += new System.EventHandler(this.generálásToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.kilépésToolStripMenuItem.Text = "Bezárás";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Font = new System.Drawing.Font("Montserrat", 10F);
            this.radioButton1.Location = new System.Drawing.Point(371, 103);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(183, 24);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.Text = "SD 4x3 (coming soon)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Montserrat", 9F);
            this.button1.Location = new System.Drawing.Point(591, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Vágólapra!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Font = new System.Drawing.Font("Montserrat", 9F);
            this.button3.Location = new System.Drawing.Point(592, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 28);
            this.button3.TabIndex = 19;
            this.button3.Text = "Vágólapra!";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 579);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbHD);
            this.Controls.Add(this.rbSD);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.tbRoute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbSelectedPic);
            this.Controls.Add(this.btSelectImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSelectProjectName);
            this.Controls.Add(this.lbName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Képmanipulátor 2000";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedPic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox cbSelectProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSelectImage;
        private System.Windows.Forms.PictureBox pbSelectedPic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRoute;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbSD;
        private System.Windows.Forms.RadioButton rbHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generálásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

