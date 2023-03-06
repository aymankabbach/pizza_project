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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labSize = new System.Windows.Forms.Label();
            this.rdBtnSizeLarge = new System.Windows.Forms.RadioButton();
            this.rdBtnSizeMedium = new System.Windows.Forms.RadioButton();
            this.rdBtnSizeSmall = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdBtnCrustThink = new System.Windows.Forms.RadioButton();
            this.rdBtnCrustThin = new System.Windows.Forms.RadioButton();
            this.labCrust = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labToppings = new System.Windows.Forms.Label();
            this.chkBoxExtCheese = new System.Windows.Forms.CheckBox();
            this.chkBoxOnion = new System.Windows.Forms.CheckBox();
            this.chkBoxMushrooms = new System.Windows.Forms.CheckBox();
            this.chkBoxTomatoes = new System.Windows.Forms.CheckBox();
            this.chkBoxOlives = new System.Windows.Forms.CheckBox();
            this.chkBoxGrnPeppers = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdBtnTakeOut = new System.Windows.Forms.RadioButton();
            this.rdBtnEatIn = new System.Windows.Forms.RadioButton();
            this.labWtoEat = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.labSize);
            this.panel1.Controls.Add(this.rdBtnSizeLarge);
            this.panel1.Controls.Add(this.rdBtnSizeMedium);
            this.panel1.Controls.Add(this.rdBtnSizeSmall);
            this.panel1.Location = new System.Drawing.Point(27, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 143);
            this.panel1.TabIndex = 1;
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
            this.rdBtnSizeLarge.Text = "Large";
            this.rdBtnSizeLarge.UseVisualStyleBackColor = true;
            // 
            // rdBtnSizeMedium
            // 
            this.rdBtnSizeMedium.AutoSize = true;
            this.rdBtnSizeMedium.Location = new System.Drawing.Point(12, 76);
            this.rdBtnSizeMedium.Name = "rdBtnSizeMedium";
            this.rdBtnSizeMedium.Size = new System.Drawing.Size(62, 17);
            this.rdBtnSizeMedium.TabIndex = 4;
            this.rdBtnSizeMedium.TabStop = true;
            this.rdBtnSizeMedium.Text = "Medium";
            this.rdBtnSizeMedium.UseVisualStyleBackColor = true;
            // 
            // rdBtnSizeSmall
            // 
            this.rdBtnSizeSmall.AutoSize = true;
            this.rdBtnSizeSmall.Location = new System.Drawing.Point(12, 41);
            this.rdBtnSizeSmall.Name = "rdBtnSizeSmall";
            this.rdBtnSizeSmall.Size = new System.Drawing.Size(50, 17);
            this.rdBtnSizeSmall.TabIndex = 3;
            this.rdBtnSizeSmall.TabStop = true;
            this.rdBtnSizeSmall.Text = "Small";
            this.rdBtnSizeSmall.UseVisualStyleBackColor = true;
            this.rdBtnSizeSmall.CheckedChanged += new System.EventHandler(this.rdBtnSizeSmall_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdBtnCrustThink);
            this.panel2.Controls.Add(this.rdBtnCrustThin);
            this.panel2.Controls.Add(this.labCrust);
            this.panel2.Location = new System.Drawing.Point(27, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(84, 110);
            this.panel2.TabIndex = 6;
            // 
            // rdBtnCrustThink
            // 
            this.rdBtnCrustThink.AutoSize = true;
            this.rdBtnCrustThink.Location = new System.Drawing.Point(15, 75);
            this.rdBtnCrustThink.Name = "rdBtnCrustThink";
            this.rdBtnCrustThink.Size = new System.Drawing.Size(52, 17);
            this.rdBtnCrustThink.TabIndex = 4;
            this.rdBtnCrustThink.TabStop = true;
            this.rdBtnCrustThink.Text = "Think";
            this.rdBtnCrustThink.UseVisualStyleBackColor = true;
            // 
            // rdBtnCrustThin
            // 
            this.rdBtnCrustThin.AutoSize = true;
            this.rdBtnCrustThin.Location = new System.Drawing.Point(15, 37);
            this.rdBtnCrustThin.Name = "rdBtnCrustThin";
            this.rdBtnCrustThin.Size = new System.Drawing.Size(46, 17);
            this.rdBtnCrustThin.TabIndex = 3;
            this.rdBtnCrustThin.TabStop = true;
            this.rdBtnCrustThin.Text = "Thin";
            this.rdBtnCrustThin.UseVisualStyleBackColor = true;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.chkBoxGrnPeppers);
            this.panel3.Controls.Add(this.chkBoxOlives);
            this.panel3.Controls.Add(this.chkBoxTomatoes);
            this.panel3.Controls.Add(this.chkBoxMushrooms);
            this.panel3.Controls.Add(this.chkBoxOnion);
            this.panel3.Controls.Add(this.chkBoxExtCheese);
            this.panel3.Controls.Add(this.labToppings);
            this.panel3.Location = new System.Drawing.Point(190, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 143);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            // chkBoxExtCheese
            // 
            this.chkBoxExtCheese.AutoSize = true;
            this.chkBoxExtCheese.Location = new System.Drawing.Point(16, 41);
            this.chkBoxExtCheese.Name = "chkBoxExtCheese";
            this.chkBoxExtCheese.Size = new System.Drawing.Size(89, 17);
            this.chkBoxExtCheese.TabIndex = 7;
            this.chkBoxExtCheese.Text = "Extra Cheese";
            this.chkBoxExtCheese.UseVisualStyleBackColor = true;
            this.chkBoxExtCheese.CheckedChanged += new System.EventHandler(this.chkBoxExtCheese_CheckedChanged);
            // 
            // chkBoxOnion
            // 
            this.chkBoxOnion.AutoSize = true;
            this.chkBoxOnion.Location = new System.Drawing.Point(16, 76);
            this.chkBoxOnion.Name = "chkBoxOnion";
            this.chkBoxOnion.Size = new System.Drawing.Size(54, 17);
            this.chkBoxOnion.TabIndex = 8;
            this.chkBoxOnion.Text = "Onion";
            this.chkBoxOnion.UseVisualStyleBackColor = true;
            // 
            // chkBoxMushrooms
            // 
            this.chkBoxMushrooms.AutoSize = true;
            this.chkBoxMushrooms.Location = new System.Drawing.Point(16, 111);
            this.chkBoxMushrooms.Name = "chkBoxMushrooms";
            this.chkBoxMushrooms.Size = new System.Drawing.Size(80, 17);
            this.chkBoxMushrooms.TabIndex = 9;
            this.chkBoxMushrooms.Text = "Mushrooms";
            this.chkBoxMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkBoxTomatoes
            // 
            this.chkBoxTomatoes.AutoSize = true;
            this.chkBoxTomatoes.Location = new System.Drawing.Point(125, 41);
            this.chkBoxTomatoes.Name = "chkBoxTomatoes";
            this.chkBoxTomatoes.Size = new System.Drawing.Size(73, 17);
            this.chkBoxTomatoes.TabIndex = 10;
            this.chkBoxTomatoes.Text = "Tomatoes";
            this.chkBoxTomatoes.UseVisualStyleBackColor = true;
            this.chkBoxTomatoes.CheckedChanged += new System.EventHandler(this.chkBoxTomatoes_CheckedChanged);
            // 
            // chkBoxOlives
            // 
            this.chkBoxOlives.AutoSize = true;
            this.chkBoxOlives.Location = new System.Drawing.Point(125, 76);
            this.chkBoxOlives.Name = "chkBoxOlives";
            this.chkBoxOlives.Size = new System.Drawing.Size(55, 17);
            this.chkBoxOlives.TabIndex = 11;
            this.chkBoxOlives.Text = "Olives";
            this.chkBoxOlives.UseVisualStyleBackColor = true;
            // 
            // chkBoxGrnPeppers
            // 
            this.chkBoxGrnPeppers.AutoSize = true;
            this.chkBoxGrnPeppers.Location = new System.Drawing.Point(125, 111);
            this.chkBoxGrnPeppers.Name = "chkBoxGrnPeppers";
            this.chkBoxGrnPeppers.Size = new System.Drawing.Size(97, 17);
            this.chkBoxGrnPeppers.TabIndex = 12;
            this.chkBoxGrnPeppers.Text = "Green Peppers";
            this.chkBoxGrnPeppers.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdBtnTakeOut);
            this.panel4.Controls.Add(this.rdBtnEatIn);
            this.panel4.Controls.Add(this.labWtoEat);
            this.panel4.Location = new System.Drawing.Point(190, 243);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 65);
            this.panel4.TabIndex = 8;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labTitle);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdBtnSizeLarge;
        private System.Windows.Forms.RadioButton rdBtnSizeMedium;
        private System.Windows.Forms.RadioButton rdBtnSizeSmall;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdBtnCrustThink;
        private System.Windows.Forms.RadioButton rdBtnCrustThin;
        private System.Windows.Forms.Label labCrust;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkBoxGrnPeppers;
        private System.Windows.Forms.CheckBox chkBoxOlives;
        private System.Windows.Forms.CheckBox chkBoxTomatoes;
        private System.Windows.Forms.CheckBox chkBoxMushrooms;
        private System.Windows.Forms.CheckBox chkBoxOnion;
        private System.Windows.Forms.CheckBox chkBoxExtCheese;
        private System.Windows.Forms.Label labToppings;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdBtnTakeOut;
        private System.Windows.Forms.RadioButton rdBtnEatIn;
        private System.Windows.Forms.Label labWtoEat;
    }
}

