using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantAutomation
{
    public partial class RestaurantTables : Form
    {
        RestaurantMenu menu = new RestaurantMenu();

        public RestaurantTables()
        {
            InitializeComponent();
        }
        public void closeall()
        {
            menu.masa1list.Visible = false;
            menu.masa1text.Visible = false;
            menu.masa2list.Visible = false;
            menu.masa2text.Visible = false;
            menu.masa3list.Visible = false;
            menu.masa3text.Visible = false;
            menu.masa4list.Visible = false;
            menu.masa4text.Visible = false;
            menu.masa5list.Visible = false;
            menu.masa5text.Visible = false;
            menu.masa6list.Visible = false;
            menu.masa6text.Visible = false;
            menu.masa7list.Visible = false;
            menu.masa7text.Visible = false;
            menu.masa8list.Visible = false;
            menu.masa8text.Visible = false;
            menu.masa9list.Visible = false;
            menu.masa9text.Visible = false;
            menu.masa10list.Visible = false;
            menu.masa10text.Visible = false;
            menu.masa11list.Visible = false;
            menu.masa11text.Visible = false;
            menu.masa12list.Visible = false;
            menu.masa12text.Visible = false;
            menu.masa13list.Visible = false;
            menu.masa13text.Visible = false;
            menu.masa14list.Visible = false;
            menu.masa14text.Visible = false;
            menu.masa15list.Visible = false;
            menu.masa15text.Visible = false;
            menu.loca1list.Visible = false;
            menu.loca1text.Visible = false;
            menu.loca2list.Visible = false;
            menu.loca2text.Visible = false;
            menu.loca3list.Visible = false;
            menu.loca3text.Visible = false;
            menu.loca4list.Visible = false;
            menu.loca4text.Visible = false;
            menu.loca5list.Visible = false;
            menu.loca5text.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Masa1";
            menu.masa1list.Visible = true;
            menu.masa1text.Visible = true;
            menu.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Masa2";
            menu.masa2list.Visible = true;
            menu.masa2text.Visible = true;
            menu.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Masa3";
            menu.masa3list.Visible = true;
            menu.masa3text.Visible = true;
            menu.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Masa4";
            menu.masa4list.Visible = true;
            menu.masa4text.Visible = true;
            menu.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Masa5";
            menu.masa5list.Visible = true;
            menu.masa5text.Visible = true;
            menu.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Masa6";
            menu.masa6list.Visible = true;
            menu.masa6text.Visible = true;
            menu.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Masa7";
            menu.masa7list.Visible = true;
            menu.masa7text.Visible = true;
            menu.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Masa8";
            menu.masa8list.Visible = true;
            menu.masa8text.Visible = true;
            menu.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Masa9";
            menu.masa9list.Visible = true;
            menu.masa9text.Visible = true;
            menu.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Masa10";
            menu.masa10list.Visible = true;
            menu.masa10text.Visible = true;
            menu.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Masa11";
            menu.masa11list.Visible = true;
            menu.masa11text.Visible = true;
            menu.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Masa12";
            menu.masa12list.Visible = true;
            menu.masa12text.Visible = true;
            menu.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Masa13";
            menu.masa13list.Visible = true;
            menu.masa13text.Visible = true;
            menu.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Masa14";
            menu.masa14list.Visible = true;
            menu.masa14text.Visible = true;
            menu.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Masa15";
            menu.masa15list.Visible = true;
            menu.masa15text.Visible = true;
            menu.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Loca1";
            menu.loca1list.Visible = true;
            menu.loca1text.Visible = true;
            menu.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Loca2";
            menu.loca2list.Visible = true;
            menu.loca2text.Visible = true;
            menu.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Loca3";
            menu.loca3list.Visible = true;
            menu.loca3text.Visible = true;
            menu.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Loca4";
            menu.loca4list.Visible = true;
            menu.loca4text.Visible = true;
            menu.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            closeall();
            menu.label12.Text = "Loca5";
            menu.loca5list.Visible = true;
            menu.loca5text.Visible = true;
            menu.ShowDialog();
        }

        private void RestaurantTables_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
