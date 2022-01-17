using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Pacjent
    {
        private string Imie_pacjenta, Wizyta_pacjenta;
        private DateTime Data_Wizyty_pacjenta;
        private int val;
        private Pacjent next;

        public Pacjent(string p_n, string p_a, DateTime p_ad)
        {
            Imie_pacjenta = p_n;
            Wizyta_pacjenta = p_a;
            Data_Wizyty_pacjenta = p_ad;
        }

        public Pacjent(int new_x)
        {
            val = new_x;
            next = null;
        }

        public void SetNext(Pacjent p)
        {
            next = p;
        }
        public Pacjent GetNext()
        {
            return next;
        }
        public int GetValue()
        {
            return val;
        }

        public DateTime GetPatientAppointmentDate()
        {
            return Data_Wizyty_pacjenta;
        }
        public string GetPatientAppointment()
        {
            return Wizyta_pacjenta;
        }
        public string GetPatientName()
        {
            return Imie_pacjenta;
        }

        public void SetPatientAppointmentDate(DateTime new_date)
        {
            Data_Wizyty_pacjenta = new_date;
        }
        public void SetPatientAppointment(string new_patient_appointment)
        {
            Wizyta_pacjenta = new_patient_appointment;
        }
        public void SetPatientName(string new_patient_name)
        {
            Imie_pacjenta = new_patient_name;
        }
    }
}
