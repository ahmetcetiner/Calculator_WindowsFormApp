using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WindowsFormApp
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Number Button
        private void btn_Number_Click(object sender, EventArgs e)
        {
            Button NumberBtn = (sender as Button);
            Display_Font();
            if (txtbox_Display.Text == "0" || Number_Control(sender, e))
            {
                txtbox_Display.Clear();
            }
            if (!Number_Cound())
            {
                txtbox_Display.Text += NumberBtn.Text;
            }
        }
        #endregion
        #region Operation Button
        private void btn_Operation_Click(object sender, EventArgs e)
        {
            Button OperationBtn = (sender as Button);
            Operation_Change();
            if (txtbox_Display.Text != "0" && Operation_Control() || Number_Control(sender, e))
            {
                txtbox_Display.Text += OperationBtn.Text;
            }
        }
        private void btn_equals_Click(object sender, EventArgs e)
        {
            Number_Control(sender, e);
            if (txtbox_Display.Text != "0")
            {
                Result(sender, e);
                Display_Font();
            }
        }

        #endregion
        #region clear Button
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtbox_Display.Clear();
            txtbox_Display.Text += "0";
            Display_Font();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (txtbox_Display.TextLength > 1)
            {

                txtbox_Display.Text = txtbox_Display.Text.Substring(0, (txtbox_Display.TextLength - 1));
            }
            else
            {
                txtbox_Display.Clear();
                txtbox_Display.Text += "0";
            }
            Display_Font();
        }
        #endregion

        private bool Number_Control(object sender, EventArgs e)
        {
            bool control = false;
            foreach (var item in txtbox_Display.Text)
            {
                if (item=='E')
                {
                    btn_Clear_Click(sender, e);
                    control = true;
                }
            }
            return control;
        }
        private void Display_Font()
        {
            if (txtbox_Display.TextLength < 16)
            {
                txtbox_Display.Font = new Font("Microsoft YaHei UI", 20);
            }
            else if (txtbox_Display.TextLength > 15 && txtbox_Display.TextLength < 20)
            {
                txtbox_Display.Font = new Font("Microsoft YaHei UI", 15);
            }
            else if (txtbox_Display.TextLength > 19)
            {
                txtbox_Display.Font = new Font("Microsoft YaHei UI", 10);
            }
        }
        private bool Number_Cound()
        {
            bool Control = false;
            string[] Numbers = { "0", "0" };
            if (txtbox_Display.TextLength > 14)
            {
                Control = true;
            }
            foreach (var item in txtbox_Display.Text)
            {
                if (item == '+' || item == '-' || item == '*' || item == '/')
                {
                    Control = false;
                    Numbers = txtbox_Display.Text.Split(item);
                }
            }
            if (txtbox_Display.TextLength > 14 && Control)
            {
                MessageBox.Show("You entered an incorrect number.");
            }
            if (txtbox_Display.Text.Length>15+Convert.ToInt32(Numbers[0].Length))
            {
                Control = true;
                MessageBox.Show("You entered an incorrect number.");
            }
            return Control;
        }
        private void Operation_Change()
        {
                if (txtbox_Display.Text[txtbox_Display.TextLength - 1] == '+' || txtbox_Display.Text[txtbox_Display.TextLength - 1] == '-' || txtbox_Display.Text[txtbox_Display.TextLength - 1] == '*' || txtbox_Display.Text[txtbox_Display.TextLength - 1] == '/')
                {
                    txtbox_Display.Text = txtbox_Display.Text.Substring(0, (txtbox_Display.TextLength - 1));
                }
        }
        private bool Operation_Control()
        {
            bool status = true;
            foreach (var item in txtbox_Display.Text)
            {
                if (item == '+' || item == '-' || item == '*' || item == '/')
                {
                    status = false;
                }
            }
            return status;

        }
        private void Result(object sender, EventArgs e)
        {
            string[] Numbers;
            double result;
            foreach (var item in txtbox_Display.Text)
            {
                switch (item)
                {
                    case '+':
                        Numbers = txtbox_Display.Text.Split('+');
                        result = Convert.ToDouble(Numbers[0]) + Convert.ToDouble(Numbers[1]);
                        txtbox_Display.Text = result.ToString();
                        break;
                    case '-':
                        Numbers = txtbox_Display.Text.Split('-');
                        result = Convert.ToDouble(Numbers[0]) - Convert.ToDouble(Numbers[1]);
                        txtbox_Display.Text = result.ToString();
                        break;
                    case '*':
                        Numbers = txtbox_Display.Text.Split('*');
                        result = Convert.ToDouble(Numbers[0]) * Convert.ToDouble(Numbers[1]);
                        txtbox_Display.Text = result.ToString();
                        break;
                    case '/':
                        Numbers = txtbox_Display.Text.Split('/');
                        result = Convert.ToDouble(Numbers[0]) / Convert.ToDouble(Numbers[1]);
                        txtbox_Display.Text = result.ToString();
                        break;
                }
            }
        }

        #region Button MauseEvent       
        private void btn__OperationButton_MouseLeave(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.FromArgb(19, 19, 19);
        }

        private void btn__NumberButton_MouseLeave(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.FromArgb(6, 6, 6);
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.FromArgb(45,45,45);
        }

        private void btn_equals_MouseEnter(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.FromArgb(170, 30, 35);
        }

        private void btn_equals_MouseLeave(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.FromArgb(111, 25, 33);
        }

        private void btn_Clear_MouseLeave(object sender, EventArgs e)
        {
            btn_Clear.BackColor = Color.FromArgb(250, 120, 50);
        }

        private void btn_Close_MouseLeave(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = Color.FromArgb(31, 31, 31);
        }

        #endregion
        #region Form Drag&Drop
        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void panel_up_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel_up_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        private void panel_up_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
        #endregion


    }
}
