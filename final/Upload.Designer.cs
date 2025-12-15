namespace TpMain
{
    partial class Upload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upload));
            btn_Upload = new Button();
            btn_Delete = new Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // btn_Upload
            // 
            btn_Upload.Location = new Point(603, 411);
            btn_Upload.Name = "btn_Upload";
            btn_Upload.Size = new Size(258, 43);
            btn_Upload.TabIndex = 0;
            btn_Upload.Text = "업로드";
            btn_Upload.UseVisualStyleBackColor = true;
            btn_Upload.Click += btn_Upload_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(603, 482);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(258, 32);
            btn_Delete.TabIndex = 1;
            btn_Delete.Text = "삭제";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(625, 186);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(222, 184);
            axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // Upload
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Upload);
            Name = "Upload";
            Text = "Upload";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Upload;
        private Button btn_Delete;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}