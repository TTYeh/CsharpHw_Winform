using HW_MyHomework.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_MyHomework
{
    public partial class hw14_PictureSubPanel : Form, ISubPanel
    {
        private string _imgPath;

        public hw14_PictureSubPanel(string path)
        {
            InitializeComponent();
            _imgPath = path;
            this.Load += Hw14_PictureSubPanel_Load;
        }

        private void Hw14_PictureSubPanel_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(_imgPath);
        }

        public void CloseSubPanel(Form panel)
        {
            panel.Close();
        }
    }
}
