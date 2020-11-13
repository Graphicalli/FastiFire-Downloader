namespace EDM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dnld_prgrss = new System.Windows.Forms.ProgressBar();
            this.Start_btn = new System.Windows.Forms.Button();
            this.pause_btn = new System.Windows.Forms.Button();
            this.resume_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.status_lbl = new System.Windows.Forms.Label();
            this.url_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dnld_lbl = new System.Windows.Forms.Label();
            this.speed_lbl = new System.Windows.Forms.Label();
            this.prctng_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dnld_prgrss
            // 
            this.dnld_prgrss.Location = new System.Drawing.Point(109, 74);
            this.dnld_prgrss.Name = "dnld_prgrss";
            this.dnld_prgrss.Size = new System.Drawing.Size(524, 18);
            this.dnld_prgrss.TabIndex = 0;
            this.dnld_prgrss.UseWaitCursor = true;
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(371, 126);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(75, 23);
            this.Start_btn.TabIndex = 1;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // pause_btn
            // 
            this.pause_btn.Location = new System.Drawing.Point(462, 125);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(75, 23);
            this.pause_btn.TabIndex = 2;
            this.pause_btn.Text = "Pause";
            this.pause_btn.UseVisualStyleBackColor = true;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // resume_btn
            // 
            this.resume_btn.Location = new System.Drawing.Point(558, 125);
            this.resume_btn.Name = "resume_btn";
            this.resume_btn.Size = new System.Drawing.Size(75, 23);
            this.resume_btn.TabIndex = 3;
            this.resume_btn.Text = "Resume";
            this.resume_btn.UseVisualStyleBackColor = true;
            this.resume_btn.Click += new System.EventHandler(this.resume_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Url:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status";
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Location = new System.Drawing.Point(106, 50);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(13, 13);
            this.status_lbl.TabIndex = 6;
            this.status_lbl.Text = "--";
            // 
            // url_txtbox
            // 
            this.url_txtbox.Location = new System.Drawing.Point(109, 23);
            this.url_txtbox.Name = "url_txtbox";
            this.url_txtbox.Size = new System.Drawing.Size(524, 20);
            this.url_txtbox.TabIndex = 7;
            this.url_txtbox.TextChanged += new System.EventHandler(this.url_txtbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Downloaded:";
            // 
            // dnld_lbl
            // 
            this.dnld_lbl.AutoSize = true;
            this.dnld_lbl.Location = new System.Drawing.Point(106, 125);
            this.dnld_lbl.Name = "dnld_lbl";
            this.dnld_lbl.Size = new System.Drawing.Size(29, 13);
            this.dnld_lbl.TabIndex = 6;
            this.dnld_lbl.Text = "0MB";
            this.dnld_lbl.Click += new System.EventHandler(this.dnld_lbl_Click);
            // 
            // speed_lbl
            // 
            this.speed_lbl.AutoSize = true;
            this.speed_lbl.Location = new System.Drawing.Point(247, 125);
            this.speed_lbl.Name = "speed_lbl";
            this.speed_lbl.Size = new System.Drawing.Size(29, 13);
            this.speed_lbl.TabIndex = 6;
            this.speed_lbl.Text = "0MB";
            this.speed_lbl.Click += new System.EventHandler(this.dnld_lbl_Click);
            // 
            // prctng_lbl
            // 
            this.prctng_lbl.AutoSize = true;
            this.prctng_lbl.Location = new System.Drawing.Point(607, 57);
            this.prctng_lbl.Name = "prctng_lbl";
            this.prctng_lbl.Size = new System.Drawing.Size(21, 13);
            this.prctng_lbl.TabIndex = 6;
            this.prctng_lbl.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(695, 172);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.url_txtbox);
            this.Controls.Add(this.speed_lbl);
            this.Controls.Add(this.dnld_lbl);
            this.Controls.Add(this.prctng_lbl);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resume_btn);
            this.Controls.Add(this.pause_btn);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.dnld_prgrss);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Tag = "FastiFire Downloader";
            this.Text = "FastiFire Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.Button resume_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.TextBox url_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dnld_lbl;
        private System.Windows.Forms.Label speed_lbl;
        private System.Windows.Forms.Label prctng_lbl;
        private System.Windows.Forms.ProgressBar dnld_prgrss;
    }
}

