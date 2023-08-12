namespace WinFormsApp3.Views
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTen = new TextBox();
            txtMoTa = new TextBox();
            txtGiaNhap = new TextBox();
            textBox4 = new TextBox();
            cmbSoLuong = new ComboBox();
            btnAdd = new Button();
            buttonDelete = new Button();
            btnShow = new Button();
            BtnClear = new Button();
            dtgView = new DataGridView();
            btnUpdate = new Button();
            label6 = new Label();
            txtMa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Mô tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Giá nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 147);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 226);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 4;
            label5.Text = "Tìm";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(122, 35);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(376, 23);
            txtTen.TabIndex = 5;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(122, 65);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(376, 23);
            txtMoTa.TabIndex = 6;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(122, 103);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(376, 23);
            txtGiaNhap.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(56, 218);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(376, 23);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // cmbSoLuong
            // 
            cmbSoLuong.FormattingEnabled = true;
            cmbSoLuong.Location = new Point(122, 147);
            cmbSoLuong.Name = "cmbSoLuong";
            cmbSoLuong.Size = new Size(376, 23);
            cmbSoLuong.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(530, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(235, 42);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(530, 65);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(235, 42);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Xóa";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(530, 147);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(235, 42);
            btnShow.TabIndex = 12;
            btnShow.Text = "Hiển thị";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(530, 195);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(235, 42);
            BtnClear.TabIndex = 13;
            BtnClear.Text = "Xóa Form";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(12, 259);
            dtgView.Name = "dtgView";
            dtgView.RowTemplate.Height = 25;
            dtgView.Size = new Size(776, 179);
            dtgView.TabIndex = 14;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(530, 106);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(235, 42);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 16;
            label6.Text = "Mã";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(122, 6);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(376, 23);
            txtMa.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMa);
            Controls.Add(label6);
            Controls.Add(btnUpdate);
            Controls.Add(dtgView);
            Controls.Add(BtnClear);
            Controls.Add(btnShow);
            Controls.Add(buttonDelete);
            Controls.Add(btnAdd);
            Controls.Add(cmbSoLuong);
            Controls.Add(textBox4);
            Controls.Add(txtGiaNhap);
            Controls.Add(txtMoTa);
            Controls.Add(txtTen);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTen;
        private TextBox txtMoTa;
        private TextBox txtGiaNhap;
        private TextBox textBox4;
        private ComboBox cmbSoLuong;
        private Button btnAdd;
        private Button buttonDelete;
        private Button btnShow;
        private Button BtnClear;
        private DataGridView dtgView;
        private Button btnUpdate;
        private Label label6;
        private TextBox txtMa;
    }
}