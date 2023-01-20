using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW_MyHomework
{
    public partial class hw10_TicTacToeGame : Form
    {
        // 定義變數
        const string firstSign = "O";
        const string secondSign = "X";
        private bool firstUser = true;
        // key: Location, value: 圈圈叉叉紀錄
        public Dictionary<string, string> record { get; private set; }

        public hw10_TicTacToeGame()
        {
            InitializeComponent();
        }

        delegate object ButtonDelegate(int number);
        private void hw10_TicTacToeGame_Load(object sender, EventArgs e)
        {
            // 一載入即創造9個Button
            const int buttonNums = 9;
            for (int i = 1; i <= buttonNums; i++)
            {
                ButtonDelegate del = CreateButton;
                this.AddButton(del(i));
            }

            // 紀錄圈圈叉叉短暫結果 key:buttonName
            this.record = new Dictionary<string, string>()
            {
                { "1", string.Empty}, { "2", string.Empty}, { "3", string.Empty},
                { "4", string.Empty}, { "5", string.Empty}, { "6", string.Empty},
                { "7", string.Empty}, { "8", string.Empty}, { "9", string.Empty},
            };

        }
        private object CreateButton(int number)
        {
            System.Windows.Forms.Button newButton = new System.Windows.Forms.Button();
            newButton.Name = number.ToString();
            newButton.Text = string.Empty;
            //newButton.Text = $"{number}";
            int eachRowNum = 3;
            int x = (number - 1) % 3;
            int y = (number - 1) / eachRowNum;
            newButton.Location = new Point( x * 56, y * 56);
            newButton.Size = new Size(55, 55);
            newButton.BackColor = Color.AliceBlue;
            newButton.Font = new Font(newButton.Name, 15); // 設定字形大小
            newButton.ForeColor = Color.Black;

            // 委派創造的button功能
            newButton.Click += new EventHandler(btnAdd_Click);
            //newButton.Click += delegate (Object ssender, EventArgs EE) {
            //    this.record[number] = this.firstUser ? "O" : "X";
            //    ssender.Text = this.firstUser ? "O" : "X";
            //    this.firstUser = !this.firstUser;
            //    MessageBox.Show(newButton.Text);
            //};
            return newButton;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newButton = sender as System.Windows.Forms.Button;
            this.record[$"{newButton.Name}"] = this.firstUser ? firstSign : secondSign;
            newButton.BackColor = Color.Beige;
            newButton.Text = this.firstUser ? firstSign : secondSign; ;
            newButton.Enabled= false;
            this.firstUser = !this.firstUser;
            newButton.Refresh();

            IsWinJudging();
        }
        private void IsWinJudging() 
        {
            // 感覺可以寫成彈性，之後可以5*5, 7*7，但我累惹
            var array2D = new string[,] {
                // horizon
                { this.record["1"], this.record["2"], this.record["3"] },
                { this.record["4"], this.record["5"], this.record["6"] },
                { this.record["7"], this.record["8"], this.record["9"] },
                // vertical
                { this.record["1"], this.record["4"], this.record["7"] },
                { this.record["2"], this.record["5"], this.record["8"] },
                { this.record["3"], this.record["6"], this.record["9"] },
                // diagonal
                { this.record["1"], this.record["5"], this.record["9"] },
                { this.record["3"], this.record["5"], this.record["7"] },
            };

            // 判斷是否誰贏
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                if (array2D.GetRow(i).All(e => e.Equals(firstSign))) {
                    MessageBox.Show($"{firstSign} Win");
                    EnableAllButton();
                }

                if (array2D.GetRow(i).All(e => e.Equals(secondSign))) {
                    MessageBox.Show($"{secondSign} Win");
                    EnableAllButton();
                } 
            }
        }

        public void AddButton(object obj)
        {
            this.Controls.Add((Control)obj);
        }
        public void EnableAllButton()
        {
            foreach (var button in this.Controls.OfType<System.Windows.Forms.Button>())
            {
                button.Enabled = false;
            }
        }
    }

    // 以下擴充方法參考

    public class CustomArray<T>
    {
        public T[] GetColumn(T[,] matrix, int columnNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(0))
                    .Select(x => matrix[x, columnNumber])
                    .ToArray();
        }

        public T[] GetRow(T[,] matrix, int rowNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(1))
                    .Select(x => matrix[rowNumber, x])
                    .ToArray();
        }
    }

    public static class MatrixExtensions
    {
        /// <summary>
        /// Returns the row with number 'row' of this matrix as a 1D-Array.
        /// </summary>
        public static T[] GetRow<T>(this T[,] matrix, int row)
        {
            var rowLength = matrix.GetLength(1);
            var rowVector = new T[rowLength];

            for (var i = 0; i < rowLength; i++)
                rowVector[i] = matrix[row, i];

            return rowVector;
        }



        /// <summary>
        /// Sets the row with number 'row' of this 2D-matrix to the parameter 'rowVector'.
        /// </summary>
        public static void SetRow<T>(this T[,] matrix, int row, T[] rowVector)
        {
            var rowLength = matrix.GetLength(1);

            for (var i = 0; i < rowLength; i++)
                matrix[row, i] = rowVector[i];
        }



        /// <summary>
        /// Returns the column with number 'col' of this matrix as a 1D-Array.
        /// </summary>
        public static T[] GetCol<T>(this T[,] matrix, int col)
        {
            var colLength = matrix.GetLength(0);
            var colVector = new T[colLength];

            for (var i = 0; i < colLength; i++)
                colVector[i] = matrix[i, col];

            return colVector;
        }



        /// <summary>
        /// Sets the column with number 'col' of this 2D-matrix to the parameter 'colVector'.
        /// </summary>
        public static void SetCol<T>(this T[,] matrix, int col, T[] colVector)
        {
            var colLength = matrix.GetLength(0);

            for (var i = 0; i < colLength; i++)
                matrix[i, col] = colVector[i];
        }
    }
}
