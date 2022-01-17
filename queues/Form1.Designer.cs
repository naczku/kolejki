
namespace Queues
{
    partial class Wizyty
    {

        private System.ComponentModel.IContainer komponenty = null;
        protected override void Dispose(bool wyrzucanie)
        {
            if (wyrzucanie && (komponenty != null))
            {
                komponenty.Dispose();
            }
            base.Dispose(wyrzucanie);
        }
        #region
        private void InitializeComponent()
        {
            this.komponenty = new System.ComponentModel.Container();
            this.DataWizyty = new System.Windows.Forms.Label();
            this.NazwaWizyty = new System.Windows.Forms.Label();
            this.ImieTextBox = new System.Windows.Forms.TextBox();
            this.NazwaWizytyTextBox = new System.Windows.Forms.TextBox();
            this.DataWizytyPicker = new System.Windows.Forms.DateTimePicker();
            this.ImiePacjenta = new System.Windows.Forms.Label();
            this.AktualnaData = new System.Windows.Forms.Label();
            this.TimeManager = new System.Windows.Forms.Timer(this.komponenty);
            this.TextAktualnaData = new System.Windows.Forms.Label();
            this.zakolejkuj = new System.Windows.Forms.Button();
            this.odkolejkuj = new System.Windows.Forms.Button();
            this.dodajDoKolejki = new System.Windows.Forms.Button();
            this.AktualnaGodz = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.DataWizyty.AutoSize = true;
            this.DataWizyty.Location = new System.Drawing.Point(15, 65);
            this.DataWizyty.Name = "DataWizyty";
            this.DataWizyty.Size = new System.Drawing.Size(30, 13);
            this.DataWizyty.TabIndex = 1;
            this.DataWizyty.Text = "Data";

            this.NazwaWizyty.AutoSize = true;
            this.NazwaWizyty.Location = new System.Drawing.Point(15, 40);
            this.NazwaWizyty.Name = "NazwaWizyty";
            this.NazwaWizyty.Size = new System.Drawing.Size(66, 13);
            this.NazwaWizyty.TabIndex = 3;
            this.NazwaWizyty.Text = "Wizyta";

            this.ImieTextBox.Location = new System.Drawing.Point(90, 8);
            this.ImieTextBox.Name = "ImieTextBox";
            this.ImieTextBox.Size = new System.Drawing.Size(100, 20);
            this.ImieTextBox.TabIndex = 4;

            this.NazwaWizytyTextBox.Location = new System.Drawing.Point(90, 33);
            this.NazwaWizytyTextBox.Name = "NazwaWizytyTextBox";
            this.NazwaWizytyTextBox.Size = new System.Drawing.Size(100, 20);
            this.NazwaWizytyTextBox.TabIndex = 5;

            this.DataWizytyPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataWizytyPicker.Location = new System.Drawing.Point(90, 58);
            this.DataWizytyPicker.Name = "DataWizytyPicker";
            this.DataWizytyPicker.Size = new System.Drawing.Size(100, 20);
            this.DataWizytyPicker.TabIndex = 6;

            this.ImiePacjenta.AutoSize = true;
            this.ImiePacjenta.Location = new System.Drawing.Point(15, 15);
            this.ImiePacjenta.Name = "ImiePacjenta";
            this.ImiePacjenta.Size = new System.Drawing.Size(69, 13);
            this.ImiePacjenta.TabIndex = 7;
            this.ImiePacjenta.Text = "imie pacjenta";

            this.AktualnaData.AutoSize = true;
            this.AktualnaData.Location = new System.Drawing.Point(15, 90);
            this.AktualnaData.Name = "AktualnaData";
            this.AktualnaData.Size = new System.Drawing.Size(65, 13);
            this.AktualnaData.TabIndex = 8;
            this.AktualnaData.Text = "Aktualna data";

            this.TimeManager.Enabled = true;
            this.TimeManager.Interval = 1000;
            this.TimeManager.Tick += new System.EventHandler(this.TimeManager_Tick);

            this.TextAktualnaData.AutoSize = true;
            this.TextAktualnaData.Location = new System.Drawing.Point(90, 90);
            this.TextAktualnaData.Name = "TextAktualnaData";
            this.TextAktualnaData.Size = new System.Drawing.Size(80, 13);
            this.TextAktualnaData.TabIndex = 9;
            this.TextAktualnaData.Text = "timeDateHolder";

            this.zakolejkuj.Location = new System.Drawing.Point(200, 7);
            this.zakolejkuj.Name = "zakolejkuj";
            this.zakolejkuj.Size = new System.Drawing.Size(100, 20);
            this.zakolejkuj.TabIndex = 10;
            this.zakolejkuj.Text = "zakolejkuj";
            this.zakolejkuj.UseVisualStyleBackColor = true;
            this.zakolejkuj.Click += new System.EventHandler(this.Enqueue_Click);

            this.odkolejkuj.Location = new System.Drawing.Point(200, 32);
            this.odkolejkuj.Name = "odkolejkuj";
            this.odkolejkuj.Size = new System.Drawing.Size(100, 20);
            this.odkolejkuj.TabIndex = 11;
            this.odkolejkuj.Text = "odkolejkuj";
            this.odkolejkuj.UseVisualStyleBackColor = true;
            this.odkolejkuj.Click += new System.EventHandler(this.Dequeue_Click);

            this.dodajDoKolejki.Location = new System.Drawing.Point(200, 58);
            this.dodajDoKolejki.Name = "dodajDoKolejki";
            this.dodajDoKolejki.Size = new System.Drawing.Size(100, 20);
            this.dodajDoKolejki.TabIndex = 14;
            this.dodajDoKolejki.Text = "Dodaj do kolejki";
            this.dodajDoKolejki.UseVisualStyleBackColor = true;
            this.dodajDoKolejki.Click += new System.EventHandler(this.InsertIntoQueue_Click);

            this.AktualnaGodz.AutoSize = true;
            this.AktualnaGodz.Location = new System.Drawing.Point(176, 90);
            this.AktualnaGodz.Name = "AktualnaGodz";
            this.AktualnaGodz.Size = new System.Drawing.Size(107, 13);
            this.AktualnaGodz.TabIndex = 15;
            this.AktualnaGodz.Text = "timeHourPlaceHolder";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 117);
            this.Controls.Add(this.AktualnaGodz);
            this.Controls.Add(this.dodajDoKolejki);
            this.Controls.Add(this.odkolejkuj);
            this.Controls.Add(this.zakolejkuj);
            this.Controls.Add(this.TextAktualnaData);
            this.Controls.Add(this.AktualnaData);
            this.Controls.Add(this.ImiePacjenta);
            this.Controls.Add(this.DataWizytyPicker);
            this.Controls.Add(this.NazwaWizytyTextBox);
            this.Controls.Add(this.ImieTextBox);
            this.Controls.Add(this.NazwaWizyty);
            this.Controls.Add(this.DataWizyty);
            this.Name = "Wizyty";
            this.Text = "Wizyty";
            this.Load += new System.EventHandler(this.Wizyty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DataWizyty;
        private System.Windows.Forms.Label NazwaWizyty;
        private System.Windows.Forms.TextBox ImieTextBox;
        private System.Windows.Forms.TextBox NazwaWizytyTextBox;
        private System.Windows.Forms.DateTimePicker DataWizytyPicker;
        private System.Windows.Forms.Label ImiePacjenta;
        private System.Windows.Forms.Label AktualnaData;
        private System.Windows.Forms.Timer TimeManager;
        private System.Windows.Forms.Label TextAktualnaData;
        private System.Windows.Forms.Button zakolejkuj;
        private System.Windows.Forms.Button odkolejkuj;
        private System.Windows.Forms.Button dodajDoKolejki;
        private System.Windows.Forms.Label AktualnaGodz;
    }
}

