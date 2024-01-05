namespace Demo_BTL
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidepanel1 = new System.Windows.Forms.Panel();
            this.Btn_Hopdong = new System.Windows.Forms.Button();
            this.Btn_Thuephong = new System.Windows.Forms.Button();
            this.Btn_TimKiem = new System.Windows.Forms.Button();
            this.Btn_Qlyktx = new System.Windows.Forms.Button();
            this.Btn_trangchu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.Btn_Dangxuat = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.trangchu1 = new Demo_BTL.Trangchu();
            this.timkiem1 = new Demo_BTL.Timkiem();
            this.thuePhong2 = new Demo_BTL.ThuePhong();
            this.qliKTX2 = new Demo_BTL.QliKTX();
            this.hopDong2 = new Demo_BTL.HopDong();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.sidepanel1);
            this.panel1.Controls.Add(this.Btn_Hopdong);
            this.panel1.Controls.Add(this.Btn_Thuephong);
            this.panel1.Controls.Add(this.Btn_TimKiem);
            this.panel1.Controls.Add(this.Btn_Qlyktx);
            this.panel1.Controls.Add(this.Btn_trangchu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 767);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sidepanel1
            // 
            this.sidepanel1.BackColor = System.Drawing.Color.IndianRed;
            this.sidepanel1.Location = new System.Drawing.Point(0, 174);
            this.sidepanel1.Margin = new System.Windows.Forms.Padding(4);
            this.sidepanel1.Name = "sidepanel1";
            this.sidepanel1.Size = new System.Drawing.Size(13, 101);
            this.sidepanel1.TabIndex = 0;
            // 
            // Btn_Hopdong
            // 
            this.Btn_Hopdong.FlatAppearance.BorderSize = 0;
            this.Btn_Hopdong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Hopdong.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Hopdong.ForeColor = System.Drawing.Color.White;
            this.Btn_Hopdong.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Hopdong.Image")));
            this.Btn_Hopdong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Hopdong.Location = new System.Drawing.Point(13, 480);
            this.Btn_Hopdong.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Hopdong.Name = "Btn_Hopdong";
            this.Btn_Hopdong.Size = new System.Drawing.Size(232, 96);
            this.Btn_Hopdong.TabIndex = 4;
            this.Btn_Hopdong.Text = "Thu Tiền";
            this.Btn_Hopdong.UseVisualStyleBackColor = true;
            this.Btn_Hopdong.Click += new System.EventHandler(this.Btn_Hopdong_Click);
            // 
            // Btn_Thuephong
            // 
            this.Btn_Thuephong.FlatAppearance.BorderSize = 0;
            this.Btn_Thuephong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Thuephong.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Thuephong.ForeColor = System.Drawing.Color.White;
            this.Btn_Thuephong.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Thuephong.Image")));
            this.Btn_Thuephong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Thuephong.Location = new System.Drawing.Point(13, 377);
            this.Btn_Thuephong.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Thuephong.Name = "Btn_Thuephong";
            this.Btn_Thuephong.Size = new System.Drawing.Size(231, 96);
            this.Btn_Thuephong.TabIndex = 3;
            this.Btn_Thuephong.Text = "Thuê Phòng";
            this.Btn_Thuephong.UseVisualStyleBackColor = true;
            this.Btn_Thuephong.Click += new System.EventHandler(this.Btn_Thuephong_Click);
            // 
            // Btn_TimKiem
            // 
            this.Btn_TimKiem.FlatAppearance.BorderSize = 0;
            this.Btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TimKiem.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.Btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("Btn_TimKiem.Image")));
            this.Btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_TimKiem.Location = new System.Drawing.Point(13, 583);
            this.Btn_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_TimKiem.Name = "Btn_TimKiem";
            this.Btn_TimKiem.Size = new System.Drawing.Size(232, 96);
            this.Btn_TimKiem.TabIndex = 2;
            this.Btn_TimKiem.Text = "Tìm Kiếm";
            this.Btn_TimKiem.UseVisualStyleBackColor = true;
            this.Btn_TimKiem.Click += new System.EventHandler(this.Btn_Timkiem_Click);
            // 
            // Btn_Qlyktx
            // 
            this.Btn_Qlyktx.FlatAppearance.BorderSize = 0;
            this.Btn_Qlyktx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Qlyktx.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Qlyktx.ForeColor = System.Drawing.Color.White;
            this.Btn_Qlyktx.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Qlyktx.Image")));
            this.Btn_Qlyktx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Qlyktx.Location = new System.Drawing.Point(13, 273);
            this.Btn_Qlyktx.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Qlyktx.Name = "Btn_Qlyktx";
            this.Btn_Qlyktx.Size = new System.Drawing.Size(228, 96);
            this.Btn_Qlyktx.TabIndex = 1;
            this.Btn_Qlyktx.Text = "Quản lý KTX";
            this.Btn_Qlyktx.UseVisualStyleBackColor = true;
            this.Btn_Qlyktx.Click += new System.EventHandler(this.Btn_Qlyktx_Click);
            // 
            // Btn_trangchu
            // 
            this.Btn_trangchu.CausesValidation = false;
            this.Btn_trangchu.FlatAppearance.BorderSize = 0;
            this.Btn_trangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_trangchu.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_trangchu.ForeColor = System.Drawing.Color.White;
            this.Btn_trangchu.Image = ((System.Drawing.Image)(resources.GetObject("Btn_trangchu.Image")));
            this.Btn_trangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_trangchu.Location = new System.Drawing.Point(13, 174);
            this.Btn_trangchu.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_trangchu.Name = "Btn_trangchu";
            this.Btn_trangchu.Size = new System.Drawing.Size(231, 96);
            this.Btn_trangchu.TabIndex = 0;
            this.Btn_trangchu.Text = "Trang chủ";
            this.Btn_trangchu.UseVisualStyleBackColor = true;
            this.Btn_trangchu.Click += new System.EventHandler(this.Btn_trangchu_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.IndianRed;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(245, 755);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1562, 12);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(4, 4);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(526, 158);
            this.panel6.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(143, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(213, 166);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 92);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(538, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1020, 158);
            this.panel5.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.Btn_Dangxuat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 91);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 91);
            this.button4.TabIndex = 7;
            this.button4.Text = "Quay lại";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // Btn_Dangxuat
            // 
            this.Btn_Dangxuat.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Dangxuat.FlatAppearance.BorderSize = 0;
            this.Btn_Dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Dangxuat.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Dangxuat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Dangxuat.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Dangxuat.Image")));
            this.Btn_Dangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Dangxuat.Location = new System.Drawing.Point(865, 0);
            this.Btn_Dangxuat.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Dangxuat.Name = "Btn_Dangxuat";
            this.Btn_Dangxuat.Size = new System.Drawing.Size(155, 91);
            this.Btn_Dangxuat.TabIndex = 0;
            this.Btn_Dangxuat.Text = "Đăng xuất";
            this.Btn_Dangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Dangxuat.UseVisualStyleBackColor = true;
            this.Btn_Dangxuat.Click += new System.EventHandler(this.Btn_Dangxuat_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.24424F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.75577F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(245, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1562, 166);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // trangchu1
            // 
            this.trangchu1.BackColor = System.Drawing.Color.IndianRed;
            this.trangchu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trangchu1.Location = new System.Drawing.Point(245, 166);
            this.trangchu1.Margin = new System.Windows.Forms.Padding(5);
            this.trangchu1.Name = "trangchu1";
            this.trangchu1.Size = new System.Drawing.Size(1562, 589);
            this.trangchu1.TabIndex = 11;
            // 
            // timkiem1
            // 
            this.timkiem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timkiem1.Location = new System.Drawing.Point(245, 166);
            this.timkiem1.Margin = new System.Windows.Forms.Padding(5);
            this.timkiem1.Name = "timkiem1";
            this.timkiem1.Size = new System.Drawing.Size(1562, 589);
            this.timkiem1.TabIndex = 10;
            // 
            // thuePhong2
            // 
            this.thuePhong2.AutoSize = true;
            this.thuePhong2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thuePhong2.Location = new System.Drawing.Point(245, 166);
            this.thuePhong2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thuePhong2.Name = "thuePhong2";
            this.thuePhong2.Size = new System.Drawing.Size(1562, 589);
            this.thuePhong2.TabIndex = 8;
            // 
            // qliKTX2
            // 
            this.qliKTX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qliKTX2.Location = new System.Drawing.Point(245, 166);
            this.qliKTX2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qliKTX2.Name = "qliKTX2";
            this.qliKTX2.Size = new System.Drawing.Size(1562, 589);
            this.qliKTX2.TabIndex = 6;
            // 
            // hopDong2
            // 
            this.hopDong2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hopDong2.Location = new System.Drawing.Point(245, 166);
            this.hopDong2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hopDong2.Name = "hopDong2";
            this.hopDong2.Size = new System.Drawing.Size(1562, 589);
            this.hopDong2.TabIndex = 5;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1807, 767);
            this.Controls.Add(this.trangchu1);
            this.Controls.Add(this.timkiem1);
            this.Controls.Add(this.thuePhong2);
            this.Controls.Add(this.qliKTX2);
            this.Controls.Add(this.hopDong2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHome";
            this.Text = "Ký túc xá UTC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHome_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ThuePhong thuePhong1;
        
        private HopDong hopDong1;
        private QliKTX qliKTX1;
        
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidepanel1;
        private System.Windows.Forms.Button Btn_Hopdong;
        private System.Windows.Forms.Button Btn_Thuephong;
        private System.Windows.Forms.Button Btn_TimKiem;
        private System.Windows.Forms.Button Btn_Qlyktx;
        private System.Windows.Forms.Button Btn_trangchu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel4;
        private HopDong hopDong2;
        private QliKTX qliKTX2;
        
        private ThuePhong thuePhong2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Btn_Dangxuat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Timkiem timkiem1;
        private Trangchu trangchu1;
    }
}

