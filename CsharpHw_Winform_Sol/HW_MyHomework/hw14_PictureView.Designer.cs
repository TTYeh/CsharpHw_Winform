namespace HW_MyHomework
{
    partial class hw14_PictureView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hw14_PictureView));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "hw03_Beer.jpg");
            this.imageList1.Images.SetKeyName(1, "hw03_Beer2.jpg");
            this.imageList1.Images.SetKeyName(2, "nasida.jpg");
            this.imageList1.Images.SetKeyName(3, "nasida2.jpg");
            this.imageList1.Images.SetKeyName(4, "pimon.jpg");
            this.imageList1.Images.SetKeyName(5, "cat1.jpg");
            this.imageList1.Images.SetKeyName(6, "cat2.jpg");
            this.imageList1.Images.SetKeyName(7, "cat3.jpg");
            this.imageList1.Images.SetKeyName(8, "cat4.jpg");
            this.imageList1.Images.SetKeyName(9, "dog1.jpg");
            this.imageList1.Images.SetKeyName(10, "dog2.jpg");
            this.imageList1.Images.SetKeyName(11, "dog3.jpg");
            this.imageList1.Images.SetKeyName(12, "dog4.jpg");
            // 
            // hw14_PictureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 414);
            this.Name = "hw14_PictureView";
            this.Text = "hw14_PictureView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;

    }
}