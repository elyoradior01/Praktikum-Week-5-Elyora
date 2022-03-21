using System.Text;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_Week_5_Elyora
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            

            if (listBoxKoleksi.Items.Contains(txtBoxIsi.Text))
            {
                MessageBox.Show("Input Kembar");
            }
            else
            {
                listBoxKoleksi.Items.Add(txtBoxIsi.Text);
            }

        }

        private void lblOutput_Click(object sender, EventArgs e)
        {
            
        }

        private void listBoxKoleksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblOutput.Text = listBoxKoleksi.SelectedItem.ToString();

            
        }

        private void CheckBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBoxAktif.Checked == true)
            {
                if(RadioButtonMerah.Checked)
                {
                    lblOutput.ForeColor = Color.Red;
                }
                else if(RadioButtonBiru.Checked)
                {
                    lblOutput.ForeColor = Color.Blue;
                }
                
            }
            else
            {
                    lblOutput.ForeColor = Color.Black;
            }
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            txtBoxIsi.Text = "";
            listBoxKoleksi.Items.Clear();
            CheckBoxAktif.Checked = false;
            RadioButtonMerah.Checked = true;
            RadioButtonBiru.Checked = false;
            lblOutput.Text = "label2";
            
        }

        private void RadioButtonMerah_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxAktif.Checked == true)
            {
                if (RadioButtonMerah.Checked)
                {
                    lblOutput.ForeColor = Color.Red;
                }
                else if (RadioButtonBiru.Checked)
                {
                    lblOutput.ForeColor = Color.Blue;
                }
                
            }
            else
            {
                    lblOutput.ForeColor = Color.Black;
            }
        }

        private void RadioButtonBiru_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxAktif.Checked== true)
            {
                if (RadioButtonMerah.Checked)
                {
                    lblOutput.ForeColor = Color.Red;
                }
                else if (RadioButtonBiru.Checked)
                {
                    lblOutput.ForeColor = Color.Blue;
                }
                
            }
            else
            {
                    lblOutput.ForeColor = Color.Black;
            }
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            RadioButtonMerah.Checked = true;
        }
    }
}