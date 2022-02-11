/* 
---------------------------------
Developed by Rhythmicbinary  :"))
---------------------------------
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DustInTheWind.WindowsApi;
using System.Drawing.Imaging;

namespace DrawBitmap
{
    public partial class Form1 : Form
    {
        string path = "";
        bool IsEmpty = true;
        public Form1()
        {
            InitializeComponent();
            int screenWidth = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width.ToString());
            int screenHeight = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height.ToString());
            ClientSize = new System.Drawing.Size(screenWidth, screenHeight);
            picbox_img.Size = this.picbox_img.Size = new System.Drawing.Size(screenWidth-300, screenHeight-60);
            int start_loc = screenWidth - 225;
            int start_loc_num = screenWidth - 138;
            int normalize = 20;
            //button's resizing ...
            btn_open.Location = new Point(start_loc, 27 + normalize);
            btn_exit.Location = new Point(start_loc, screenHeight - 65);
            btn_gray.Location = new Point(start_loc, 253 + normalize);
            btn_bw.Location = new Point(start_loc, 357 + normalize);
            btn_neg.Location = new Point(start_loc, 427 + normalize);
            btn_save.Location = new Point(start_loc, 89 + normalize);
            btn_org.Location = new Point(start_loc, 489 + normalize);
            btn_aply.Location = new Point(start_loc, 661 + normalize);
            // Labal's resizing ...
            lbl_blueS.Location = new Point(start_loc, 211 + normalize);
            lbl_greenS.Location = new Point(start_loc, 180 + normalize);
            lbl_redS.Location = new Point(start_loc, 150 + normalize);
            lbl_int.Location = new Point(start_loc, 314 + normalize);
            lbl_red.Location = new Point(start_loc, 562 + normalize);
            lbl_green.Location = new Point(start_loc, 592 + normalize);
            lbl_blue.Location = new Point(start_loc, 623 + normalize);
            // numericUpDown's resizing
            num_red.Location = new Point(start_loc_num, 556 + normalize);
            num_green.Location = new Point(start_loc_num, 592 + normalize);
            num_blue.Location = new Point(start_loc_num, 623 + normalize);
            num_bw.Location = new Point(start_loc_num, 309 + normalize);
            num_redS.Location = new Point(start_loc_num, 144 + normalize);
            num_greenS.Location = new Point(start_loc_num, 180 + normalize);
            num_blueS.Location = new Point(start_loc_num, 211 + normalize);

        }
        //Close form
        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?","exit",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Close();
            }          
        }
        //open Image
        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Format|*.gif;*.jpg;*.jpeg;*.jfif;*.pjpeg;*.pjp;*.png;*.svg;*.bmp;*.tif;*.tiff;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName;
                picbox_img.Image = new Bitmap(path);
                IsEmpty = false;

            }
        }
        //Save image
        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_img = new SaveFileDialog();
            if (!IsEmpty)
            {
                save_img.Filter = "|*.jpg;*.jpeg;*.jfif;*.pjpeg;*.pjp;*.png;*.gif;*.svg;;*.bmp;";
                save_img.Title = "Save Image";
                if (DialogResult.OK == save_img.ShowDialog())
                {
                    picbox_img.Image.Save(save_img.FileName);
                }
            }
            else
            {
                MessageBox.Show("لطفا تصویری را انتخاب کنید");
            }
        }

        //Make Gray
        private void btn_gray_Click(object sender, EventArgs e)
        {
            if (!IsEmpty)
            {
                Bitmap cpy = new Bitmap(path);
                double r = Convert.ToDouble(num_redS.Value == null ? num_redS.Value = 1 : num_redS.Value);
                double g = Convert.ToDouble(num_greenS.Value == null ? num_greenS.Value = 1 : num_greenS.Value);
                double b = Convert.ToDouble(num_blueS.Value == null ? num_blueS.Value = 1 : num_blueS.Value);
                picbox_img.Image = ImageProc.MakeGray(cpy, r, g, b);

            }
            else
            {
                MessageBox.Show("لطفا تصویری را انتخاب کنید");
            }
        }

        //Make Black and white
        private void btn_bw_Click(object sender, EventArgs e)
        {

            if (!IsEmpty)
            {
                int val = (int)num_bw.Value;
                Bitmap img = new Bitmap(path);
                picbox_img.Image = ImageProc.MakeBlackWhite(img, val);

            }
            else
            {
                MessageBox.Show("لطفا تصویری را انتخاب کنید");

            }


        }

        //Show orginal image
        private void btn_org_Click(object sender, EventArgs e)
        {
            if (!IsEmpty)
            {
                picbox_img.Image = new Bitmap(path);
            }
            else
            {
                MessageBox.Show("لطفا تصویری را انتخاب کنید");

            }

        }

        // Make negetive 
        private void btn_neg_Click(object sender, EventArgs e)
        {
            if (!IsEmpty)
            {
                picbox_img.Image = ImageProc.MakeNegative(new Bitmap(path));
            }
            else
            {
                MessageBox.Show("لطفا تصویری را انتخاب کنید");

            }
        }
        // if red or green or blue value is be chenged this method called 
        private void num_ValueChanged(object sender, EventArgs e)
        {

            if (!IsEmpty)
            {
                int red = (int)num_red.Value;
                int green = (int)num_green.Value;
                int blue = (int)num_blue.Value;
                picbox_img.Image = ImageProc.ApplyChanges(new Bitmap(path), red, green, blue);
            }
            else
            {
                num_red.Value = 0;
                num_green.Value = 0;
                num_blue.Value = 0;
                MessageBox.Show("لطفا تصویری را انتخاب کنید");

            }
        }

        private void btn_alpy_Click(object sender, EventArgs e)
        {
            if (!IsEmpty)
            {
                int red = (int)num_red.Value;
                int green = (int)num_green.Value;
                int blue = (int)num_blue.Value;
                picbox_img.Image = ImageProc.ApplyChanges(new Bitmap(path), red, green, blue);
            }
            else
            {
                MessageBox.Show("لطفا تصویری را انتخاب کنید");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}



