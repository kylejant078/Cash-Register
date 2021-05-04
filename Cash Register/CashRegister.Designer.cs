
namespace Cash_Register
{
    partial class CashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashRegister));
            this.title = new System.Windows.Forms.Label();
            this.labelCoffee = new System.Windows.Forms.Label();
            this.labelSandwich = new System.Windows.Forms.Label();
            this.labelDonuts = new System.Windows.Forms.Label();
            this.calculateTotal = new System.Windows.Forms.Button();
            this.drinksNumber = new System.Windows.Forms.TextBox();
            this.donutsNumber = new System.Windows.Forms.TextBox();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.calculateChange = new System.Windows.Forms.Button();
            this.printReciept = new System.Windows.Forms.Button();
            this.newOrder = new System.Windows.Forms.Button();
            this.receipt = new System.Windows.Forms.Label();
            this.blackLine = new System.Windows.Forms.Label();
            this.labelTendered = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.tenderedAmount = new System.Windows.Forms.TextBox();
            this.sandwichesNumber = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonTimbits = new System.Windows.Forms.Button();
            this.easterEgg = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.oldfashionedTimbit = new System.Windows.Forms.PictureBox();
            this.jellyfilledTimbit = new System.Windows.Forms.PictureBox();
            this.birthdaycakeTimbit = new System.Windows.Forms.PictureBox();
            this.chocolateTimbit = new System.Windows.Forms.PictureBox();
            this.pictureDrink = new System.Windows.Forms.PictureBox();
            this.pictureDonuts = new System.Windows.Forms.PictureBox();
            this.labelEasterEgg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oldfashionedTimbit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jellyfilledTimbit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdaycakeTimbit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chocolateTimbit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDonuts)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.White;
            this.title.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Firebrick;
            this.title.Location = new System.Drawing.Point(-2, -4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(618, 79);
            this.title.TabIndex = 0;
            this.title.Text = "Tim Hortons";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCoffee
            // 
            this.labelCoffee.AutoSize = true;
            this.labelCoffee.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoffee.ForeColor = System.Drawing.Color.LightGray;
            this.labelCoffee.Location = new System.Drawing.Point(13, 97);
            this.labelCoffee.Name = "labelCoffee";
            this.labelCoffee.Size = new System.Drawing.Size(124, 25);
            this.labelCoffee.TabIndex = 1;
            this.labelCoffee.Text = "# of Drinks";
            // 
            // labelSandwich
            // 
            this.labelSandwich.AutoSize = true;
            this.labelSandwich.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSandwich.ForeColor = System.Drawing.Color.LightGray;
            this.labelSandwich.Location = new System.Drawing.Point(12, 170);
            this.labelSandwich.Name = "labelSandwich";
            this.labelSandwich.Size = new System.Drawing.Size(170, 25);
            this.labelSandwich.TabIndex = 2;
            this.labelSandwich.Text = "# of Sandwiches";
            // 
            // labelDonuts
            // 
            this.labelDonuts.AutoSize = true;
            this.labelDonuts.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonuts.ForeColor = System.Drawing.Color.LightGray;
            this.labelDonuts.Location = new System.Drawing.Point(12, 133);
            this.labelDonuts.Name = "labelDonuts";
            this.labelDonuts.Size = new System.Drawing.Size(125, 25);
            this.labelDonuts.TabIndex = 3;
            this.labelDonuts.Text = "# of Donuts";
            // 
            // calculateTotal
            // 
            this.calculateTotal.BackColor = System.Drawing.Color.FloralWhite;
            this.calculateTotal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.calculateTotal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.calculateTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateTotal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculateTotal.Location = new System.Drawing.Point(17, 202);
            this.calculateTotal.Name = "calculateTotal";
            this.calculateTotal.Size = new System.Drawing.Size(260, 28);
            this.calculateTotal.TabIndex = 4;
            this.calculateTotal.Text = "Calculate Totals";
            this.calculateTotal.UseVisualStyleBackColor = false;
            this.calculateTotal.Click += new System.EventHandler(this.calculateTotal_Click);
            // 
            // drinksNumber
            // 
            this.drinksNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksNumber.Location = new System.Drawing.Point(211, 98);
            this.drinksNumber.Name = "drinksNumber";
            this.drinksNumber.Size = new System.Drawing.Size(66, 26);
            this.drinksNumber.TabIndex = 5;
            this.drinksNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // donutsNumber
            // 
            this.donutsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donutsNumber.Location = new System.Drawing.Point(211, 134);
            this.donutsNumber.Name = "donutsNumber";
            this.donutsNumber.Size = new System.Drawing.Size(66, 26);
            this.donutsNumber.TabIndex = 7;
            this.donutsNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.ForeColor = System.Drawing.Color.LightGray;
            this.labelSubtotal.Location = new System.Drawing.Point(12, 242);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(266, 23);
            this.labelSubtotal.TabIndex = 8;
            this.labelSubtotal.Text = "Sub Total";
            // 
            // labelTotal
            // 
            this.labelTotal.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.LightGray;
            this.labelTotal.Location = new System.Drawing.Point(13, 313);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(264, 25);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "Total";
            // 
            // labelTax
            // 
            this.labelTax.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTax.ForeColor = System.Drawing.Color.LightGray;
            this.labelTax.Location = new System.Drawing.Point(12, 276);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(266, 25);
            this.labelTax.TabIndex = 10;
            this.labelTax.Text = "Tax";
            // 
            // calculateChange
            // 
            this.calculateChange.BackColor = System.Drawing.Color.FloralWhite;
            this.calculateChange.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.calculateChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.calculateChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateChange.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateChange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculateChange.Location = new System.Drawing.Point(17, 414);
            this.calculateChange.Name = "calculateChange";
            this.calculateChange.Size = new System.Drawing.Size(260, 28);
            this.calculateChange.TabIndex = 11;
            this.calculateChange.Text = "Calculate Change";
            this.calculateChange.UseVisualStyleBackColor = false;
            this.calculateChange.Click += new System.EventHandler(this.calculateChange_Click);
            // 
            // printReciept
            // 
            this.printReciept.BackColor = System.Drawing.Color.FloralWhite;
            this.printReciept.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.printReciept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.printReciept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReciept.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReciept.ForeColor = System.Drawing.SystemColors.ControlText;
            this.printReciept.Location = new System.Drawing.Point(17, 525);
            this.printReciept.Name = "printReciept";
            this.printReciept.Size = new System.Drawing.Size(260, 28);
            this.printReciept.TabIndex = 12;
            this.printReciept.Text = "Print Receipt";
            this.printReciept.UseVisualStyleBackColor = false;
            this.printReciept.Click += new System.EventHandler(this.printReciept_Click);
            // 
            // newOrder
            // 
            this.newOrder.BackColor = System.Drawing.Color.FloralWhite;
            this.newOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.newOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.newOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrder.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newOrder.Location = new System.Drawing.Point(329, 525);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(260, 28);
            this.newOrder.TabIndex = 13;
            this.newOrder.Text = "New Order";
            this.newOrder.UseVisualStyleBackColor = false;
            this.newOrder.Click += new System.EventHandler(this.newOrder_Click);
            // 
            // receipt
            // 
            this.receipt.BackColor = System.Drawing.SystemColors.Info;
            this.receipt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.receipt.Location = new System.Drawing.Point(329, 106);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(260, 393);
            this.receipt.TabIndex = 14;
            this.receipt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // blackLine
            // 
            this.blackLine.BackColor = System.Drawing.Color.Black;
            this.blackLine.Location = new System.Drawing.Point(15, 347);
            this.blackLine.Name = "blackLine";
            this.blackLine.Size = new System.Drawing.Size(263, 10);
            this.blackLine.TabIndex = 15;
            // 
            // labelTendered
            // 
            this.labelTendered.AutoSize = true;
            this.labelTendered.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTendered.ForeColor = System.Drawing.Color.LightGray;
            this.labelTendered.Location = new System.Drawing.Point(13, 369);
            this.labelTendered.Name = "labelTendered";
            this.labelTendered.Size = new System.Drawing.Size(103, 25);
            this.labelTendered.TabIndex = 16;
            this.labelTendered.Text = "Tendered";
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.ForeColor = System.Drawing.Color.LightGray;
            this.labelChange.Location = new System.Drawing.Point(17, 474);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(82, 25);
            this.labelChange.TabIndex = 17;
            this.labelChange.Text = "Change";
            // 
            // tenderedAmount
            // 
            this.tenderedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedAmount.Location = new System.Drawing.Point(211, 370);
            this.tenderedAmount.Name = "tenderedAmount";
            this.tenderedAmount.Size = new System.Drawing.Size(66, 26);
            this.tenderedAmount.TabIndex = 18;
            this.tenderedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sandwichesNumber
            // 
            this.sandwichesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sandwichesNumber.Location = new System.Drawing.Point(211, 169);
            this.sandwichesNumber.Name = "sandwichesNumber";
            this.sandwichesNumber.Size = new System.Drawing.Size(66, 26);
            this.sandwichesNumber.TabIndex = 19;
            this.sandwichesNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelError
            // 
            this.labelError.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.White;
            this.labelError.Location = new System.Drawing.Point(17, 556);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(572, 23);
            this.labelError.TabIndex = 20;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTimbits
            // 
            this.buttonTimbits.BackColor = System.Drawing.Color.White;
            this.buttonTimbits.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonTimbits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimbits.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTimbits.Location = new System.Drawing.Point(518, 1);
            this.buttonTimbits.Name = "buttonTimbits";
            this.buttonTimbits.Size = new System.Drawing.Size(100, 74);
            this.buttonTimbits.TabIndex = 23;
            this.buttonTimbits.UseVisualStyleBackColor = false;
            this.buttonTimbits.Click += new System.EventHandler(this.buttonTimbits_Click);
            // 
            // easterEgg
            // 
            this.easterEgg.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easterEgg.ForeColor = System.Drawing.Color.White;
            this.easterEgg.Location = new System.Drawing.Point(134, 106);
            this.easterEgg.Name = "easterEgg";
            this.easterEgg.Size = new System.Drawing.Size(344, 45);
            this.easterEgg.TabIndex = 24;
            this.easterEgg.Text = "Choose Your Timbit";
            this.easterEgg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.White;
            this.buttonReturn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonReturn.Location = new System.Drawing.Point(225, 483);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(187, 36);
            this.buttonReturn.TabIndex = 25;
            this.buttonReturn.Text = "Return to Order";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // oldfashionedTimbit
            // 
            this.oldfashionedTimbit.BackColor = System.Drawing.Color.White;
            this.oldfashionedTimbit.Image = global::Cash_Register.Properties.Resources.old_fasioned_timbit;
            this.oldfashionedTimbit.Location = new System.Drawing.Point(152, 360);
            this.oldfashionedTimbit.Name = "oldfashionedTimbit";
            this.oldfashionedTimbit.Size = new System.Drawing.Size(88, 88);
            this.oldfashionedTimbit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oldfashionedTimbit.TabIndex = 29;
            this.oldfashionedTimbit.TabStop = false;
            this.oldfashionedTimbit.Click += new System.EventHandler(this.oldfashionedTimbit_Click);
            // 
            // jellyfilledTimbit
            // 
            this.jellyfilledTimbit.BackColor = System.Drawing.Color.White;
            this.jellyfilledTimbit.Image = global::Cash_Register.Properties.Resources.jelly_filled_timbit;
            this.jellyfilledTimbit.Location = new System.Drawing.Point(391, 363);
            this.jellyfilledTimbit.Name = "jellyfilledTimbit";
            this.jellyfilledTimbit.Size = new System.Drawing.Size(87, 79);
            this.jellyfilledTimbit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jellyfilledTimbit.TabIndex = 28;
            this.jellyfilledTimbit.TabStop = false;
            this.jellyfilledTimbit.Click += new System.EventHandler(this.jellyfilledTimbit_Click);
            // 
            // birthdaycakeTimbit
            // 
            this.birthdaycakeTimbit.BackColor = System.Drawing.Color.White;
            this.birthdaycakeTimbit.Image = global::Cash_Register.Properties.Resources.birthdaycake_timbit;
            this.birthdaycakeTimbit.Location = new System.Drawing.Point(391, 202);
            this.birthdaycakeTimbit.Name = "birthdaycakeTimbit";
            this.birthdaycakeTimbit.Size = new System.Drawing.Size(87, 79);
            this.birthdaycakeTimbit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.birthdaycakeTimbit.TabIndex = 27;
            this.birthdaycakeTimbit.TabStop = false;
            this.birthdaycakeTimbit.Click += new System.EventHandler(this.birthdaycakeTimbit_Click);
            // 
            // chocolateTimbit
            // 
            this.chocolateTimbit.BackColor = System.Drawing.Color.White;
            this.chocolateTimbit.Image = global::Cash_Register.Properties.Resources.chocolate_timbit;
            this.chocolateTimbit.Location = new System.Drawing.Point(152, 202);
            this.chocolateTimbit.Name = "chocolateTimbit";
            this.chocolateTimbit.Size = new System.Drawing.Size(88, 79);
            this.chocolateTimbit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chocolateTimbit.TabIndex = 26;
            this.chocolateTimbit.TabStop = false;
            this.chocolateTimbit.Click += new System.EventHandler(this.chocolateTimbit_Click);
            // 
            // pictureDrink
            // 
            this.pictureDrink.BackColor = System.Drawing.Color.White;
            this.pictureDrink.Image = global::Cash_Register.Properties.Resources.tim_hortons;
            this.pictureDrink.Location = new System.Drawing.Point(12, -4);
            this.pictureDrink.Name = "pictureDrink";
            this.pictureDrink.Size = new System.Drawing.Size(133, 79);
            this.pictureDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDrink.TabIndex = 21;
            this.pictureDrink.TabStop = false;
            // 
            // pictureDonuts
            // 
            this.pictureDonuts.BackColor = System.Drawing.Color.White;
            this.pictureDonuts.Image = global::Cash_Register.Properties.Resources.timbits;
            this.pictureDonuts.Location = new System.Drawing.Point(504, -4);
            this.pictureDonuts.Name = "pictureDonuts";
            this.pictureDonuts.Size = new System.Drawing.Size(100, 79);
            this.pictureDonuts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDonuts.TabIndex = 22;
            this.pictureDonuts.TabStop = false;
            // 
            // labelEasterEgg
            // 
            this.labelEasterEgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEasterEgg.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEasterEgg.ForeColor = System.Drawing.Color.White;
            this.labelEasterEgg.Location = new System.Drawing.Point(-1, 307);
            this.labelEasterEgg.Name = "labelEasterEgg";
            this.labelEasterEgg.Size = new System.Drawing.Size(617, 31);
            this.labelEasterEgg.TabIndex = 30;
            this.labelEasterEgg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(616, 588);
            this.Controls.Add(this.labelEasterEgg);
            this.Controls.Add(this.oldfashionedTimbit);
            this.Controls.Add(this.jellyfilledTimbit);
            this.Controls.Add(this.birthdaycakeTimbit);
            this.Controls.Add(this.chocolateTimbit);
            this.Controls.Add(this.pictureDrink);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.easterEgg);
            this.Controls.Add(this.pictureDonuts);
            this.Controls.Add(this.buttonTimbits);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.sandwichesNumber);
            this.Controls.Add(this.tenderedAmount);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.labelTendered);
            this.Controls.Add(this.blackLine);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.printReciept);
            this.Controls.Add(this.calculateChange);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.donutsNumber);
            this.Controls.Add(this.drinksNumber);
            this.Controls.Add(this.calculateTotal);
            this.Controls.Add(this.labelDonuts);
            this.Controls.Add(this.labelSandwich);
            this.Controls.Add(this.labelCoffee);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tim Hortons";
            ((System.ComponentModel.ISupportInitialize)(this.oldfashionedTimbit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jellyfilledTimbit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdaycakeTimbit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chocolateTimbit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDonuts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label labelCoffee;
        private System.Windows.Forms.Label labelSandwich;
        private System.Windows.Forms.Label labelDonuts;
        private System.Windows.Forms.Button calculateTotal;
        private System.Windows.Forms.TextBox drinksNumber;
        private System.Windows.Forms.TextBox donutsNumber;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Button calculateChange;
        private System.Windows.Forms.Button printReciept;
        private System.Windows.Forms.Button newOrder;
        private System.Windows.Forms.Label receipt;
        private System.Windows.Forms.Label blackLine;
        private System.Windows.Forms.Label labelTendered;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.TextBox tenderedAmount;
        private System.Windows.Forms.TextBox sandwichesNumber;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.PictureBox pictureDrink;
        private System.Windows.Forms.PictureBox pictureDonuts;
        private System.Windows.Forms.Button buttonTimbits;
        private System.Windows.Forms.Label easterEgg;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.PictureBox chocolateTimbit;
        private System.Windows.Forms.PictureBox birthdaycakeTimbit;
        private System.Windows.Forms.PictureBox jellyfilledTimbit;
        private System.Windows.Forms.PictureBox oldfashionedTimbit;
        private System.Windows.Forms.Label labelEasterEgg;
    }
}

