﻿
namespace DBP_Project
{
    partial class ChatPanel
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LastChat = new System.Windows.Forms.Label();
            this.ReadCheck = new System.Windows.Forms.CheckBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(110, 20);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(194, 19);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // LastChat
            // 
            this.LastChat.ForeColor = System.Drawing.Color.White;
            this.LastChat.Location = new System.Drawing.Point(112, 69);
            this.LastChat.Name = "LastChat";
            this.LastChat.Size = new System.Drawing.Size(192, 12);
            this.LastChat.TabIndex = 2;
            this.LastChat.Text = "last chat";

            // 
            // ReadCheck
            // 
            this.ReadCheck.Enabled = false;
            this.ReadCheck.Location = new System.Drawing.Point(427, 49);
            this.ReadCheck.Name = "ReadCheck";
            this.ReadCheck.Size = new System.Drawing.Size(20, 20);
            this.ReadCheck.TabIndex = 3;
            this.ReadCheck.UseVisualStyleBackColor = true;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("굴림", 13F);
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TimeLabel.Location = new System.Drawing.Point(262, 20);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(127, 48);
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "time";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DBP_Project.Properties.Resources.check;
            this.pictureBox2.Location = new System.Drawing.Point(265, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // ChatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ReadCheck);
            this.Controls.Add(this.LastChat);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ChatPanel";
            this.Size = new System.Drawing.Size(624, 105);
            this.Load += new System.EventHandler(this.ChatPanel_Load);
            this.Click += new System.EventHandler(this.ChatPanel_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LastChat;
        private System.Windows.Forms.CheckBox ReadCheck;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
