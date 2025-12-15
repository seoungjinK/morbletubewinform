using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TpMain
{
    public partial class MyPage : Form
    {
        public MyPage()
        {
            InitializeComponent();
        }

        private void MyPage_Load(object sender, EventArgs e)
        {
            lb_Name.Text = UserSession.Nickname;
            try
            {
                List<VideoInfo> videoList = GetVideoDataFromDB();

                foreach (var video in videoList)
                {
                    // 영상 카드 생성
                    Panel panel1 = CreateVideoPanel(video);
                    Panel panel2 = CreateVideoPanel(video);

                    // 각각의 FlowLayoutPanel에 추가
                    flowLayoutPanel1.Controls.Add(panel1);
                    flowLayoutPanel2.Controls.Add(panel2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터를 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 영상 1개의 UI 패널을 생성하는 함수
        /// </summary>
        private Panel CreateVideoPanel(VideoInfo video)
        {
            Panel videoPanel = new Panel
            {
                Width = 340,
                Height = 320,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };

            // 썸네일 추가
            PictureBox thumbnail = new PictureBox
            {
                Width = 320,
                Height = 200,
                Location = new Point(10, 5),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.DarkGray,
                //Image = Image.FromFile(@"C:\Users\모블\Desktop\30초 영상 썸네일\영상4 썸네일.PNG"),
                Cursor = Cursors.Hand
            };



            // AxWindowsMediaPlayer 생성 및 초기화
            AxWindowsMediaPlayer wmp = new AxWindowsMediaPlayer
            {
                Width = 320,
                Height = 200,
                Location = new Point(10, 5),
                Enabled = true,
                Visible = false
            };

            ((System.ComponentModel.ISupportInitialize)(wmp)).BeginInit();
            videoPanel.Controls.Add(wmp);
            ((System.ComponentModel.ISupportInitialize)(wmp)).EndInit();

            wmp.URL = video.FilePath;
            wmp.uiMode = "none";
            wmp.Ctlcontrols.stop(); // 자동 재생 방지

            //썸네일에 마우스를 올리면 → 썸네일 숨기고 영상 재생
            thumbnail.MouseEnter += (s, e) =>
            {
                thumbnail.Visible = false;
                wmp.Visible = true;
                wmp.Ctlcontrols.play();
            };


            // 플레이어에서 마우스를 벗어나면 → 재생 중지하고 썸네일 다시 표시
            videoPanel.MouseLeave += (s, e) =>
            {
                wmp.Ctlcontrols.stop();
                wmp.Visible = false;
                thumbnail.Visible = true;
            };

            //// 제목 라벨
            //Label titleLabel = new Label
            //{
            //    Text = video.Title,
            //    Font = new Font("맑은 고딕", 12F, FontStyle.Bold),
            //    Location = new Point(10, 230),
            //    ForeColor = Color.White,
            //    AutoSize = true,
            //    MaximumSize = new Size(320, 0)

            //};

            // 닉네임 라벨
            Button nicknameButton = new Button
            {
                Text = video.Nickname,
                Font = new Font("맑은 고딕", 9F, FontStyle.Regular),
                ForeColor = Color.White,
                BackColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(10, 250),
                Width = 320,
                Height = 25,
                TextAlign = ContentAlignment.MiddleLeft
            };
            nicknameButton.FlatAppearance.BorderSize = 0;

            // 버튼 클릭시 사용자 이름이 바뀜
            nicknameButton.Click += (sender, e) =>
            {
                // lb_Name이 현재 폼의 라벨일 경우
                lb_Name.Text = video.Nickname;
            };

            // 버튼 추가
            Button playButton = new Button
            {
                Text = $"제목:{video.Title}",
                Location = new Point(10, 200),
                Width = 320,
                Height = 30,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleLeft
            };
            playButton.FlatAppearance.BorderSize = 0;

            //버튼 클릭시 메세지 박스 띄우기
            playButton.Click += (sender, e) =>
            {
                MessageBox.Show($"버튼이 눌린 영상 제목: {video.Title}", "알림");

            };



            //videoPanel.Controls.Add(titleLabel);
            videoPanel.Controls.Add(thumbnail);
            videoPanel.Controls.Add(nicknameButton);
            videoPanel.Controls.Add(playButton);

            thumbnail.BringToFront();




            return videoPanel;
        }

        /// <summary>
        /// MySQL DB에서 영상 목록 조회
        /// </summary>
        private List<VideoInfo> GetVideoDataFromDB()
        {
            var videoList = new List<VideoInfo>();
            string connectionString = "Server=localhost;Database=youtube;Uid=root;Pwd=1234;";

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT title, user_id, video_path, video_sum_path FROM posts ORDER BY user_id DESC";
                    using (var command = new MySqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            videoList.Add(new VideoInfo
                            {
                                Title = reader.GetString("title"),
                                Nickname = reader.GetInt32(reader.GetOrdinal("user_id")).ToString(),
                                FilePath = reader.GetString("video_path"),
                                ThumbnailPath = reader.GetString("video_sum_path")
                                //ThumbnailPath = reader.GetString("video_sum_path")

                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터베이스 오류: {ex.Message}", "DB 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return videoList;
        }

        private void btn_goUp_Click(object sender, EventArgs e)
        {
            Upload upload = new Upload();
            upload.ShowDialog();
            this.Close();
        }
    }
}
