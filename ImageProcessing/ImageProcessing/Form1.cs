using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool zoomed = false;
        string selectedfilename;
        Bitmap originalimage;
        Bitmap zoomedimage;
        bool loaded = false;
        int zoomtox = -1, zoomtoy = -1;
        Color color;
        bool colorselected = false;
        int paintx, painyy;
        bool mousedown = false;
        Rectangle selection;
        int current_theme_index = 0;
        string[] themes = { "pastel", "dark", "light" };

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            find_coordinates_to_zoom_to(e);
        }

        public void find_coordinates_to_zoom_to(MouseEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0 && colorselected == false && zoomed == false)
            {
                zoomtox = e.X;
                zoomtoy = e.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browse_file();
            fill_resize_tab();
            fill_picturebox();
            button2.Enabled = true;
        }

        public void browse_file()
        {
            OpenFileDialog di = new OpenFileDialog();
            di.Title = "Select the image you want to edit";
            di.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            if (di.ShowDialog() == DialogResult.OK)
            {
                selectedfilename = di.FileName;
                //create a copy of original image
                originalimage = new Bitmap(Image.FromFile(selectedfilename), pictureBox1.Width, pictureBox1.Height);
                zoomedimage = originalimage;
            }
        }

        public void fill_resize_tab()
        {
            if (selectedfilename != null)
            {
                Image img = Image.FromFile(selectedfilename);
                label1.Text = "Original image width: ";
                label1.Text += img.Width.ToString();
                label2.Text = "Original image height: ";
                label2.Text += img.Height.ToString();
                textBox1.Text = img.Width.ToString();
                textBox2.Text = img.Height.ToString();
            }
        }

        public void fill_picturebox()
        {
            if (zoomedimage != null)
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.Clear(Color.LightCyan);
                if (zoomed)
                {
                    zoomedimage = new Bitmap(zoomedimage, pictureBox1.Width * trackBar1.Value, pictureBox1.Height * trackBar1.Value);
                    g.DrawImage(zoomedimage, -zoomtox * (trackBar1.Value), -zoomtoy * (trackBar1.Value));
                }
                else
                {
                    zoomedimage = new Bitmap(zoomedimage, originalimage.Width, originalimage.Height);
                    g.DrawImage(zoomedimage, 0, 0);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tryzoom();
            fill_picturebox();
        }

        public void tryzoom()
        {
            if (!zoomed)
            {
                if (zoomtox != -1)
                {
                    zoomed = true;
                    button2.Text = "Zoom out";
                }
                else
                {
                    button2.Text = "Zoom in"; ;
                    MessageBox.Show("Click on image to select the point you want to zoom in to");
                }
            }
            else
            {
                zoomed = false;
                zoomedimage = new Bitmap(zoomedimage, originalimage.Width, originalimage.Height);
                button2.Text = "Zoom in";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (selectedfilename != null)
            {
                Image img = Image.FromFile(selectedfilename);
                if (Convert.ToInt32(textBox1.Text) != img.Width || Convert.ToInt32(textBox2.Text) != img.Height)
                {
                    MessageBox.Show(originalimage.Width.ToString());
                    if (MessageBox.Show("The dimensions of the image have been changed. Do you want to save the image in current size?", "Save image", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                        save_image();
                }
                else
                    save_image();
            }
            else
                MessageBox.Show("Please select a file before attempting to save your project!");
        }

        public void save_image()
        {
            Bitmap newimage = new Bitmap(zoomedimage, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save new image";
            saveFileDialog.Filter = "PNG|*.png|GIF|*.gif|BMP|*.bmp|JPEG|*.jpg;*.jpeg";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                newimage.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                colorselected = true;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            colorselected = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                if (colorselected)
                {
                    Graphics g = Graphics.FromImage(zoomedimage);
                    Graphics pic = pictureBox1.CreateGraphics();
                    Rectangle stroke;
                    if (zoomed)
                        stroke = new Rectangle(zoomtox * (trackBar1.Value) + e.X, zoomtoy * (trackBar1.Value) + e.Y, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox3.Text));
                    else
                        stroke = new Rectangle(e.X, e.Y, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox3.Text));
                    Brush brush = new SolidBrush(color);
                    Rectangle strokey = new Rectangle(e.X, e.Y, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox3.Text));
                    g.FillEllipse(brush, stroke);
                    pic.FillEllipse(brush, strokey);
                }
                else
                {
                    if (mousedown && tabControl1.SelectedIndex == 3)
                    {
                        fill_picturebox();
                        int selectionwidth = Convert.ToInt32(textBox4.Text);
                        int selectionheight = Convert.ToInt32(textBox5.Text);
                        selection = new Rectangle(e.X, e.Y, selectionwidth, selectionheight);
                        Pen pen = new Pen(Color.White);
                        Graphics g = pictureBox1.CreateGraphics();
                        g.DrawRectangle(pen, selection);
                    }
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
            if (colorselected)
                fill_picturebox();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //clear previous selections
            fill_picturebox();
            //generate new selection
            int selectionwidth = Convert.ToInt32(textBox4.Text);
            int selectionheight = Convert.ToInt32(textBox5.Text);
            selection = new Rectangle(pictureBox1.Width / 2 - selectionwidth / 2, pictureBox1.Height / 2 - selectionheight / 2, selectionwidth, selectionheight);
            Pen pen = new Pen(Color.White);
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawRectangle(pen, selection);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != 2) //automatically clear brush if tab has changed
                colorselected = false;
            fill_picturebox();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap cropped = new Bitmap(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
            Graphics g = Graphics.FromImage(cropped);
            g.DrawImage(zoomedimage, -(zoomtox + selection.X) * (trackBar1.Value), -(zoomtoy + selection.Y) * (trackBar1.Value));

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save croped selection";
            saveFileDialog.Filter = "PNG|*.png|GIF|*.gif|BMP|*.bmp|JPEG|*.jpg;*.jpeg";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                cropped.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(zoomedimage);
            g.Clear(Color.Transparent);
            zoomedimage = originalimage;
            fill_picturebox();
        }
    }
}
