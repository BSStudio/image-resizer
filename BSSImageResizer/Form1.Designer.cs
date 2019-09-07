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
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(13, 105);
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
            this.cbSelectProjectName.Location = new System.Drawing.Point(270, 209);
            this.cbSelectProjectName.Name = "cbSelectProjectName";
            this.cbSelectProjectName.Size = new System.Drawing.Size(412, 26);
            this.cbSelectProjectName.TabIndex = 1;
            this.cbSelectProjectName.TextUpdate += new System.EventHandler(this.cbSelectProjectName_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Projekt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elkészített kép:";
            // 
            // btSelectImage
            // 
            this.btSelectImage.Font = new System.Drawing.Font("Montserrat", 9F);
            this.btSelectImage.Location = new System.Drawing.Point(194, 251);
            this.btSelectImage.Name = "btSelectImage";
            this.btSelectImage.Size = new System.Drawing.Size(90, 28);
            this.btSelectImage.TabIndex = 4;
            this.btSelectImage.Text = "Kiválasztás";
            this.btSelectImage.UseVisualStyleBackColor = true;
            this.btSelectImage.Click += new System.EventHandler(this.btSelectImage_Click);
            // 
            // pbSelectedPic
            // 
            this.pbSelectedPic.Location = new System.Drawing.Point(194, 285);
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
            this.label3.Location = new System.Drawing.Point(14, 153);
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
            this.tbRoute.Location = new System.Drawing.Point(194, 152);
            this.tbRoute.Name = "tbRoute";
            this.tbRoute.Size = new System.Drawing.Size(488, 24);
            this.tbRoute.TabIndex = 7;
            this.tbRoute.Text = "C:\\Users\\marta\\Documents\\BSS\\web";
            this.tbRoute.TextChanged += new System.EventHandler(this.tbRoute_TextChanged);
            // 
            // btGenerate
            // 
            this.btGenerate.Font = new System.Drawing.Font("Montserrat", 9F);
            this.btGenerate.Location = new System.Drawing.Point(497, 566);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(90, 28);
            this.btGenerate.TabIndex = 8;
            this.btGenerate.Text = "Generálás";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Montserrat", 9F);
            this.button2.Location = new System.Drawing.Point(593, 566);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Kilépés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbSD
            // 
            this.rbSD.AutoSize = true;
            this.rbSD.Font = new System.Drawing.Font("Montserrat", 10F);
            this.rbSD.Location = new System.Drawing.Point(194, 185);
            this.rbSD.Name = "rbSD";
            this.rbSD.Size = new System.Drawing.Size(48, 24);
            this.rbSD.TabIndex = 10;
            this.rbSD.Text = "SD";
            this.rbSD.UseVisualStyleBackColor = true;
            // 
            // rbHD
            // 
            this.rbHD.AutoSize = true;
            this.rbHD.Checked = true;
            this.rbHD.Font = new System.Drawing.Font("Montserrat", 10F);
            this.rbHD.Location = new System.Drawing.Point(248, 185);
            this.rbHD.Name = "rbHD";
            this.rbHD.Size = new System.Drawing.Size(50, 24);
            this.rbHD.TabIndex = 11;
            this.rbHD.TabStop = true;
            this.rbHD.Text = "HD";
            this.rbHD.UseVisualStyleBackColor = true;
            this.rbHD.CheckedChanged += new System.EventHandler(this.rbHD_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tőfájlnév:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 603);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BSS Image Resizer v2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedPic)).EndInit();
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
    }
}

