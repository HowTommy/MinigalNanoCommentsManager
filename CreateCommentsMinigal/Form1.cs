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
            try
            {
                if (txtPath.Text.Trim() != "")
                {
                    string path = txtPath.Text.Trim();
                    _files = Directory.GetFiles(path).Where(p => p.EndsWith(".jpg") || p.EndsWith(".jpeg") || p.EndsWith(".png")).ToArray();

                    if (_files.Any())
                    {
                        _currentPicture = 0;
                        LoadImage();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, an error occured :(");

                File.AppendAllText("logs.txt", DateTime.UtcNow.ToString() + Environment.NewLine + ex.ToString() + Environment.NewLine + Environment.NewLine);
            }
        }

        private void LoadImage()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, an error occured :(");

                File.AppendAllText("logs.txt", DateTime.UtcNow.ToString() + Environment.NewLine + ex.ToString() + Environment.NewLine + Environment.NewLine);
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
            try
            {
                var path = _files[_currentPicture] + ".html";
                File.WriteAllText(path, txtComment.Text);
                this.btNext_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, an error occured :(");

                File.AppendAllText("logs.txt", DateTime.UtcNow.ToString() + Environment.NewLine + ex.ToString() + Environment.NewLine + Environment.NewLine);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
