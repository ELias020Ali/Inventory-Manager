namespace Prog_Assignment
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
            this.Display = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ItemBox = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.Label();
            this.NumbBox = new System.Windows.Forms.TextBox();
            this.Item = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.itemList = new System.Windows.Forms.ListBox();
            this.CheckList = new System.Windows.Forms.ListBox();
            this.CheckBox = new System.Windows.Forms.TextBox();
            this.LabelCheck = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logInbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.AutoSize = true;
            this.Display.Location = new System.Drawing.Point(12, 181);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(0, 15);
            this.Display.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.AllowDrop = true;
            this.AddButton.BackColor = System.Drawing.Color.Lime;
            this.AddButton.Location = new System.Drawing.Point(447, 113);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(132, 44);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Red;
            this.RemoveButton.Location = new System.Drawing.Point(612, 113);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(140, 44);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Visible = false;
            this.RemoveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ItemBox
            // 
            this.ItemBox.Location = new System.Drawing.Point(446, 79);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(133, 23);
            this.ItemBox.TabIndex = 5;
            this.ItemBox.Visible = false;
            this.ItemBox.TextChanged += new System.EventHandler(this.ItemBox_TextChanged);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(589, 83);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(57, 15);
            this.Amount.TabIndex = 6;
            this.Amount.Text = "Amount :";
            this.Amount.Visible = false;
            // 
            // NumbBox
            // 
            this.NumbBox.Location = new System.Drawing.Point(652, 79);
            this.NumbBox.Name = "NumbBox";
            this.NumbBox.Size = new System.Drawing.Size(100, 23);
            this.NumbBox.TabIndex = 7;
            this.NumbBox.Visible = false;
            this.NumbBox.TextChanged += new System.EventHandler(this.NumbBox_TextChanged);
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.Location = new System.Drawing.Point(403, 83);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(37, 15);
            this.Item.TabIndex = 8;
            this.Item.Text = "Item :";
            this.Item.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 75);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter or Remove the selected Amount of Stock\r\n\r\n\r\n\r\n\r\n";
            this.label1.Visible = false;
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.ItemHeight = 15;
            this.itemList.Location = new System.Drawing.Point(447, 196);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(305, 244);
            this.itemList.TabIndex = 10;
            this.itemList.Visible = false;
            this.itemList.SelectedIndexChanged += new System.EventHandler(this.StockList_SelectedIndexChanged);
            // 
            // CheckList
            // 
            this.CheckList.FormattingEnabled = true;
            this.CheckList.ItemHeight = 15;
            this.CheckList.Location = new System.Drawing.Point(12, 196);
            this.CheckList.Name = "CheckList";
            this.CheckList.Size = new System.Drawing.Size(197, 229);
            this.CheckList.TabIndex = 11;
            this.CheckList.Visible = false;
            this.CheckList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // CheckBox
            // 
            this.CheckBox.Location = new System.Drawing.Point(95, 134);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(114, 23);
            this.CheckBox.TabIndex = 12;
            this.CheckBox.Visible = false;
            this.CheckBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelCheck
            // 
            this.LabelCheck.AutoSize = true;
            this.LabelCheck.Location = new System.Drawing.Point(35, 137);
            this.LabelCheck.Name = "LabelCheck";
            this.LabelCheck.Size = new System.Drawing.Size(37, 15);
            this.LabelCheck.TabIndex = 13;
            this.LabelCheck.Text = "Item :";
            this.LabelCheck.Visible = false;
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(95, 12);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(100, 23);
            this.textUser.TabIndex = 14;
            this.textUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(95, 58);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(100, 23);
            this.textPass.TabIndex = 15;
            this.textPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password";
            // 
            // logInbtn
            // 
            this.logInbtn.Location = new System.Drawing.Point(235, 34);
            this.logInbtn.Name = "logInbtn";
            this.logInbtn.Size = new System.Drawing.Size(75, 23);
            this.logInbtn.TabIndex = 18;
            this.logInbtn.Text = "Log in";
            this.logInbtn.UseVisualStyleBackColor = true;
            this.logInbtn.Click += new System.EventHandler(this.logInbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logInbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.LabelCheck);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.CheckList);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.NumbBox);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.ItemBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label Display;
        private Button AddButton;
        private Button RemoveButton;
        private TextBox ItemBox;
        private Label Amount;
        private TextBox NumbBox;
        private Label Item;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox itemList;
        private ListBox CheckList;
        private TextBox CheckBox;
        private Label LabelCheck;
        private TextBox textUser;
        private TextBox textPass;
        private Label label2;
        private Label label3;
        private Button logInbtn;
    }
}