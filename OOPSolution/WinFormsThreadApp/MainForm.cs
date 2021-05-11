using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsThreadApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1000;
          

            //Thread로 분리 윈폼의 GUI 화면 스레드/ 처리 스레드를 분리
            // for 문을 밖으로 꺼내면 멀티태스킹에 문제가 생겨서 응답없음이 뜬다
            Thread th = new Thread(() =>
            {
                for (int i = 0; i <= 1000; i++)
                {
                    progressBar1.BeginInvoke(
                        new Action(() =>
                        {
                            progressBar1.Value = i;
                        }));  // 크로스 스레드 문제 해결, 스레드 분리

                    Thread.Sleep(5);// 응답없음 발생 50ms가 걸리는 일을 컴퓨터가 처리 X -> 그래픽, 처리 분리해서 single thread로 처리해줘야 한다.
                }
            });
            th.IsBackground = true; //백그라운드로 실행할 지 여부 
            th.Start();
        }
    }
}
