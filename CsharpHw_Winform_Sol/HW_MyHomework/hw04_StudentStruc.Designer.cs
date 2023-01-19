namespace HW_MyHomework
{
    partial class hw04_StudentStruc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxChinese = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEng = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxDisplayMaxMin = new System.Windows.Forms.TextBox();
            this.buttonCalMaxMinSuj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.ForeColor = System.Drawing.Color.Black;
            this.buttonDisplay.Location = new System.Drawing.Point(142, 242);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(112, 46);
            this.buttonDisplay.TabIndex = 1;
            this.buttonDisplay.Text = "顯示儲存內容";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(24, 242);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(112, 46);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "暫時儲存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxName.ForeColor = System.Drawing.Color.Black;
            this.textBoxName.Location = new System.Drawing.Point(88, 31);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(166, 31);
            this.textBoxName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "國文:";
            // 
            // textBoxChinese
            // 
            this.textBoxChinese.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxChinese.ForeColor = System.Drawing.Color.Black;
            this.textBoxChinese.Location = new System.Drawing.Point(88, 89);
            this.textBoxChinese.Name = "textBoxChinese";
            this.textBoxChinese.Size = new System.Drawing.Size(166, 31);
            this.textBoxChinese.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "英文:";
            // 
            // textBoxEng
            // 
            this.textBoxEng.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxEng.ForeColor = System.Drawing.Color.Black;
            this.textBoxEng.Location = new System.Drawing.Point(88, 147);
            this.textBoxEng.Name = "textBoxEng";
            this.textBoxEng.Size = new System.Drawing.Size(166, 31);
            this.textBoxEng.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "數學:";
            // 
            // textBoxMath
            // 
            this.textBoxMath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxMath.ForeColor = System.Drawing.Color.Black;
            this.textBoxMath.Location = new System.Drawing.Point(88, 205);
            this.textBoxMath.Name = "textBoxMath";
            this.textBoxMath.Size = new System.Drawing.Size(166, 31);
            this.textBoxMath.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBoxDisplayMaxMin);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(260, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 205);
            this.panel1.TabIndex = 11;
            // 
            // textBoxDisplayMaxMin
            // 
            this.textBoxDisplayMaxMin.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDisplayMaxMin.Enabled = false;
            this.textBoxDisplayMaxMin.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxDisplayMaxMin.Location = new System.Drawing.Point(9, 142);
            this.textBoxDisplayMaxMin.Multiline = true;
            this.textBoxDisplayMaxMin.Name = "textBoxDisplayMaxMin";
            this.textBoxDisplayMaxMin.Size = new System.Drawing.Size(266, 59);
            this.textBoxDisplayMaxMin.TabIndex = 14;
            // 
            // buttonCalMaxMinSuj
            // 
            this.buttonCalMaxMinSuj.ForeColor = System.Drawing.Color.Black;
            this.buttonCalMaxMinSuj.Location = new System.Drawing.Point(375, 242);
            this.buttonCalMaxMinSuj.Name = "buttonCalMaxMinSuj";
            this.buttonCalMaxMinSuj.Size = new System.Drawing.Size(163, 46);
            this.buttonCalMaxMinSuj.TabIndex = 12;
            this.buttonCalMaxMinSuj.Text = "最高分/最低分科目";
            this.buttonCalMaxMinSuj.UseVisualStyleBackColor = true;
            this.buttonCalMaxMinSuj.Click += new System.EventHandler(this.buttonCalMaxMinSuj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(266, 132);
            this.dataGridView1.TabIndex = 15;
            // 
            // hw04_StudentStruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(556, 348);
            this.Controls.Add(this.buttonCalMaxMinSuj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxChinese);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDisplay);
            this.Name = "hw04_StudentStruc";
            this.Text = "hw04_StudentStruc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxChinese;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEng;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxDisplayMaxMin;
        private System.Windows.Forms.Button buttonCalMaxMinSuj;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}