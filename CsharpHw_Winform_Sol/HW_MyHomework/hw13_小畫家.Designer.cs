namespace HW_MyHomework
{
    partial class hw13_SmallPrinter
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
            this.buttonChooseColor = new System.Windows.Forms.Button();
            this.labelDispColor = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelDispPenWidth = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChooseColor
            // 
            this.buttonChooseColor.ForeColor = System.Drawing.Color.Black;
            this.buttonChooseColor.Location = new System.Drawing.Point(678, 12);
            this.buttonChooseColor.Name = "buttonChooseColor";
            this.buttonChooseColor.Size = new System.Drawing.Size(83, 30);
            this.buttonChooseColor.TabIndex = 0;
            this.buttonChooseColor.Text = "選擇顏色";
            this.buttonChooseColor.UseVisualStyleBackColor = true;
            this.buttonChooseColor.Click += new System.EventHandler(this.buttonChooseColor_Click);
            // 
            // labelDispColor
            // 
            this.labelDispColor.AutoSize = true;
            this.labelDispColor.BackColor = System.Drawing.Color.Black;
            this.labelDispColor.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelDispColor.Location = new System.Drawing.Point(678, 44);
            this.labelDispColor.Name = "labelDispColor";
            this.labelDispColor.Size = new System.Drawing.Size(120, 30);
            this.labelDispColor.TabIndex = 1;
            this.labelDispColor.Text = "PenColor";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(678, 94);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 172);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // labelDispPenWidth
            // 
            this.labelDispPenWidth.AutoSize = true;
            this.labelDispPenWidth.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelDispPenWidth.ForeColor = System.Drawing.Color.Black;
            this.labelDispPenWidth.Location = new System.Drawing.Point(683, 273);
            this.labelDispPenWidth.Name = "labelDispPenWidth";
            this.labelDispPenWidth.Size = new System.Drawing.Size(125, 28);
            this.labelDispPenWidth.TabIndex = 3;
            this.labelDispPenWidth.Text = "PenWidth";
            // 
            // hw13_SmallPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDispPenWidth);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.labelDispColor);
            this.Controls.Add(this.buttonChooseColor);
            this.Name = "hw13_SmallPrinter";
            this.Text = "hw13_小畫家";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hw13_SmallPrinter_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hw13_SmallPrinter_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hw13_SmallPrinter_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChooseColor;
        private System.Windows.Forms.Label labelDispColor;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelDispPenWidth;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}