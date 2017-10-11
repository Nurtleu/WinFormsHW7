namespace WinForms5
{
    partial class BestOil
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelFuel = new System.Windows.Forms.Panel();
            this.panelPaymentone = new System.Windows.Forms.Panel();
            this.currencyPetrolStation = new System.Windows.Forms.Label();
            this.textBoxPaymentOne = new System.Windows.Forms.TextBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.labelPaymentone = new System.Windows.Forms.Label();
            this.panelLiterPrice = new System.Windows.Forms.Panel();
            this.radioButtonPrice = new System.Windows.Forms.RadioButton();
            this.radioButtonQuantity = new System.Windows.Forms.RadioButton();
            this.labelPriceRub = new System.Windows.Forms.Label();
            this.textBoxPriceRub = new System.Windows.Forms.TextBox();
            this.labelOilLiter = new System.Windows.Forms.Label();
            this.labelCurrencyPriceRub = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxOil = new System.Windows.Forms.ComboBox();
            this.textBoxPriceLiter = new System.Windows.Forms.TextBox();
            this.labelFuelPrice = new System.Windows.Forms.Label();
            this.labelFuel = new System.Windows.Forms.Label();
            this.labelAutoFueling = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelTotalPriceRub = new System.Windows.Forms.Label();
            this.panelFuel.SuspendLayout();
            this.panelPaymentone.SuspendLayout();
            this.panelLiterPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFuel
            // 
            this.panelFuel.BackColor = System.Drawing.Color.LightGray;
            this.panelFuel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFuel.Controls.Add(this.panelPaymentone);
            this.panelFuel.Controls.Add(this.labelPaymentone);
            this.panelFuel.Controls.Add(this.panelLiterPrice);
            this.panelFuel.Controls.Add(this.labelPriceRub);
            this.panelFuel.Controls.Add(this.textBoxPriceRub);
            this.panelFuel.Controls.Add(this.labelOilLiter);
            this.panelFuel.Controls.Add(this.labelCurrencyPriceRub);
            this.panelFuel.Controls.Add(this.textBoxPrice);
            this.panelFuel.Controls.Add(this.comboBoxOil);
            this.panelFuel.Controls.Add(this.textBoxPriceLiter);
            this.panelFuel.Controls.Add(this.labelFuelPrice);
            this.panelFuel.Controls.Add(this.labelFuel);
            this.panelFuel.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelFuel.Location = new System.Drawing.Point(12, 28);
            this.panelFuel.Name = "panelFuel";
            this.panelFuel.Size = new System.Drawing.Size(397, 281);
            this.panelFuel.TabIndex = 0;
            // 
            // panelPaymentone
            // 
            this.panelPaymentone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPaymentone.Controls.Add(this.currencyPetrolStation);
            this.panelPaymentone.Controls.Add(this.textBoxPaymentOne);
            this.panelPaymentone.Controls.Add(this.buttonPay);
            this.panelPaymentone.Location = new System.Drawing.Point(6, 189);
            this.panelPaymentone.Name = "panelPaymentone";
            this.panelPaymentone.Size = new System.Drawing.Size(384, 85);
            this.panelPaymentone.TabIndex = 0;
            // 
            // currencyPetrolStation
            // 
            this.currencyPetrolStation.AutoSize = true;
            this.currencyPetrolStation.Location = new System.Drawing.Point(343, 56);
            this.currencyPetrolStation.Name = "currencyPetrolStation";
            this.currencyPetrolStation.Size = new System.Drawing.Size(34, 13);
            this.currencyPetrolStation.TabIndex = 22;
            this.currencyPetrolStation.Text = "Рубл.";
            // 
            // textBoxPaymentOne
            // 
            this.textBoxPaymentOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPaymentOne.Location = new System.Drawing.Point(212, 19);
            this.textBoxPaymentOne.MaxLength = 6;
            this.textBoxPaymentOne.Multiline = true;
            this.textBoxPaymentOne.Name = "textBoxPaymentOne";
            this.textBoxPaymentOne.ReadOnly = true;
            this.textBoxPaymentOne.Size = new System.Drawing.Size(130, 50);
            this.textBoxPaymentOne.TabIndex = 18;
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.White;
            this.buttonPay.Location = new System.Drawing.Point(8, 19);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(149, 50);
            this.buttonPay.TabIndex = 20;
            this.buttonPay.Text = "Оплатить";
            this.buttonPay.UseVisualStyleBackColor = false;
            // 
            // labelPaymentone
            // 
            this.labelPaymentone.AutoSize = true;
            this.labelPaymentone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPaymentone.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelPaymentone.Location = new System.Drawing.Point(13, 170);
            this.labelPaymentone.Name = "labelPaymentone";
            this.labelPaymentone.Size = new System.Drawing.Size(76, 16);
            this.labelPaymentone.TabIndex = 16;
            this.labelPaymentone.Text = "До оплаты";
            this.labelPaymentone.UseMnemonic = false;
            // 
            // panelLiterPrice
            // 
            this.panelLiterPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLiterPrice.Controls.Add(this.radioButtonPrice);
            this.panelLiterPrice.Controls.Add(this.radioButtonQuantity);
            this.panelLiterPrice.Location = new System.Drawing.Point(6, 95);
            this.panelLiterPrice.Name = "panelLiterPrice";
            this.panelLiterPrice.Size = new System.Drawing.Size(212, 72);
            this.panelLiterPrice.TabIndex = 16;
            // 
            // radioButtonPrice
            // 
            this.radioButtonPrice.AutoSize = true;
            this.radioButtonPrice.Location = new System.Drawing.Point(3, 37);
            this.radioButtonPrice.Name = "radioButtonPrice";
            this.radioButtonPrice.Size = new System.Drawing.Size(59, 17);
            this.radioButtonPrice.TabIndex = 21;
            this.radioButtonPrice.TabStop = true;
            this.radioButtonPrice.Text = "Сумма";
            this.radioButtonPrice.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuantity
            // 
            this.radioButtonQuantity.AutoSize = true;
            this.radioButtonQuantity.Location = new System.Drawing.Point(3, 11);
            this.radioButtonQuantity.Name = "radioButtonQuantity";
            this.radioButtonQuantity.Size = new System.Drawing.Size(84, 17);
            this.radioButtonQuantity.TabIndex = 20;
            this.radioButtonQuantity.TabStop = true;
            this.radioButtonQuantity.Text = "Количество";
            this.radioButtonQuantity.UseVisualStyleBackColor = true;
            this.radioButtonQuantity.CheckedChanged += new System.EventHandler(this.RadioButtonQuantity_CheckedChanged);
            // 
            // labelPriceRub
            // 
            this.labelPriceRub.AutoSize = true;
            this.labelPriceRub.Location = new System.Drawing.Point(356, 140);
            this.labelPriceRub.Name = "labelPriceRub";
            this.labelPriceRub.Size = new System.Drawing.Size(34, 13);
            this.labelPriceRub.TabIndex = 17;
            this.labelPriceRub.Text = "Рубл.";
            // 
            // textBoxPriceRub
            // 
            this.textBoxPriceRub.Enabled = false;
            this.textBoxPriceRub.Location = new System.Drawing.Point(232, 133);
            this.textBoxPriceRub.Name = "textBoxPriceRub";
            this.textBoxPriceRub.Size = new System.Drawing.Size(118, 20);
            this.textBoxPriceRub.TabIndex = 19;
            // 
            // labelOilLiter
            // 
            this.labelOilLiter.AutoSize = true;
            this.labelOilLiter.Location = new System.Drawing.Point(356, 110);
            this.labelOilLiter.Name = "labelOilLiter";
            this.labelOilLiter.Size = new System.Drawing.Size(18, 13);
            this.labelOilLiter.TabIndex = 18;
            this.labelOilLiter.Text = "Л.";
            // 
            // labelCurrencyPriceRub
            // 
            this.labelCurrencyPriceRub.AutoSize = true;
            this.labelCurrencyPriceRub.Location = new System.Drawing.Point(356, 55);
            this.labelCurrencyPriceRub.Name = "labelCurrencyPriceRub";
            this.labelCurrencyPriceRub.Size = new System.Drawing.Size(34, 13);
            this.labelCurrencyPriceRub.TabIndex = 15;
            this.labelCurrencyPriceRub.Text = "Рубл.";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(232, 48);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrice.TabIndex = 5;
            // 
            // comboBoxOil
            // 
            this.comboBoxOil.FormattingEnabled = true;
            this.comboBoxOil.Items.AddRange(new object[] {
            "АИ-76",
            "АИ-80",
            "АИ-92",
            "АИ-93",
            "АИ-95",
            "АИ-98",
            "ДТ"});
            this.comboBoxOil.Location = new System.Drawing.Point(232, 16);
            this.comboBoxOil.Name = "comboBoxOil";
            this.comboBoxOil.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOil.TabIndex = 3;
            this.comboBoxOil.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOil_SelectedIndexChanged);
            // 
            // textBoxPriceLiter
            // 
            this.textBoxPriceLiter.Enabled = false;
            this.textBoxPriceLiter.Location = new System.Drawing.Point(232, 103);
            this.textBoxPriceLiter.Name = "textBoxPriceLiter";
            this.textBoxPriceLiter.Size = new System.Drawing.Size(118, 20);
            this.textBoxPriceLiter.TabIndex = 17;
            // 
            // labelFuelPrice
            // 
            this.labelFuelPrice.AutoSize = true;
            this.labelFuelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFuelPrice.Location = new System.Drawing.Point(8, 49);
            this.labelFuelPrice.Name = "labelFuelPrice";
            this.labelFuelPrice.Size = new System.Drawing.Size(41, 16);
            this.labelFuelPrice.TabIndex = 2;
            this.labelFuelPrice.Text = "Цена";
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFuel.Location = new System.Drawing.Point(8, 17);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(57, 16);
            this.labelFuel.TabIndex = 1;
            this.labelFuel.Text = "Бензин";
            // 
            // labelAutoFueling
            // 
            this.labelAutoFueling.AutoSize = true;
            this.labelAutoFueling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutoFueling.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelAutoFueling.Location = new System.Drawing.Point(12, 9);
            this.labelAutoFueling.Name = "labelAutoFueling";
            this.labelAutoFueling.Size = new System.Drawing.Size(103, 16);
            this.labelAutoFueling.TabIndex = 0;
            this.labelAutoFueling.Text = "Автозаправка";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(157, 317);
            this.textBox1.MaxLength = 6;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(140, 27);
            this.textBox1.TabIndex = 22;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelTotalPrice.Location = new System.Drawing.Point(17, 327);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(118, 16);
            this.labelTotalPrice.TabIndex = 23;
            this.labelTotalPrice.Text = "Выручка за день";
            // 
            // labelTotalPriceRub
            // 
            this.labelTotalPriceRub.AutoSize = true;
            this.labelTotalPriceRub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalPriceRub.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelTotalPriceRub.Location = new System.Drawing.Point(320, 328);
            this.labelTotalPriceRub.Name = "labelTotalPriceRub";
            this.labelTotalPriceRub.Size = new System.Drawing.Size(44, 16);
            this.labelTotalPriceRub.TabIndex = 24;
            this.labelTotalPriceRub.Text = "Рубл.";
            // 
            // BestOil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(410, 354);
            this.Controls.Add(this.labelTotalPriceRub);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelFuel);
            this.Controls.Add(this.labelAutoFueling);
            this.Name = "BestOil";
            this.Text = "BestOil";
            this.panelFuel.ResumeLayout(false);
            this.panelFuel.PerformLayout();
            this.panelPaymentone.ResumeLayout(false);
            this.panelPaymentone.PerformLayout();
            this.panelLiterPrice.ResumeLayout(false);
            this.panelLiterPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFuel;
        private System.Windows.Forms.Label labelAutoFueling;
        private System.Windows.Forms.Label labelFuelPrice;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Panel panelLiterPrice;
        private System.Windows.Forms.Label labelCurrencyPriceRub;
        private System.Windows.Forms.TextBox textBoxPriceRub;
        private System.Windows.Forms.Label labelPriceRub;
        private System.Windows.Forms.Label labelOilLiter;
        private System.Windows.Forms.TextBox textBoxPriceLiter;
        private System.Windows.Forms.RadioButton radioButtonQuantity;
        private System.Windows.Forms.RadioButton radioButtonPrice;
        private System.Windows.Forms.Panel panelPaymentone;
        private System.Windows.Forms.TextBox textBoxPaymentOne;
        private System.Windows.Forms.Label labelPaymentone;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.ComboBox comboBoxOil;
        private System.Windows.Forms.Label currencyPetrolStation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelTotalPriceRub;
    }
}

