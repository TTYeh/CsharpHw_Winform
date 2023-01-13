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
    public partial class hw00_MainForm : Form
    {
        private hw01_Hello _hw01;
        private hw02_Loan _hw02;
        private hw03_POS _hw03;
        private hw04_StudentStruc _hw04;
        private hw05_StudentGrade _hw05;
        private hw06_StudentGrade_List _hw06;
        private hw07_Mothod _hw07;
        private hw08_MyCalc _hw08;
        private hw09_ControlStructure _hw09;
        private hw10_TicTacToeGame _hw10;
        private hw11_ScreenSaver _hw11;
        //private hw12_Notepad _hw12;
        private hw13_SmallPrinter _hw13;
        private hw14_PictureView _hw14;
        private hw15_guessMain _hw15;
        private int subPanelHeight;
        private int subPanelWidth;


        public hw00_MainForm()
        {
            InitializeComponent();
        }


        private void btn_hello_Click(object sender, EventArgs e)
        {
            if (_hw01 == null || IsClosed("hw01_Hello"))
            {
                CloseOtherSubForm();
                this.splitContainer1.Panel2.Controls.Clear();
                _hw01 = new hw01_Hello();
                var frm = _hw01;
                frm.Name = "hw01_Hello";
                frm.Owner = this;
                frm.TopLevel = false;
                frm.Show();
                this.splitContainer1.Panel2.Controls.Add(frm);
            }

            // 原本的寫法

            //hw01_Hello frm01 = new hw01_Hello();
            //int windowTop = this.panel1.Location.Y + splitContainer1.Size.Height;
            //int windowLeft = this.panel1.Location.X + splitContainer1.Size.Width;
            //// MessageBox.Show(Convert.ToString(windowTop) +","+ Convert.ToString(windowLeft));
            //frm01.StartPosition = FormStartPosition.Manual;
            //frm01.Left = 310;
            //frm01.Top = 120;
            //// 可塞到容器
            //// helloForm.StartPosition = FormStartPosition.CenterScreen;
            //frm01.Owner = this;
            //frm01.ShowDialog();

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // 想要讓winform有RWD的效果但是有點難
            var size = splitContainer1.Size;
            var size2 = splitContainer1.SplitterRectangle;
            subPanelHeight = Convert.ToInt32(Convert.ToDouble(splitContainer1.Panel2.Height) * 0.8);
            subPanelWidth = Convert.ToInt32(Convert.ToDouble(splitContainer1.Panel2.Width) * 0.8); ;
            splitContainer1.SplitterDistance = 200; //左邊按鈕最小寬度
        }

        private void btn_Loan_Click(object sender, EventArgs e)
        {

            if (_hw02 == null || IsClosed("hw02_Loan"))
            {
                CloseOtherSubForm();
                this.splitContainer1.Panel2.Controls.Clear();
                _hw02 = new hw02_Loan();
                var frm = _hw02;
                frm.Name = "hw02_Loan";
                frm.Owner = this;
                frm.TopLevel = false;
                frm.Show();
                this.splitContainer1.Panel2.Controls.Add(frm);
            }
            // note: c#笨，要先new元件出來再用他的資料格式接，先打資料格式出來會抓不到

            //調整位置
            //hw02_Loan frm02 = new hw02_Loan();
            //frm02.StartPosition = FormStartPosition.Manual;
            //frm02.Left = 310;
            //frm02.Top = 120;
            //// helloForm.StartPosition = FormStartPosition.CenterScreen;
            //frm02.Owner = this;
            //frm02.Show();
        }

        private void btn_Exam_guessNub_Click(object sender, EventArgs e)
        {
            if (_hw15 == null || IsClosed("hw15_guessMain"))
            {
                CloseOtherSubForm();
                this.splitContainer1.Panel2.Controls.Clear();
                _hw15 = new hw15_guessMain();
                var frm = _hw15;
                frm.Name = "hw15_guessMain";
                frm.Owner = this;
                frm.TopLevel = false;
                frm.Show();
                this.splitContainer1.Panel2.Controls.Add(frm);
            }
        }

        private void btn_POS_Click(object sender, EventArgs e)
        {
            if (_hw03 == null || IsClosed("hw03_POS"))
            {
                CloseOtherSubForm();
                this.splitContainer1.Panel2.Controls.Clear();
                _hw03 = new hw03_POS();
                var frm = _hw03;
                frm.Name = "hw03_POS";
                frm.Owner = this;
                frm.TopLevel = false;
                frm.Show();
                this.splitContainer1.Panel2.Controls.Add(frm);
            }
        }

        private void buttonStudent_Struc_Click(object sender, EventArgs e)
        {
            if (_hw04 == null || IsClosed("hw04_StudentStruc"))
            {
                CloseOtherSubForm();
                this.splitContainer1.Panel2.Controls.Clear();
                _hw04 = new hw04_StudentStruc();
                var frm = _hw04;
                frm.Name = "hw04_StudentStruc";
                frm.Owner = this;
                frm.TopLevel = false;
                frm.Show();
                this.splitContainer1.Panel2.Controls.Add(frm);
            }
        }

        private void button06_StudentGrade_List_Click(object sender, EventArgs e)
        {
            if (_hw06 == null || IsClosed("hw06_StudentGrade_List"))
            {
                CloseOtherSubForm();
                this.splitContainer1.Panel2.Controls.Clear();
                _hw06 = new hw06_StudentGrade_List();
                var frm = _hw06;
                frm.Name = "hw06_StudentGrade_List";
                frm.Owner = this;
                frm.TopLevel = false;
                frm.Show();
                this.splitContainer1.Panel2.Controls.Add(frm);
            }
        }

        private void buttonStudentGrade_Click_1(object sender, EventArgs e)
        {
            if (_hw05 == null || IsClosed("hw05_StudentGrade"))
            {
                CloseOtherSubForm();
                this.splitContainer1.Panel2.Controls.Clear();
                _hw05 = new hw05_StudentGrade();
                var frm = _hw05;
                frm.Name = "hw05_StudentGrade";
                frm.Owner = this;
                frm.TopLevel = false;
                frm.Show();
                this.splitContainer1.Panel2.Controls.Add(frm);
            }
        }

        private void button07_Method_Click(object sender, EventArgs e)
        {
            if (_hw07 == null || IsClosed("hw07_Mothod"))
            {
                CloseOtherSubForm();
                this.splitContainer1.Panel2.Controls.Clear();
                _hw07 = new hw07_Mothod();
                var frm = _hw07;
                frm.Name = "hw07_Mothod";
                frm.Owner = this;
                frm.TopLevel = false;
                frm.Show();
                this.splitContainer1.Panel2.Controls.Add(frm);
            }
        }

        private void button08_MyCalc_Click(object sender, EventArgs e)
        {

            if (_hw08 == null || IsClosed("hw08_MyCalc"))
            {
                CloseOtherSubForm();
                this.splitContainer1.Panel2.Controls.Clear();
                _hw08 = new hw08_MyCalc();
                var frm = _hw08;
                frm.Name = "hw08_MyCalc";
                frm.Owner = this;
                frm.TopLevel = false;
                frm.Show();
                this.splitContainer1.Panel2.Controls.Add(frm);
            }
        }

        private void button09_ControlStructure_Click(object sender, EventArgs e)
        {
            if (_hw09 == null || IsClosed("hw09_ControlStructure"))
            {
                CloseOtherSubForm();
                this.splitContainer1.Panel2.Controls.Clear();
                _hw09 = new hw09_ControlStructure();
                var frm = _hw09;
                frm.Name = "hw09_ControlStructure";
                frm.Owner = this;
                frm.TopLevel = false;
                frm.Show();
                this.splitContainer1.Panel2.Controls.Add(frm);
            }
        }

        private void button10_TicTacToeGame_Click(object sender, EventArgs e)
        {
            if (_hw10 == null || IsClosed("hw10_TicTacToeGame"))
            {
                CloseOtherSubForm();
                this.splitContainer1.Panel2.Controls.Clear();
                _hw10 = new hw10_TicTacToeGame();
                var frm = _hw10;
                frm.Name = "hw10_TicTacToeGame";
                frm.Owner = this;
                frm.TopLevel = false;
                frm.Show();
                this.splitContainer1.Panel2.Controls.Add(frm);
            }
        }

        private void buttonScreenSaver_Click(object sender, EventArgs e)
        {
            if (_hw11 == null || IsClosed("hw11_ScreenSaver"))
            {
                CloseOtherSubForm();
                this.splitContainer1.Panel2.Controls.Clear();
                _hw11 = new hw11_ScreenSaver();
                var frm = _hw11;
                frm.Name = "hw11_ScreenSaver";
                frm.Owner = this;
                frm.TopLevel = false;
                frm.Show();
                this.splitContainer1.Panel2.Controls.Add(frm);
            }
        }
        private hw12_Notepad _hw12;
        private void buttonNotepad_Click(object sender, EventArgs e)
        {
            if (_hw12 == null || IsClosed("hw12_Notepad"))
            {
                CloseOtherSubForm();
                this.splitContainer1.Panel2.Controls.Clear();
                _hw12 = new hw12_Notepad();
                var frm = _hw12;
                frm.Name = "hw12_Notepad";
                frm.Owner = this;
                frm.TopLevel = false;
                frm.Show();
                this.splitContainer1.Panel2.Controls.Add(frm);
            }
            // OpenForm(_hw12, hw12_Notepad , hw12_Notepad as Type);
        }
        // TODO把這個寫成方法
        private void OpenForm(System.Windows.Forms.Form propertyName, Form formName, Type className) 
        {
            //if (propertyName == null ) || IsClosed(nameof(className)))
            //{
            //    // 複製貼上一堆真的會忘記改 應該要寫成function但不會寫
            //    //propertyName = new formName();
            //    propertyName = (Form)Activator.CreateInstance(className);
            //    var frm = propertyName;
            //    frm.Owner = this;
            //    frm.Show();
            //}
        }


        private void buttonSmallPrinter_Click(object sender, EventArgs e)
        {
            if (_hw13 == null || IsClosed("hw13_SmallPrinter"))
            {
                CloseOtherSubForm();
                this.splitContainer1.Panel2.Controls.Clear();
                _hw13 = new hw13_SmallPrinter();
                var frm = _hw13;
                frm.Name = "hw13_SmallPrinter";
                frm.Owner = this;
                frm.TopLevel = false;
                frm.Show();
                this.splitContainer1.Panel2.Controls.Add(frm);
            }

        }

        private void buttonPictureView_Click(object sender, EventArgs e)
        {
            if (_hw14 == null || IsClosed("hw14_PictureView"))
            {
                CloseOtherSubForm();
                this.splitContainer1.Panel2.Controls.Clear();
                _hw14 = new hw14_PictureView();
                var frm = _hw14;
                frm.Name = "hw14_PictureView";
                frm.Owner = this;
                frm.TopLevel = false;
                frm.Show();
                this.splitContainer1.Panel2.Controls.Add(frm);
            }
        }

        private bool IsFormExist(string formName)
        {
            bool isFormExist = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm != null && frm.Name == formName) isFormExist = true;
            }
            return isFormExist;
        }
        private bool IsClosed(string fromName)
        {
            //int maxFormNumber = 2;

            // 跟 IsFormExist對照
            foreach (var item in Application.OpenForms)
            {
                var frm = item as Form;
                if (frm == null ) return false;
                if (frm != null && frm.Name == fromName) return false;
            }
            return true;
        }
        private void CloseOtherSubForm() 
        {
            // 只能存在一個_subForm _hw1~_hw14都不同的資料型態QQ
            if (_hw01 != null) _hw01.Close();
            if (_hw02 != null) _hw02.Close();
            if (_hw03 != null) _hw03.Close();
            if (_hw04 != null) _hw04.Close();
            if (_hw05 != null) _hw05.Close();
            if (_hw06 != null) _hw06.Close();
            if (_hw07 != null) _hw07.Close();
            if (_hw08 != null) _hw08.Close();
            if (_hw09 != null) _hw09.Close();
            if (_hw10 != null) _hw10.Close();
            if (_hw11 != null) _hw11.Close();
            if (_hw12 != null) _hw12.Close();
            if (_hw13 != null) _hw13.Close();
            if (_hw14 != null) _hw14.Close();
            if (_hw15 != null) _hw15.Close();
            _hw01 = null;
            _hw02 = null;
            _hw03 = null;
            _hw04 = null;
            _hw05 = null;
            _hw06 = null;
            _hw07 = null;
            _hw08 = null;
            _hw09 = null;
            _hw10 = null;
            _hw11 = null;
            _hw12 = null;
            _hw13 = null;
            _hw14 = null;
            _hw15 = null;
        }
    }
}
