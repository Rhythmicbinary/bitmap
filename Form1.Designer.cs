/* 
---------------------------------
Developed by Rhythmicbinary  :"))
---------------------------------
*/
namespace DrawBitmap
{
    partial class Form1
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
            this.picbox_img = new System.Windows.Forms.PictureBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_gray = new System.Windows.Forms.Button();
            this.btn_bw = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_org = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.num_bw = new System.Windows.Forms.NumericUpDown();
            this.lbl_int = new System.Windows.Forms.Label();
            this.btn_neg = new System.Windows.Forms.Button();
            this.lbl_red = new System.Windows.Forms.Label();
            this.lbl_green = new System.Windows.Forms.Label();
            this.lbl_blue = new System.Windows.Forms.Label();
            this.num_red = new System.Windows.Forms.NumericUpDown();
            this.num_green = new System.Windows.Forms.NumericUpDown();
            this.num_blue = new System.Windows.Forms.NumericUpDown();
            this.num_blueS = new System.Windows.Forms.NumericUpDown();
            this.num_greenS = new System.Windows.Forms.NumericUpDown();
            this.num_redS = new System.Windows.Forms.NumericUpDown();
            this.lbl_blueS = new System.Windows.Forms.Label();
            this.lbl_greenS = new System.Windows.Forms.Label();
            this.lbl_redS = new System.Windows.Forms.Label();
            this.btn_aply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_bw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_blueS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_greenS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_redS)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_img
            // 
            this.picbox_img.Location = new System.Drawing.Point(30, 30);
            this.picbox_img.Name = "picbox_img";
            this.picbox_img.Size = new System.Drawing.Size(915, 736);
            this.picbox_img.TabIndex = 0;
            this.picbox_img.TabStop = false;
            this.picbox_img.WaitOnLoad = true;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(975, 27);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(181, 39);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_gray
            // 
            this.btn_gray.Location = new System.Drawing.Point(975, 253);
            this.btn_gray.Name = "btn_gray";
            this.btn_gray.Size = new System.Drawing.Size(181, 39);
            this.btn_gray.TabIndex = 3;
            this.btn_gray.Text = "Gray Scale";
            this.btn_gray.UseVisualStyleBackColor = true;
            this.btn_gray.Click += new System.EventHandler(this.btn_gray_Click);
            // 
            // btn_bw
            // 
            this.btn_bw.Location = new System.Drawing.Point(975, 357);
            this.btn_bw.Name = "btn_bw";
            this.btn_bw.Size = new System.Drawing.Size(181, 39);
            this.btn_bw.TabIndex = 4;
            this.btn_bw.Text = "Black and Withe";
            this.btn_bw.UseVisualStyleBackColor = true;
            this.btn_bw.Click += new System.EventHandler(this.btn_bw_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(975, 89);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(181, 39);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_org
            // 
            this.btn_org.Location = new System.Drawing.Point(975, 489);
            this.btn_org.Name = "btn_org";
            this.btn_org.Size = new System.Drawing.Size(181, 39);
            this.btn_org.TabIndex = 6;
            this.btn_org.Text = "Orginal";
            this.btn_org.UseVisualStyleBackColor = true;
            this.btn_org.Click += new System.EventHandler(this.btn_org_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(975, 723);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(181, 39);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // num_bw
            // 
            this.num_bw.Location = new System.Drawing.Point(1064, 309);
            this.num_bw.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_bw.Name = "num_bw";
            this.num_bw.Size = new System.Drawing.Size(92, 21);
            this.num_bw.TabIndex = 8;
            this.num_bw.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // lbl_int
            // 
            this.lbl_int.AutoSize = true;
            this.lbl_int.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_int.Location = new System.Drawing.Point(982, 314);
            this.lbl_int.Name = "lbl_int";
            this.lbl_int.Size = new System.Drawing.Size(51, 15);
            this.lbl_int.TabIndex = 12;
            this.lbl_int.Text = "Intensity";
            // 
            // btn_neg
            // 
            this.btn_neg.Location = new System.Drawing.Point(975, 427);
            this.btn_neg.Name = "btn_neg";
            this.btn_neg.Size = new System.Drawing.Size(181, 39);
            this.btn_neg.TabIndex = 10;
            this.btn_neg.Text = "Negetive";
            this.btn_neg.UseVisualStyleBackColor = true;
            this.btn_neg.Click += new System.EventHandler(this.btn_neg_Click);
            // 
            // lbl_red
            // 
            this.lbl_red.AutoSize = true;
            this.lbl_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_red.Location = new System.Drawing.Point(990, 562);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(30, 15);
            this.lbl_red.TabIndex = 11;
            this.lbl_red.Text = "Red";
            // 
            // lbl_green
            // 
            this.lbl_green.AutoSize = true;
            this.lbl_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_green.Location = new System.Drawing.Point(990, 592);
            this.lbl_green.Name = "lbl_green";
            this.lbl_green.Size = new System.Drawing.Size(41, 15);
            this.lbl_green.TabIndex = 12;
            this.lbl_green.Text = "Green";
            // 
            // lbl_blue
            // 
            this.lbl_blue.AutoSize = true;
            this.lbl_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_blue.Location = new System.Drawing.Point(990, 623);
            this.lbl_blue.Name = "lbl_blue";
            this.lbl_blue.Size = new System.Drawing.Size(32, 15);
            this.lbl_blue.TabIndex = 13;
            this.lbl_blue.Text = "Blue";
            // 
            // num_red
            // 
            this.num_red.Location = new System.Drawing.Point(1064, 556);
            this.num_red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_red.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.num_red.Name = "num_red";
            this.num_red.Size = new System.Drawing.Size(92, 21);
            this.num_red.TabIndex = 14;
            // 
            // num_green
            // 
            this.num_green.Location = new System.Drawing.Point(1064, 592);
            this.num_green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_green.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.num_green.Name = "num_green";
            this.num_green.Size = new System.Drawing.Size(92, 21);
            this.num_green.TabIndex = 15;
            // 
            // num_blue
            // 
            this.num_blue.Location = new System.Drawing.Point(1064, 623);
            this.num_blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_blue.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.num_blue.Name = "num_blue";
            this.num_blue.Size = new System.Drawing.Size(92, 21);
            this.num_blue.TabIndex = 16;
            // 
            // num_blueS
            // 
            this.num_blueS.DecimalPlaces = 2;
            this.num_blueS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_blueS.Location = new System.Drawing.Point(1064, 211);
            this.num_blueS.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_blueS.Name = "num_blueS";
            this.num_blueS.Size = new System.Drawing.Size(92, 21);
            this.num_blueS.TabIndex = 22;
            this.num_blueS.ThousandsSeparator = true;
            this.num_blueS.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // num_greenS
            // 
            this.num_greenS.DecimalPlaces = 2;
            this.num_greenS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_greenS.Location = new System.Drawing.Point(1064, 180);
            this.num_greenS.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_greenS.Name = "num_greenS";
            this.num_greenS.Size = new System.Drawing.Size(92, 21);
            this.num_greenS.TabIndex = 21;
            this.num_greenS.ThousandsSeparator = true;
            this.num_greenS.Value = new decimal(new int[] {
            11,
            0,
            0,
            131072});
            // 
            // num_redS
            // 
            this.num_redS.DecimalPlaces = 2;
            this.num_redS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_redS.Location = new System.Drawing.Point(1064, 144);
            this.num_redS.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_redS.Name = "num_redS";
            this.num_redS.Size = new System.Drawing.Size(92, 21);
            this.num_redS.TabIndex = 20;
            this.num_redS.ThousandsSeparator = true;
            this.num_redS.Value = new decimal(new int[] {
            33,
            0,
            0,
            131072});
            // 
            // lbl_blueS
            // 
            this.lbl_blueS.AutoSize = true;
            this.lbl_blueS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_blueS.Location = new System.Drawing.Point(982, 211);
            this.lbl_blueS.Name = "lbl_blueS";
            this.lbl_blueS.Size = new System.Drawing.Size(69, 15);
            this.lbl_blueS.TabIndex = 19;
            this.lbl_blueS.Text = "Blue Scale ";
            // 
            // lbl_greenS
            // 
            this.lbl_greenS.AutoSize = true;
            this.lbl_greenS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_greenS.Location = new System.Drawing.Point(982, 180);
            this.lbl_greenS.Name = "lbl_greenS";
            this.lbl_greenS.Size = new System.Drawing.Size(78, 15);
            this.lbl_greenS.TabIndex = 18;
            this.lbl_greenS.Text = "Green Scale ";
            // 
            // lbl_redS
            // 
            this.lbl_redS.AutoSize = true;
            this.lbl_redS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_redS.Location = new System.Drawing.Point(982, 150);
            this.lbl_redS.Name = "lbl_redS";
            this.lbl_redS.Size = new System.Drawing.Size(67, 15);
            this.lbl_redS.TabIndex = 17;
            this.lbl_redS.Text = "Red Scale ";
            // 
            // btn_aply
            // 
            this.btn_aply.Location = new System.Drawing.Point(975, 661);
            this.btn_aply.Name = "btn_aply";
            this.btn_aply.Size = new System.Drawing.Size(181, 39);
            this.btn_aply.TabIndex = 23;
            this.btn_aply.Text = "Apply";
            this.btn_aply.UseVisualStyleBackColor = true;
            this.btn_aply.Click += new System.EventHandler(this.btn_alpy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 792);
            this.Controls.Add(this.btn_aply);
            this.Controls.Add(this.num_blueS);
            this.Controls.Add(this.num_greenS);
            this.Controls.Add(this.num_redS);
            this.Controls.Add(this.lbl_blueS);
            this.Controls.Add(this.lbl_greenS);
            this.Controls.Add(this.lbl_redS);
            this.Controls.Add(this.num_blue);
            this.Controls.Add(this.num_green);
            this.Controls.Add(this.num_red);
            this.Controls.Add(this.lbl_blue);
            this.Controls.Add(this.lbl_green);
            this.Controls.Add(this.lbl_red);
            this.Controls.Add(this.btn_neg);
            this.Controls.Add(this.lbl_int);
            this.Controls.Add(this.num_bw);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_org);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_bw);
            this.Controls.Add(this.btn_gray);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.picbox_img);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_bw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_blueS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_greenS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_redS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_img;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_gray;
        private System.Windows.Forms.Button btn_bw;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_org;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.NumericUpDown num_bw;
        private System.Windows.Forms.Label lbl_int;
        private System.Windows.Forms.Button btn_neg;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.Label lbl_green;
        private System.Windows.Forms.Label lbl_blue;
        private System.Windows.Forms.NumericUpDown num_red;
        private System.Windows.Forms.NumericUpDown num_green;
        private System.Windows.Forms.NumericUpDown num_blue;
        private System.Windows.Forms.NumericUpDown num_blueS;
        private System.Windows.Forms.NumericUpDown num_greenS;
        private System.Windows.Forms.NumericUpDown num_redS;
        private System.Windows.Forms.Label lbl_blueS;
        private System.Windows.Forms.Label lbl_greenS;
        private System.Windows.Forms.Label lbl_redS;
        private System.Windows.Forms.Button btn_aply;
    }
}

