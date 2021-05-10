using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandlerCheckApp
{
    public partial class MainForm : Form
    {
        static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public object TxtUserID;
        //public string Text;

        public object TxtPassword { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var result = TxtUserID.Text + "\n" + TxtPassword.Text;
            Message.Show($"당신의 아이디와 패스워드는 {result}");

            try
            {
                var val = TxtPassword.Text.Substring(3, 2);
                MessageBox.Show($"{val}");
                logger.Info("제대로 완료!");
            }
            catch (Exception ex)
            {

                 MessageBox.Show($"예외발생, 관리자에게 문의 요망");
                logger.Error("제대로 완료!");
                logger.Error($"{ ex}");


            }
        }

        private void Text(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //초기화 내용
            
            logger.Info("메인폼 초기화 로그");
            Console.WriteLine("NLog 출력 종료");
        }
    }
}
