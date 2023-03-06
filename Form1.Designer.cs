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
            this.rdBtnSizeSmall = new System.Windows.Forms.RadioButton();
            this.rdBtnSizeMedium = new System.Windows.Forms.RadioButton();
            this.rdBtnSizeLarge = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdBtnCrustThink = new System.Windows.Forms.RadioButton();
            this.rdBtnCrustThin = new System.Windows.Forms.RadioButton();
            this.labCrust = new System.Windows.Forms.Label();
            this.labSize = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(27, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 143);
            this.panel1.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.rdBtnCrustThink);
            this.panel2.Controls.Add(this.rdBtnCrustThin);
            this.panel2.Controls.Add(this.labCrust);
            this.panel2.Location = new System.Drawing.Point(27, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 110);
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
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Location = new System.Drawing.Point(12, 10);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(27, 13);
            this.labSize.TabIndex = 6;
            this.labSize.Text = "Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labTitle);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}

