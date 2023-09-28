namespace MyFirstWinFormsProject
{
    partial class MakePizza
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
            this.Title = new System.Windows.Forms.Label();
            this.btnSmallSize = new System.Windows.Forms.RadioButton();
            this.btnLargeSize = new System.Windows.Forms.RadioButton();
            this.btnMeduimSize = new System.Windows.Forms.RadioButton();
            this.chkPizzaSize = new System.Windows.Forms.GroupBox();
            this.GrbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.GrbCrustType = new System.Windows.Forms.GroupBox();
            this.btnThinkCrust = new System.Windows.Forms.RadioButton();
            this.btnThinCrust = new System.Windows.Forms.RadioButton();
            this.GrbEWhereToEat = new System.Windows.Forms.GroupBox();
            this.BtnTakeOut = new System.Windows.Forms.RadioButton();
            this.btnEatIn = new System.Windows.Forms.RadioButton();
            this.Btn_OrderPizza = new System.Windows.Forms.Button();
            this.Btn_ResetForm = new System.Windows.Forms.Button();
            this.GrbOrderSummary = new System.Windows.Forms.GroupBox();
            this.LbEat = new System.Windows.Forms.Label();
            this.LbTextSize2 = new System.Windows.Forms.Label();
            this.LbCrustTypeText = new System.Windows.Forms.Label();
            this.lblTotalePrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LbTextSize = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.LbWhereToEat = new System.Windows.Forms.Label();
            this.LbToppings = new System.Windows.Forms.Label();
            this.LbCrustType = new System.Windows.Forms.Label();
            this.LbSize = new System.Windows.Forms.Label();
            this.GrToppings = new System.Windows.Forms.GroupBox();
            this.chkPizzaSize.SuspendLayout();
            this.GrbToppings.SuspendLayout();
            this.GrbCrustType.SuspendLayout();
            this.GrbEWhereToEat.SuspendLayout();
            this.GrbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Red;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Khaki;
            this.Title.Location = new System.Drawing.Point(292, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(477, 80);
            this.Title.TabIndex = 0;
            this.Title.Text = "MAKE YOUR PIZZA";
            // 
            // btnSmallSize
            // 
            this.btnSmallSize.AutoSize = true;
            this.btnSmallSize.Checked = true;
            this.btnSmallSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmallSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmallSize.Location = new System.Drawing.Point(39, 25);
            this.btnSmallSize.Name = "btnSmallSize";
            this.btnSmallSize.Size = new System.Drawing.Size(58, 20);
            this.btnSmallSize.TabIndex = 1;
            this.btnSmallSize.TabStop = true;
            this.btnSmallSize.Tag = "20";
            this.btnSmallSize.Text = "Small";
            this.btnSmallSize.UseVisualStyleBackColor = true;
            this.btnSmallSize.CheckedChanged += new System.EventHandler(this.btnSmallSize_CheckedChanged);
            // 
            // btnLargeSize
            // 
            this.btnLargeSize.AutoSize = true;
            this.btnLargeSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLargeSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLargeSize.Location = new System.Drawing.Point(39, 71);
            this.btnLargeSize.Name = "btnLargeSize";
            this.btnLargeSize.Size = new System.Drawing.Size(51, 20);
            this.btnLargeSize.TabIndex = 2;
            this.btnLargeSize.Tag = "40";
            this.btnLargeSize.Text = "Larg";
            this.btnLargeSize.UseVisualStyleBackColor = true;
            this.btnLargeSize.CheckedChanged += new System.EventHandler(this.btnLargeSize_CheckedChanged);
            // 
            // btnMeduimSize
            // 
            this.btnMeduimSize.AutoSize = true;
            this.btnMeduimSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeduimSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeduimSize.Location = new System.Drawing.Point(39, 48);
            this.btnMeduimSize.Name = "btnMeduimSize";
            this.btnMeduimSize.Size = new System.Drawing.Size(72, 20);
            this.btnMeduimSize.TabIndex = 3;
            this.btnMeduimSize.Tag = "30";
            this.btnMeduimSize.Text = "Meduim";
            this.btnMeduimSize.UseVisualStyleBackColor = true;
            this.btnMeduimSize.CheckedChanged += new System.EventHandler(this.btnMeduimSize_CheckedChanged);
            // 
            // chkPizzaSize
            // 
            this.chkPizzaSize.BackColor = System.Drawing.SystemColors.Control;
            this.chkPizzaSize.Controls.Add(this.btnMeduimSize);
            this.chkPizzaSize.Controls.Add(this.btnLargeSize);
            this.chkPizzaSize.Controls.Add(this.btnSmallSize);
            this.chkPizzaSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkPizzaSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPizzaSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkPizzaSize.Location = new System.Drawing.Point(62, 103);
            this.chkPizzaSize.Name = "chkPizzaSize";
            this.chkPizzaSize.Size = new System.Drawing.Size(143, 112);
            this.chkPizzaSize.TabIndex = 4;
            this.chkPizzaSize.TabStop = false;
            this.chkPizzaSize.Text = "Size";
            // 
            // GrbToppings
            // 
            this.GrbToppings.Controls.Add(this.chkGreenPeppers);
            this.GrbToppings.Controls.Add(this.chkOlives);
            this.GrbToppings.Controls.Add(this.chkOnion);
            this.GrbToppings.Controls.Add(this.chkMushrooms);
            this.GrbToppings.Controls.Add(this.chkExtraChees);
            this.GrbToppings.Controls.Add(this.chkTomatoes);
            this.GrbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbToppings.Location = new System.Drawing.Point(296, 128);
            this.GrbToppings.Name = "GrbToppings";
            this.GrbToppings.Size = new System.Drawing.Size(319, 112);
            this.GrbToppings.TabIndex = 5;
            this.GrbToppings.TabStop = false;
            this.GrbToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(183, 70);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(118, 20);
            this.chkGreenPeppers.TabIndex = 11;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(183, 49);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(64, 20);
            this.chkOlives.TabIndex = 10;
            this.chkOlives.Tag = "3";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(183, 28);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(61, 20);
            this.chkOnion.TabIndex = 9;
            this.chkOnion.Tag = "3";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(37, 51);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(96, 20);
            this.chkMushrooms.TabIndex = 8;
            this.chkMushrooms.Tag = "10";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(37, 28);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(98, 20);
            this.chkExtraChees.TabIndex = 6;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(37, 74);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(88, 20);
            this.chkTomatoes.TabIndex = 7;
            this.chkTomatoes.Tag = "3";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // GrbCrustType
            // 
            this.GrbCrustType.BackColor = System.Drawing.SystemColors.Control;
            this.GrbCrustType.Controls.Add(this.btnThinkCrust);
            this.GrbCrustType.Controls.Add(this.btnThinCrust);
            this.GrbCrustType.Cursor = System.Windows.Forms.Cursors.Default;
            this.GrbCrustType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCrustType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GrbCrustType.Location = new System.Drawing.Point(62, 253);
            this.GrbCrustType.Name = "GrbCrustType";
            this.GrbCrustType.Size = new System.Drawing.Size(143, 90);
            this.GrbCrustType.TabIndex = 6;
            this.GrbCrustType.TabStop = false;
            this.GrbCrustType.Text = "Crust Type";
            // 
            // btnThinkCrust
            // 
            this.btnThinkCrust.AutoSize = true;
            this.btnThinkCrust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThinkCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThinkCrust.Location = new System.Drawing.Point(39, 48);
            this.btnThinkCrust.Name = "btnThinkCrust";
            this.btnThinkCrust.Size = new System.Drawing.Size(90, 20);
            this.btnThinkCrust.TabIndex = 3;
            this.btnThinkCrust.Tag = "10";
            this.btnThinkCrust.Text = "Think Crust";
            this.btnThinkCrust.UseVisualStyleBackColor = true;
            this.btnThinkCrust.CheckedChanged += new System.EventHandler(this.btnThinkCrust_CheckedChanged);
            // 
            // btnThinCrust
            // 
            this.btnThinCrust.AutoSize = true;
            this.btnThinCrust.Checked = true;
            this.btnThinCrust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThinCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThinCrust.Location = new System.Drawing.Point(39, 25);
            this.btnThinCrust.Name = "btnThinCrust";
            this.btnThinCrust.Size = new System.Drawing.Size(83, 20);
            this.btnThinCrust.TabIndex = 1;
            this.btnThinCrust.TabStop = true;
            this.btnThinCrust.Tag = "0";
            this.btnThinCrust.Text = "Thin Crust";
            this.btnThinCrust.UseVisualStyleBackColor = true;
            this.btnThinCrust.CheckedChanged += new System.EventHandler(this.btnThinCrust_CheckedChanged);
            // 
            // GrbEWhereToEat
            // 
            this.GrbEWhereToEat.Controls.Add(this.BtnTakeOut);
            this.GrbEWhereToEat.Controls.Add(this.btnEatIn);
            this.GrbEWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbEWhereToEat.Location = new System.Drawing.Point(296, 293);
            this.GrbEWhereToEat.Name = "GrbEWhereToEat";
            this.GrbEWhereToEat.Size = new System.Drawing.Size(319, 79);
            this.GrbEWhereToEat.TabIndex = 7;
            this.GrbEWhereToEat.TabStop = false;
            this.GrbEWhereToEat.Text = "Where To Eat";
            // 
            // BtnTakeOut
            // 
            this.BtnTakeOut.AutoSize = true;
            this.BtnTakeOut.Location = new System.Drawing.Point(186, 40);
            this.BtnTakeOut.Name = "BtnTakeOut";
            this.BtnTakeOut.Size = new System.Drawing.Size(80, 20);
            this.BtnTakeOut.TabIndex = 1;
            this.BtnTakeOut.TabStop = true;
            this.BtnTakeOut.Text = "Take Out";
            this.BtnTakeOut.UseVisualStyleBackColor = true;
            this.BtnTakeOut.CheckedChanged += new System.EventHandler(this.BtnTakeOut_CheckedChanged);
            // 
            // btnEatIn
            // 
            this.btnEatIn.AutoSize = true;
            this.btnEatIn.Checked = true;
            this.btnEatIn.Location = new System.Drawing.Point(35, 40);
            this.btnEatIn.Name = "btnEatIn";
            this.btnEatIn.Size = new System.Drawing.Size(58, 20);
            this.btnEatIn.TabIndex = 0;
            this.btnEatIn.TabStop = true;
            this.btnEatIn.Text = "Eat In";
            this.btnEatIn.UseVisualStyleBackColor = true;
            this.btnEatIn.CheckedChanged += new System.EventHandler(this.btnEatIn_CheckedChanged);
            // 
            // Btn_OrderPizza
            // 
            this.Btn_OrderPizza.Location = new System.Drawing.Point(319, 408);
            this.Btn_OrderPizza.Name = "Btn_OrderPizza";
            this.Btn_OrderPizza.Size = new System.Drawing.Size(143, 44);
            this.Btn_OrderPizza.TabIndex = 8;
            this.Btn_OrderPizza.Text = "Order Pizza";
            this.Btn_OrderPizza.UseVisualStyleBackColor = true;
            this.Btn_OrderPizza.Click += new System.EventHandler(this.Btn_OrderPizza_Click);
            // 
            // Btn_ResetForm
            // 
            this.Btn_ResetForm.Location = new System.Drawing.Point(521, 408);
            this.Btn_ResetForm.Name = "Btn_ResetForm";
            this.Btn_ResetForm.Size = new System.Drawing.Size(147, 44);
            this.Btn_ResetForm.TabIndex = 9;
            this.Btn_ResetForm.Text = "Reset";
            this.Btn_ResetForm.UseVisualStyleBackColor = true;
            this.Btn_ResetForm.Click += new System.EventHandler(this.Btn_ResetForm_Click);
            // 
            // GrbOrderSummary
            // 
            this.GrbOrderSummary.Controls.Add(this.GrToppings);
            this.GrbOrderSummary.Controls.Add(this.LbEat);
            this.GrbOrderSummary.Controls.Add(this.LbTextSize2);
            this.GrbOrderSummary.Controls.Add(this.LbCrustTypeText);
            this.GrbOrderSummary.Controls.Add(this.lblTotalePrice);
            this.GrbOrderSummary.Controls.Add(this.label4);
            this.GrbOrderSummary.Controls.Add(this.LbTextSize);
            this.GrbOrderSummary.Controls.Add(this.TotalPrice);
            this.GrbOrderSummary.Controls.Add(this.LbWhereToEat);
            this.GrbOrderSummary.Controls.Add(this.LbToppings);
            this.GrbOrderSummary.Controls.Add(this.LbCrustType);
            this.GrbOrderSummary.Controls.Add(this.LbSize);
            this.GrbOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbOrderSummary.Location = new System.Drawing.Point(735, 111);
            this.GrbOrderSummary.Name = "GrbOrderSummary";
            this.GrbOrderSummary.Size = new System.Drawing.Size(299, 292);
            this.GrbOrderSummary.TabIndex = 10;
            this.GrbOrderSummary.TabStop = false;
            this.GrbOrderSummary.Text = "Order Summary";
            // 
            // LbEat
            // 
            this.LbEat.AutoSize = true;
            this.LbEat.Location = new System.Drawing.Point(78, 190);
            this.LbEat.Name = "LbEat";
            this.LbEat.Size = new System.Drawing.Size(40, 16);
            this.LbEat.TabIndex = 17;
            this.LbEat.Text = "Eat In";
            // 
            // LbTextSize2
            // 
            this.LbTextSize2.AutoSize = true;
            this.LbTextSize2.Location = new System.Drawing.Point(72, 42);
            this.LbTextSize2.Name = "LbTextSize2";
            this.LbTextSize2.Size = new System.Drawing.Size(41, 16);
            this.LbTextSize2.TabIndex = 16;
            this.LbTextSize2.Text = "Small";
            // 
            // LbCrustTypeText
            // 
            this.LbCrustTypeText.AutoSize = true;
            this.LbCrustTypeText.Location = new System.Drawing.Point(122, 142);
            this.LbCrustTypeText.Name = "LbCrustTypeText";
            this.LbCrustTypeText.Size = new System.Drawing.Size(66, 16);
            this.LbCrustTypeText.TabIndex = 15;
            this.LbCrustTypeText.Text = "Thin Crust";
            // 
            // lblTotalePrice
            // 
            this.lblTotalePrice.AutoSize = true;
            this.lblTotalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalePrice.ForeColor = System.Drawing.Color.Green;
            this.lblTotalePrice.Location = new System.Drawing.Point(139, 207);
            this.lblTotalePrice.Name = "lblTotalePrice";
            this.lblTotalePrice.Size = new System.Drawing.Size(106, 73);
            this.lblTotalePrice.TabIndex = 9;
            this.lblTotalePrice.Text = "0$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 8;
            // 
            // LbTextSize
            // 
            this.LbTextSize.AutoSize = true;
            this.LbTextSize.Enabled = false;
            this.LbTextSize.Location = new System.Drawing.Point(81, 42);
            this.LbTextSize.Name = "LbTextSize";
            this.LbTextSize.Size = new System.Drawing.Size(0, 16);
            this.LbTextSize.TabIndex = 5;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(29, 216);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(87, 16);
            this.TotalPrice.TabIndex = 4;
            this.TotalPrice.Text = "Total Price:";
            // 
            // LbWhereToEat
            // 
            this.LbWhereToEat.AutoSize = true;
            this.LbWhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWhereToEat.Location = new System.Drawing.Point(29, 167);
            this.LbWhereToEat.Name = "LbWhereToEat";
            this.LbWhereToEat.Size = new System.Drawing.Size(106, 16);
            this.LbWhereToEat.TabIndex = 3;
            this.LbWhereToEat.Text = "Where To Eat:";
            // 
            // LbToppings
            // 
            this.LbToppings.AutoSize = true;
            this.LbToppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbToppings.Location = new System.Drawing.Point(29, 69);
            this.LbToppings.Name = "LbToppings";
            this.LbToppings.Size = new System.Drawing.Size(77, 16);
            this.LbToppings.TabIndex = 2;
            this.LbToppings.Text = "Toppings:";
            // 
            // LbCrustType
            // 
            this.LbCrustType.AutoSize = true;
            this.LbCrustType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCrustType.Location = new System.Drawing.Point(30, 142);
            this.LbCrustType.Name = "LbCrustType";
            this.LbCrustType.Size = new System.Drawing.Size(86, 16);
            this.LbCrustType.TabIndex = 1;
            this.LbCrustType.Text = "Crust Type:";
            // 
            // LbSize
            // 
            this.LbSize.AutoSize = true;
            this.LbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSize.Location = new System.Drawing.Point(29, 41);
            this.LbSize.Name = "LbSize";
            this.LbSize.Size = new System.Drawing.Size(41, 16);
            this.LbSize.TabIndex = 0;
            this.LbSize.Text = "Size:";
            // 
            // GrToppings
            // 
            this.GrToppings.Location = new System.Drawing.Point(17, 91);
            this.GrToppings.Name = "GrToppings";
            this.GrToppings.Size = new System.Drawing.Size(264, 51);
            this.GrToppings.TabIndex = 18;
            this.GrToppings.TabStop = false;
            this.GrToppings.Text = "No Toppings";
            // 
            // MakePizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 526);
            this.Controls.Add(this.GrbOrderSummary);
            this.Controls.Add(this.Btn_ResetForm);
            this.Controls.Add(this.Btn_OrderPizza);
            this.Controls.Add(this.GrbEWhereToEat);
            this.Controls.Add(this.GrbCrustType);
            this.Controls.Add(this.GrbToppings);
            this.Controls.Add(this.chkPizzaSize);
            this.Controls.Add(this.Title);
            this.Name = "MakePizza";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MakePizza_Load);
            this.chkPizzaSize.ResumeLayout(false);
            this.chkPizzaSize.PerformLayout();
            this.GrbToppings.ResumeLayout(false);
            this.GrbToppings.PerformLayout();
            this.GrbCrustType.ResumeLayout(false);
            this.GrbCrustType.PerformLayout();
            this.GrbEWhereToEat.ResumeLayout(false);
            this.GrbEWhereToEat.PerformLayout();
            this.GrbOrderSummary.ResumeLayout(false);
            this.GrbOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.RadioButton btnSmallSize;
        private System.Windows.Forms.RadioButton btnLargeSize;
        private System.Windows.Forms.RadioButton btnMeduimSize;
        private System.Windows.Forms.GroupBox chkPizzaSize;
        private System.Windows.Forms.GroupBox GrbToppings;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.GroupBox GrbCrustType;
        private System.Windows.Forms.RadioButton btnThinkCrust;
        private System.Windows.Forms.RadioButton btnThinCrust;
        private System.Windows.Forms.GroupBox GrbEWhereToEat;
        private System.Windows.Forms.RadioButton btnEatIn;
        private System.Windows.Forms.RadioButton BtnTakeOut;
        private System.Windows.Forms.Button Btn_OrderPizza;
        private System.Windows.Forms.Button Btn_ResetForm;
        private System.Windows.Forms.GroupBox GrbOrderSummary;
        private System.Windows.Forms.Label LbWhereToEat;
        private System.Windows.Forms.Label LbToppings;
        private System.Windows.Forms.Label LbCrustType;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Label lblTotalePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbTextSize;
 
        private System.Windows.Forms.Label LbSize;
        private System.Windows.Forms.Label LbCrustTypeText;
        private System.Windows.Forms.Label LbTextSize2;
        private System.Windows.Forms.Label LbEat;
        private System.Windows.Forms.GroupBox GrToppings;
    }
}

