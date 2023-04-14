namespace Assigment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.TextBox();
            this.nameSurnameText = new System.Windows.Forms.TextBox();
            this.pizzaTypesGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.mixedRadioBtn = new System.Windows.Forms.RadioButton();
            this.napolitenRadioBtn = new System.Windows.Forms.RadioButton();
            this.marineRadioBtn = new System.Windows.Forms.RadioButton();
            this.sicilianRadioBtn = new System.Windows.Forms.RadioButton();
            this.additionGroupBox = new System.Windows.Forms.GroupBox();
            this.pickleBox = new System.Windows.Forms.CheckBox();
            this.oliveBox = new System.Windows.Forms.CheckBox();
            this.mushroomBox = new System.Windows.Forms.CheckBox();
            this.tomatoBox = new System.Windows.Forms.CheckBox();
            this.greenPeperBox = new System.Windows.Forms.CheckBox();
            this.currentOrderBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grandTotalText = new System.Windows.Forms.TextBox();
            this.orderListView = new System.Windows.Forms.ListView();
            this.insertBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.newOrderBtn = new System.Windows.Forms.Button();
            this.newCustomerBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.lastGroupBox = new System.Windows.Forms.GroupBox();
            this.ofUnitSpinText = new System.Windows.Forms.NumericUpDown();
            this.calorieText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unitPriceText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.pizzaTypesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.additionGroupBox.SuspendLayout();
            this.currentOrderBox.SuspendLayout();
            this.lastGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ofUnitSpinText)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addressText);
            this.groupBox1.Controls.Add(this.nameSurnameText);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1640, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name Surname";
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(180, 111);
            this.addressText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(1122, 26);
            this.addressText.TabIndex = 1;
            this.addressText.TextChanged += new System.EventHandler(this.customerInformationChanged);
            // 
            // nameSurnameText
            // 
            this.nameSurnameText.Location = new System.Drawing.Point(180, 51);
            this.nameSurnameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameSurnameText.Name = "nameSurnameText";
            this.nameSurnameText.Size = new System.Drawing.Size(432, 26);
            this.nameSurnameText.TabIndex = 0;
            this.nameSurnameText.TextChanged += new System.EventHandler(this.customerInformationChanged);
            this.nameSurnameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameSurnameText_KeyDown);
            // 
            // pizzaTypesGroupBox
            // 
            this.pizzaTypesGroupBox.Controls.Add(this.pictureBox);
            this.pizzaTypesGroupBox.Controls.Add(this.mixedRadioBtn);
            this.pizzaTypesGroupBox.Controls.Add(this.napolitenRadioBtn);
            this.pizzaTypesGroupBox.Controls.Add(this.marineRadioBtn);
            this.pizzaTypesGroupBox.Controls.Add(this.sicilianRadioBtn);
            this.pizzaTypesGroupBox.Location = new System.Drawing.Point(18, 214);
            this.pizzaTypesGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pizzaTypesGroupBox.Name = "pizzaTypesGroupBox";
            this.pizzaTypesGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pizzaTypesGroupBox.Size = new System.Drawing.Size(410, 220);
            this.pizzaTypesGroupBox.TabIndex = 1;
            this.pizzaTypesGroupBox.TabStop = false;
            this.pizzaTypesGroupBox.Text = "Pizza Types";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(207, 34);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(168, 151);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // mixedRadioBtn
            // 
            this.mixedRadioBtn.AutoSize = true;
            this.mixedRadioBtn.Location = new System.Drawing.Point(9, 152);
            this.mixedRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mixedRadioBtn.Name = "mixedRadioBtn";
            this.mixedRadioBtn.Size = new System.Drawing.Size(68, 24);
            this.mixedRadioBtn.TabIndex = 3;
            this.mixedRadioBtn.TabStop = true;
            this.mixedRadioBtn.Text = "Mixed";
            this.mixedRadioBtn.UseVisualStyleBackColor = true;
            this.mixedRadioBtn.Click += new System.EventHandler(this.mixedRadioBtn_Click);
            // 
            // napolitenRadioBtn
            // 
            this.napolitenRadioBtn.AutoSize = true;
            this.napolitenRadioBtn.Location = new System.Drawing.Point(9, 117);
            this.napolitenRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.napolitenRadioBtn.Name = "napolitenRadioBtn";
            this.napolitenRadioBtn.Size = new System.Drawing.Size(94, 24);
            this.napolitenRadioBtn.TabIndex = 2;
            this.napolitenRadioBtn.TabStop = true;
            this.napolitenRadioBtn.Text = "Napoliten";
            this.napolitenRadioBtn.UseVisualStyleBackColor = true;
            this.napolitenRadioBtn.Click += new System.EventHandler(this.napolitenRadioBtn_Click);
            // 
            // marineRadioBtn
            // 
            this.marineRadioBtn.AutoSize = true;
            this.marineRadioBtn.Location = new System.Drawing.Point(9, 82);
            this.marineRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.marineRadioBtn.Name = "marineRadioBtn";
            this.marineRadioBtn.Size = new System.Drawing.Size(75, 24);
            this.marineRadioBtn.TabIndex = 1;
            this.marineRadioBtn.TabStop = true;
            this.marineRadioBtn.Text = "Marine";
            this.marineRadioBtn.UseVisualStyleBackColor = true;
            this.marineRadioBtn.Click += new System.EventHandler(this.marineRadioBtn_Click);
            // 
            // sicilianRadioBtn
            // 
            this.sicilianRadioBtn.AutoSize = true;
            this.sicilianRadioBtn.Location = new System.Drawing.Point(9, 46);
            this.sicilianRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sicilianRadioBtn.Name = "sicilianRadioBtn";
            this.sicilianRadioBtn.Size = new System.Drawing.Size(76, 24);
            this.sicilianRadioBtn.TabIndex = 0;
            this.sicilianRadioBtn.TabStop = true;
            this.sicilianRadioBtn.Text = "Sicilian";
            this.sicilianRadioBtn.UseVisualStyleBackColor = true;
            this.sicilianRadioBtn.Click += new System.EventHandler(this.sicilianRadioBtn_Click);
            // 
            // additionGroupBox
            // 
            this.additionGroupBox.Controls.Add(this.pickleBox);
            this.additionGroupBox.Controls.Add(this.oliveBox);
            this.additionGroupBox.Controls.Add(this.mushroomBox);
            this.additionGroupBox.Controls.Add(this.tomatoBox);
            this.additionGroupBox.Controls.Add(this.greenPeperBox);
            this.additionGroupBox.Location = new System.Drawing.Point(18, 463);
            this.additionGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.additionGroupBox.Name = "additionGroupBox";
            this.additionGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.additionGroupBox.Size = new System.Drawing.Size(410, 185);
            this.additionGroupBox.TabIndex = 2;
            this.additionGroupBox.TabStop = false;
            this.additionGroupBox.Text = "Additions";
            // 
            // pickleBox
            // 
            this.pickleBox.AutoSize = true;
            this.pickleBox.Location = new System.Drawing.Point(9, 131);
            this.pickleBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pickleBox.Name = "pickleBox";
            this.pickleBox.Size = new System.Drawing.Size(69, 24);
            this.pickleBox.TabIndex = 4;
            this.pickleBox.Text = "Pickle";
            this.pickleBox.UseVisualStyleBackColor = true;
            this.pickleBox.CheckedChanged += new System.EventHandler(this.pickleBox_CheckedChanged);
            // 
            // oliveBox
            // 
            this.oliveBox.AutoSize = true;
            this.oliveBox.Location = new System.Drawing.Point(158, 131);
            this.oliveBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oliveBox.Name = "oliveBox";
            this.oliveBox.Size = new System.Drawing.Size(62, 24);
            this.oliveBox.TabIndex = 3;
            this.oliveBox.Text = "Olive";
            this.oliveBox.UseVisualStyleBackColor = true;
            this.oliveBox.CheckedChanged += new System.EventHandler(this.oliveBox_CheckedChanged);
            // 
            // mushroomBox
            // 
            this.mushroomBox.AutoSize = true;
            this.mushroomBox.Location = new System.Drawing.Point(158, 46);
            this.mushroomBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mushroomBox.Name = "mushroomBox";
            this.mushroomBox.Size = new System.Drawing.Size(103, 24);
            this.mushroomBox.TabIndex = 2;
            this.mushroomBox.Text = "Mushroom";
            this.mushroomBox.UseVisualStyleBackColor = true;
            this.mushroomBox.CheckedChanged += new System.EventHandler(this.mushroomBox_CheckedChanged);
            // 
            // tomatoBox
            // 
            this.tomatoBox.AutoSize = true;
            this.tomatoBox.Location = new System.Drawing.Point(9, 92);
            this.tomatoBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tomatoBox.Name = "tomatoBox";
            this.tomatoBox.Size = new System.Drawing.Size(82, 24);
            this.tomatoBox.TabIndex = 1;
            this.tomatoBox.Text = "Tomato";
            this.tomatoBox.UseVisualStyleBackColor = true;
            this.tomatoBox.CheckedChanged += new System.EventHandler(this.tomatoBox_CheckedChanged);
            // 
            // greenPeperBox
            // 
            this.greenPeperBox.AutoSize = true;
            this.greenPeperBox.Location = new System.Drawing.Point(9, 46);
            this.greenPeperBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.greenPeperBox.Name = "greenPeperBox";
            this.greenPeperBox.Size = new System.Drawing.Size(128, 24);
            this.greenPeperBox.TabIndex = 0;
            this.greenPeperBox.Text = "Green Pepper";
            this.greenPeperBox.UseVisualStyleBackColor = true;
            this.greenPeperBox.CheckedChanged += new System.EventHandler(this.greenPeperBox_CheckedChanged);
            // 
            // currentOrderBox
            // 
            this.currentOrderBox.Controls.Add(this.label3);
            this.currentOrderBox.Controls.Add(this.grandTotalText);
            this.currentOrderBox.Controls.Add(this.orderListView);
            this.currentOrderBox.Location = new System.Drawing.Point(477, 214);
            this.currentOrderBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentOrderBox.Name = "currentOrderBox";
            this.currentOrderBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentOrderBox.Size = new System.Drawing.Size(1180, 434);
            this.currentOrderBox.TabIndex = 3;
            this.currentOrderBox.TabStop = false;
            this.currentOrderBox.Text = "Current Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(788, 368);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grand Total";
            // 
            // grandTotalText
            // 
            this.grandTotalText.Location = new System.Drawing.Point(903, 362);
            this.grandTotalText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grandTotalText.Name = "grandTotalText";
            this.grandTotalText.ReadOnly = true;
            this.grandTotalText.Size = new System.Drawing.Size(266, 26);
            this.grandTotalText.TabIndex = 1;
            this.grandTotalText.Text = "0";
            // 
            // orderListView
            // 
            this.orderListView.HideSelection = false;
            this.orderListView.Location = new System.Drawing.Point(10, 46);
            this.orderListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderListView.Name = "orderListView";
            this.orderListView.Size = new System.Drawing.Size(1159, 273);
            this.orderListView.TabIndex = 0;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(554, 683);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(201, 54);
            this.insertBtn.TabIndex = 4;
            this.insertBtn.Text = "Insert Order";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(813, 683);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(201, 54);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete Order";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // newOrderBtn
            // 
            this.newOrderBtn.Location = new System.Drawing.Point(1179, 683);
            this.newOrderBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newOrderBtn.Name = "newOrderBtn";
            this.newOrderBtn.Size = new System.Drawing.Size(201, 54);
            this.newOrderBtn.TabIndex = 6;
            this.newOrderBtn.Text = "New Order";
            this.newOrderBtn.UseVisualStyleBackColor = true;
            this.newOrderBtn.Click += new System.EventHandler(this.newOrderBtn_Click);
            // 
            // newCustomerBtn
            // 
            this.newCustomerBtn.Location = new System.Drawing.Point(1448, 683);
            this.newCustomerBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newCustomerBtn.Name = "newCustomerBtn";
            this.newCustomerBtn.Size = new System.Drawing.Size(201, 54);
            this.newCustomerBtn.TabIndex = 7;
            this.newCustomerBtn.Text = "New Customer";
            this.newCustomerBtn.UseVisualStyleBackColor = true;
            this.newCustomerBtn.Click += new System.EventHandler(this.newCustomerBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(554, 842);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(1095, 54);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lastGroupBox
            // 
            this.lastGroupBox.Controls.Add(this.ofUnitSpinText);
            this.lastGroupBox.Controls.Add(this.calorieText);
            this.lastGroupBox.Controls.Add(this.label7);
            this.lastGroupBox.Controls.Add(this.totalText);
            this.lastGroupBox.Controls.Add(this.label6);
            this.lastGroupBox.Controls.Add(this.label5);
            this.lastGroupBox.Controls.Add(this.unitPriceText);
            this.lastGroupBox.Controls.Add(this.label4);
            this.lastGroupBox.Location = new System.Drawing.Point(18, 698);
            this.lastGroupBox.Name = "lastGroupBox";
            this.lastGroupBox.Size = new System.Drawing.Size(410, 255);
            this.lastGroupBox.TabIndex = 9;
            this.lastGroupBox.TabStop = false;
            // 
            // ofUnitSpinText
            // 
            this.ofUnitSpinText.Location = new System.Drawing.Point(120, 78);
            this.ofUnitSpinText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ofUnitSpinText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ofUnitSpinText.Name = "ofUnitSpinText";
            this.ofUnitSpinText.Size = new System.Drawing.Size(90, 26);
            this.ofUnitSpinText.TabIndex = 10;
            this.ofUnitSpinText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ofUnitSpinText.ValueChanged += new System.EventHandler(this.ofUnitSpinText_ValueChanged);
            // 
            // calorieText
            // 
            this.calorieText.Location = new System.Drawing.Point(120, 186);
            this.calorieText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calorieText.Name = "calorieText";
            this.calorieText.ReadOnly = true;
            this.calorieText.Size = new System.Drawing.Size(216, 26);
            this.calorieText.TabIndex = 9;
            this.calorieText.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 40);
            this.label7.TabIndex = 8;
            this.label7.Text = "Amount of \r\nCalorie";
            // 
            // totalText
            // 
            this.totalText.Location = new System.Drawing.Point(120, 132);
            this.totalText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.totalText.Name = "totalText";
            this.totalText.ReadOnly = true;
            this.totalText.Size = new System.Drawing.Size(216, 26);
            this.totalText.TabIndex = 7;
            this.totalText.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "# of unit";
            // 
            // unitPriceText
            // 
            this.unitPriceText.Location = new System.Drawing.Point(120, 28);
            this.unitPriceText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unitPriceText.Name = "unitPriceText";
            this.unitPriceText.ReadOnly = true;
            this.unitPriceText.Size = new System.Drawing.Size(216, 26);
            this.unitPriceText.TabIndex = 4;
            this.unitPriceText.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unit Price";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Marine.jpg");
            this.imageList.Images.SetKeyName(1, "Mixed.jpg");
            this.imageList.Images.SetKeyName(2, "Napoliten.jpg");
            this.imageList.Images.SetKeyName(3, "Sicilian.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 1026);
            this.Controls.Add(this.lastGroupBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.newCustomerBtn);
            this.Controls.Add(this.newOrderBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.currentOrderBox);
            this.Controls.Add(this.additionGroupBox);
            this.Controls.Add(this.pizzaTypesGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Ordering System";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pizzaTypesGroupBox.ResumeLayout(false);
            this.pizzaTypesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.additionGroupBox.ResumeLayout(false);
            this.additionGroupBox.PerformLayout();
            this.currentOrderBox.ResumeLayout(false);
            this.currentOrderBox.PerformLayout();
            this.lastGroupBox.ResumeLayout(false);
            this.lastGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ofUnitSpinText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox nameSurnameText;
        private System.Windows.Forms.GroupBox pizzaTypesGroupBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RadioButton mixedRadioBtn;
        private System.Windows.Forms.RadioButton napolitenRadioBtn;
        private System.Windows.Forms.RadioButton marineRadioBtn;
        private System.Windows.Forms.RadioButton sicilianRadioBtn;
        private System.Windows.Forms.GroupBox additionGroupBox;
        private System.Windows.Forms.CheckBox pickleBox;
        private System.Windows.Forms.CheckBox oliveBox;
        private System.Windows.Forms.CheckBox mushroomBox;
        private System.Windows.Forms.CheckBox tomatoBox;
        private System.Windows.Forms.CheckBox greenPeperBox;
        private System.Windows.Forms.GroupBox currentOrderBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox grandTotalText;
        private System.Windows.Forms.ListView orderListView;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button newOrderBtn;
        private System.Windows.Forms.Button newCustomerBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox lastGroupBox;
        private System.Windows.Forms.TextBox unitPriceText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox calorieText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ofUnitSpinText;
        private System.Windows.Forms.ImageList imageList;
    }
}

