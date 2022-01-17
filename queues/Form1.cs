using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queues
{
    public partial class Wizyty : Form
    {
        public Wizyty()
        {
            InitializeComponent();
        }
        private void Wizyty_Load(object sender, EventArgs e)
        {
            TextAktualnaData.Text = DateTime.Today.ToString("dd-MM-yyyy");

            if (DateTime.Now.Minute < 10)
            {
                AktualnaGodz.Text = DateTime.Now.Hour.ToString() + ":" + "0" + DateTime.Now.Minute.ToString();
            }
            else AktualnaGodz.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
        }
        private readonly int timer_tick = 10000;    // 10s
        private void TimeManager_Tick(object sender, EventArgs e)
        {
            TimeManager.Interval = timer_tick;

            if (DateTime.Now.Minute < 10)
            {
                AktualnaGodz.Text = DateTime.Now.Hour.ToString() + ":" + "0" + DateTime.Now.Minute.ToString();
            }
            else AktualnaGodz.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
        }
        public bool CheckInfo()
        {
            if ((ImieTextBox.Text == "") ||
                (NazwaWizytyTextBox.Text == "") ||
                (DataWizytyPicker.Value < DateTime.Today))
            {
                return true;
            }
            return false;
        }
        public void InputError()
        {
            string title = "błąd";
            string err_mess = "prosze wypełnić wszystkie wymagane pola";

            if (CheckInfo())
                MessageBox.Show(err_mess, title);
        }
        kolejka queue = new kolejka();
        private void Enqueue_Click(object sender, EventArgs e)
        {
            InputError();

            if (queue.Empty())
                return;

        }
        private void Dequeue_Click(object sender, EventArgs e)
        {
            InputError();

            if (queue.Empty())
                return;

        }
        private void InsertIntoQueue_Click(object sender, EventArgs e)
        {
            InputError();

            if (queue.Empty())
                return;

        }
    }
}
