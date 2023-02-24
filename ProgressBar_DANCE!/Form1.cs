using System.Drawing;

namespace ProgressBar_DANCE_
{
    public partial class Form1 : Form
    {
        System.Threading.Timer timer;
        List<ResultRow> results = new List<ResultRow>();
        //String resultTable[][];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TimerCallback callback = new TimerCallback(CallbackDel);// Task1
            //timer = new System.Threading.Timer(callback, this.Controls, 0, 1500);
            //resultTable = new string[2][5];
            TimerCallback callback = new TimerCallback(CallbackDel);
            timer = new System.Threading.Timer(callback, this.Controls, 0, 500);

        }

        void CallbackDel(object collection)
        {
            //foreach (Control control in (ControlCollection)collection)    //Task1
            //{
            //    if (control != null && control.GetType() == progressBar1.GetType())
            //    {
            //        ProgressBar bar = (ProgressBar)control;
            //        bar.BeginInvoke(new Action(() =>
            //        {
            //            Random random = new Random();
            //            bar.Value = random.Next(bar.Minimum, bar.Maximum);
            //            Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            //            bar.BackColor = color;
            //            Thread.Sleep(30);
            //        }));
            //    }
            //}

            foreach (Control control in (ControlCollection)collection)    //Task2
            {
                if (control != null && control.GetType() == progressBar1.GetType())
                {
                    ProgressBar bar = (ProgressBar)control;
                    bar.BeginInvoke(new Action(() =>
                    {
                        Random random = new Random();
                        int step = random.Next(0, 5);
                        if (bar.Value + step > bar.Maximum)
                        {
                            bar.Value = bar.Maximum;
                            results.Add(new ResultRow ( bar.Name, TimeSpan.Zero ));
                        }
                        else
                            bar.Value += step;
                    }));
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*foreach (Control control in this.Controls)    //Task1
            {
                if (control != null && control.GetType() == progressBar1.GetType())
                {
                    ProgressBar bar = (ProgressBar)control;
                    bar.EndInvoke(null);
                }
            }*/
        }
    }

    class ResultRow
    {
        string BarName;
        TimeSpan span;
        public ResultRow(string name, TimeSpan time)
        {
            BarName = name;
            span = time;
        }

        public override string ToString()
        {
            return BarName + " " + span.ToString();
        }
    }
}