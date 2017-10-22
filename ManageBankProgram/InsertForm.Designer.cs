namespace ManageBankProgram
{
    partial class InsertForm
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
            this.itemInsertTime = new System.Windows.Forms.DateTimePicker();
            this.comboBoxInsertDescription = new System.Windows.Forms.ComboBox();
            this.textBoxInsertAmount = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.comboBoxInsertSign = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelSign = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labelNote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemInsertTime
            // 
            this.itemInsertTime.Checked = false;
            this.itemInsertTime.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemInsertTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.itemInsertTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.itemInsertTime.Location = new System.Drawing.Point(12, 37);
            this.itemInsertTime.Name = "itemInsertTime";
            this.itemInsertTime.Size = new System.Drawing.Size(154, 32);
            this.itemInsertTime.TabIndex = 0;
            this.itemInsertTime.TabStop = false;
            this.itemInsertTime.ValueChanged += new System.EventHandler(this.itemInsertTime_ValueChanged);
            // 
            // comboBoxInsertDescription
            // 
            this.comboBoxInsertDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInsertDescription.DropDownWidth = 150;
            this.comboBoxInsertDescription.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxInsertDescription.FormattingEnabled = true;
            this.comboBoxInsertDescription.Items.AddRange(new object[] {
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
            this.comboBoxInsertDescription.Location = new System.Drawing.Point(172, 37);
            this.comboBoxInsertDescription.Name = "comboBoxInsertDescription";
            this.comboBoxInsertDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxInsertDescription.Size = new System.Drawing.Size(167, 31);
            this.comboBoxInsertDescription.TabIndex = 1;
            this.comboBoxInsertDescription.SelectedIndexChanged += new System.EventHandler(this.comboBoxInsertDescription_SelectedIndexChanged);
            // 
            // textBoxInsertAmount
            // 
            this.textBoxInsertAmount.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInsertAmount.Location = new System.Drawing.Point(345, 37);
            this.textBoxInsertAmount.Name = "textBoxInsertAmount";
            this.textBoxInsertAmount.Size = new System.Drawing.Size(125, 30);
            this.textBoxInsertAmount.TabIndex = 2;
            this.textBoxInsertAmount.TextChanged += new System.EventHandler(this.textBoxInsert_TextChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 191);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // comboBoxInsertSign
            // 
            this.comboBoxInsertSign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInsertSign.DropDownWidth = 150;
            this.comboBoxInsertSign.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxInsertSign.FormattingEnabled = true;
            this.comboBoxInsertSign.Items.AddRange(new object[] {
            "Receive ( + )",
            "Spend ( - )"});
            this.comboBoxInsertSign.Location = new System.Drawing.Point(476, 36);
            this.comboBoxInsertSign.Name = "comboBoxInsertSign";
            this.comboBoxInsertSign.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxInsertSign.Size = new System.Drawing.Size(120, 31);
            this.comboBoxInsertSign.TabIndex = 4;
            this.comboBoxInsertSign.SelectedIndexChanged += new System.EventHandler(this.comboBoxInsertSign_SelectedIndexChanged);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(67, 14);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(40, 20);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Date";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(219, 14);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(83, 20);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Description";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(381, 14);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(61, 20);
            this.labelAmount.TabIndex = 7;
            this.labelAmount.Text = "Amount";
            // 
            // labelSign
            // 
            this.labelSign.AutoSize = true;
            this.labelSign.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSign.Location = new System.Drawing.Point(518, 13);
            this.labelSign.Name = "labelSign";
            this.labelSign.Size = new System.Drawing.Size(36, 20);
            this.labelSign.TabIndex = 8;
            this.labelSign.Text = "Sign";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(227, 142);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 35);
            this.buttonInsert.TabIndex = 9;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(101, 91);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(428, 13);
            this.labelNote.TabIndex = 10;
            this.labelNote.Text = "Note : Code Format = Selected Description Position + CurrentTime (hh mm ss yyy MM" +
    " dd )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Only Income/Wage or Bonus Money is expected to have a positive sign";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(308, 142);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 35);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 191);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelSign);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxInsertSign);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.textBoxInsertAmount);
            this.Controls.Add(this.comboBoxInsertDescription);
            this.Controls.Add(this.itemInsertTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertForm";
            this.Text = "Insert Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker itemInsertTime;
        private System.Windows.Forms.ComboBox comboBoxInsertDescription;
        private System.Windows.Forms.TextBox textBoxInsertAmount;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ComboBox comboBoxInsertSign;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelSign;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
    }
}