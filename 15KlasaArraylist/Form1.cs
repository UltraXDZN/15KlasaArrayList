using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15KlasaArraylist
{
    public partial class Form1 : Form
    {
        List<string> m_automobili;

        public Form1()
        {
            m_automobili = new List<string>();
            InitializeComponent();
        }

        private void ChangeInputState()
        {
            imeAutaText.Enabled = !imeAutaText.Enabled;
            unesiButton.Enabled = !unesiButton.Enabled;
        }

        private void UpdateMainTextBox()
        {
            listaAutaText.Text = string.Empty;
            for (int i = 0; i < m_automobili.Count; i++)
            {
                listaAutaText.Text += $"{i + 1}. {m_automobili[i]}\r\n";
            }
        }

        private void noviAutoButton_Click(object sender, EventArgs e)
        {
            ChangeInputState();
        }

        private void unesiButton_Click(object sender, EventArgs e)
        {
            m_automobili.Add(imeAutaText.Text);
            imeAutaText.Text = string.Empty;
            ChangeInputState();

            UpdateMainTextBox();
        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {
            listaAutaText.Text = string.Empty;
            m_automobili = new List<string>();
        }
    }
}
