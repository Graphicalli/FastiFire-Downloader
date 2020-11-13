using AltoHttp;
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

namespace EDM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        HttpDownloader httpdownloader;
        
        private void dnld_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            httpdownloader = new HttpDownloader(url_txtbox.Text,$"{Application.StartupPath}\\{Path.GetFileName(url_txtbox.Text)}");
            httpdownloader.DownloadCompleted += HttpDownloader_DownloadComplete;
            httpdownloader.ProgressChanged += HttpDownloader_ProgressChanged;
            httpdownloader.Start();
            Start_btn.Enabled = false;
            resume_btn.Enabled = true;
            pause_btn.Enabled = true;
        }

        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            dnld_prgrss.Value = (int)e.Progress;
            prctng_lbl.Text = $"{e.Progress.ToString("0.00")} %";
            speed_lbl.Text = string.Format("{0} MB/s", (e.SpeedInBytes / 1024d/1024d).ToString("0.00"));
            dnld_lbl.Text = string.Format("{0} MB/s", (httpdownloader.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
            status_lbl.Text = "downloading.....";
        }

        private void HttpDownloader_DownloadComplete(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                status_lbl.Text = "Finish";
                prctng_lbl.Text = "100";
            });
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            if(httpdownloader != null)
            httpdownloader.Pause();
            pause_btn.Enabled = false;
            Start_btn.Enabled = true;
            resume_btn.Enabled = true;
        }

        private void resume_btn_Click(object sender, EventArgs e)
        {
            if (httpdownloader != null)
                httpdownloader.Resume();
            resume_btn.Enabled = false;
            pause_btn.Enabled = true;
            Start_btn.Enabled = true;
        }

        private void url_txtbox_TextChanged(object sender, EventArgs e)
        {
            Start_btn.Enabled = true;
            pause_btn.Enabled = true;
            resume_btn.Enabled = true;
        }
    }
}
