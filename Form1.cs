using GaraSSCuadre.Models;


namespace GaraSSCuadre
{
    public partial class Form1 : Form
    {

        private Gara gara;

        public Form1(Gara gara)
        {
            InitializeComponent();

            this.gara = gara;

            DrawTabellone();

            gara.Register(this);
        }

        public void SetTimeLabel(string time)
        {
            labelTempo.Text = time;
        }

        public void DrawTabellone()
        {
            tabellone.Controls.Clear();

            List<Squadra> squadre = gara.Squadre.OrderByDescending(x => x.PuntiTotali).ToList();
            List<Problema> problemi = gara.Problemi.OrderBy(x => x.Numero).ToList();

            int lunghezzaPanel = gara.Problemi.Count * 60 + 270;

            Panel panelDomande = new Panel()
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(lunghezzaPanel - 270, 50),
                Location = new Point(280, 10)
            };
            tabellone.Controls.Add(panelDomande);

            int x = 0;
            foreach (Problema problema in problemi)
            {
                Panel panelProblema = new Panel()
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(60, 50),
                    Location = new Point(x, 0)
                };
                x += 60;
                panelDomande.Controls.Add(panelProblema);

                Label labelNumero = new Label()
                {
                    Text = "D" + problema.Numero,
                    Size = new Size(60, 30),
                    Location = new Point(0, 0),
                    Font = new Font(Label.DefaultFont, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                panelProblema.Controls.Add(labelNumero);
                Label labelPunti = new Label()
                {
                    Text = problema.PunteggioCorrente.ToString(),
                    Size = new Size(60, 20),
                    Location = new Point(0, 30),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                panelProblema.Controls.Add(labelPunti);
            }

            int y = 60;
            int pos = 1;
            foreach (Squadra squad in squadre)
            {
                Panel panelSquad = new Panel()
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(lunghezzaPanel, 50),
                    Location = new Point(10, y)
                };
                tabellone.Controls.Add(panelSquad);

                Label labelPos = new Label()
                {
                    Text = pos.ToString(),
                    Size = new Size(30, 50),
                    Location = new Point(0, 0),
                    Font = new Font(Label.DefaultFont, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                panelSquad.Controls.Add(labelPos);

                Label labelNome = new Label()
                {
                    Text = squad.Nome,
                    Size = new Size(150, 50),
                    Location = new Point(40, 0),
                    Font = new Font(Label.DefaultFont, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                panelSquad.Controls.Add(labelNome);

                Label labelPunti = new Label()
                {
                    Text = squad.PuntiTotali.ToString(),
                    Size = new Size(70, 50),
                    Location = new Point(200, 0),
                    Font = new Font(Label.DefaultFont, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleRight
                };
                panelSquad.Controls.Add(labelPunti);

                x = 270;
                for (int i = 0; i < problemi.Count; i++)
                {
                    Panel panelProblema = new Panel()
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        Size = new Size(60, 50),
                        Location = new Point(x, 0)
                    };
                    x += 60;
                    panelSquad.Controls.Add(panelProblema);

                    if (squad.QuesitoJolly == i + 1)
                    {
                        Label labelJolly = new Label()
                        {
                            Text = "J",
                            Size = new Size(20, 20),
                            Location = new Point(40, 30),
                            Font = new Font(Label.DefaultFont, FontStyle.Bold),
                            TextAlign = ContentAlignment.BottomRight,
                            ForeColor = Color.DarkGreen,
                            BackColor = Color.Transparent
                        };
                        panelProblema.Controls.Add(labelJolly);
                    }

                    Label labelPuntiProblema;
                    if (!squad.QuesitiRisolti[i])
                    {
                        if (squad.QuesitiPunti[i] < 0)
                        {
                            labelPuntiProblema = new Label()
                            {
                                Text = squad.QuesitiPunti[i].ToString(),
                                Size = new Size(60, 20),
                                Location = new Point(0, 10),
                                TextAlign = ContentAlignment.MiddleCenter
                            };
                            panelProblema.Controls.Add(labelPuntiProblema);

                            panelProblema.BackColor = Color.Red;
                        }
                        continue;
                    }

                    labelPuntiProblema = new Label()
                    {
                        Text = squad.QuesitiPunti[i].ToString(),
                        Size = new Size(60, 20),
                        Location = new Point(0, 10),
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    panelProblema.Controls.Add(labelPuntiProblema);

                    panelProblema.BackColor = Color.LightGreen;
                }

                y += 60;
                pos++;
            }

        }
    }
}