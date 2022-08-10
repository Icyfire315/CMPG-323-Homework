//Sarah Masu 32850123
//Form 1
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Creative_I_DO
{
    public partial class fmFlorists : Form
    {
        public fmFlorists()
        {
            InitializeComponent();
            columnHeader();
        }

        string colunmns = "{0,0}\t{1,-15}\t{2,-25}\t{3,-20}\t{4,-10}\t{5,-10}\t{6,-20}\t{7,-10}";
        string headings = "{0,0}\t{1,-15}\t{2,-25}\t{3,-20}\t{4,-10}\t{5,-10}\t{6,-20}\t{7,-10}";

        private void columnHeader()
        {
            listPlants.Items.Clear();
            listPlants.Items.Add(string.Format(headings, "Order", "No.", "Name", "Total", "Qty", "P/D", "Payment", "Address"));
        }

        private void fmFlorists_Load(object sender, EventArgs e)
        {
            string openMsg = "Welcome to Budding Florist\nWould you like to make an order?";
            string openTitle = "Welcome!";
            MessageBoxButtons btnOpen = MessageBoxButtons.YesNo;
            DialogResult openRes = MessageBox.Show(openMsg, openTitle, btnOpen);

            if (openRes == DialogResult.No)
            {
                MessageBox.Show("We hope to see you again.");
                Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int plantNum = int.Parse(txtNum.Text);
                int qty = int.Parse(txtQuantity.Text);
                int orderNum;

                decimal price;

                string address = txtAddress.Text;
                string pay = cboPayment.Items[cboPayment.SelectedIndex].ToString();
                string fetch = cboP_or_D.Items[cboP_or_D.SelectedIndex].ToString();

                Random rand = new Random();
                orderNum = rand.Next(100, 1000);

                if (decimal.TryParse(txtPrice.Text, out price))
                {
                    if (price >= 10.00m)
                    {
                        
                        if (plantNum > 0 && plantNum < 10)
                        {
                            if (fetch == "Pick up")
                            {
                                address = " - ";
                                plantSwitch(orderNum, plantNum, qty, fetch, pay, address);
                            }

                            else
                            {
                                plantSwitch(orderNum, plantNum, qty, fetch, pay, address);
                            }
                        }
                    }
                    else
                        MessageBox.Show("The quantity cannot be smaller than 10");
                }

                else
                {
                    MessageBox.Show("Please use decimal data types.");
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Please use the correct data type.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                listPlants.Items.RemoveAt(listPlants.SelectedIndex);
            }

            catch
            {
                MessageBox.Show("Please select an item from the list you wish to remove.");
            }
        }

        private decimal CalcPay(int quantity, decimal price)
        {
            const decimal VAT = 0.15m;
            decimal total = Math.Round(((quantity * price)*VAT), 2);
            return total;
        }
        
        private int plantSwitch(int orderNum, int plantNum, int qty , string fetch, string pay, string address)
        {
            int num = plantNum;
            decimal price = decimal.Parse(txtPrice.Text);
            decimal total = CalcPay(qty, price);
                switch (num)
                {
                    case 1:
                        listPlants.Items.Add(string.Format(colunmns, orderNum, plantNum, "African Daisy", total.ToString("C"), qty, fetch, pay, address));
                        break;
                    case 2:
                        listPlants.Items.Add(string.Format(colunmns, orderNum, plantNum, "Baby's Breath", total.ToString("C"), qty, fetch, pay, address)); 
                        break;
                    case 3:
                        listPlants.Items.Add(string.Format(colunmns, orderNum, plantNum, "Desert Rose", total.ToString("C"), qty, fetch, pay, address)); 
                        break;
                    case 4:
                        listPlants.Items.Add(string.Format(colunmns, orderNum, plantNum, "English BlueBell", total.ToString("C"), qty, fetch, pay, address)); 
                        break;
                    case 5:
                        listPlants.Items.Add(string.Format(colunmns, orderNum, plantNum, "Forget-Me-Nots", total.ToString("C"), qty, fetch, pay, address)); 
                        break;
                    case 6:
                        listPlants.Items.Add(string.Format(colunmns, orderNum, plantNum, "Gerbera", total.ToString("C"), qty, fetch, pay, address)); 
                        break;
                    case 7:
                        listPlants.Items.Add(string.Format(colunmns, orderNum, plantNum, "Hisbiscus", total.ToString("C"), qty, fetch, pay, address)); 
                        break;
                    case 8:
                        listPlants.Items.Add(string.Format(colunmns, orderNum, plantNum, "Red Coranation", total.ToString("C"), qty, fetch, pay, address));
                        break;
                    case 9:
                        listPlants.Items.Add(string.Format(colunmns, orderNum, plantNum, "SnapDragons", total.ToString("C"), qty, fetch, pay, address));
                        break;
                    default:
                        MessageBox.Show("Please see the list of flowers next to the group box.");
                        break;
                }
            
            return num;
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtAddress.Clear();

            cboPayment.SelectedIndex = -1;
            cboP_or_D.SelectedIndex = -1;

            txtNum.Focus();

            lblSelected.Text = "?";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtAddress.Clear();

            cboPayment.SelectedIndex = -1;
            cboP_or_D.SelectedIndex = -1;

            txtNum.Focus();

            lblSelected.Text = "?";
            columnHeader();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            StreamWriter listWrite;
            try
            {
                if (saveOrders.ShowDialog() == DialogResult.OK)
                {
                    string path = saveOrders.FileName;

                    listWrite = File.CreateText(path);

                    foreach (var item in listPlants.Items)
                    {
                        listWrite.WriteLine(item.ToString());
                    }

                    listWrite.Close();

                    MessageBox.Show("Save successful!");
                }

                else
                {
                    MessageBox.Show("Error: save unsuccessful.");
                }
            }

            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            StreamWriter listAppend;

            try
            {
                if (saveOrders.ShowDialog() == DialogResult.OK)
                {
                    string path = saveOrders.FileName;

                    listAppend = File.AppendText(path);

                    listAppend.WriteLine(listPlants.SelectedItem);

                    listAppend.Close();
                    MessageBox.Show("Save successful!");
                }

                else
                    MessageBox.Show("Error: unable to append.");
            }

            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            StreamReader listRead;
            listPlants.Items.Clear();
            try
            {
                if (openOrders.ShowDialog() == DialogResult.OK)
                {
                    string path = openOrders.FileName;
                    listRead = File.OpenText(path);

                    while (!listRead.EndOfStream)
                    {
                        listPlants.Items.Add(listRead.ReadLine());
                    }

                    listRead.Close();

                    MessageBox.Show("File opened!");
                }

                else
                {
                    MessageBox.Show("Error: unable to open.");
                }

            }

            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string closeMsg = "Are you sure you want to close the program?";
            string closeTitle = "Warning!";
            MessageBoxButtons closeBtn = MessageBoxButtons.YesNo;
            DialogResult closeRes = MessageBox.Show(closeMsg, closeTitle, closeBtn);

            if(closeRes == DialogResult.Yes)
            {
                MessageBox.Show("Hope to see you soon!");
                Close();
            }    
        }

        private void cboxT_and_C_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listPlants_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelected.Text = listPlants.Text;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {

                int plantNum = int.Parse(txtNum.Text);
                int qty = int.Parse(txtQuantity.Text);
                int orderNum;

                Random rand = new Random();
                orderNum = rand.Next(100, 1000);
               
                displayPlant(orderNum, plantNum, qty);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void displayPlant(int order, int plantNum, int qty)
        {
            fmReciept bill = new fmReciept();
            int num = plantNum;
            decimal price = decimal.Parse(txtPrice.Text);
            const decimal VAT = 0.15m;
            decimal vatTotal = Math.Round((VAT * price),2);
            decimal total = CalcPay(qty, price);
            switch (num)
            {
                case 1:
                    bill.lblNumber.Text = plantNum.ToString();
                    bill.lblName.Text = "Afican Daisy";
                    bill.lblQuantity.Text = qty.ToString();
                    bill.lblPrice.Text = price.ToString("c");
                    bill.lblVAT.Text = vatTotal.ToString("c");
                    bill.lblTotal.Text = total.ToString("c");
                    bill.lblOrder.Text = order.ToString();
                    break;
                case 2:
                    bill.lblNumber.Text = plantNum.ToString();
                    bill.lblName.Text = "Baby's Breath";
                    bill.lblQuantity.Text = qty.ToString();
                    bill.lblPrice.Text = price.ToString("c");
                    bill.lblVAT.Text = vatTotal.ToString("c");
                    bill.lblTotal.Text = total.ToString("c");
                    bill.lblOrder.Text = order.ToString();
                    break;
                case 3:
                    bill.lblNumber.Text = plantNum.ToString();
                    bill.lblName.Text = "Desert Rose";
                    bill.lblQuantity.Text = qty.ToString();
                    bill.lblPrice.Text = price.ToString("c");
                    bill.lblVAT.Text = vatTotal.ToString("c");
                    bill.lblTotal.Text = total.ToString("c");
                    bill.lblOrder.Text = order.ToString();
                    break;
                case 4:
                    bill.lblNumber.Text = plantNum.ToString();
                    bill.lblName.Text = "English BlueBell";
                    bill.lblQuantity.Text = qty.ToString();
                    bill.lblPrice.Text = price.ToString("c");
                    bill.lblVAT.Text = vatTotal.ToString("c");
                    bill.lblTotal.Text = total.ToString("c");
                    bill.lblOrder.Text = order.ToString();
                    break;
                case 5:
                    bill.lblNumber.Text = plantNum.ToString();
                    bill.lblName.Text = "Forget-Me-Nots";
                    bill.lblQuantity.Text = qty.ToString();
                    bill.lblPrice.Text = price.ToString("c");
                    bill.lblVAT.Text = vatTotal.ToString("c");
                    bill.lblTotal.Text = total.ToString("c");
                    bill.lblOrder.Text = order.ToString();
                    break;
                case 6:
                    bill.lblNumber.Text = plantNum.ToString();
                    bill.lblName.Text = "Gerbera";
                    bill.lblQuantity.Text = qty.ToString();
                    bill.lblPrice.Text = price.ToString("c");
                    bill.lblVAT.Text = vatTotal.ToString("c");
                    bill.lblTotal.Text = total.ToString("c");
                    break;
                case 7:
                    bill.lblNumber.Text = plantNum.ToString();
                    bill.lblName.Text = "Hisbiscus";
                    bill.lblQuantity.Text = qty.ToString();
                    bill.lblPrice.Text = price.ToString("c");
                    bill.lblVAT.Text = vatTotal.ToString("c");
                    bill.lblTotal.Text = total.ToString("c");
                    bill.lblOrder.Text = order.ToString();
                    break;
                case 8:
                    bill.lblNumber.Text = plantNum.ToString();
                    bill.lblName.Text = "Red Coranation";
                    bill.lblQuantity.Text = qty.ToString();
                    bill.lblPrice.Text = price.ToString("c");
                    bill.lblVAT.Text = vatTotal.ToString("c");
                    bill.lblTotal.Text = total.ToString("c");
                    bill.lblOrder.Text = order.ToString();
                    break;
                case 9:
                    bill.lblNumber.Text = plantNum.ToString();
                    bill.lblName.Text = "SnapDragons";
                    bill.lblQuantity.Text = qty.ToString();
                    bill.lblPrice.Text = price.ToString("c");
                    bill.lblVAT.Text = vatTotal.ToString("c");
                    bill.lblTotal.Text = total.ToString("c");
                    bill.lblOrder.Text = order.ToString();
                    break;
                default:
                    MessageBox.Show("Please see the list of flowers next to the group box.");
                    break;
            }
            bill.ShowDialog();
        }

        private void cboPayment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
