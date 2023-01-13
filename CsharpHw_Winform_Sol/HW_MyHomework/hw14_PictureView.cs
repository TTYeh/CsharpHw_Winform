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

namespace HW_MyHomework
{
    public partial class hw14_PictureView : Form
    {
        public hw14_PictureView()
        {
            InitializeComponent();
            this.Load += Hw14_PictureView_Load;
        }

        private void Hw14_PictureView_Load(object sender, EventArgs e)
        {
            var a = GetMyImageForderPath();
        }
        public string GetMyImageForderPath()
        {
            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;

            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            
            return projectDirectory + $@"\source\image_hw";
        }
    }
}
