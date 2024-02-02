using GaraSSCuadre.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaraSSCuadre
{
    public partial class FormControlli : Form
    {
        private Gara gara;
        private Form tabellone;

        public FormControlli()
        {
            InitializeComponent();

            gara = new Gara();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            gara.Start();
            buttonStart.Visible = false;

            tabellone = new Form1(gara);
            tabellone.Show();
        }

        private void buttonSoluzione_Click(object sender, EventArgs e)
        {
            try
            {
                int problema = int.Parse(textBoxPAdd.Text);
                int squadra = int.Parse(textBoxSAdd.Text);
                int soluzione = int.Parse(textBoxSoluzione.Text);

                MessageBox.Show(gara.AddRisposta(gara.GetSquadra(squadra), gara.GetProblema(problema), soluzione));

                textBoxPAdd.Text = "";
                textBoxSAdd.Text = "";
                textBoxSoluzione.Text = "";
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonJolly_Click(object sender, EventArgs e)
        {
            try
            {
                int problema = int.Parse(textBoxPAdd.Text);
                int squadra = int.Parse(textBoxSAdd.Text);

                MessageBox.Show(gara.SetJolly(gara.GetSquadra(squadra), problema));

                textBoxPAdd.Text = "";
                textBoxSAdd.Text = "";
                textBoxSoluzione.Text = "";
            }
            catch (Exception ex)
            {

            }
        }
    }
}
