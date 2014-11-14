using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankInterface
{
    public partial class AccountNumberForm : Form
    {
        public int account;
        Users userobj = new Users();
        
        public AccountNumberForm()
        {
            InitializeComponent();
        }


        //#####                           #####
        //##### START ENTER ACCOUNT PANEL #####
        //#####                           #####


        private void accountPad1_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("1");
        }

        private void accountPad2_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("2");
        }

        private void accountPad3_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("3");
        }

        private void accountPad4_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("4");
        }

        private void accountPad5_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("5");
        }

        private void accountPad6_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("6");
        }

        private void accountPad7_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("7");
        }

        private void accountPad8_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("8");
        }

        private void accountPad9_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("9");
        }

        private void accountPad0_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("0");
        }

        private void accountPadOK_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            for (int i = 0; i <Users.accounts.Length ; i++) // fixed; don't use .GetLength, use .Length
            {
               
                if(accountNumberBox.Text.Equals(userobj.getAccountNum(i).ToString()))
                {
                account = i;
                panel1.Visible = false;
                PinPanel.BringToFront();
                PinPanel.Visible = true;
                accountNumberBox.Text = "";
                found = true;
                break;
                }
            }

            if(!found)
            {
                accountNumberBox.Text = "";
                MessageBox.Show("Account not found");
            }

            
        }

        private void accountPadClear_Click(object sender, EventArgs e)
        {
            accountNumberBox.Text = "";
        }

        private void accountBackspace_Click(object sender, EventArgs e)
        {
            if(accountNumberBox.Text.Length >0)
            accountNumberBox.Text = accountNumberBox.Text.Remove((accountNumberBox.Text.Length - 1), 1);
        }

        //#####                       #####
        //##### START ENTER PIN PANEL #####
        //#####                       #####

        private void PinOk_Click(object sender, EventArgs e)
        {
             

                if (PinBox.Text.Equals(userobj.getPinNum(account).ToString()))
                {

                    PinPanel.Visible = false;
                    usermain.BringToFront();
                    PinBox.Text = "";
                    usermain.Visible = true;
                  
                }
            

                else
                {
                   PinBox.Text = "";
                   MessageBox.Show("Incorrect Pin");
                }

            
        }

        private void Pin1_Click(object sender, EventArgs e)
        {
            PinBox.AppendText("1");
        }

        private void Pin2_Click(object sender, EventArgs e)
        {
            PinBox.AppendText("2");
        }

        private void Pin3_Click(object sender, EventArgs e)
        {
            PinBox.AppendText("3");
        }
        private void Pin4_Click(object sender, EventArgs e)
        {
            PinBox.AppendText("4");
        }

        private void Pin5_Click(object sender, EventArgs e)
        {
            PinBox.AppendText("5");
        }

        private void Pin6_Click(object sender, EventArgs e)
        {
            PinBox.AppendText("6");
        }

        private void Pin7_Click(object sender, EventArgs e)
        {
            PinBox.AppendText("7");
        }

        private void Pin8_Click(object sender, EventArgs e)
        {
            PinBox.AppendText("8");
        }

        private void Pin9_Click(object sender, EventArgs e)
        {
            PinBox.AppendText("9");
        }

        private void Pin0_Click(object sender, EventArgs e)
        {
            PinBox.AppendText("0");
        }

        private void PinBack_Click(object sender, EventArgs e)
        {
            if (PinBox.Text.Length > 0)
                PinBox.Text = PinBox.Text.Remove((PinBox.Text.Length - 1), 1);
        }

        private void PinClear_Click(object sender, EventArgs e)
        {
            if (PinBox.Text.Length > 0)
                PinBox.Text = "";
        }

        //#####                       #####
        //##### START MAIN MENU PANEL #####
        //#####                       #####

        private void SignOut_Click(object sender, EventArgs e)
        {
            account = -1;
            panel1.BringToFront();
            usermain.Visible = false;
            panel1.Visible = true;
        }

        private void withdrawbutton_Click(object sender, EventArgs e)
        {
            withdrawpanel.BringToFront();
            usermain.Visible = false;
            withdrawpanel.Visible = true;
        }

        private void depositbutton_Click(object sender, EventArgs e)
        {
            dpanel.BringToFront();
            usermain.Visible = false;
            dpanel.Visible = true;
        }

        private void viewbalance_Click(object sender, EventArgs e)
        {
            viewpanel.BringToFront();
            usermain.Visible = false;
            viewpanel.Visible = true;
        }

        private void transferfunds_Click(object sender, EventArgs e)
        {
            transferpanelacc.BringToFront();
            usermain.Visible = false;
            transferpanelacc.Visible = true;
        }

        //#####                      #####
        //##### START WITHDRAW PANEL #####
        //#####                      #####

        private void withdraw1_Click(object sender, EventArgs e)
        {
            withdrawbox.AppendText("1");
        }

        private void withdraw2_Click(object sender, EventArgs e)
        {
            withdrawbox.AppendText("2");
        }

        private void withdraw3_Click(object sender, EventArgs e)
        {
            withdrawbox.AppendText("3");
        }

        private void withdraw4_Click(object sender, EventArgs e)
        {
            withdrawbox.AppendText("4");
        }

        private void withdraw5_Click(object sender, EventArgs e)
        {
            withdrawbox.AppendText("5");
        }

        private void withdraw6_Click(object sender, EventArgs e)
        {
            withdrawbox.AppendText("6");
        }

        private void withdraw7_Click(object sender, EventArgs e)
        {
            withdrawbox.AppendText("7");
        }

        private void withdraw8_Click(object sender, EventArgs e)
        {
            withdrawbox.AppendText("8");
        }

        private void withdraw9_Click(object sender, EventArgs e)
        {
            withdrawbox.AppendText("9");
        }

        private void withdraw0_Click(object sender, EventArgs e)
        {
            withdrawbox.AppendText("0");
        }

        private void withdrawOk_Click(object sender, EventArgs e)
        {
            int balance = 0;
            if (Convert.ToInt32(withdrawbox.Text)<(userobj.getMoney(account)))
                {
                    userobj.loseMoney(account, Convert.ToInt32(withdrawbox.Text));
                    viewpanel.BringToFront();
                    withdrawpanel.Visible = false;
                    viewbox.Text = "My Balance";
                    withdrawbox.Text = "";
                    viewpanel.Visible = true;
                }

                else
                {
                    balance = userobj.getMoney(account);
                    MessageBox.Show(string.Format ("Insufficient Funds. \nAccount balance: {0}", balance),"Error");
                }
           
            
        }

        private void withdrawclear_Click(object sender, EventArgs e)
        {
            if (withdrawbox.Text.Length > 0)
                withdrawbox.Text = "";
        }

        private void withdrawback_Click(object sender, EventArgs e)
        {
            if (withdrawbox.Text.Length > 0)
               withdrawbox.Text = withdrawbox.Text.Remove((withdrawbox.Text.Length - 1), 1);
        }

        private void wcancel_Click(object sender, EventArgs e)
        {
            withdrawbox.Text = "";
            usermain.BringToFront();
            usermain.Visible = true;
            withdrawpanel.Visible = false;
        }

        //#####                     #####
        //##### START DEPOSIT PANEL #####
        //#####                     #####

        private void d1_Click(object sender, EventArgs e)
        {
            dbox.AppendText("1");
        }

        private void d2_Click(object sender, EventArgs e)
        {
            dbox.AppendText("2");
        }

        private void d3_Click(object sender, EventArgs e)
        {
            dbox.AppendText("3");
        }

        private void d4_Click(object sender, EventArgs e)
        {
            dbox.AppendText("4");
        }

        private void d5_Click(object sender, EventArgs e)
        {
            dbox.AppendText("5");
        }

        private void d6_Click(object sender, EventArgs e)
        {
            dbox.AppendText("6");
        }

        private void d7_Click(object sender, EventArgs e)
        {
            dbox.AppendText("7");
        }

        private void d9_Click(object sender, EventArgs e)
        {
            dbox.AppendText("9");
        }

        private void d8_Click(object sender, EventArgs e)
        {
            dbox.AppendText("8");
        }

        private void d0_Click(object sender, EventArgs e)
        {
            dbox.AppendText("0");
        }

        private void db_Click(object sender, EventArgs e)
        {
            if (dbox.Text.Length > 0)
                dbox.Text = dbox.Text.Remove((dbox.Text.Length - 1), 1);
        }

        private void dc_Click(object sender, EventArgs e)
        {
            if (dbox.Text.Length > 0)
               dbox.Text = "";
        }

        private void dok_Click(object sender, EventArgs e)
        {
            userobj.addMoney(account, Convert.ToInt32(withdrawbox.Text));
            viewpanel.BringToFront();
            dpanel.Visible = false;
            viewbox.Text = "My Balance";
            dbox.Text = "";
            viewpanel.Visible = true;
        }

     
        private void dcancel_Click(object sender, EventArgs e)
        {
            usermain.BringToFront();
            dpanel.Visible = false;
            usermain.Visible = true;
            dbox.Text = "";
        }

        //#####                     #####
        //##### START BALANCE PANEL #####
        //#####                     #####

        private void viewback_Click(object sender, EventArgs e)
        {
            usermain.BringToFront();
            viewpanel.Visible = false;
            usermain.Visible = true;
        }

        private void viewpanel_Paint(object sender, PaintEventArgs e)
        {
            viewbox.Text = Convert.ToString(userobj.getMoney(account));
        }

        //#####                              #####
        //##### START TRANSFER ACCOUNT PANEL #####
        //#####                              #####

        private void tacc1_Click(object sender, EventArgs e)
        {
            tacctext.AppendText("1");
        }

        private void tacc2_Click(object sender, EventArgs e)
        {
            tacctext.AppendText("2");
        }

        private void tacc3_Click(object sender, EventArgs e)
        {
            tacctext.AppendText("3");
        }

        private void tacc4_Click(object sender, EventArgs e)
        {
            tacctext.AppendText("4");
        }

        private void tacc5_Click(object sender, EventArgs e)
        {
            tacctext.AppendText("5");
        }

        private void tacc6_Click(object sender, EventArgs e)
        {
            tacctext.AppendText("6");
        }

        private void tacc7_Click(object sender, EventArgs e)
        {
            tacctext.AppendText("7");
        }

        private void tacc8_Click(object sender, EventArgs e)
        {
            tacctext.AppendText("8");
        }

        private void tacc9_Click(object sender, EventArgs e)
        {
            tacctext.AppendText("9");
        }

        private void tacc0_Click(object sender, EventArgs e)
        {
            tacctext.AppendText("0");
        }

        private void taccback_Click(object sender, EventArgs e)
        {
            if (tacctext.Text.Length > 0)
                tacctext.Text = tacctext.Text.Remove((tacctext.Text.Length - 1), 1);
        }

        private void tclearacc_Click(object sender, EventArgs e)
        {
            if (dbox.Text.Length > 0)
                dbox.Text = "";
        }

        private void taccok_Click(object sender, EventArgs e)
        {
            tamountpanel.BringToFront();
            tamountpanel.Visible = true;
            transferpanelacc.Visible = false;
        }

        private void tcancelacc_Click(object sender, EventArgs e)
        {
            tacctext.Text = "";
            usermain.BringToFront();
            usermain.Visible = true;
            transferpanelacc.Visible = false;
        }

        //#####                             #####
        //##### START TRANSFER AMOUNT PANEL #####
        //#####                             #####

        private void tamount1_Click(object sender, EventArgs e)
        {
            tamounttext.AppendText("1");
        }

        private void tamount2_Click(object sender, EventArgs e)
        {
            tamounttext.AppendText("2");
        }

        private void tamount3_Click(object sender, EventArgs e)
        {
            tamounttext.AppendText("3");
        }

        private void tamount4_Click(object sender, EventArgs e)
        {
            tamounttext.AppendText("4");
        }

        private void tamount5_Click(object sender, EventArgs e)
        {
            tamounttext.AppendText("5");
        }

        private void tamount6_Click(object sender, EventArgs e)
        {
            tamounttext.AppendText("6");
        }

        private void tamount7_Click(object sender, EventArgs e)
        {
            tamounttext.AppendText("7");
        }

        private void tamount8_Click(object sender, EventArgs e)
        {
            tamounttext.AppendText("8");
        }

        private void tamount9_Click(object sender, EventArgs e)
        {
            tamounttext.AppendText("9");
        }

        private void tamount0_Click(object sender, EventArgs e)
        {
            tamounttext.AppendText("6");
        }

        private void tamountback_Click(object sender, EventArgs e)
        {
            if (tamounttext.Text.Length > 0)
                tamounttext.Text = tamounttext.Text.Remove((tamounttext.Text.Length - 1), 1);
        }

        private void tamountclear_Click(object sender, EventArgs e)
        {
            if (tamounttext.Text.Length > 0)
                tamounttext.Text = "";
        }

        private void tamountcancel_Click(object sender, EventArgs e)
        {
            tacctext.Text = "";
            tamounttext.Text = "";
            usermain.BringToFront();
            usermain.Visible = true;
            tamountpanel.Visible = false;
        }

        private void tamountok_Click(object sender, EventArgs e)
        {
            tacctext.Text = "";
            tamounttext.Text = "";
            usermain.BringToFront();
            usermain.Visible = true;
            tamountpanel.Visible = false;

            //add logic
        }

        
    }
}
