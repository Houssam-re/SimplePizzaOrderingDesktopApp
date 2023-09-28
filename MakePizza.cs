using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class MakePizza : Form
    {
        public MakePizza()
        {
           
            InitializeComponent();

        }
        float CalculateSizePrice()
        {
            if(btnSmallSize.Checked) 
            {
                return Convert.ToSingle(btnSmallSize.Tag);
            }
            else if (btnLargeSize.Checked) 
            {
                return Convert.ToSingle(btnLargeSize.Tag);
            }
            else
                return Convert.ToSingle(btnMeduimSize.Tag);
        }
        float CalculateToppingsPrice()
        {
            float ToppingsPrice = 0;
            if(chkExtraChees.Checked) 
            {
                ToppingsPrice += Convert.ToSingle(chkExtraChees.Tag);
               
            }
            if(chkOlives.Checked) 
            {
                ToppingsPrice += Convert.ToSingle(chkOlives.Tag);
            }
            if(chkOnion.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkOnion.Tag);
            }
            if(chkTomatoes.Checked) 
            {
                ToppingsPrice += Convert.ToSingle(chkTomatoes.Tag);
            }
            if(chkMushrooms.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkMushrooms.Tag);
            }
            if(chkGreenPeppers.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }
            return ToppingsPrice;
        }
        float CalculateCrustPrice()
        {
            float CrustPrice = 0;
            if(btnThinCrust.Checked) 
            {
                CrustPrice += Convert.ToSingle(btnThinCrust.Tag);
            }
            else if(btnThinkCrust.Checked)
            {
                CrustPrice += Convert.ToSingle(btnThinkCrust.Tag);
            }
            return CrustPrice;
        }


        float TotalePrice ()
        {
            return CalculateSizePrice() + CalculateToppingsPrice()+ CalculateCrustPrice();
        }
        void UpdatePrice()
        {
            lblTotalePrice.Text = "$" + TotalePrice().ToString();
        }

        void UpdateToppings()
        {
            UpdatePrice();

            string sToppings = "";

            if (chkExtraChees.Checked)
            {
                sToppings = "Extra Chees";
            }


            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatos";
            }

            if (chkGreenPeppers.Checked)
            {
                sToppings += ", Green Peppars";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            GrToppings.Text = sToppings;

        }
        private void btnSmallSize_CheckedChanged(object sender, EventArgs e)
        {
           UpdatePrice();
        }

        private void btnMeduimSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();

        }
       
        private void btnLargeSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();

        }

        private void btnThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void btnThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void btnEatIn_CheckedChanged(object sender, EventArgs e)
        {
            LbEat.Text = "Eat In";
        }

        private void BtnTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            LbEat.Text = "Take Out";
        }

        private void Btn_OrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirme Your Ordre,", "Confirme",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                GrbToppings.Enabled = false;
                GrbCrustType.Enabled = false;
                chkPizzaSize.Enabled = false;
                GrbEWhereToEat.Enabled = false;
                Btn_OrderPizza.Enabled = false;
            }
            else
            {
                MessageBox.Show("Update Your Order", "Update", MessageBoxButtons.OK);
            }
        }

   
        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
          UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void MakePizza_Load(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void Btn_ResetForm_Click(object sender, EventArgs e)
        {
            UpdatePrice();
            GrbToppings.Enabled = true;
            GrbCrustType.Enabled = true;
            chkPizzaSize.Enabled = true;
            GrbEWhereToEat.Enabled = true;
            Btn_OrderPizza.Enabled = true;
            btnSmallSize.Checked = true;
            btnThinCrust.Checked = true;
            BtnTakeOut.Checked = true;
            chkExtraChees.Checked = false;
            chkGreenPeppers.Checked = false;
            chkTomatoes.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
        }
    }
}
