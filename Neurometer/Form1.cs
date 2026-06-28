using System;

namespace Neurometer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isRuning = false;

        int timeCounter = 0;

        Random random = new Random();

        public void RandomShortCut()
        {
            lblShortcut1.Visible = lblShortcut2.Visible = lblShortcut3.Visible = lblShortcut4.Visible = lblShortcut5.Visible = lblShortcut6.Visible = false;

            int count = 0;

            while (count < 3)
            {
                int number = random.Next(1, 7);

                switch (number)
                {
                    case 1:
                        if (!lblShortcut1.Visible)
                        {
                            lblShortcut1.Visible = true;
                            count++;
                        }
                        break;

                    case 2:
                        if (!lblShortcut2.Visible)
                        {
                            lblShortcut2.Visible = true;
                            count++;
                        }
                        break;

                    case 3:
                        if (!lblShortcut3.Visible)
                        {
                            lblShortcut3.Visible = true;
                            count++;
                        }
                        break;

                    case 4:
                        if (!lblShortcut4.Visible)
                        {
                            lblShortcut4.Visible = true;
                            count++;
                        }
                        break;

                    case 5:
                        if (!lblShortcut5.Visible)
                        {
                            lblShortcut5.Visible = true;
                            count++;
                        }
                        break;

                    case 6:
                        if (!lblShortcut6.Visible)
                        {
                            lblShortcut6.Visible = true;
                            count++;
                        }
                        break;
                }
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            RandomShortCut();
            changeShortCut.Start();
            isRuning = true;
            timeCounter = 0;
            Time.Start();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (isRuning)
            {
                isRuning = false;
                Time.Stop();
                changeShortCut.Stop();
                this.Text = "Neurometer";
                MessageBox.Show("شما بازنده شدید", "نتیجه");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (isRuning)
            {
                isRuning = false;
                MessageBox.Show($"شما با زمان {timeCounter}  ثانیه برنده شدید", "نتیجه");
                Time.Stop();
                changeShortCut.Stop();
                this.Text = "Neurometer";

            }
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            timeCounter++;
            this.Text = $"Neurometer   Timer({timeCounter.ToString()})";
        }

        private void changeShortCut_Tick(object sender, EventArgs e)
        {
            RandomShortCut();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            MessageBox.Show("1- بعضی از مسیرها میانبر هستند\n" +
                "2- مسیرهای میانبر هر پنج ثانیه تغییر میکنند\n" +
                "3- زمان سپری شده را می توانید در قسمت بالای فرم مشاهده کنید\n", ":نکات قبل از بازی");
        }
    }
}
