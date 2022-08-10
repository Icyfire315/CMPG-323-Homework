namespace Creative_I_DO
{
    partial class fmFlorists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmFlorists));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.saveOrders = new System.Windows.Forms.SaveFileDialog();
            this.openOrders = new System.Windows.Forms.OpenFileDialog();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboPayment = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboP_or_D = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gpResults = new System.Windows.Forms.GroupBox();
            this.cboxT_and_C = new System.Windows.Forms.CheckBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.listPlants = new System.Windows.Forms.ListBox();
            this.pnlPlants = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpResults.SuspendLayout();
            this.pnlPlants.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAppend);
            this.groupBox1.Controls.Add(this.btnRead);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.btnWrite);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(0, 56);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(87, 23);
            this.btnAppend.TabIndex = 8;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.Transparent;
            this.btnRead.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(93, 23);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(87, 27);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.Color.Transparent;
            this.btnWrite.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(0, 23);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(87, 27);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(171, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openOrders
            // 
            this.openOrders.FileName = "openFileDialog1";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(147, 51);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(116, 22);
            this.txtNum.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(147, 107);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(116, 22);
            this.txtQuantity.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(147, 79);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(116, 22);
            this.txtPrice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plant number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSlateGray;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("French Script MT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(707, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Budding Florists";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Please enter the following:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboPayment);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cboP_or_D);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Location = new System.Drawing.Point(12, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 220);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // cboPayment
            // 
            this.cboPayment.FormattingEnabled = true;
            this.cboPayment.Items.AddRange(new object[] {
            "Credit Card",
            "EFT"});
            this.cboPayment.Location = new System.Drawing.Point(142, 191);
            this.cboPayment.Name = "cboPayment";
            this.cboPayment.Size = new System.Drawing.Size(121, 23);
            this.cboPayment.Sorted = true;
            this.cboPayment.TabIndex = 6;
            this.cboPayment.Text = "EFT";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 193);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 15);
            this.label19.TabIndex = 11;
            this.label19.Text = "Payment method:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(116, 163);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(147, 22);
            this.txtAddress.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Pickup/Delivery:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Enter Address:";
            // 
            // cboP_or_D
            // 
            this.cboP_or_D.FormattingEnabled = true;
            this.cboP_or_D.Items.AddRange(new object[] {
            "Delivery",
            "Pick up"});
            this.cboP_or_D.Location = new System.Drawing.Point(147, 135);
            this.cboP_or_D.Name = "cboP_or_D";
            this.cboP_or_D.Size = new System.Drawing.Size(116, 23);
            this.cboP_or_D.Sorted = true;
            this.cboP_or_D.TabIndex = 4;
            this.cboP_or_D.Text = "Delivery";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSlateGray;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Font = new System.Drawing.Font("French Script MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(0, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(707, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Adding a bit of colour to your life!";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpResults
            // 
            this.gpResults.BackColor = System.Drawing.Color.Transparent;
            this.gpResults.Controls.Add(this.cboxT_and_C);
            this.gpResults.Controls.Add(this.btnClose);
            this.gpResults.Controls.Add(this.lblSelected);
            this.gpResults.Controls.Add(this.btnClearAll);
            this.gpResults.Controls.Add(this.btnRemove);
            this.gpResults.Controls.Add(this.groupBox1);
            this.gpResults.Controls.Add(this.btnClear);
            this.gpResults.Controls.Add(this.btnAdd);
            this.gpResults.Controls.Add(this.lblItem);
            this.gpResults.Controls.Add(this.listPlants);
            this.gpResults.Location = new System.Drawing.Point(12, 271);
            this.gpResults.Name = "gpResults";
            this.gpResults.Size = new System.Drawing.Size(683, 246);
            this.gpResults.TabIndex = 11;
            this.gpResults.TabStop = false;
            this.gpResults.Text = "Results..";
            // 
            // cboxT_and_C
            // 
            this.cboxT_and_C.AutoSize = true;
            this.cboxT_and_C.Location = new System.Drawing.Point(9, 181);
            this.cboxT_and_C.Name = "cboxT_and_C";
            this.cboxT_and_C.Size = new System.Drawing.Size(238, 19);
            this.cboxT_and_C.TabIndex = 10;
            this.cboxT_and_C.Text = "I agree to the terms and conditions";
            this.cboxT_and_C.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(93, 56);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(87, 23);
            this.btnDisplay.TabIndex = 9;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(94, 215);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(13, 15);
            this.lblSelected.TabIndex = 7;
            this.lblSelected.Text = "?";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(90, 50);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(99, 23);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(90, 21);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(9, 50);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(9, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(0, 215);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(91, 15);
            this.lblItem.TabIndex = 1;
            this.lblItem.Text = "Selected item:";
            // 
            // listPlants
            // 
            this.listPlants.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPlants.FormattingEnabled = true;
            this.listPlants.HorizontalScrollbar = true;
            this.listPlants.ItemHeight = 16;
            this.listPlants.Location = new System.Drawing.Point(358, 19);
            this.listPlants.Name = "listPlants";
            this.listPlants.ScrollAlwaysVisible = true;
            this.listPlants.Size = new System.Drawing.Size(319, 180);
            this.listPlants.TabIndex = 0;
            this.listPlants.SelectedIndexChanged += new System.EventHandler(this.listPlants_SelectedIndexChanged);
            // 
            // pnlPlants
            // 
            this.pnlPlants.BackColor = System.Drawing.Color.Thistle;
            this.pnlPlants.Controls.Add(this.label18);
            this.pnlPlants.Controls.Add(this.label16);
            this.pnlPlants.Controls.Add(this.label15);
            this.pnlPlants.Controls.Add(this.label14);
            this.pnlPlants.Controls.Add(this.label13);
            this.pnlPlants.Controls.Add(this.label12);
            this.pnlPlants.Controls.Add(this.label11);
            this.pnlPlants.Controls.Add(this.label10);
            this.pnlPlants.Controls.Add(this.label9);
            this.pnlPlants.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPlants.Location = new System.Drawing.Point(375, 81);
            this.pnlPlants.Name = "pnlPlants";
            this.pnlPlants.Size = new System.Drawing.Size(249, 147);
            this.pnlPlants.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(72, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 15);
            this.label18.TabIndex = 8;
            this.label18.Text = "9.SnapDragons";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(118, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 15);
            this.label16.TabIndex = 7;
            this.label16.Text = "8.Red Coranation";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(118, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 15);
            this.label15.TabIndex = 6;
            this.label15.Text = "7.Hibiscus";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(118, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "6.Gerbera";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(118, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 15);
            this.label13.TabIndex = 4;
            this.label13.Text = "5.Forget-Me-Nots";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "4.English BlueBell";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "3.Desert Rose";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "2.Baby\'s Breath";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "1. African Daisy";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Bright", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(442, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 15);
            this.label17.TabIndex = 13;
            this.label17.Text = "Plant Numbers";
            // 
            // fmFlorists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(707, 563);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pnlPlants);
            this.Controls.Add(this.gpResults);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fmFlorists";
            this.Text = "Budding Florists";
            this.Load += new System.EventHandler(this.fmFlorists_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpResults.ResumeLayout(false);
            this.gpResults.PerformLayout();
            this.pnlPlants.ResumeLayout(false);
            this.pnlPlants.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.SaveFileDialog saveOrders;
        private System.Windows.Forms.OpenFileDialog openOrders;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboP_or_D;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpResults;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.ListBox listPlants;
        private System.Windows.Forms.Panel pnlPlants;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.CheckBox cboxT_and_C;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cboPayment;
    }
}

