using static System.Windows.Forms.AxHost;
using System.Windows.Forms;

namespace Clase03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string validarRadios()
        {
            string valorRadio = "";

            foreach (RadioButton radio in groupBox1.Controls)
            {
                if (radio.Checked)
                {
                    valorRadio = radio.Text;
                }
            }
            return valorRadio;
        }

        private int largoCheck()
        {
            int resultado = 0;
            if (checkBox1.Checked)
            {
                resultado = resultado + 1;
            }
            if (checkBox2.Checked)
            {
                resultado = resultado + 1;
            }
            if (checkBox3.Checked)
            {
                resultado = resultado + 1;
            }
            if (checkBox4.Checked)
            {
                resultado = resultado + 1;
            }
            if (checkBox5.Checked)
            {
                resultado = resultado + 1;
            }
            return resultado;
        }

        private string[] validarCheckBox(int largoArray)
        {
            int i = 1;
            string[] resultado = new string[largoArray];
            foreach (CheckBox chk in groupBox2.Controls)
            {
                if (chk.Checked)
                {
                    resultado[largoArray - i] = chk.Text;
                    i++;
                }
            }
            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidadChk = largoCheck();
            string[] educacion = validarCheckBox(cantidadChk);
            label1.Text = "Estado civil : " + validarRadios() + "\n";
            label1.Text += "Educacion: ";
            foreach (string s in educacion)
            {
                label1.Text += $"{s} -";
            }
            label1.Text += $"\nPais: {listBox1.SelectedItem}";
            label1.Text += $"\nEdad: {(Math.Floor((DateTime.Now - dateTimePicker1.Value).TotalDays / 365))}";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Red":
                    this.ForeColor = Color.White;
                    groupBox1.ForeColor = Color.White;
                    groupBox2.ForeColor = Color.White;
                    button1.ForeColor = Color.Black;
                    label1.ForeColor = Color.White;
                    this.BackColor = Color.Red;
                    break;
                case "Green":
                    groupBox1.ForeColor = Color.White;
                    groupBox2.ForeColor = Color.White;
                    label1.ForeColor = Color.White;
                    button1.ForeColor = Color.Black;
                    this.BackColor = Color.Green;
                    break;
                case "Blue":
                    groupBox1.ForeColor = Color.White;
                    groupBox2.ForeColor = Color.White;
                    label1.ForeColor = Color.White;
                    button1.ForeColor = Color.Black;
                    this.ForeColor = Color.White;
                    this.BackColor = Color.Blue;
                    break;
                case "White":
                    groupBox1.ForeColor = Color.Black;
                    groupBox2.ForeColor = Color.Black;
                    button1.ForeColor = Color.Black;
                    label1.ForeColor = Color.Black;
                    this.ForeColor = Color.Black;
                    this.BackColor = Color.White;
                    break;
                default:
                    break;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}