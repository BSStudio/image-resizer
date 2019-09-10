using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace BSSImageResizer
{
    public partial class Form1 : Form
    {
        private const String HDFolder = "bss_vagott_web_16a9_HD";
        private const String SDFolder = "bss_vagott_web_16a9_SD";

        public Form1()
        {
            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;  //csodás WinXP looks PeeT személyes kérésére :D

            InitializeComponent();
        }

        private void btSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            //For any other formats
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pbSelectedPic.SizeMode = PictureBoxSizeMode.StretchImage;
                pbSelectedPic.ImageLocation = of.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearFields()
        {
            btGenerate.BackColor = Color.LightGray;

            tbRoute.BackColor = Color.White;

            lbDesc.Text = "Amit be kell másolj a videó leírásába:";
            tbDesc.Text = "";
        }

        private void RefreshProjectLink()
        {
            String VideosRoute = tbRoute.Text + "\\" + (rbHD.Checked ? HDFolder : SDFolder) + "\\high_quality"; 

            DirectoryInfo DI = new DirectoryInfo(VideosRoute);

            try
            {
                FileInfo[] fileList = DI.GetFiles();
                Array.Sort<FileInfo>(fileList, new Comparison<FileInfo>(
                    (x, y) => x.Name.CompareTo(y.Name)));
                /*
                foreach (var fileInfo in fileList)
                {
                    Console.WriteLine(fileInfo.Name);
                }*/

                if (fileList.Length != 0)
                {
                    clearFields();

                    cbSelectProjectName.Items.Clear();
                }

                foreach (FileInfo fi in fileList)
                {
                    String fullname = fi.Name.Split('.')[0];
                    String name = fullname.Substring(0, fullname.Length - 6);

                    if (cbSelectProjectName.Text.Length == 0)       //ha nincs beleirva semmi a kivalasztoba, akkor mindent belerakunk, 
                    {
                        cbSelectProjectName.Items.Add(name);
                    }
                    else                                            //ha van irva valami, akkor csak azokat tesszuk bele, amikben bennevan a beirt szoveg
                    {
                        if(name.ToLower().Contains(cbSelectProjectName.Text.ToLower()))
                            cbSelectProjectName.Items.Add(name);
                    }
                }
            }
            catch
            {
                tbRoute.BackColor = Color.MistyRose;
                Console.WriteLine("jajj jajj");
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshProjectLink();
        }

        private void tbRoute_TextChanged(object sender, EventArgs e)
        {
            RefreshProjectLink();
        }

        private void cbSelectProjectName_TextUpdate(object sender, EventArgs e)
        {
            RefreshProjectLink();

            cbSelectProjectName.SelectionStart = cbSelectProjectName.Text.Length;
            cbSelectProjectName.SelectionLength = 0;
        }

        private void rbHD_CheckedChanged(object sender, EventArgs e)
        {
            RefreshProjectLink();
            cbSelectProjectName.Text = "";
        }

        private void cbSelectProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearFields();
        }

        private void generateImages()
        {
            if (cbSelectProjectName.Text.Length != 0)
            {
                String VideosRoute = tbRoute.Text + "\\" + (rbHD.Checked ? HDFolder : SDFolder);

                Image indexPic = new Bitmap(pbSelectedPic.ImageLocation);

                Image thumbnail = ResizeImage(indexPic, 160, 90);
                thumbnail.Save(VideosRoute + "\\thumbnail\\" + cbSelectProjectName.Text + "_tn.png", ImageFormat.Png);

                Image keyframe = ResizeImage(indexPic, 768, 432);
                keyframe.Save(VideosRoute + "\\keyframe\\" + cbSelectProjectName.Text + "_lq.png", ImageFormat.Png);

                tbDesc.Text = "<img src = \"https://v.bsstudio.hu/bss_vagott_web_16a9_" + (rbHD.Checked ? "HD" : "SD") +
                              "/keyframe/" + cbSelectProjectName.Text + "_lq.png\" style = \"display: none;\" />";

                btGenerate.BackColor = Color.LightGreen;
            }
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            generateImages();
        }

        private void generálásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateImages();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string message = "Készítette: ifj. Boldi\nKészült 2019 őszén, nagyságos törzsfőnökünk, PitaÚr megbízásából.\nGit: https://github.com/BSStudio/image-resizer";
            string caption = "About";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            
            result = MessageBox.Show(message, caption, buttons);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbDesc.Text != "")
            {
                Clipboard.SetText(tbDesc.Text);
                lbDesc.Text += " (vágólapra másolva)";

                button3.BackColor = Color.LightGray;
                button1.BackColor = Color.LightGreen;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cbSelectProjectName.Text != "")
            {
                Clipboard.SetText(cbSelectProjectName.Text);

                button1.BackColor = Color.LightGray;
                button3.BackColor = Color.LightGreen;
            }
        }
    }
}

//C:\Users\marta\Documents\BSS\web
//W:\web\bss_vagott_web_16x9_HD
//768x432 -> keyframe/_lq
//160x90 -> thumbnail/_tn