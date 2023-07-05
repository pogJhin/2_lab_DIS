using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgApp_2_WinForms
{
    public partial class Form1 : Form
    {
        Bitmap image1 = null;
        Bitmap result = null;
        Bitmap image2 = null;
        Bitmap[] figure = new Bitmap[3];
        public Form1()
        {
            InitializeComponent();
            figure[0] = new Bitmap(filename:"..\\..\\one.jpg");
            figure[1] = new Bitmap(filename: "..\\..\\two.jpg");
            figure[2] = new Bitmap(filename: "..\\..\\three.jpg");
        }
        private void bAdd1_Click(object sender, EventArgs e)
        {
            if (image1 != null)
            {
                image1form.Image = null;
                image1.Dispose();
            }

            image1 = AddImage();
            image1form.Image = image1;
            imageviewform.Image = image1;
        }
        private void bAdd2_Click(object sender, EventArgs e)
        {
            if (image2 != null)
            {
                image2form.Image = null;
                image2.Dispose();
            }
            image2 = AddImage();
            image2form.Image = image2;
            imageviewform.Image = image2;
        }
        private Bitmap AddImage()
        {
            Bitmap image = null;
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "Картинки (png, jpg, bmp, gif) |*.png;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(openFileDialog.FileName);
                return image;
            }
            else
                return null;
        }
        private void bReS_Click(object sender, EventArgs e)
        {
            if ((image1 == null) || (image2 == null))
            {
                MessageBox.Show("No images to resize");
                return;
            }
            if ((image1.Width == image2.Width) && (image2.Height == image1.Height))
            {
                MessageBox.Show("images heights and wifths are equal");
                return;

            }
            Bitmap result = new Bitmap(image2.Width, image2.Height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(image1, 0, 0, image2.Width, image2.Height);
            }
            image1 = result;
            image1form.Image = image1;
            imageviewform.Image = image1;
        }
        private void image1form_Click(object sender, EventArgs e)
        {
            imageviewform.Image = image1;
        }
        private void image2form_Click(object sender, EventArgs e)
        {
            imageviewform.Image = image2;
        }
        private void resultform_Click(object sender, EventArgs e)
        {
            imageviewform.Image = result;
        }
        private void bSumm_Click(object sender, EventArgs e)
        {
            if ((image1.Height == 141) || (image2.Height == 141))
            {
                MessageBox.Show("not enough images");
                return;
            }
            if(!(image1.Width == image2.Width) && !(image2.Height == image1.Height))
            {
                MessageBox.Show("images widhts and heights are not equal");
                return;
            }
            result = new Bitmap(image2.Width, image2.Height);
            resultform.Image = result;
            for (int i =0;i < image2.Width;i++)
            {
                for (int j = 0; j< image2.Height; j++)
                {
                    var f = image1.GetPixel(i, j);
                    var t = image2.GetPixel(i, j);
                    int r = f.R + t.R;
                    if (r > 255)
                        r = 255;
                    int g = f.G + t.G;
                    if (g > 255)
                        g = 255;
                    int b = f.B + t.B;
                    if (b > 255)
                        b = 255;
                    var color = Color.FromArgb(r,g,b);
                    result.SetPixel(i, j, color);
                }
            }
            imageviewform.Image = result;
            resultform.Image = result;
        }
        private void bAvg_Click(object sender, EventArgs e)
        {
            if ((image1.Height == 141) || (image2.Height == 141))
            {
                MessageBox.Show("not enough images");
                return;
            }
            if (!(image1.Width == image2.Width) && !(image2.Height == image1.Height))
            {
                MessageBox.Show("images widhts and heights are not equal");
                return;
            }
            result = new Bitmap(image2.Width, image2.Height);
            resultform.Image = result;
            for (int i = 0; i < image2.Width; i++)
            {
                for (int j = 0; j < image2.Height; j++)
                {
                    var f = image1.GetPixel(i, j);
                    var t = image2.GetPixel(i, j);
                    int r = (f.R + t.R)/2;
                    int g = (f.G + t.G) / 2;
                    int b = (f.B + t.B) / 2;
                    var color = Color.FromArgb(r, g, b);
                    result.SetPixel(i, j, color);
                }
            }
            resultform.Image = result;
            imageviewform.Image = result;
        }
        private void bTms_Click(object sender, EventArgs e)
        {
            if ((image1.Height == 141) || (image2.Height == 141))
            {
                MessageBox.Show("not enough images");
                return;
            }
            if (!(image1.Width == image2.Width) && !(image2.Height == image1.Height))
            {
                MessageBox.Show("images widhts and heights are not equal");
                return;
            }
            result = new Bitmap(image2.Width, image2.Height);
            resultform.Image = result;
            for (int i = 0; i < image2.Width; i++)
            {
                for (int j = 0; j < image2.Height; j++)
                {
                    var f = image1.GetPixel(i, j);
                    var t = image2.GetPixel(i, j);
                    int r = f.R*t.R/255;
                    int g = f.G * t.G / 255;
                    int b = f.B * t.B / 255;
                    var color = Color.FromArgb(r, g, b);
                    result.SetPixel(i, j, color);
                }
            }
            resultform.Image = result;
            imageviewform.Image = result;
        }
        private void vMin_Click(object sender, EventArgs e)
        {
            if ((image1.Height == 141) || (image2.Height == 141))
            {
                MessageBox.Show("not enough images");
                return;
            }
            if (!(image1.Width == image2.Width) && !(image2.Height == image1.Height))
            {
                MessageBox.Show("images widhts and heights are not equal");
                return;
            }
            result = new Bitmap(image2.Width, image2.Height);
            resultform.Image = result;
            for (int i = 0; i < image2.Width; i++)
            {
                for (int j = 0; j < image2.Height; j++)
                {
                    var f = image1.GetPixel(i, j);
                    var t = image2.GetPixel(i, j);
                    int r, g, b;
                    if (t.R < f.R)
                        r = t.R;
                    else
                        r = f.R;
                    if (t.G < f.G)
                        g = t.G;
                    else
                        g = f.G;
                    if (t.B < f.B)
                        b = t.B;
                    else
                        b = f.B;
                    var color = Color.FromArgb(r, g, b);
                    result.SetPixel(i, j, color);
                }
            }
            resultform.Image = result;
            imageviewform.Image = result;
        }
        private void bMax_Click(object sender, EventArgs e)
        {
            if ((image1.Height == 141) || (image2.Height == 141))
            {
                MessageBox.Show("not enough images");
                return;
            }
            if (!(image1.Width == image2.Width) && !(image2.Height == image1.Height))
            {
                MessageBox.Show("images widhts and heights are not equal");
                return;
            }
            result = new Bitmap(image2.Width, image2.Height);
            resultform.Image = result;
            for (int i = 0; i < image2.Width; i++)
            {
                for (int j = 0; j < image2.Height; j++)
                {
                    var f = image1.GetPixel(i, j);
                    var t = image2.GetPixel(i, j);
                    int r, g, b;
                    if (t.R > f.R)
                        r = t.R;
                    else
                        r = f.R;
                    if (t.G > f.G)
                        g = t.G;
                    else
                        g = f.G;
                    if (t.B > f.B)
                        b = t.B;
                    else
                        b = f.B;
                    var color = Color.FromArgb(r, g, b);
                    result.SetPixel(i, j, color);
                }
            }
            resultform.Image = result;
            imageviewform.Image = result;
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            if (resultform.Image == null)
            {
                MessageBox.Show("nothing to save");
                return;
            }
            using SaveFileDialog saveFileFialog = new SaveFileDialog();
            saveFileFialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileFialog.Filter = "Картинки (png, jpg, bmp, gif) |*.png;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";
            saveFileFialog.RestoreDirectory = true;

            if (saveFileFialog.ShowDialog() == DialogResult.OK)
            {
                if (result != null)
                {
                    result.Save(saveFileFialog.FileName);
                }
            }
        }
        private void bMask_Click(object sender, EventArgs e)
        {
            int k;
            switch (comboBox1.Text)
            {
                case "овал":
                    k = 0;
                    break;
                case "треугольник":
                    k = 1;
                    break;
                case "прямоугольник":
                    k = 2;
                    break;
                default:
                    k = -1;
                    break;
            }
            if (k==-1)
            {
                MessageBox.Show("select mask type");
                return;
            }

            if (imageviewform.Image == null)
            {
                MessageBox.Show("no image to work with");
                return;
            }
            result = new Bitmap(imageviewform.Image);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(figure[k], 0, 0, result.Width, result.Height);
            }
            figure[k] = result;

            for (int i = 0; i < result.Width; i++)
            {
                for (int j = 0; j < result.Height; j++)
                {
                    var f = figure[k].GetPixel(i, j);
                    int r, g, b;
                    if (!(f.Name == "ff000000")&&!(f.Name == "ffffffff"))
                    {
                        r = 0;
                        g = 0;
                        b = 0;
                        var color = Color.FromArgb(r, g, b);
                        figure[k].SetPixel(i, j, color);
                    }
                }
            }

            result = new Bitmap(imageviewform.Image);
            for (int i = 0; i < result.Width; i++)
            {
                for (int j = 0; j < result.Height; j++)
                {
                    var f = result.GetPixel(i, j);
                    var t = figure[k].GetPixel(i, j);
                    int r, g, b;
                    if (t.Name == "ff000000")
                    {
                        r = 255;
                        g = 255;
                        b = 255;
                    }
                    else
                    {
                        r = f.R * t.R / 255;
                        g = f.G * t.G / 255;
                        b = f.B * t.B / 255;
                    }
                    var color = Color.FromArgb(r, g, b);
                    result.SetPixel(i, j, color);
                }
            }

            resultform.Image = result;
            imageviewform.Image = result;
        }
        private void bChn_Click(object sender, EventArgs e)
        {
            int kR, kB, kG;
            switch (comboBox2.Text)
            {
                case "R":
                    kR = 1; kB = 0; kG = 0;
                    break;
                case "G":
                    kR = 0; kB = 0; kG = 1;
                    break;
                case "B":
                    kR = 0; kB = 1; kG = 0;
                    break;
                case "RG":
                    kR = 1; kB = 0; kG = 1;
                    break;
                case "RB":
                    kR = 1; kB = 1; kG = 0;
                    break;
                case "GB":
                    kR = 0; kB = 1; kG = 1;
                    break;
                default:
                    MessageBox.Show("select channel type");
                    return;
            }

            if (imageviewform.Image == null)
            {
                MessageBox.Show("no image to work with");
                return;
            }

            result = new Bitmap(imageviewform.Image);
            for (int i = 0; i < result.Width; i++)
            {
                for (int j = 0; j < result.Height; j++)
                {
                    var f = result.GetPixel(i, j);
                    int r = f.R * kR;
                    int g = f.G * kG;
                    int b = f.B * kB;
                    var color = Color.FromArgb(r, g, b);
                    result.SetPixel(i, j, color);
                }
            }

            resultform.Image = result;
            imageviewform.Image = result;
        }

    }
}
