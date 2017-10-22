namespace ManageBankProgram
{
    partial class ChangeFormTemp
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
            this.labelSign = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.comboBoxChangeSign = new System.Windows.Forms.ComboBox();
            this.textBoxChangeAmount = new System.Windows.Forms.TextBox();
            this.comboBoxChangeDescription = new System.Windows.Forms.ComboBox();
            this.itemChangeTime = new System.Windows.Forms.DateTimePicker();
            this.buttonChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSign
            // 
            this.labelSign.AutoSize = true;
            this.labelSign.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSign.Location = new System.Drawing.Point(518, 19);
            this.labelSign.Name = "labelSign";
            this.labelSign.Size = new System.Drawing.Size(36, 20);
            this.labelSign.TabIndex = 16;
            this.labelSign.Text = "Sign";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(381, 20);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(61, 20);
            this.labelAmount.TabIndex = 15;
            this.labelAmount.Text = "Amount";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(219, 20);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(83, 20);
            this.labelDescription.TabIndex = 14;
            this.labelDescription.Text = "Description";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(67, 20);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(40, 20);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "Date";
            // 
            // comboBoxChangeSign
            // 
            this.comboBoxChangeSign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChangeSign.DropDownWidth = 150;
            this.comboBoxChangeSign.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChangeSign.FormattingEnabled = true;
            this.comboBoxChangeSign.Items.AddRange(new object[] {
            "Receive ( + )",
            "Spend ( - )"});
            this.comboBoxChangeSign.Location = new System.Drawing.Point(476, 42);
            this.comboBoxChangeSign.Name = "comboBoxChangeSign";
            this.comboBoxChangeSign.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxChangeSign.Size = new System.Drawing.Size(120, 31);
            this.comboBoxChangeSign.TabIndex = 12;
            // 
            // textBoxChangeAmount
            // 
            this.textBoxChangeAmount.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChangeAmount.Location = new System.Drawing.Point(345, 43);
            this.textBoxChangeAmount.Name = "textBoxChangeAmount";
            this.textBoxChangeAmount.Size = new System.Drawing.Size(125, 30);
            this.textBoxChangeAmount.TabIndex = 11;
            // 
            // comboBoxChangeDescription
            // 
            this.comboBoxChangeDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChangeDescription.DropDownWidth = 150;
            this.comboBoxChangeDescription.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChangeDescription.FormattingEnabled = true;
            this.comboBoxChangeDescription.Items.AddRange(new object[] {
            "Income/Wage ",
            "Bonus Money ",
            "Housing",
            "Food/Grogeries ",
            "Transportation  ",
            "Health/Insurance",
            "Education",
            "Buying things",
            "Entertainment",
            "Others "});
            this.comboBoxChangeDescription.Location = new System.Drawing.Point(172, 43);
            this.comboBoxChangeDescription.Name = "comboBoxChangeDescription";
            this.comboBoxChangeDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxChangeDescription.Size = new System.Drawing.Size(167, 31);
            this.comboBoxChangeDescription.TabIndex = 10;
            // 
            // itemChangeTime
            // 
            this.itemChangeTime.Checked = false;
            this.itemChangeTime.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemChangeTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.itemChangeTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.itemChangeTime.Location = new System.Drawing.Point(12, 43);
            this.itemChangeTime.Name = "itemChangeTime";
            this.itemChangeTime.Size = new System.Drawing.Size(154, 32);
            this.itemChangeTime.TabIndex = 9;
            this.itemChangeTime.TabStop = false;
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.Location = new System.Drawing.Point(262, 99);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonChange.Size = new System.Drawing.Size(112, 35);
            this.buttonChange.TabIndex = 17;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // ChangeFormTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 146);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.labelSign);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxChangeSign);
            this.Controls.Add(this.textBoxChangeAmount);
            this.Controls.Add(this.comboBoxChangeDescription);
            this.Controls.Add(this.itemChangeTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeFormTemp";
            this.Text = "Change Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSign;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox comboBoxChangeSign;
        private System.Windows.Forms.TextBox textBoxChangeAmount;
        private System.Windows.Forms.ComboBox comboBoxChangeDescription;
        private System.Windows.Forms.DateTimePicker itemChangeTime;
        private System.Windows.Forms.Button buttonChange;
    }
}