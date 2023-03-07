namespace Pizza_Project
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labTitle = new System.Windows.Forms.Label();
            this.panelSize = new System.Windows.Forms.Panel();
            this.labSize = new System.Windows.Forms.Label();
            this.rdBtnSizeLarge = new System.Windows.Forms.RadioButton();
            this.rdBtnSizeMedium = new System.Windows.Forms.RadioButton();
            this.rdBtnSizeSmall = new System.Windows.Forms.RadioButton();
            this.panelCrust = new System.Windows.Forms.Panel();
            this.rdBtnCrustThink = new System.Windows.Forms.RadioButton();
            this.rdBtnCrustThin = new System.Windows.Forms.RadioButton();
            this.labCrust = new System.Windows.Forms.Label();
            this.panelToppings = new System.Windows.Forms.Panel();
            this.chkBoxGrnPeppers = new System.Windows.Forms.CheckBox();
            this.chkBoxOlives = new System.Windows.Forms.CheckBox();
            this.chkBoxTomatoes = new System.Windows.Forms.CheckBox();
            this.chkBoxMushrooms = new System.Windows.Forms.CheckBox();
            this.chkBoxOnion = new System.Windows.Forms.CheckBox();
            this.chkBoxExtCheese = new System.Windows.Forms.CheckBox();
            this.labToppings = new System.Windows.Forms.Label();
            this.panelWtoEat = new System.Windows.Forms.Panel();
            this.rdBtnTakeOut = new System.Windows.Forms.RadioButton();
            this.rdBtnEatIn = new System.Windows.Forms.RadioButton();
            this.labWtoEat = new System.Windows.Forms.Label();
            this.labSummary = new System.Windows.Forms.Label();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.labTprice = new System.Windows.Forms.Label();
            this.labCurrency = new System.Windows.Forms.Label();
            this.labTotPrice = new System.Windows.Forms.Label();
            this.labTopRes = new System.Windows.Forms.Label();
            this.labSumToppings = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labWtoEatRes = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labSizeRes = new System.Windows.Forms.Label();
            this.labSumSize = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panelSize.SuspendLayout();
            this.panelCrust.SuspendLayout();
            this.panelToppings.SuspendLayout();
            this.panelWtoEat.SuspendLayout();
            this.panelSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.Red;
            this.labTitle.Location = new System.Drawing.Point(282, 20);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(264, 32);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "Make Your Pizza";
            this.labTitle.Click += new System.EventHandler(this.labTitle_Click);
            // 
            // panelSize
            // 
            this.panelSize.Controls.Add(this.labSize);
            this.panelSize.Controls.Add(this.rdBtnSizeLarge);
            this.panelSize.Controls.Add(this.rdBtnSizeMedium);
            this.panelSize.Controls.Add(this.rdBtnSizeSmall);
            this.panelSize.Location = new System.Drawing.Point(27, 59);
            this.panelSize.Name = "panelSize";
            this.panelSize.Size = new System.Drawing.Size(84, 143);
            this.panelSize.TabIndex = 1;
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Location = new System.Drawing.Point(12, 10);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(27, 13);
            this.labSize.TabIndex = 6;
            this.labSize.Text = "Size";
            // 
            // rdBtnSizeLarge
            // 
            this.rdBtnSizeLarge.AutoSize = true;
            this.rdBtnSizeLarge.Location = new System.Drawing.Point(12, 111);
            this.rdBtnSizeLarge.Name = "rdBtnSizeLarge";
            this.rdBtnSizeLarge.Size = new System.Drawing.Size(52, 17);
            this.rdBtnSizeLarge.TabIndex = 5;
            this.rdBtnSizeLarge.TabStop = true;
            this.rdBtnSizeLarge.Tag = "10";
            this.rdBtnSizeLarge.Text = "Large";
            this.rdBtnSizeLarge.UseVisualStyleBackColor = true;
            this.rdBtnSizeLarge.CheckedChanged += new System.EventHandler(this.rdBtnSizeLarge_CheckedChanged);
            // 
            // rdBtnSizeMedium
            // 
            this.rdBtnSizeMedium.AutoSize = true;
            this.rdBtnSizeMedium.Location = new System.Drawing.Point(12, 76);
            this.rdBtnSizeMedium.Name = "rdBtnSizeMedium";
            this.rdBtnSizeMedium.Size = new System.Drawing.Size(62, 17);
            this.rdBtnSizeMedium.TabIndex = 4;
            this.rdBtnSizeMedium.TabStop = true;
            this.rdBtnSizeMedium.Tag = "8";
            this.rdBtnSizeMedium.Text = "Medium";
            this.rdBtnSizeMedium.UseVisualStyleBackColor = true;
            this.rdBtnSizeMedium.CheckedChanged += new System.EventHandler(this.rdBtnSizeMedium_CheckedChanged);
            // 
            // rdBtnSizeSmall
            // 
            this.rdBtnSizeSmall.AutoSize = true;
            this.rdBtnSizeSmall.Location = new System.Drawing.Point(12, 41);
            this.rdBtnSizeSmall.Name = "rdBtnSizeSmall";
            this.rdBtnSizeSmall.Size = new System.Drawing.Size(50, 17);
            this.rdBtnSizeSmall.TabIndex = 3;
            this.rdBtnSizeSmall.TabStop = true;
            this.rdBtnSizeSmall.Tag = "5";
            this.rdBtnSizeSmall.Text = "Small";
            this.rdBtnSizeSmall.UseVisualStyleBackColor = true;
            this.rdBtnSizeSmall.CheckedChanged += new System.EventHandler(this.rdBtnSizeSmall_CheckedChanged);
            // 
            // panelCrust
            // 
            this.panelCrust.Controls.Add(this.rdBtnCrustThink);
            this.panelCrust.Controls.Add(this.rdBtnCrustThin);
            this.panelCrust.Controls.Add(this.labCrust);
            this.panelCrust.Location = new System.Drawing.Point(27, 243);
            this.panelCrust.Name = "panelCrust";
            this.panelCrust.Size = new System.Drawing.Size(84, 110);
            this.panelCrust.TabIndex = 6;
            // 
            // rdBtnCrustThink
            // 
            this.rdBtnCrustThink.AutoSize = true;
            this.rdBtnCrustThink.Location = new System.Drawing.Point(15, 75);
            this.rdBtnCrustThink.Name = "rdBtnCrustThink";
            this.rdBtnCrustThink.Size = new System.Drawing.Size(52, 17);
            this.rdBtnCrustThink.TabIndex = 4;
            this.rdBtnCrustThink.TabStop = true;
            this.rdBtnCrustThink.Tag = "2";
            this.rdBtnCrustThink.Text = "Think";
            this.rdBtnCrustThink.UseVisualStyleBackColor = true;
            this.rdBtnCrustThink.CheckedChanged += new System.EventHandler(this.rdBtnCrustThink_CheckedChanged);
            // 
            // rdBtnCrustThin
            // 
            this.rdBtnCrustThin.AutoSize = true;
            this.rdBtnCrustThin.Location = new System.Drawing.Point(15, 37);
            this.rdBtnCrustThin.Name = "rdBtnCrustThin";
            this.rdBtnCrustThin.Size = new System.Drawing.Size(46, 17);
            this.rdBtnCrustThin.TabIndex = 3;
            this.rdBtnCrustThin.TabStop = true;
            this.rdBtnCrustThin.Tag = "1";
            this.rdBtnCrustThin.Text = "Thin";
            this.rdBtnCrustThin.UseVisualStyleBackColor = true;
            this.rdBtnCrustThin.CheckedChanged += new System.EventHandler(this.rdBtnCrustThin_CheckedChanged);
            // 
            // labCrust
            // 
            this.labCrust.AutoSize = true;
            this.labCrust.Location = new System.Drawing.Point(15, 10);
            this.labCrust.Name = "labCrust";
            this.labCrust.Size = new System.Drawing.Size(31, 13);
            this.labCrust.TabIndex = 2;
            this.labCrust.Text = "Crust";
            // 
            // panelToppings
            // 
            this.panelToppings.Controls.Add(this.chkBoxGrnPeppers);
            this.panelToppings.Controls.Add(this.chkBoxOlives);
            this.panelToppings.Controls.Add(this.chkBoxTomatoes);
            this.panelToppings.Controls.Add(this.chkBoxMushrooms);
            this.panelToppings.Controls.Add(this.chkBoxOnion);
            this.panelToppings.Controls.Add(this.chkBoxExtCheese);
            this.panelToppings.Controls.Add(this.labToppings);
            this.panelToppings.Location = new System.Drawing.Point(166, 59);
            this.panelToppings.Name = "panelToppings";
            this.panelToppings.Size = new System.Drawing.Size(226, 143);
            this.panelToppings.TabIndex = 7;
            this.panelToppings.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // chkBoxGrnPeppers
            // 
            this.chkBoxGrnPeppers.AutoSize = true;
            this.chkBoxGrnPeppers.Location = new System.Drawing.Point(125, 111);
            this.chkBoxGrnPeppers.Name = "chkBoxGrnPeppers";
            this.chkBoxGrnPeppers.Size = new System.Drawing.Size(97, 17);
            this.chkBoxGrnPeppers.TabIndex = 12;
            this.chkBoxGrnPeppers.Tag = "1";
            this.chkBoxGrnPeppers.Text = "Green Peppers";
            this.chkBoxGrnPeppers.UseVisualStyleBackColor = true;
            this.chkBoxGrnPeppers.CheckedChanged += new System.EventHandler(this.chkBoxGrnPeppers_CheckedChanged);
            // 
            // chkBoxOlives
            // 
            this.chkBoxOlives.AutoSize = true;
            this.chkBoxOlives.Location = new System.Drawing.Point(125, 76);
            this.chkBoxOlives.Name = "chkBoxOlives";
            this.chkBoxOlives.Size = new System.Drawing.Size(55, 17);
            this.chkBoxOlives.TabIndex = 11;
            this.chkBoxOlives.Tag = "1";
            this.chkBoxOlives.Text = "Olives";
            this.chkBoxOlives.UseVisualStyleBackColor = true;
            this.chkBoxOlives.CheckedChanged += new System.EventHandler(this.chkBoxOlives_CheckedChanged);
            // 
            // chkBoxTomatoes
            // 
            this.chkBoxTomatoes.AutoSize = true;
            this.chkBoxTomatoes.Location = new System.Drawing.Point(125, 41);
            this.chkBoxTomatoes.Name = "chkBoxTomatoes";
            this.chkBoxTomatoes.Size = new System.Drawing.Size(73, 17);
            this.chkBoxTomatoes.TabIndex = 10;
            this.chkBoxTomatoes.Tag = "1";
            this.chkBoxTomatoes.Text = "Tomatoes";
            this.chkBoxTomatoes.UseVisualStyleBackColor = true;
            this.chkBoxTomatoes.CheckedChanged += new System.EventHandler(this.chkBoxTomatoes_CheckedChanged);
            // 
            // chkBoxMushrooms
            // 
            this.chkBoxMushrooms.AutoSize = true;
            this.chkBoxMushrooms.Location = new System.Drawing.Point(16, 111);
            this.chkBoxMushrooms.Name = "chkBoxMushrooms";
            this.chkBoxMushrooms.Size = new System.Drawing.Size(80, 17);
            this.chkBoxMushrooms.TabIndex = 9;
            this.chkBoxMushrooms.Tag = "1";
            this.chkBoxMushrooms.Text = "Mushrooms";
            this.chkBoxMushrooms.UseVisualStyleBackColor = true;
            this.chkBoxMushrooms.CheckedChanged += new System.EventHandler(this.chkBoxMushrooms_CheckedChanged);
            // 
            // chkBoxOnion
            // 
            this.chkBoxOnion.AutoSize = true;
            this.chkBoxOnion.Location = new System.Drawing.Point(16, 76);
            this.chkBoxOnion.Name = "chkBoxOnion";
            this.chkBoxOnion.Size = new System.Drawing.Size(54, 17);
            this.chkBoxOnion.TabIndex = 8;
            this.chkBoxOnion.Tag = "1";
            this.chkBoxOnion.Text = "Onion";
            this.chkBoxOnion.UseVisualStyleBackColor = true;
            this.chkBoxOnion.CheckedChanged += new System.EventHandler(this.chkBoxOnion_CheckedChanged);
            // 
            // chkBoxExtCheese
            // 
            this.chkBoxExtCheese.AutoSize = true;
            this.chkBoxExtCheese.Location = new System.Drawing.Point(16, 41);
            this.chkBoxExtCheese.Name = "chkBoxExtCheese";
            this.chkBoxExtCheese.Size = new System.Drawing.Size(89, 17);
            this.chkBoxExtCheese.TabIndex = 7;
            this.chkBoxExtCheese.Tag = "1";
            this.chkBoxExtCheese.Text = "Extra Cheese";
            this.chkBoxExtCheese.UseVisualStyleBackColor = true;
            this.chkBoxExtCheese.CheckedChanged += new System.EventHandler(this.chkBoxExtCheese_CheckedChanged);
            // 
            // labToppings
            // 
            this.labToppings.AutoSize = true;
            this.labToppings.Location = new System.Drawing.Point(13, 10);
            this.labToppings.Name = "labToppings";
            this.labToppings.Size = new System.Drawing.Size(51, 13);
            this.labToppings.TabIndex = 6;
            this.labToppings.Text = "Toppings";
            // 
            // panelWtoEat
            // 
            this.panelWtoEat.Controls.Add(this.rdBtnTakeOut);
            this.panelWtoEat.Controls.Add(this.rdBtnEatIn);
            this.panelWtoEat.Controls.Add(this.labWtoEat);
            this.panelWtoEat.Location = new System.Drawing.Point(166, 243);
            this.panelWtoEat.Name = "panelWtoEat";
            this.panelWtoEat.Size = new System.Drawing.Size(170, 65);
            this.panelWtoEat.TabIndex = 8;
            // 
            // rdBtnTakeOut
            // 
            this.rdBtnTakeOut.AutoSize = true;
            this.rdBtnTakeOut.Location = new System.Drawing.Point(98, 37);
            this.rdBtnTakeOut.Name = "rdBtnTakeOut";
            this.rdBtnTakeOut.Size = new System.Drawing.Size(70, 17);
            this.rdBtnTakeOut.TabIndex = 4;
            this.rdBtnTakeOut.TabStop = true;
            this.rdBtnTakeOut.Text = "Take Out";
            this.rdBtnTakeOut.UseVisualStyleBackColor = true;
            this.rdBtnTakeOut.CheckedChanged += new System.EventHandler(this.rdBtnTakeOut_CheckedChanged);
            // 
            // rdBtnEatIn
            // 
            this.rdBtnEatIn.AutoSize = true;
            this.rdBtnEatIn.Location = new System.Drawing.Point(15, 37);
            this.rdBtnEatIn.Name = "rdBtnEatIn";
            this.rdBtnEatIn.Size = new System.Drawing.Size(52, 17);
            this.rdBtnEatIn.TabIndex = 3;
            this.rdBtnEatIn.TabStop = true;
            this.rdBtnEatIn.Text = "Eat in";
            this.rdBtnEatIn.UseVisualStyleBackColor = true;
            this.rdBtnEatIn.CheckedChanged += new System.EventHandler(this.rdBtnEatIn_CheckedChanged);
            // 
            // labWtoEat
            // 
            this.labWtoEat.AutoSize = true;
            this.labWtoEat.Location = new System.Drawing.Point(15, 10);
            this.labWtoEat.Name = "labWtoEat";
            this.labWtoEat.Size = new System.Drawing.Size(78, 13);
            this.labWtoEat.TabIndex = 2;
            this.labWtoEat.Text = "Where to eat ?";
            // 
            // labSummary
            // 
            this.labSummary.AutoSize = true;
            this.labSummary.Location = new System.Drawing.Point(13, 10);
            this.labSummary.Name = "labSummary";
            this.labSummary.Size = new System.Drawing.Size(79, 13);
            this.labSummary.TabIndex = 6;
            this.labSummary.Text = "Order Summary";
            // 
            // panelSummary
            // 
            this.panelSummary.Controls.Add(this.labTprice);
            this.panelSummary.Controls.Add(this.labCurrency);
            this.panelSummary.Controls.Add(this.labTotPrice);
            this.panelSummary.Controls.Add(this.labTopRes);
            this.panelSummary.Controls.Add(this.labSumToppings);
            this.panelSummary.Controls.Add(this.label3);
            this.panelSummary.Controls.Add(this.labWtoEatRes);
            this.panelSummary.Controls.Add(this.lab);
            this.panelSummary.Controls.Add(this.label1);
            this.panelSummary.Controls.Add(this.labSizeRes);
            this.panelSummary.Controls.Add(this.labSumSize);
            this.panelSummary.Controls.Add(this.labSummary);
            this.panelSummary.Location = new System.Drawing.Point(411, 59);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(377, 329);
            this.panelSummary.TabIndex = 13;
            this.panelSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSummary_Paint);
            // 
            // labTprice
            // 
            this.labTprice.AutoSize = true;
            this.labTprice.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labTprice.Location = new System.Drawing.Point(88, 259);
            this.labTprice.Name = "labTprice";
            this.labTprice.Size = new System.Drawing.Size(28, 33);
            this.labTprice.TabIndex = 17;
            this.labTprice.Text = "0";
            // 
            // labCurrency
            // 
            this.labCurrency.AutoSize = true;
            this.labCurrency.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labCurrency.Location = new System.Drawing.Point(56, 261);
            this.labCurrency.Name = "labCurrency";
            this.labCurrency.Size = new System.Drawing.Size(26, 33);
            this.labCurrency.TabIndex = 16;
            this.labCurrency.Text = "$";
            this.labCurrency.Click += new System.EventHandler(this.label2_Click);
            // 
            // labTotPrice
            // 
            this.labTotPrice.AutoSize = true;
            this.labTotPrice.Location = new System.Drawing.Point(28, 235);
            this.labTotPrice.Name = "labTotPrice";
            this.labTotPrice.Size = new System.Drawing.Size(64, 13);
            this.labTotPrice.TabIndex = 15;
            this.labTotPrice.Text = "Total Price :";
            // 
            // labTopRes
            // 
            this.labTopRes.AutoSize = true;
            this.labTopRes.Location = new System.Drawing.Point(38, 130);
            this.labTopRes.Name = "labTopRes";
            this.labTopRes.Size = new System.Drawing.Size(0, 13);
            this.labTopRes.TabIndex = 14;
            // 
            // labSumToppings
            // 
            this.labSumToppings.AutoSize = true;
            this.labSumToppings.Location = new System.Drawing.Point(25, 111);
            this.labSumToppings.Name = "labSumToppings";
            this.labSumToppings.Size = new System.Drawing.Size(57, 13);
            this.labSumToppings.TabIndex = 13;
            this.labSumToppings.Text = "Toppings :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 12;
            // 
            // labWtoEatRes
            // 
            this.labWtoEatRes.AutoSize = true;
            this.labWtoEatRes.Location = new System.Drawing.Point(25, 184);
            this.labWtoEatRes.Name = "labWtoEatRes";
            this.labWtoEatRes.Size = new System.Drawing.Size(76, 13);
            this.labWtoEatRes.TabIndex = 11;
            this.labWtoEatRes.Text = "Where to Eat :";
            this.labWtoEatRes.Click += new System.EventHandler(this.labWtoEatRes_Click);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(69, 76);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(0, 13);
            this.lab.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Crust :";
            // 
            // labSizeRes
            // 
            this.labSizeRes.AutoSize = true;
            this.labSizeRes.Location = new System.Drawing.Point(74, 46);
            this.labSizeRes.Name = "labSizeRes";
            this.labSizeRes.Size = new System.Drawing.Size(0, 13);
            this.labSizeRes.TabIndex = 8;
            this.labSizeRes.Click += new System.EventHandler(this.labSizeRes_Click);
            // 
            // labSumSize
            // 
            this.labSumSize.AutoSize = true;
            this.labSumSize.Location = new System.Drawing.Point(25, 46);
            this.labSumSize.Name = "labSumSize";
            this.labSumSize.Size = new System.Drawing.Size(33, 13);
            this.labSumSize.TabIndex = 7;
            this.labSumSize.Text = "Size :";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(184, 341);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(90, 39);
            this.btnOrder.TabIndex = 14;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(291, 341);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 39);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.panelWtoEat);
            this.Controls.Add(this.panelToppings);
            this.Controls.Add(this.panelCrust);
            this.Controls.Add(this.panelSize);
            this.Controls.Add(this.labTitle);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSize.ResumeLayout(false);
            this.panelSize.PerformLayout();
            this.panelCrust.ResumeLayout(false);
            this.panelCrust.PerformLayout();
            this.panelToppings.ResumeLayout(false);
            this.panelToppings.PerformLayout();
            this.panelWtoEat.ResumeLayout(false);
            this.panelWtoEat.PerformLayout();
            this.panelSummary.ResumeLayout(false);
            this.panelSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Panel panelSize;
        private System.Windows.Forms.RadioButton rdBtnSizeLarge;
        private System.Windows.Forms.RadioButton rdBtnSizeMedium;
        private System.Windows.Forms.RadioButton rdBtnSizeSmall;
        private System.Windows.Forms.Panel panelCrust;
        private System.Windows.Forms.RadioButton rdBtnCrustThink;
        private System.Windows.Forms.RadioButton rdBtnCrustThin;
        private System.Windows.Forms.Label labCrust;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Panel panelToppings;
        private System.Windows.Forms.CheckBox chkBoxGrnPeppers;
        private System.Windows.Forms.CheckBox chkBoxOlives;
        private System.Windows.Forms.CheckBox chkBoxTomatoes;
        private System.Windows.Forms.CheckBox chkBoxMushrooms;
        private System.Windows.Forms.CheckBox chkBoxOnion;
        private System.Windows.Forms.CheckBox chkBoxExtCheese;
        private System.Windows.Forms.Label labToppings;
        private System.Windows.Forms.Panel panelWtoEat;
        private System.Windows.Forms.RadioButton rdBtnTakeOut;
        private System.Windows.Forms.RadioButton rdBtnEatIn;
        private System.Windows.Forms.Label labWtoEat;
        private System.Windows.Forms.Label labSummary;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label labSizeRes;
        private System.Windows.Forms.Label labSumSize;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labWtoEatRes;
        private System.Windows.Forms.Label labSumToppings;
        private System.Windows.Forms.Label labCurrency;
        private System.Windows.Forms.Label labTotPrice;
        private System.Windows.Forms.Label labTopRes;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labTprice;
    }
}

