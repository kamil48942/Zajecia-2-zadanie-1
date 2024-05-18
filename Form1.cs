using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace zad2lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                string dzielnaText = txtDzielna.Text;
                string dzielnikText = txtDzielnik.Text;

                if (double.TryParse(dzielnaText, out double dzielna) && double.TryParse(dzielnikText, out double dzielnik))
                {
                    if (dzielnik == 0)
                    {
                        throw new DivideByZeroException("Dzielnik nie może być zerem.");
                    }

                    double wynik = dzielna / dzielnik;

                    txtWynik.Text = wynik.ToString();
                }
                else
                {
                    throw new FormatException("Wprowadzone wartości muszą być liczbami.");
                }
            }
            catch (Exception ex)
            {
                LogErrorToEventLog(ex);

                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogErrorToEventLog(Exception ex)
        {
            string source = "DivisionApp";
            string log = "Application";

            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, log);
            }

            EventLog.WriteEntry(source, ex.ToString(), EventLogEntryType.Error);
        }
    }
}
