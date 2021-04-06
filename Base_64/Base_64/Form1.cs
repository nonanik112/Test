using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Base_64
{
    public partial class Form1 : Form
    {
        string base64Text;
        Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;"+
                "|All files(*.*)|*.*";
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = (Image)image;

                byte[] imageArray = System.IO.File.ReadAllBytes(dialog.FileName);
                // base64 Metini evrensel olmalı, ancak zengin metin türünde kullanacağım 
                 base64Text = Convert.ToBase64String(imageArray);
                richTextBox1.Text = base64Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = @"C:\\Users\Metehan\Desktop\İŞ SINAVI\base64";
            using(StreamWriter stream = File.CreateText(path))
            {
                //stream.Write(richTextBox1.Text);
                stream.Write(base64Text); //Alternatif yol 

            }
        }
    }
}
