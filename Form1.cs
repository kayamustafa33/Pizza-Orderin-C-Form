using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assigment
{
    public partial class Form1 : Form
    {

        Food Sicilian = new Food("Sicilian", 100, 27.5);
        Food Marine = new Food("Marine", 125, 28.5);
        Food Napoliten = new Food("Napoliten", 125, 30.0);
        Food Mixed = new Food("Mixed", 140, 27.5);
        Food GreenPepper  = new Food("Green Pepper", 15, 2.25);
        Food Tomato = new Food("Tomato", 10, 1.25);
        Food Pickle = new Food("Pickle", 25, 2.35);
        Food Mushroom = new Food("Mushroom", 40, 2.75);
        Food Olive = new Food("Olive", 10, 0.70);

        private string pizzaType = "";
        private string orderingType = "";

        private double totalPrice = 0.0;
        private double unitPrice = 0.0;
        private int totalCalorie = 0;

        public Form1()
        {
            InitializeComponent();
            disableAttr();
            orderListView.Columns.Add("Pizza");
            orderListView.Columns.Add("# Of Unit");
            orderListView.Columns.Add("Unit Price");
            orderListView.Columns.Add("Total");
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {

           
            
            ListViewItem item = new ListViewItem(pizzaType+"("+orderingType+")");
            item.SubItems.Add(Convert.ToString(ofUnitSpinText.Value));
            item.SubItems.Add(unitPriceText.Text.ToString());
            item.SubItems.Add(totalText.Text.ToString());

            orderListView.Items.Add(item);
            insertBtn.Enabled = false;
            newOrderBtn.Enabled = true;
            deleteBtn.Enabled = true;
            addGrandTotal();

            deleteAttr();


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            for (int i = orderListView.SelectedItems.Count - 1; i >= 0; i--)
            {
                orderListView.SelectedItems[i].Remove();
            }

            addGrandTotal();

        }

        private void newOrderBtn_Click(object sender, EventArgs e)
        {


            deleteAttr();
        }

        private void newCustomerBtn_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show(nameSurnameText.Text.ToString()+"\n Total Price: "+grandTotalText.Text.ToString(), "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                nameSurnameText.Clear();
                addressText.Clear();

                deleteAttr();

                foreach (ListViewItem item in orderListView.Items)
                {
                    orderListView.Items.Remove(item);
                }
            }
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customerInformationChanged(object sender, EventArgs e)
        {
            if (!nameSurnameText.Text.Equals("") && !addressText.Text.Equals(""))
            {

                enableAttr();

            }

            if (nameSurnameText.Text.Equals("") || addressText.Text.Equals(""))
            {
                disableAttr();
            }

            if (!string.IsNullOrEmpty(nameSurnameText.Text) || !string.IsNullOrEmpty(addressText.Text))
            {
                string[] nameWords = nameSurnameText.Text.Split(' ');
                string[] addressWords = addressText.Text.Split(' ');

                for (int i = 0; i < nameWords.Length; i++)
                {
                    if (nameWords[i].Length > 0)
                    {
                        nameWords[i] = nameWords[i].Substring(0, 1).ToUpper() + nameWords[i].Substring(1);
                    }
                }

                for (int i = 0; i < addressWords.Length; i++)
                {
                    if (addressWords[i].Length > 0)
                    {
                        addressWords[i] = addressWords[i].Substring(0, 1).ToUpper() + addressWords[i].Substring(1);
                    }
                }

                nameSurnameText.Text = string.Join(" ", nameWords);
                nameSurnameText.Select(nameSurnameText.Text.Length, 0);

                addressText.Text = string.Join(" ", addressWords);
                addressText.Select(addressText.Text.Length, 0);

            }

        }
            private void enableAttr()
        {
            pizzaTypesGroupBox.Enabled = true;
            
        }

        private void disableAttr()
        {
            pizzaTypesGroupBox.Enabled = false;
            additionGroupBox.Enabled = false;
            lastGroupBox.Enabled = false;
            orderListView.Enabled = false;
            insertBtn.Enabled = false;
            deleteBtn.Enabled = false;
            newOrderBtn.Enabled = false;            
        }

        

        private void ofUnitSpinText_ValueChanged(object sender, EventArgs e)
        {
            
           //calculate related variables for the textBox
           totalPrice = unitPrice * Convert.ToDouble(ofUnitSpinText.Value);
           totalText.Text = totalPrice.ToString();

           
           calorieText.Text = (totalCalorie * Convert.ToInt32(ofUnitSpinText.Value)).ToString();

        }

        private void addGrandTotal()
        {
            double total = 0.0;
            if (orderListView.Items.Count != 0)
            {
                foreach (ListViewItem item in orderListView.Items)
                {
                    
                    total += double.Parse(item.SubItems[3].Text);
                    grandTotalText.Text = total.ToString();
                }
            }
            else
            {
                total = 0.0;
                grandTotalText.Text = total.ToString();
            }
        }

        private void greenPeperBox_CheckedChanged(object sender, EventArgs e)
        {
            if (greenPeperBox.Checked)
            {
                unitPrice += GreenPepper.Price;
                totalCalorie += GreenPepper.Calories;
                orderingType += "G ";
            }else
            {
                unitPrice -= GreenPepper.Price;
                totalCalorie -= GreenPepper.Calories;
                orderingType = orderingType.Replace("G ", "");
            }

            unitPriceText.Text = unitPrice.ToString();
            calorieText.Text = totalCalorie.ToString();
            totalPrice = unitPrice * Convert.ToDouble(ofUnitSpinText.Value);
            totalText.Text = totalPrice.ToString();

        }

        private void tomatoBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tomatoBox.Checked)
            {
                unitPrice += Tomato.Price;
                totalCalorie += Tomato.Calories;
                orderingType += "T ";
            }
            else
            {
                unitPrice -= Tomato.Price;
                totalCalorie -= Tomato.Calories;
                orderingType = orderingType.Replace("T ", "");
            }

            unitPriceText.Text = unitPrice.ToString();
            calorieText.Text = totalCalorie.ToString();
            totalPrice = unitPrice * Convert.ToDouble(ofUnitSpinText.Value);
            totalText.Text = totalPrice.ToString();
        }

        private void pickleBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pickleBox.Checked)
            {
                unitPrice += Pickle.Price;
                totalCalorie += Pickle.Calories;
                orderingType += "P ";
            }
            else
            {
                unitPrice -= Pickle.Price;
                totalCalorie -= Pickle.Calories;
                orderingType = orderingType.Replace("P ", "");
            }

            unitPriceText.Text = unitPrice.ToString();
            calorieText.Text = totalCalorie.ToString();
            totalPrice = unitPrice * Convert.ToDouble(ofUnitSpinText.Value);
            totalText.Text = totalPrice.ToString();
        }

        private void mushroomBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mushroomBox.Checked)
            {
                unitPrice += Mushroom.Price;
                totalCalorie += Mushroom.Calories;
                orderingType += "M ";
            }
            else
            {
                unitPrice -= Mushroom.Price;
                totalCalorie -= Mushroom.Calories;
                orderingType = orderingType.Replace("M ", "");
            }

            unitPriceText.Text = unitPrice.ToString();
            calorieText.Text = totalCalorie.ToString();
            totalPrice = unitPrice * Convert.ToDouble(ofUnitSpinText.Value);
            totalText.Text = totalPrice.ToString();

        }

        private void oliveBox_CheckedChanged(object sender, EventArgs e)
        {
            if (oliveBox.Checked)
            {
                unitPrice += Olive.Price;
                totalCalorie += Olive.Calories;
                orderingType += "O ";
            }
            else
            {
                unitPrice -= Olive.Price;
                totalCalorie -= Olive.Calories;
                orderingType = orderingType.Replace("O ", "");
            }

            unitPriceText.Text = unitPrice.ToString();
            calorieText.Text = totalCalorie.ToString();
            totalPrice = unitPrice * Convert.ToDouble(ofUnitSpinText.Value);
            totalText.Text = totalPrice.ToString();

        }

        

        private void sicilianRadioBtn_Click(object sender, EventArgs e)
        {
            if (sicilianRadioBtn.Checked)
            {
                unitPrice = Sicilian.Price;
                totalCalorie = Sicilian.Calories;
                pizzaType = Sicilian.Name;
                pictureBox.Image = imageList.Images[3];

                resetAdditions();
                unitPriceText.Text = unitPrice.ToString();
                calorieText.Text = totalCalorie.ToString();
                totalPrice = unitPrice * Convert.ToDouble(ofUnitSpinText.Value);
                totalText.Text = totalPrice.ToString();
            }
          
        }

        private void marineRadioBtn_Click(object sender, EventArgs e)
        {
            if (marineRadioBtn.Checked)
            {
                unitPrice = Marine.Price;
                totalCalorie = Marine.Calories;
                pizzaType = Marine.Name;
                pictureBox.Image = imageList.Images[0];

                resetAdditions();
                unitPriceText.Text = unitPrice.ToString();
                calorieText.Text = totalCalorie.ToString();
                totalPrice = unitPrice * Convert.ToDouble(ofUnitSpinText.Value);
                totalText.Text = totalPrice.ToString();
            }
        }

        private void napolitenRadioBtn_Click(object sender, EventArgs e)
        {
            if (napolitenRadioBtn.Checked)
            {
                unitPrice = Napoliten.Price;
                totalCalorie = Napoliten.Calories;
                pizzaType = Napoliten.Name;
                pictureBox.Image = imageList.Images[2];

                resetAdditions();
                unitPriceText.Text = unitPrice.ToString();
                calorieText.Text = totalCalorie.ToString();
                totalPrice = unitPrice * Convert.ToDouble(ofUnitSpinText.Value);
                totalText.Text = totalPrice.ToString();
            }
        }

        private void mixedRadioBtn_Click(object sender, EventArgs e)
        {
            if (mixedRadioBtn.Checked)
            {
                unitPrice = Mixed.Price;
                totalCalorie = Mixed.Calories;
                pizzaType = Mixed.Name;
                pictureBox.Image = imageList.Images[1];

                resetAdditions();
                unitPriceText.Text = unitPrice.ToString();
                calorieText.Text = totalCalorie.ToString();
                totalPrice = unitPrice * Convert.ToDouble(ofUnitSpinText.Value);
                totalText.Text = totalPrice.ToString();
            }
        }

        private void resetAdditions()
        {
            greenPeperBox.Checked = false;
            tomatoBox.Checked = false;
            pickleBox.Checked = false;
            mushroomBox.Checked = false;
            oliveBox.Checked = false;
            additionGroupBox.Enabled = true;
            lastGroupBox.Enabled = true;
            orderListView.Enabled = true;
            insertBtn.Enabled = true;
        }

        private void deleteAttr()
        {
            sicilianRadioBtn.Checked = false;
            marineRadioBtn.Checked = false;
            mixedRadioBtn.Checked = false;
            napolitenRadioBtn.Checked = false;
            greenPeperBox.Checked = false;
            tomatoBox.Checked = false;
            pickleBox.Checked = false;
            mushroomBox.Checked = false;
            oliveBox.Checked = false;
            additionGroupBox.Enabled = false;
            unitPriceText.Text = "0";
            ofUnitSpinText.Value = 1;
            totalText.Text = "0";
            calorieText.Text = "0";
            lastGroupBox.Enabled = false;
            pizzaTypesGroupBox.Enabled = false;
            totalCalorie = 0;
            totalPrice = 0.0;
            unitPrice = 0.0;
        }

        private void nameSurnameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                this.SelectNextControl((Control)sender, true, true, true, true); 
            }
        }
    }
}
