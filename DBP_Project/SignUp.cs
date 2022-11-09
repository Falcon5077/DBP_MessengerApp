﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_Project
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Button_Click(object sender, EventArgs e)
        {
            //회원가입 버튼을 눌렀을 때,
            // 확인 할 것
            // 1. 사원 번호의 중복 여부
            // 2. 재입력한 비밀번호가 같은지
            // 3. 비어있는 칸이 있는지

            // 1~3을 전부 확인 후
            // 4. 비밀번호 암호화 해서 저장
        }

        private void button_photo_Button_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //사진 파일을 가지고 옵니다.
                string file = FD.FileName; //파일명
                string[] fileName = FD.SafeFileName.Split('.'); //파일명
                string fileName_c = fileName[0];
                //확인용 메세지 박스
                MessageBox.Show(file);
                MessageBox.Show(fileName[0]);
                MessageBox.Show(fileName[1]);

                //사진 입력
                pictureBox_Photo.Image = Image.FromFile(file);
                pictureBox_Photo.SizeMode = PictureBoxSizeMode.Zoom;   
            }
        }
    }
}