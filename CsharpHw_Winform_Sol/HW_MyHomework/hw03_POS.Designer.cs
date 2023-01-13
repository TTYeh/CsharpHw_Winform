namespace HW_MyHomework
{
    partial class hw03_POS
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
            this.buttonTequila = new System.Windows.Forms.Button();
            this.buttonWineNT = new System.Windows.Forms.Button();
            this.buttonWhisky = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBeer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCard = new System.Windows.Forms.Button();
            this.buttonCash = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxShoppingList = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTequila
            // 
            this.buttonTequila.Location = new System.Drawing.Point(136, 23);
            this.buttonTequila.Name = "buttonTequila";
            this.buttonTequila.Size = new System.Drawing.Size(86, 64);
            this.buttonTequila.TabIndex = 1;
            this.buttonTequila.Text = "龍舌蘭\r\nTequila\r\nNT$180";
            this.buttonTequila.UseVisualStyleBackColor = true;
            this.buttonTequila.Click += new System.EventHandler(this.buttonTequila_Click);
            // 
            // buttonWineNT
            // 
            this.buttonWineNT.Location = new System.Drawing.Point(136, 103);
            this.buttonWineNT.Name = "buttonWineNT";
            this.buttonWineNT.Size = new System.Drawing.Size(86, 64);
            this.buttonWineNT.TabIndex = 2;
            this.buttonWineNT.Text = "紅酒\r\nWine \r\nNT$320";
            this.buttonWineNT.UseVisualStyleBackColor = true;
            this.buttonWineNT.Click += new System.EventHandler(this.buttonWineNT_Click);
            // 
            // buttonWhisky
            // 
            this.buttonWhisky.Location = new System.Drawing.Point(28, 103);
            this.buttonWhisky.Name = "buttonWhisky";
            this.buttonWhisky.Size = new System.Drawing.Size(86, 64);
            this.buttonWhisky.TabIndex = 3;
            this.buttonWhisky.Text = "威士忌\r\nWhisky\r\nNT$350";
            this.buttonWhisky.UseVisualStyleBackColor = true;
            this.buttonWhisky.Click += new System.EventHandler(this.buttonWhisky_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(186)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonWhisky);
            this.panel1.Controls.Add(this.buttonWineNT);
            this.panel1.Controls.Add(this.buttonTequila);
            this.panel1.Controls.Add(this.buttonBeer);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 203);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "菜單 Menu";
            // 
            // buttonBeer
            // 
            this.buttonBeer.Location = new System.Drawing.Point(28, 23);
            this.buttonBeer.Name = "buttonBeer";
            this.buttonBeer.Size = new System.Drawing.Size(86, 64);
            this.buttonBeer.TabIndex = 0;
            this.buttonBeer.Text = "啤酒\r\nBeer \r\nNT$120";
            this.buttonBeer.UseVisualStyleBackColor = true;
            this.buttonBeer.Click += new System.EventHandler(this.buttonBeer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(186)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.textBoxTotalPrice);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(271, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 72);
            this.panel2.TabIndex = 5;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(31, 32);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(129, 25);
            this.textBoxTotalPrice.TabIndex = 5;
            this.textBoxTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTotalPrice.TextChanged += new System.EventHandler(this.textBoxTotalPrice_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "總金額Total Price";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(186)))), ((int)(((byte)(116)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.buttonCard);
            this.panel3.Controls.Add(this.buttonCash);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(271, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 109);
            this.panel3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(83, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "信用卡享9折";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "付現方式Payment";
            // 
            // buttonCard
            // 
            this.buttonCard.Location = new System.Drawing.Point(114, 23);
            this.buttonCard.Name = "buttonCard";
            this.buttonCard.Size = new System.Drawing.Size(64, 64);
            this.buttonCard.TabIndex = 1;
            this.buttonCard.Text = "信用卡";
            this.buttonCard.UseVisualStyleBackColor = true;
            this.buttonCard.Click += new System.EventHandler(this.buttonCard_Click);
            // 
            // buttonCash
            // 
            this.buttonCash.Location = new System.Drawing.Point(28, 23);
            this.buttonCash.Name = "buttonCash";
            this.buttonCash.Size = new System.Drawing.Size(64, 64);
            this.buttonCash.TabIndex = 0;
            this.buttonCash.Text = "現金";
            this.buttonCash.UseVisualStyleBackColor = true;
            this.buttonCash.Click += new System.EventHandler(this.buttonCash_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(186)))), ((int)(((byte)(116)))));
            this.panel4.Controls.Add(this.buttonClear);
            this.panel4.Controls.Add(this.textBoxShoppingList);
            this.panel4.Controls.Add(this.label4);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(488, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 203);
            this.panel4.TabIndex = 6;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(194, 158);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(97, 41);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "清除清單";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxShoppingList
            // 
            this.textBoxShoppingList.Location = new System.Drawing.Point(31, 18);
            this.textBoxShoppingList.Multiline = true;
            this.textBoxShoppingList.Name = "textBoxShoppingList";
            this.textBoxShoppingList.Size = new System.Drawing.Size(260, 135);
            this.textBoxShoppingList.TabIndex = 5;
            this.textBoxShoppingList.Text = "尚未點餐";
            this.textBoxShoppingList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "購物清單List";
            // 
            // hw03_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HW_MyHomework.Properties.Resources.hw03_Beer2;
            this.ClientSize = new System.Drawing.Size(812, 381);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "hw03_POS";
            this.Text = "hw03_POS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTequila;
        private System.Windows.Forms.Button buttonWineNT;
        private System.Windows.Forms.Button buttonWhisky;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBeer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCard;
        private System.Windows.Forms.Button buttonCash;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxShoppingList;
        private System.Windows.Forms.Label label4;
    }
}