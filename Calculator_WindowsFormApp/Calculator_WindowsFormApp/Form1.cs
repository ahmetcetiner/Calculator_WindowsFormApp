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
        private void btn_1_Click(object sender, EventArgs e)
        {
            Display_Font();
            if (txtbox_Display.Text == "0" || Number_Control(sender, e))
            {
                txtbox_Display.Clear();
            }
            if (!Number_Cound())
            {
                txtbox_Display.Text += "1";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Display_Font();
            if (txtbox_Display.Text == "0" || Number_Control(sender, e))
            {
                txtbox_Display.Clear();
            }
            if (!Number_Cound())
            {
                txtbox_Display.Text += "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Display_Font();
            if (txtbox_Display.Text == "0" || Number_Control(sender, e))
            {
                txtbox_Display.Clear();
            }
            if (!Number_Cound())
            {
                txtbox_Display.Text += "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Display_Font();
            if (txtbox_Display.Text == "0" || Number_Control(sender, e))
            {
                txtbox_Display.Clear();
            }
            if (!Number_Cound())
            {
                txtbox_Display.Text += "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Display_Font();
            if (txtbox_Display.Text == "0" || Number_Control(sender, e))
            {
                txtbox_Display.Clear();
            }
            if (!Number_Cound())
            {
                txtbox_Display.Text += "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            Display_Font();
            if (txtbox_Display.Text == "0" || Number_Control(sender, e))
            {
                txtbox_Display.Clear();
            }
            if (!Number_Cound())
            {
                txtbox_Display.Text += "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            Display_Font();
            if (txtbox_Display.Text == "0" || Number_Control(sender, e))
            {
                txtbox_Display.Clear();
            }
            if (!Number_Cound())
            {
                txtbox_Display.Text += "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            Display_Font();
            if (txtbox_Display.Text == "0" || Number_Control(sender, e))
            {
                txtbox_Display.Clear();
            }
            if (!Number_Cound())
            {
                txtbox_Display.Text += "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            Display_Font();
            if (txtbox_Display.Text == "0" || Number_Control(sender, e))
            {
                txtbox_Display.Clear();
            }
            if (!Number_Cound())
            {
                txtbox_Display.Text += "9";
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            Display_Font();
            if (txtbox_Display.Text == "0" || Number_Control(sender, e))
            {
                txtbox_Display.Clear();
            }
            if (!Number_Cound())
            {
                txtbox_Display.Text += "0";
            }
        }
        #endregion
        #region Operation Button
        private void btn_pls_Click(object sender, EventArgs e)
        {
            Operation_Change();
            if (txtbox_Display.Text != "0" && Operation_Control() || Number_Control(sender, e))
            {
                txtbox_Display.Text += "+";
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            Operation_Change();
            if (txtbox_Display.Text != "0" && Operation_Control() || Number_Control(sender, e))
            {
                txtbox_Display.Text += "-";
            }
        }

        private void btn_times_Click(object sender, EventArgs e)
        {
            Operation_Change();
            if (txtbox_Display.Text != "0" && Operation_Control() || Number_Control(sender, e))
            {
                txtbox_Display.Text += "*";
            }
        }

        private void btn_divided_Click(object sender, EventArgs e)
        {
            Operation_Change();
            if (txtbox_Display.Text != "0" && Operation_Control() || Number_Control(sender, e))
            {
                txtbox_Display.Text += "/";
            }
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            if (txtbox_Display.Text != "0" || Number_Control(sender, e))
            {
                Result(sender, e);
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
            if (txtbox_Display.TextLength < 15)
            {
                txtbox_Display.Font = new Font("Microsoft YaHei UI", 20);
            }
            else if (txtbox_Display.TextLength > 15 && txtbox_Display.TextLength < 20)
            {
                txtbox_Display.Font = new Font("Microsoft YaHei UI", 15);
            }
            else if (txtbox_Display.TextLength > 20)
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
            if (txtbox_Display.Text.Length>15+Convert.ToInt32(Numbers[0].Length))
            {
                Control = true;
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
                        if (Numbers[0].Length < 101 && Numbers[1].Length < 101)
                        {
                            result = Convert.ToDouble(Numbers[0]) + Convert.ToDouble(Numbers[1]);
                            txtbox_Display.Text = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("You entered an incorrect number.");
                            btn_Clear_Click(sender, e);
                        }
                        break;
                    case '-':
                        Numbers = txtbox_Display.Text.Split('-');
                        if (Numbers[0].Length < 101 && Numbers[1].Length < 101)
                        {
                            result = Convert.ToDouble(Numbers[0]) - Convert.ToDouble(Numbers[1]);
                            txtbox_Display.Text = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("You entered an incorrect number.");
                            btn_Clear_Click(sender, e);
                        }
                        break;
                    case '*':
                        Numbers = txtbox_Display.Text.Split('*');
                        if (Numbers[0].Length < 20 && Numbers[1].Length < 20)
                        {
                            result = Convert.ToDouble(Numbers[0]) * Convert.ToDouble(Numbers[1]);
                            txtbox_Display.Text = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("You entered an incorrect number.");
                            btn_Clear_Click(sender, e);
                        }
                        break;
                    case '/':
                        Numbers = txtbox_Display.Text.Split('/');
                        if (Numbers[0].Length < 101 && Numbers[1].Length < 101)
                        {
                            result = Convert.ToDouble(Numbers[0]) / Convert.ToDouble(Numbers[1]);
                            txtbox_Display.Text = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("You entered an incorrect number.");
                            btn_Clear_Click(sender, e);
                        }
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
