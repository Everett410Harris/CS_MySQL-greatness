namespace CS_Beginner_MySQL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.memberTypeCb = new System.Windows.Forms.ComboBox();
            this.genderCb = new System.Windows.Forms.ComboBox();
            this.postCodeTb = new System.Windows.Forms.TextBox();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.moblieTb = new System.Windows.Forms.TextBox();
            this.addressTb = new System.Windows.Forms.TextBox();
            this.lastNameTb = new System.Windows.Forms.TextBox();
            this.firstNameTb = new System.Windows.Forms.TextBox();
            this.memberIdTb = new System.Windows.Forms.TextBox();
            this.memberTypeLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.postCodeLabel = new System.Windows.Forms.Label();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.memberIdLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.selectBtn = new System.Windows.Forms.Button();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.headerLabel);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1359, 100);
            this.panel1.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(450, 12);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(518, 73);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "SQL Connection";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.memberTypeCb);
            this.panel2.Controls.Add(this.genderCb);
            this.panel2.Controls.Add(this.postCodeTb);
            this.panel2.Controls.Add(this.emailTb);
            this.panel2.Controls.Add(this.moblieTb);
            this.panel2.Controls.Add(this.addressTb);
            this.panel2.Controls.Add(this.lastNameTb);
            this.panel2.Controls.Add(this.firstNameTb);
            this.panel2.Controls.Add(this.memberIdTb);
            this.panel2.Controls.Add(this.memberTypeLabel);
            this.panel2.Controls.Add(this.emailLabel);
            this.panel2.Controls.Add(this.postCodeLabel);
            this.panel2.Controls.Add(this.mobileLabel);
            this.panel2.Controls.Add(this.genderLabel);
            this.panel2.Controls.Add(this.addressLabel);
            this.panel2.Controls.Add(this.lastNameLabel);
            this.panel2.Controls.Add(this.firstNameLabel);
            this.panel2.Controls.Add(this.memberIdLabel);
            this.panel2.Location = new System.Drawing.Point(12, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1359, 212);
            this.panel2.TabIndex = 1;
            // 
            // memberTypeCb
            // 
            this.memberTypeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.memberTypeCb.FormattingEnabled = true;
            this.memberTypeCb.Location = new System.Drawing.Point(1107, 150);
            this.memberTypeCb.Name = "memberTypeCb";
            this.memberTypeCb.Size = new System.Drawing.Size(243, 45);
            this.memberTypeCb.TabIndex = 18;
            // 
            // genderCb
            // 
            this.genderCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genderCb.FormattingEnabled = true;
            this.genderCb.Location = new System.Drawing.Point(624, 86);
            this.genderCb.Name = "genderCb";
            this.genderCb.Size = new System.Drawing.Size(243, 45);
            this.genderCb.TabIndex = 17;
            // 
            // postCodeTb
            // 
            this.postCodeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.postCodeTb.Location = new System.Drawing.Point(1102, 23);
            this.postCodeTb.Name = "postCodeTb";
            this.postCodeTb.Size = new System.Drawing.Size(243, 44);
            this.postCodeTb.TabIndex = 16;
            // 
            // emailTb
            // 
            this.emailTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailTb.Location = new System.Drawing.Point(1107, 87);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(243, 44);
            this.emailTb.TabIndex = 15;
            // 
            // moblieTb
            // 
            this.moblieTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.moblieTb.Location = new System.Drawing.Point(624, 151);
            this.moblieTb.Name = "moblieTb";
            this.moblieTb.Size = new System.Drawing.Size(243, 44);
            this.moblieTb.TabIndex = 14;
            // 
            // addressTb
            // 
            this.addressTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addressTb.Location = new System.Drawing.Point(624, 23);
            this.addressTb.Name = "addressTb";
            this.addressTb.Size = new System.Drawing.Size(243, 44);
            this.addressTb.TabIndex = 13;
            // 
            // lastNameTb
            // 
            this.lastNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastNameTb.Location = new System.Drawing.Point(215, 151);
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.Size = new System.Drawing.Size(243, 44);
            this.lastNameTb.TabIndex = 12;
            // 
            // firstNameTb
            // 
            this.firstNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstNameTb.Location = new System.Drawing.Point(215, 89);
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.Size = new System.Drawing.Size(243, 44);
            this.firstNameTb.TabIndex = 11;
            // 
            // memberIdTb
            // 
            this.memberIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.memberIdTb.Location = new System.Drawing.Point(215, 23);
            this.memberIdTb.Name = "memberIdTb";
            this.memberIdTb.Size = new System.Drawing.Size(243, 44);
            this.memberIdTb.TabIndex = 10;
            // 
            // memberTypeLabel
            // 
            this.memberTypeLabel.AutoSize = true;
            this.memberTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.memberTypeLabel.Location = new System.Drawing.Point(878, 159);
            this.memberTypeLabel.Name = "memberTypeLabel";
            this.memberTypeLabel.Size = new System.Drawing.Size(223, 37);
            this.memberTypeLabel.TabIndex = 9;
            this.memberTypeLabel.Text = "Member Type";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(878, 94);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(102, 37);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email";
            // 
            // postCodeLabel
            // 
            this.postCodeLabel.AutoSize = true;
            this.postCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.postCodeLabel.Location = new System.Drawing.Point(878, 30);
            this.postCodeLabel.Name = "postCodeLabel";
            this.postCodeLabel.Size = new System.Drawing.Size(175, 37);
            this.postCodeLabel.TabIndex = 7;
            this.postCodeLabel.Text = "Post Code";
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mobileLabel.Location = new System.Drawing.Point(476, 159);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(116, 37);
            this.mobileLabel.TabIndex = 6;
            this.mobileLabel.Text = "Moblie";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genderLabel.Location = new System.Drawing.Point(476, 94);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(129, 37);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = "Gender";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.Location = new System.Drawing.Point(476, 30);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(142, 37);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.Location = new System.Drawing.Point(27, 159);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(172, 37);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "LastName";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.Location = new System.Drawing.Point(27, 94);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(175, 37);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "FirstName";
            // 
            // memberIdLabel
            // 
            this.memberIdLabel.AutoSize = true;
            this.memberIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.memberIdLabel.Location = new System.Drawing.Point(27, 30);
            this.memberIdLabel.Name = "memberIdLabel";
            this.memberIdLabel.Size = new System.Drawing.Size(182, 37);
            this.memberIdLabel.TabIndex = 1;
            this.memberIdLabel.Text = "Member ID";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(12, 431);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1359, 381);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1329, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(12, 818);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1359, 87);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SandyBrown;
            this.panel5.Controls.Add(this.addNewBtn);
            this.panel5.Controls.Add(this.displayBtn);
            this.panel5.Controls.Add(this.deleteBtn);
            this.panel5.Controls.Add(this.resetBtn);
            this.panel5.Controls.Add(this.exitBtn);
            this.panel5.Location = new System.Drawing.Point(3, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1347, 65);
            this.panel5.TabIndex = 1;
            // 
            // addNewBtn
            // 
            this.addNewBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.addNewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addNewBtn.Location = new System.Drawing.Point(36, 13);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(239, 44);
            this.addNewBtn.TabIndex = 25;
            this.addNewBtn.Text = "Add New";
            this.addNewBtn.UseVisualStyleBackColor = false;
            // 
            // displayBtn
            // 
            this.displayBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.displayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.displayBtn.Location = new System.Drawing.Point(309, 13);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(239, 44);
            this.displayBtn.TabIndex = 24;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.Location = new System.Drawing.Point(576, 13);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(239, 44);
            this.deleteBtn.TabIndex = 23;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetBtn.Location = new System.Drawing.Point(838, 13);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(239, 44);
            this.resetBtn.TabIndex = 22;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.Location = new System.Drawing.Point(1102, 13);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(239, 44);
            this.exitBtn.TabIndex = 21;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.selectBtn);
            this.panel6.Controls.Add(this.searchTb);
            this.panel6.Location = new System.Drawing.Point(12, 132);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1359, 75);
            this.panel6.TabIndex = 2;
            // 
            // selectBtn
            // 
            this.selectBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.selectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectBtn.Location = new System.Drawing.Point(974, 17);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(173, 44);
            this.selectBtn.TabIndex = 20;
            this.selectBtn.Text = "Search";
            this.selectBtn.UseVisualStyleBackColor = false;
            // 
            // searchTb
            // 
            this.searchTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchTb.Location = new System.Drawing.Point(512, 17);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(386, 44);
            this.searchTb.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1383, 912);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label headerLabel;
        private Panel panel2;
        private TextBox postCodeTb;
        private TextBox emailTb;
        private TextBox moblieTb;
        private TextBox addressTb;
        private TextBox lastNameTb;
        private TextBox firstNameTb;
        private TextBox memberIdTb;
        private Label memberTypeLabel;
        private Label emailLabel;
        private Label postCodeLabel;
        private Label mobileLabel;
        private Label genderLabel;
        private Label addressLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private Label memberIdLabel;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private ComboBox memberTypeCb;
        private ComboBox genderCb;
        private DataGridView dataGridView1;
        private Panel panel6;
        private Button addNewBtn;
        private Button displayBtn;
        private Button deleteBtn;
        private Button resetBtn;
        private Button exitBtn;
        private Button selectBtn;
        private TextBox searchTb;
    }
}