namespace Calculator_WindowsFormApp
{
    partial class frm_main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_pls = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_times = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_divided = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.txtbox_Display = new System.Windows.Forms.TextBox();
            this.btn_equals = new System.Windows.Forms.Button();
            this.panel_up = new System.Windows.Forms.Panel();
            this.lbl_FormName = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel_up.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btn_1.FlatAppearance.BorderSize = 0;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.ForeColor = System.Drawing.Color.White;
            this.btn_1.Location = new System.Drawing.Point(5, 150);
            this.btn_1.Margin = new System.Windows.Forms.Padding(5);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(65, 35);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_Number_Click);
            this.btn_1.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_1.MouseLeave += new System.EventHandler(this.btn__NumberButton_MouseLeave);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btn_2.FlatAppearance.BorderSize = 0;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.ForeColor = System.Drawing.Color.White;
            this.btn_2.Location = new System.Drawing.Point(75, 150);
            this.btn_2.Margin = new System.Windows.Forms.Padding(5);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(65, 35);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_Number_Click);
            this.btn_2.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_2.MouseLeave += new System.EventHandler(this.btn__NumberButton_MouseLeave);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btn_3.FlatAppearance.BorderSize = 0;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.ForeColor = System.Drawing.Color.White;
            this.btn_3.Location = new System.Drawing.Point(145, 150);
            this.btn_3.Margin = new System.Windows.Forms.Padding(5);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(65, 35);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_Number_Click);
            this.btn_3.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_3.MouseLeave += new System.EventHandler(this.btn__NumberButton_MouseLeave);
            // 
            // btn_pls
            // 
            this.btn_pls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btn_pls.FlatAppearance.BorderSize = 0;
            this.btn_pls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pls.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pls.ForeColor = System.Drawing.Color.White;
            this.btn_pls.Location = new System.Drawing.Point(215, 150);
            this.btn_pls.Margin = new System.Windows.Forms.Padding(5);
            this.btn_pls.Name = "btn_pls";
            this.btn_pls.Size = new System.Drawing.Size(65, 35);
            this.btn_pls.TabIndex = 3;
            this.btn_pls.Text = "+";
            this.btn_pls.UseVisualStyleBackColor = false;
            this.btn_pls.Click += new System.EventHandler(this.btn_Operation_Click);
            this.btn_pls.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_pls.MouseLeave += new System.EventHandler(this.btn__OperationButton_MouseLeave);
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.Location = new System.Drawing.Point(215, 190);
            this.btn_min.Margin = new System.Windows.Forms.Padding(5);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(65, 35);
            this.btn_min.TabIndex = 7;
            this.btn_min.Text = "-";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_Operation_Click);
            this.btn_min.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_min.MouseLeave += new System.EventHandler(this.btn__OperationButton_MouseLeave);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btn_6.FlatAppearance.BorderSize = 0;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.ForeColor = System.Drawing.Color.White;
            this.btn_6.Location = new System.Drawing.Point(145, 190);
            this.btn_6.Margin = new System.Windows.Forms.Padding(5);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(65, 35);
            this.btn_6.TabIndex = 6;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_Number_Click);
            this.btn_6.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_6.MouseLeave += new System.EventHandler(this.btn__NumberButton_MouseLeave);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btn_5.FlatAppearance.BorderSize = 0;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.ForeColor = System.Drawing.Color.White;
            this.btn_5.Location = new System.Drawing.Point(75, 190);
            this.btn_5.Margin = new System.Windows.Forms.Padding(5);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(65, 35);
            this.btn_5.TabIndex = 5;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_Number_Click);
            this.btn_5.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_5.MouseLeave += new System.EventHandler(this.btn__NumberButton_MouseLeave);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btn_4.FlatAppearance.BorderSize = 0;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.ForeColor = System.Drawing.Color.White;
            this.btn_4.Location = new System.Drawing.Point(5, 190);
            this.btn_4.Margin = new System.Windows.Forms.Padding(5);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(65, 35);
            this.btn_4.TabIndex = 4;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_Number_Click);
            this.btn_4.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_4.MouseLeave += new System.EventHandler(this.btn__NumberButton_MouseLeave);
            // 
            // btn_times
            // 
            this.btn_times.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btn_times.FlatAppearance.BorderSize = 0;
            this.btn_times.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_times.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_times.ForeColor = System.Drawing.Color.White;
            this.btn_times.Location = new System.Drawing.Point(75, 110);
            this.btn_times.Margin = new System.Windows.Forms.Padding(5);
            this.btn_times.Name = "btn_times";
            this.btn_times.Size = new System.Drawing.Size(65, 35);
            this.btn_times.TabIndex = 11;
            this.btn_times.Text = "*";
            this.btn_times.UseVisualStyleBackColor = false;
            this.btn_times.Click += new System.EventHandler(this.btn_Operation_Click);
            this.btn_times.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_times.MouseLeave += new System.EventHandler(this.btn__OperationButton_MouseLeave);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btn_9.FlatAppearance.BorderSize = 0;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.ForeColor = System.Drawing.Color.White;
            this.btn_9.Location = new System.Drawing.Point(145, 230);
            this.btn_9.Margin = new System.Windows.Forms.Padding(5);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(65, 35);
            this.btn_9.TabIndex = 10;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_Number_Click);
            this.btn_9.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_9.MouseLeave += new System.EventHandler(this.btn__NumberButton_MouseLeave);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btn_8.FlatAppearance.BorderSize = 0;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.ForeColor = System.Drawing.Color.White;
            this.btn_8.Location = new System.Drawing.Point(75, 230);
            this.btn_8.Margin = new System.Windows.Forms.Padding(5);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(65, 35);
            this.btn_8.TabIndex = 9;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_Number_Click);
            this.btn_8.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_8.MouseLeave += new System.EventHandler(this.btn__NumberButton_MouseLeave);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btn_7.FlatAppearance.BorderSize = 0;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.ForeColor = System.Drawing.Color.White;
            this.btn_7.Location = new System.Drawing.Point(5, 230);
            this.btn_7.Margin = new System.Windows.Forms.Padding(5);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(65, 35);
            this.btn_7.TabIndex = 8;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_Number_Click);
            this.btn_7.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_7.MouseLeave += new System.EventHandler(this.btn__NumberButton_MouseLeave);
            // 
            // btn_divided
            // 
            this.btn_divided.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btn_divided.FlatAppearance.BorderSize = 0;
            this.btn_divided.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_divided.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_divided.ForeColor = System.Drawing.Color.White;
            this.btn_divided.Location = new System.Drawing.Point(5, 110);
            this.btn_divided.Margin = new System.Windows.Forms.Padding(5);
            this.btn_divided.Name = "btn_divided";
            this.btn_divided.Size = new System.Drawing.Size(65, 35);
            this.btn_divided.TabIndex = 15;
            this.btn_divided.Text = "/";
            this.btn_divided.UseVisualStyleBackColor = false;
            this.btn_divided.Click += new System.EventHandler(this.btn_Operation_Click);
            this.btn_divided.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_divided.MouseLeave += new System.EventHandler(this.btn__OperationButton_MouseLeave);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btn_0.FlatAppearance.BorderSize = 0;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.ForeColor = System.Drawing.Color.White;
            this.btn_0.Location = new System.Drawing.Point(75, 270);
            this.btn_0.Margin = new System.Windows.Forms.Padding(5);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(65, 35);
            this.btn_0.TabIndex = 13;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_Number_Click);
            this.btn_0.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_0.MouseLeave += new System.EventHandler(this.btn__NumberButton_MouseLeave);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(120)))), ((int)(((byte)(50)))));
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(215, 110);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(65, 35);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "C";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            this.btn_Clear.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_Clear.MouseLeave += new System.EventHandler(this.btn_Clear_MouseLeave);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btn_del.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_del.BackgroundImage")));
            this.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_del.ForeColor = System.Drawing.Color.White;
            this.btn_del.Location = new System.Drawing.Point(145, 110);
            this.btn_del.Margin = new System.Windows.Forms.Padding(5);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(65, 35);
            this.btn_del.TabIndex = 17;
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            this.btn_del.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_del.MouseLeave += new System.EventHandler(this.btn__OperationButton_MouseLeave);
            // 
            // txtbox_Display
            // 
            this.txtbox_Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtbox_Display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Display.Enabled = false;
            this.txtbox_Display.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_Display.ForeColor = System.Drawing.Color.White;
            this.txtbox_Display.Location = new System.Drawing.Point(5, 49);
            this.txtbox_Display.Name = "txtbox_Display";
            this.txtbox_Display.Size = new System.Drawing.Size(275, 35);
            this.txtbox_Display.TabIndex = 18;
            this.txtbox_Display.Text = "0";
            this.txtbox_Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbox_Display.UseWaitCursor = true;
            // 
            // btn_equals
            // 
            this.btn_equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.btn_equals.FlatAppearance.BorderSize = 0;
            this.btn_equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_equals.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_equals.ForeColor = System.Drawing.Color.White;
            this.btn_equals.Location = new System.Drawing.Point(215, 230);
            this.btn_equals.Margin = new System.Windows.Forms.Padding(5);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(65, 35);
            this.btn_equals.TabIndex = 20;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = false;
            this.btn_equals.Click += new System.EventHandler(this.btn_equals_Click);
            this.btn_equals.MouseEnter += new System.EventHandler(this.btn_equals_MouseEnter);
            this.btn_equals.MouseLeave += new System.EventHandler(this.btn_equals_MouseLeave);
            // 
            // panel_up
            // 
            this.panel_up.Controls.Add(this.lbl_FormName);
            this.panel_up.Controls.Add(this.btn_Close);
            this.panel_up.Location = new System.Drawing.Point(0, 0);
            this.panel_up.Name = "panel_up";
            this.panel_up.Size = new System.Drawing.Size(285, 30);
            this.panel_up.TabIndex = 21;
            this.panel_up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_up_MouseDown);
            this.panel_up.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_up_MouseMove);
            this.panel_up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_up_MouseUp);
            // 
            // lbl_FormName
            // 
            this.lbl_FormName.AutoSize = true;
            this.lbl_FormName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lbl_FormName.Location = new System.Drawing.Point(1, 7);
            this.lbl_FormName.Name = "lbl_FormName";
            this.lbl_FormName.Size = new System.Drawing.Size(66, 17);
            this.lbl_FormName.TabIndex = 20;
            this.lbl_FormName.Text = "Calculator";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(240, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(45, 30);
            this.btn_Close.TabIndex = 19;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseEnter += new System.EventHandler(this.btn_equals_MouseEnter);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_Close_MouseLeave);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(285, 345);
            this.Controls.Add(this.panel_up);
            this.Controls.Add(this.btn_equals);
            this.Controls.Add(this.txtbox_Display);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_divided);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_times);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_pls);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_main";
            this.Text = "Form1";
            this.panel_up.ResumeLayout(false);
            this.panel_up.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_pls;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_times;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_divided;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.TextBox txtbox_Display;
        private System.Windows.Forms.Button btn_equals;
        private System.Windows.Forms.Panel panel_up;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_FormName;
    }
}

