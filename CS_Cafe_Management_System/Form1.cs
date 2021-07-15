using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Cafe_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            
            txtLattle.Text = "0";
            txtEspresso.Text = "0";
            txtIcedLattle.Text = "0";
            txtVale.Text = "0";
            txtCappuccino.Text = "0";
            txtAfrican.Text = "0";
            txtAmerican.Text = "0";
            txtIcedCappu.Text = "0";

            txtCoffeC.Text = "0";
            txtRedC.Text = "0";
            txtBlackC.Text = "0";
            txtBostonC.Text = "0";
            txtLagosC.Text = "0";
            txtKilburnC.Text = "0";
            txtCarltonC.Text = "0";
            txtQueenC.Text = "0";

            lblCostDrinks.Text = "0";
            lblCostCakes.Text = "0";
            lblServiceCharge.Text = "1.75";
            lblSubTotal.Text = "0";
            lblTax.Text = "0";
            lblTotal.Text = "0";

            txtLattle.Enabled = false;
            txtEspresso.Enabled = false;
            txtIcedLattle.Enabled = false;
            txtVale.Enabled = false;
            txtCappuccino.Enabled = false;
            txtAfrican.Enabled = false;
            txtAmerican.Enabled = false;
            txtIcedCappu.Enabled = false;

            txtCoffeC.Enabled = false;
            txtRedC.Enabled = false;
            txtBlackC.Enabled = false;
            txtBostonC.Enabled = false;
            txtLagosC.Enabled = false;
            txtKilburnC.Enabled = false;
            txtCarltonC.Enabled = false;
            txtQueenC.Enabled = false;



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }


        
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLattle.Text = "0";
            txtEspresso.Text = "0";
            txtIcedLattle.Text = "0";
            txtVale.Text = "0";
            txtCappuccino.Text = "0";
            txtAfrican.Text = "0";
            txtAmerican.Text = "0";
            txtIcedCappu.Text = "0";

            txtCoffeC.Text = "0";
            txtRedC.Text = "0";
            txtBlackC.Text = "0";
            txtBostonC.Text = "0";
            txtLagosC.Text = "0";
            txtKilburnC.Text = "0";
            txtCarltonC.Text = "0";
            txtQueenC.Text = "0";

            lblCostDrinks.Text = "0";
            lblCostCakes.Text = "0";
            lblServiceCharge.Text = "1.75";
            lblSubTotal.Text = "0";
            lblTax.Text = "0";
            lblTotal.Text = "0";

            chkLattle.Checked = false;
            chkEspresso.Checked = false;
            chkIced_Lattle.Checked = false;
            chkVale_Cof.Checked = false;
            chkCappuccino.Checked = false;
            chkAfrican_Cof.Checked = false;
            chkAmerican_Cof.Checked = false;
            chkIced_Capu.Checked = false;

            chkCoffee_Cake.Checked = false;
            chkRed_Vel_Cake.Checked = false;
            chkBlack_Fo_Cake.Checked = false;
            chkBoston_Cre_Cake.Checked = false;
            chkLagos_Choco_Cake.Checked = false;
            chkKilburn_Choco_Cake.Checked = false;
            chkCarlton_Choco_Cake.Checked = false;
            chkQueen_Choco_Cake.Checked = false;


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void chkLattle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLattle.Checked == true)
            {
                txtLattle.Enabled = true;
            }
            else
            {
                txtLattle.Enabled = false;
                txtLattle.Text = "0";
            }
        }

        private void chkEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEspresso.Checked == true)
            {
                txtEspresso.Enabled = true;
            }
            else
            {
                txtEspresso.Enabled = false;
                txtEspresso.Text = "0";
            }
        }

        private void chkIced_Lattle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIced_Lattle.Checked == true)
            {
                txtIcedLattle.Enabled = true;
            }
            else
            {
                txtIcedLattle.Enabled = false;
                txtIcedLattle.Text = "0";
            }
        }

        private void chkVale_Cof_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVale_Cof.Checked == true)
            {
                txtVale.Enabled = true;
            }
            else
            {
                txtVale.Enabled = false;
                txtVale.Text = "0";
            }
        }

        private void chkCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCappuccino.Checked == true)
            {
                txtCappuccino.Enabled = true;
            }
            else
            {
                txtCappuccino.Enabled = false;
                txtCappuccino.Text = "0";
            }
        }

        private void chkAfrican_Cof_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAfrican_Cof.Checked == true)
            {
                txtAfrican.Enabled = true;
            }
            else
            {
                txtAfrican.Enabled = false;
                txtAfrican.Text = "0";
            }
        }

        private void chkAmerican_Cof_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAmerican_Cof.Checked == true)
            {
                txtAmerican.Enabled = true;
            }
            else
            {
                txtAmerican.Enabled = false;
                txtAmerican.Text = "0";
            }
        }

        private void chkIced_Capu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIced_Capu.Checked == true)
            {
                txtIcedCappu.Enabled = true;
            }
            else
            {
                txtIcedCappu.Enabled = false;
                txtIcedCappu.Text = "0";
            }
        }



        private void chkCoffee_Cake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffee_Cake.Checked == true)
            {
                txtCoffeC.Enabled = true;
            }
            else
            {
                txtCoffeC.Enabled = false;
                txtCoffeC.Text = "0";
            }
        }

        private void chkRed_Vel_Cake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRed_Vel_Cake.Checked == true)
            {
                txtRedC.Enabled = true;
            }
            else
            {
                txtRedC.Enabled = false;
                txtRedC.Text = "0";
            }
        }

        private void chkBlack_Fo_Cake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlack_Fo_Cake.Checked == true)
            {
                txtBlackC.Enabled = true;
            }
            else
            {
                txtBlackC.Enabled = false;
                txtBlackC.Text = "0";
            }
        }

        private void chkBoston_Cre_Cake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoston_Cre_Cake.Checked == true)
            {
                txtBostonC.Enabled = true;
            }
            else
            {
                txtBostonC.Enabled = false;
                txtBostonC.Text = "0";
            }
        }

        private void chkLagos_Choco_Cake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLagos_Choco_Cake.Checked == true)
            {
                txtLagosC.Enabled = true;
            }
            else
            {
                txtLagosC.Enabled = false;
                txtLagosC.Text = "0";
            }
        }

        private void chkKilburn_Choco_Cake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKilburn_Choco_Cake.Checked == true)
            {
                txtKilburnC.Enabled = true;
            }
            else
            {
                txtKilburnC.Enabled = false;
                txtKilburnC.Text = "0";
            }
        }

        private void chkCarlton_Choco_Cake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCarlton_Choco_Cake.Checked == true)
            {
                txtCarltonC.Enabled = true;
            }
            else
            {
                txtCarltonC.Enabled = false;
                txtCarltonC.Text = "0";
            }
        }

        private void chkQueen_Choco_Cake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQueen_Choco_Cake.Checked == true)
            {
                txtQueenC.Enabled = true;
            }
            else
            {
                txtQueenC.Enabled = false;
                txtQueenC.Text = "0";
            }
        }



        private void txtLattle_TextChanged(object sender, EventArgs e)
        {

        }

        
        
        private void txtLattle_Click(object sender, EventArgs e)
        {
            txtLattle.Text = "";
            txtLattle.Focus();
        }

        private void txtEspresso_Click(object sender, EventArgs e)
        {
            txtEspresso.Text = "";
            txtEspresso.Focus();
        }

        private void txtIcedLattle_Click(object sender, EventArgs e)
        {
            txtIcedLattle.Text = "";
            txtIcedLattle.Focus();
        }

        private void txtVale_Click(object sender, EventArgs e)
        {
            txtVale.Text = "";
            txtVale.Focus();
        }

        private void txtCappuccino_Click(object sender, EventArgs e)
        {
            txtCappuccino.Text = "";
            txtCappuccino.Focus();
        }

        private void txtAfrican_Click(object sender, EventArgs e)
        {
            txtAfrican.Text = "";
            txtAfrican.Focus();
        }

        private void txtAmerican_Click(object sender, EventArgs e)
        {
            txtAmerican.Text = "";
            txtAmerican.Focus();
        }

        private void txtIcedCappu_Click(object sender, EventArgs e)
        {
            txtIcedCappu.Text = "";
            txtIcedCappu.Focus();
        }

        private void txtCoffeC_Click(object sender, EventArgs e)
        {
            txtCoffeC.Text = "";
            txtCoffeC.Focus();
        }

        private void txtRedC_Click(object sender, EventArgs e)
        {
            txtRedC.Text = "";
            txtRedC.Focus();
        }

        private void txtBlackC_Click(object sender, EventArgs e)
        {
            txtBlackC.Text = "";
            txtBlackC.Focus();
        }

        private void txtBostonC_Click(object sender, EventArgs e)
        {
            txtBostonC.Text = "";
            txtBostonC.Focus();
        }

        private void txtLagosC_Click(object sender, EventArgs e)
        {
            txtLagosC.Text = "";
            txtLagosC.Focus();
        }

        private void txtKilburnC_Click(object sender, EventArgs e)
        {
            txtKilburnC.Text = "";
            txtKilburnC.Focus();
        }

        private void txtCarltonC_Click(object sender, EventArgs e)
        {
            txtCarltonC.Text = "";
            txtCarltonC.Focus();
        }

        private void txtQueenC_Click(object sender, EventArgs e)
        {
            txtQueenC.Text = "";
            txtQueenC.Focus();
        }

        
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            //This Code will open text files
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.text)|*.text|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtfReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //This Code will Save text files
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.text)|*.text|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();

            rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("\t\t" + " Just Dock Cafe " + Environment.NewLine);
            rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);

            rtfReceipt.AppendText(" Latte \t\t\t\t\t" + txtLattle.Text + Environment.NewLine);
            rtfReceipt.AppendText(" Espresso \t\t\t\t" + txtEspresso.Text + Environment.NewLine);
            rtfReceipt.AppendText(" Iced Latte \t\t\t\t" + txtIcedLattle.Text + Environment.NewLine);
            rtfReceipt.AppendText(" Vale Coffee \t\t\t\t" + txtVale.Text + Environment.NewLine);
            rtfReceipt.AppendText(" Cappuccino \t\t\t\t" + txtCappuccino.Text + Environment.NewLine);
            rtfReceipt.AppendText(" African Coffee \t\t\t\t" + txtAfrican.Text + Environment.NewLine);
            rtfReceipt.AppendText(" American Coffee \t\t\t" + txtAmerican.Text + Environment.NewLine);
            rtfReceipt.AppendText(" Iced - Cappuccino \t\t\t" + txtIcedCappu.Text + Environment.NewLine);

            rtfReceipt.AppendText(" Coffee Cake \t\t\t\t" + txtCoffeC.Text + Environment.NewLine);
            rtfReceipt.AppendText(" Red Velvet Cake \t\t\t" + txtRedC.Text + Environment.NewLine);
            rtfReceipt.AppendText(" Black Forest Cake \t\t\t" + txtBlackC.Text + Environment.NewLine);
            rtfReceipt.AppendText(" Boston Cream Cake \t\t\t" + txtBostonC.Text + Environment.NewLine);
            rtfReceipt.AppendText(" Lagos Chocolate Cake \t\t\t" + txtLagosC.Text + Environment.NewLine);
            rtfReceipt.AppendText(" Kilburn Chocolate Cake \t\t\t" + txtKilburnC.Text + Environment.NewLine);
            rtfReceipt.AppendText(" Carlton Hill Chocolate Cake \t\t" + txtCarltonC.Text + Environment.NewLine);
            rtfReceipt.AppendText(" Queen's Park Chocolate Cake \t\t" + txtQueenC.Text + Environment.NewLine);

            rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(" Service Charge \t\t\t         " + lblServiceCharge.Text + Environment.NewLine);
            rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(" Tax \t\t\t\t         " + lblTax.Text + Environment.NewLine);
            rtfReceipt.AppendText(" Sub Total \t\t\t       " + lblSubTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText(" Total \t\t\t\t       " + lblTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(lblTime.Text + "\t" +  lblDate.Text);

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double tax;
            tax = 0.45;
            double Latte, Espresso, iLatte, Vale, Cappu, AfCoffee, AmeCoffee, iCappu;
            double CoffeeC, RedC, BlackC, BostonC, LagosC, KilburnC, CarltonC, QueenC;

            //Drinks
            Latte = 1.20; Espresso = 1.50; iLatte = 1.29; Vale = 1.45; Cappu = 1.60; AfCoffee = 1.50; AmeCoffee = 1.50; iCappu = 1.69;

            double Latte_Coff = Convert.ToDouble(txtLattle.Text);
            double Esp_Coff = Convert.ToDouble(txtEspresso.Text);
            double iLat_Coff = Convert.ToDouble(txtIcedLattle.Text);
            double vale_Coff = Convert.ToDouble(txtVale.Text);
            double cappu_Coff = Convert.ToDouble(txtCappuccino.Text);
            double Af_Coff = Convert.ToDouble(txtAfrican.Text);
            double Ame_Coff = Convert.ToDouble(txtAmerican.Text);
            double iCap_Coff = Convert.ToDouble(txtIcedCappu.Text);

            //Cakes
            CoffeeC = 1.30; RedC = 1.20; BlackC = 1.30; BostonC = 1.90; LagosC = 1.50; KilburnC = 1.40; CarltonC = 1.30; QueenC = 1.10;

            double Coffee_C = Convert.ToDouble(txtCoffeC.Text);
            double Red_C = Convert.ToDouble(txtRedC.Text);
            double Black_C = Convert.ToDouble(txtBlackC.Text);
            double Boston_C = Convert.ToDouble(txtBostonC.Text);
            double Lagos_C = Convert.ToDouble(txtLagosC.Text);
            double Kilburn_C = Convert.ToDouble(txtKilburnC.Text);
            double Carlton_C = Convert.ToDouble(txtCarltonC.Text);
            double Queen_C = Convert.ToDouble(txtQueenC.Text);

            Cafe eat_in_Cafe = new Cafe(Latte_Coff, Esp_Coff, iLat_Coff, vale_Coff, cappu_Coff, Af_Coff, Ame_Coff, iCap_Coff,
                Coffee_C, Red_C, Black_C, Boston_C, Lagos_C, Kilburn_C, Carlton_C, Queen_C);

            double cost_of_drinks = (Latte_Coff * Latte) + (Esp_Coff * Espresso) + (iLat_Coff * iLatte) + (vale_Coff * Vale) + 
                (cappu_Coff * Cappu) + (Af_Coff * AfCoffee) + (Ame_Coff * AmeCoffee) + (iCap_Coff * iCappu);
            lblCostDrinks.Text = Convert.ToString(cost_of_drinks);

            double cost_of_cakes = (Coffee_C * CoffeeC) + (Red_C * RedC) + (Black_C * BlackC) + (Boston_C * BostonC) +
                (Lagos_C * LagosC) + (Kilburn_C * KilburnC) + (Carlton_C * CarltonC) + (Queen_C * QueenC);
            lblCostCakes.Text = Convert.ToString(cost_of_cakes);

            double service_charge = Convert.ToDouble(lblServiceCharge.Text);

            lblSubTotal.Text = Convert.ToString(cost_of_drinks + cost_of_cakes + service_charge);
            lblTax.Text = Convert.ToString(((cost_of_drinks + cost_of_cakes + service_charge) * tax) / 100);
            double iTax = Convert.ToDouble(lblTax.Text);
            lblTotal.Text = Convert.ToString(cost_of_drinks + cost_of_cakes + service_charge + iTax);

            lblCostDrinks.Text = String.Format("{0:C}", cost_of_drinks);
            lblCostCakes.Text = String.Format("{0:C}", cost_of_cakes);
            lblServiceCharge.Text = String.Format("{0:C}", service_charge);
            lblSubTotal.Text = String.Format("{0:C}", (cost_of_drinks + cost_of_cakes + service_charge));
            lblTax.Text = String.Format("{0:C}", iTax);
            lblTotal.Text = String.Format("{0:C}", (cost_of_drinks + cost_of_cakes + service_charge + iTax));

        }
    }
}
