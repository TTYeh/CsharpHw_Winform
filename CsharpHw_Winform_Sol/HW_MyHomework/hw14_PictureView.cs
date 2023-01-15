using Csharp_UtilityToolBox_Lib;
using HW_MyHomework.Interface;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW_MyHomework
{
    public partial class hw14_PictureView : Form
    {
        // hw14要做介面主表單叫出的多個子表單，當主表單關閉，大量的子表單要一起關閉，想用介面ISubPanel實作但失敗QQ
        //private List<ISubPanel> subpanels;
        private string[] ImageList;

        // 主要練習若this關掉時，this介面產生的圖片瀏覽小視窗(winForm)要跟著關，用介面。
        // 動態產生影像瀏覽物件&事件
        public hw14_PictureView()
        {
            InitializeComponent();
            this.Load += Hw14_PictureView_Load;
        }

        private void Hw14_PictureView_Load(object sender, EventArgs e)
        {
            ImageList = LoadImages();
            CreatePictureBoxs();
        }
        //以下都是subFunction
        #region 
        
        private object CreatePictureBox(int number)
        {
            int eachRowNum = 5;
            int x = number % eachRowNum;
            int y = number / eachRowNum;
            int PicRecWidth = 100;
            int eachPicDistance = PicRecWidth;


            PictureBox newPictureBox = new PictureBox
            {
                Name = $"myPictureBox{number}",
                Location = new Point(x * eachPicDistance, y * eachPicDistance),
                Size = new Size(PicRecWidth, PicRecWidth),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            newPictureBox.Image = Image.FromFile(ImageList[number]);
            // MainPanel的按下事件發生後執行方法，將subPanel的showdDialog方法加進去
            newPictureBox.Click += delegate (Object ssender, EventArgs EE)
            {
                hw14_PictureSubPanel sub = new hw14_PictureSubPanel(ImageList[number]);
                sub.Owner= this;
                var sub1 = sub as ISubPanel;
                //subpanels.Append(sub1);
                sub.Show();
            };
            return newPictureBox;
        }

        public void AddControl(object obj)
        {
            this.Controls.Add((Control)obj);
        }

        delegate object ButtonDelegate(int number);


        public void CreatePictureBoxs()
        {

            for (int i = 0; i < ImageList.Count(); i++)
            {
                ButtonDelegate del = CreatePictureBox;
                AddControl((Control)del(i));
            }
        }

        private string[] LoadImages()
        {
            string myImageSource = $@"\source\image_hw";
            var imgsPath = PathExtension.ProjectDirConcat(myImageSource);
                // Utility.ConcatWithProjectPath(myImageSource);
            var fileEntries = ProcessDirectory(imgsPath);
            return fileEntries;
        }

        public string ConcatWithProjectPath(string UserAdd)
        {
            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            return projectDirectory + UserAdd;
        }
        public static string[] ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
            return fileEntries;
        }

        // Insert logic for processing found files here.
        public static void ProcessFile(string path)
        {
            string a = $"Processed file '{path}";
        }
        #endregion
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //foreach (var panel in (ISubPanel)subpanels )
            //foreach (var panel in subpanels)
            //{
            //    panel.CloseSubPanel(panel as Form);
            //};
        }
        
    }
}
