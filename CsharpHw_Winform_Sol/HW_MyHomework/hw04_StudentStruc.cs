using System;
using System.Collections;
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
    public partial class hw04_StudentStruc : Form
    {
        private Student _stu;
        public hw04_StudentStruc()
        {
            InitializeComponent();
            this.Load += Hw04_StudentStruc_Load;
        }

        private void Hw04_StudentStruc_Load(object sender, EventArgs e)
        {
            _stu = new Student();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _stu.Name = textBoxName.Text == string.Empty 
                ? "無名氏" 
                : textBoxName.Text;
            int.TryParse(textBoxChinese.Text, out int chiScore);
            int.TryParse(textBoxEng.Text, out int engScore);
            int.TryParse(textBoxMath.Text, out int mathScore);

            // ♪沒填成績就當零分啦♪~
            _stu.ChineseScore= chiScore;
            _stu.EngScore= engScore;
            _stu.MathScore= mathScore;
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            // 可以用繼承資料的模式，但這個不用詳見:https://learn.microsoft.com/zh-tw/dotnet/framework/data/adonet/creating-a-datatable-from-a-query-linq-to-dataset
            var dt = new DataTable("StudentData");
            dt.Columns.Add(new DataColumn("姓名"));
            dt.Columns.Add(new DataColumn("科目"));
            dt.Columns.Add(new DataColumn("分數"));
            //dt.Columns.Add("Subject", typeof(string));
            //dt.Columns.Add("Score", typeof(int));

            var row1 = dt.NewRow();
            row1["姓名"] = _stu.Name;
            row1["科目"] = "國文";
            row1["分數"] = _stu.ChineseScore;
            dt.Rows.Add(row1);
            var row2 = dt.NewRow();
            row2["姓名"] = _stu.Name;
            row2["科目"] = "英文";
            row2["分數"] = _stu.EngScore;
            dt.Rows.Add(row2);
            var row3 = dt.NewRow();
            row3["姓名"] = _stu.Name;
            row3["科目"] = "數學";
            row3["分數"] = _stu.MathScore;
            dt.Rows.Add(row3);

            dataGridView1.DataSource= dt;

            //textBoxDisplayAll.Text = $"姓名: {_stu.Name} \r\n" +
            //    $"中文: {_stu.ChineseScore} \r\n" +
            //    $"英文: {_stu.EngScore} \r\n" +
            //    $"數學: {_stu.MathScore} " ;
        }

        private void buttonCalMaxMinSuj_Click(object sender, EventArgs e)
        {
            //_stu.EngScore= 0;
            //_stu.ChineseScore
            //_stu.MathScore
            textBoxDisplayMaxMin.Text = $"最高分的成績為: {_stu.GetMaxScoreSuj()}{_stu.GetMinScore()} \r\n" +
                $"最低分的成績為:{_stu.GetMinScoreSuj()} {_stu.GetMaxScore()}";
        }
    }
    public class PersonalSubject {
        public string Subject { get; set; }
        public int Score { get; set; }
    }

    public class Student {

        public string Name { get; set; }
        public int ChineseScore { get; set; }
        public int EngScore { get; set; }
        public int MathScore { get; set; }
        
        public string GetMaxScoreSuj()
        {
            // LINQ算RANK，硬是不想用字典
            PersonalSubject[] allSubject = new PersonalSubject[] {
                new PersonalSubject{ Subject = "中文" , Score = ChineseScore},
                new PersonalSubject{ Subject = "英文" , Score = EngScore},
                new PersonalSubject{ Subject = "數學" , Score = MathScore},
            };

            Dictionary<int, int> numRanks = allSubject
                .GroupBy(i => i.Score)
                .OrderByDescending(g => g.Key)
                .Select((g, index) => (num: g.Key, rank: index + 1))
                .ToDictionary(x => x.rank, x => x.num);

            var query = from data in allSubject
                        where data.Score == numRanks[1]
                        select data.Subject;
            string result = string.Empty;
            foreach (var item in query.ToArray())
            {
                result += item;
            }

            return result;
        }

        public string GetMinScoreSuj()
        {
            // LINQ算RANK
            PersonalSubject[] allSubject = new PersonalSubject[] {
                new PersonalSubject{ Subject = "中文" , Score = ChineseScore},
                new PersonalSubject{ Subject = "英文" , Score = EngScore},
                new PersonalSubject{ Subject = "數學" , Score = MathScore},
            };

            Dictionary<int, int> numRanks = allSubject
                .GroupBy(i => i.Score)
                .OrderBy(g => g.Key)
                .Select((g, index) => (num: g.Key, rank: index + 1))
                .ToDictionary(x => x.rank, x => x.num);

            var query = from data in allSubject
                        where data.Score == numRanks[1]
                        select data.Subject;
            string result = string.Empty;
            foreach (var item in query.ToArray())
            {
                result += item;
            }

            return result;
        }
        public int GetMaxScore()
        {
            return new List<int> { this.ChineseScore, this.EngScore, this.MathScore }.Max();
        }

        public int GetMinScore()
        {
            return new List<int> { this.ChineseScore, this.EngScore, this.MathScore }.Min();
        }

    }
}
