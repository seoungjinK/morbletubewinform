using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpMain
{
    public partial class Upload : Form
    {
        public Upload()
        {
            InitializeComponent();
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            using (UpSub f = new UpSub())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    string path = f.SelectedVideoPath;

                    // 영상 경로가 올바른 경우 재생
                    if (!string.IsNullOrEmpty(path) && System.IO.File.Exists(path))
                    {
                        axWindowsMediaPlayer1.URL = path;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                    }
                    else
                    {
                        MessageBox.Show("유효하지 않은 영상 파일입니다.");
                    }
                }
                else
                {
                    MessageBox.Show("업로드를 취소했습니다.");
                }
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();


            axWindowsMediaPlayer1.URL = "";
        }
    }

}
