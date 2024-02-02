using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaraSSCuadre.Models
{
    public class Gara
    {
        private Form1 observer;

        public DateTime TimeStart { get; set; }
        public List<Squadra> Squadre { get; set; }
        public List<Problema> Problemi { get; set; }

        private int volteDieciMinuti = 0;

        private object locker = new object();
        private System.Threading.Timer timer;
        private System.Threading.Timer timerTempo;

        public Gara()
        {
            Problemi = new List<Problema>() {
                new Problema(1360), new Problema(9743), new Problema(8904), new Problema(420), new Problema(3960), new Problema(1051), new Problema(198), new Problema(5188), new Problema(12), new Problema(571), new Problema(103), new Problema(27), new Problema(816), new Problema(9813), new Problema(9999), new Problema(448), new Problema(9), new Problema(14)
            };
            Squadre = new List<Squadra>()
            {
                new Squadra("Algebra", Problemi.Count),
                new Squadra("Geometria", Problemi.Count),
                new Squadra("Analisi", Problemi.Count)
            };
        }

        public void TimerEvent(Object? stateInfo)
        {
            volteDieciMinuti++;

            lock (locker)
                foreach (Problema problema in Problemi)
                    if (problema.SquadreCheHannoRisolto == 0)
                        problema.PunteggioCorrente += 10;

            if (volteDieciMinuti == 9)
            {
                //FINE GARA
                timer.Change(Timeout.Infinite, Timeout.Infinite);
            }

            observer.Invoke(() => Notify());

        }

        public void ChangeTime(Object? stateInfo)
        {
            TimeSpan tempoRimasto = TimeStart.AddMinutes(90).Subtract(DateTime.Now);

            observer.Invoke(() =>
            {
                if (tempoRimasto.TotalSeconds > 0)
                    observer.SetTimeLabel(tempoRimasto.Hours.ToString("00") + ":" + tempoRimasto.Minutes.ToString("00") + ":" + tempoRimasto.Seconds.ToString("00"));
                else
                {
                    observer.SetTimeLabel("GARA TERMINATA");
                    timerTempo.Change(Timeout.Infinite, Timeout.Infinite);
                }
            });
        }

        public void Start()
        {
            TimeStart = DateTime.Now;
            var periodTimeSpan = TimeSpan.FromMinutes(10);
            var periodTimeSecondSpan = TimeSpan.FromSeconds(1);

            timer = new System.Threading.Timer(TimerEvent, null, periodTimeSpan, periodTimeSpan);
            timerTempo = new System.Threading.Timer(ChangeTime, null, periodTimeSecondSpan, periodTimeSecondSpan);
        }

        public void Register(Form1 form) => observer = form;

        public void Notify()
        {
            observer.DrawTabellone();
        }

        public string AddRisposta(Squadra squadra, Problema problema, int soluzione)
        {
            if (problema.Soluzione == soluzione && !squadra.QuesitiRisolti[problema.Numero - 1])
            {
                int punteggioAggiunto = problema.PunteggioCorrente;
                switch (problema.SquadreCheHannoRisolto)
                {
                    case 0:
                        punteggioAggiunto += 10;
                        break;
                        //case 1:
                        //    punteggioAggiunto += 10;
                        //    break;
                        //case 2:
                        //    punteggioAggiunto += 5;
                        //    break;
                }

                if (squadra.QuesitoJolly == problema.Numero)
                    punteggioAggiunto *= 2;

                squadra.QuesitiPunti[problema.Numero - 1] += punteggioAggiunto;
                squadra.QuesitiRisolti[problema.Numero - 1] = true;
                problema.SquadreCheHannoRisolto++;

                Notify();

                return "Risposta GIUSTA!";
            }
            else if (problema.Soluzione != soluzione)
            {
                if (problema.SquadreCheHannoRisolto == 0)
                    lock (locker)
                        problema.PunteggioCorrente += 10;

                int punteggioTolto = 10;
                if (squadra.QuesitoJolly == problema.Numero)
                    punteggioTolto *= 2;

                squadra.QuesitiPunti[problema.Numero - 1] -= punteggioTolto;

                Notify();

                return "Risposta SBAGLIATA!";
            }
            else
            {
                return "Sei un coglione!";
            }


        }

        public string SetJolly(Squadra squadra, int numeroProblema)
        {
            int oldValue = squadra.QuesitoJolly;
            squadra.QuesitoJolly = numeroProblema;

            Notify();

            if (oldValue == -1)
                return "Settato correttamente";
            else
                return "Jolly già scelto, ma modificato. Valore precedente: " + oldValue;


        }

        public Squadra GetSquadra(int numero)
        {
            foreach (Squadra squadra in Squadre)
                if (squadra.Numero == numero)
                    return squadra;

            throw new Exception("");
        }

        public Problema GetProblema(int numero)
        {
            foreach (Problema problema in Problemi)
                if (problema.Numero == numero)
                    return problema;

            throw new Exception("");
        }
    }
}
