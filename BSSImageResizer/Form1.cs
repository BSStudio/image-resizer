using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSSImageResizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
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

        private void RefreshProjectLink()
        {
            //W:\web\bss_vagott_web_16x9_HD

            String HDFolder = "bss_vagott_web_16a9_HD"; //high_quality/low_quality
            String SDFolder = "bss_vagott_web_16a9_SD";

            String VideosRoute = tbRoute.Text + "\\" + (rbHD.Checked ? HDFolder : SDFolder) + "\\high_quality"; 

            DirectoryInfo DI = new DirectoryInfo(VideosRoute);

            try
            {
                FileInfo[] fileList = DI.GetFiles();
                Array.Sort<FileInfo>(fileList, new Comparison<FileInfo>(
                    (x, y) => x.Name.CompareTo(y.Name)));

                Console.WriteLine(fileList);

                if (fileList.Length != 0)
                {
                    cbSelectProjectName.Items.Clear();
                    tbRoute.BackColor = Color.White;
                }
                    

                foreach (FileInfo fi in fileList)
                {
                    String fullname = fi.Name.Split('.')[0];
                    String name = fullname.Substring(0, fullname.Length - 3);

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
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {

        }
    }
}


//768x432 -> keyframe/_lq
//160x90 -> thumbnail/_tn