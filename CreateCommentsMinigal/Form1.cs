using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CreateCommentsMinigal
{
    using System.IO;

    public partial class Form1 : Form
    {
        private string[] _files;

        private int _currentPicture;
 
        public Form1()
        {
            InitializeComponent();
        }

        private void btLoadPictures_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text;
            _files = Directory.GetFiles(path).Where(p => p.EndsWith(".jpg") || p.EndsWith(".jpeg") || p.EndsWith(".png")).ToArray();

            if (_files.Any())
            {
                _currentPicture = 0;
                LoadImage();
            }
        }

        private void LoadImage()
        {
            if (_currentPicture > _files.Count() - 1)
            {
                _currentPicture = 0;
            }
            else if (_currentPicture == -1)
            {
                _currentPicture = _files.Count() - 1;
            }
            var path = _files[_currentPicture];
            pictureBox1.Image = new Bitmap(path);
            if (File.Exists(path + ".html"))
            {
                txtComment.Text = File.ReadAllText(path + ".html");
            }
            else
            {
                txtComment.Text = "";
            }
        }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            _currentPicture--;
            this.LoadImage();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            _currentPicture++;
            this.LoadImage();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var path = _files[_currentPicture] + ".html";
            File.WriteAllText(path, txtComment.Text);
            this.btNext_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (!string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath;
                this.btLoadPictures_Click(sender, e);
            }
        }
    }
}
