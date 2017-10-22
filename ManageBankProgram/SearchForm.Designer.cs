namespace ManageBankProgram
{
    partial class SearchForm
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
            this.checkBoxID = new System.Windows.Forms.CheckBox();
            this.checkBoxInfo = new System.Windows.Forms.CheckBox();
            this.labelSign = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.comboBoxSearchSign = new System.Windows.Forms.ComboBox();
            this.textBoxSearchAmount = new System.Windows.Forms.TextBox();
            this.comboBoxSearchDescription = new System.Windows.Forms.ComboBox();
            this.itemSearchTime = new System.Windows.Forms.DateTimePicker();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelNote = new System.Windows.Forms.Label();
            this.labelNote2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxID
            // 
            this.checkBoxID.AutoSize = true;
            this.checkBoxID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxID.Location = new System.Drawing.Point(13, 33);
            this.checkBoxID.Name = "checkBoxID";
            this.checkBoxID.Size = new System.Drawing.Size(65, 26);
            this.checkBoxID.TabIndex = 0;
            this.checkBoxID.Text = "By ID";
            this.checkBoxID.UseVisualStyleBackColor = true;
            this.checkBoxID.CheckedChanged += new System.EventHandler(this.checkBoxID_CheckedChanged);
            // 
            // checkBoxInfo
            // 
            this.checkBoxInfo.AutoSize = true;
            this.checkBoxInfo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInfo.Location = new System.Drawing.Point(12, 96);
            this.checkBoxInfo.Name = "checkBoxInfo";
            this.checkBoxInfo.Size = new System.Drawing.Size(78, 26);
            this.checkBoxInfo.TabIndex = 6;
            this.checkBoxInfo.Text = "By Info";
            this.checkBoxInfo.UseVisualStyleBackColor = true;
            this.checkBoxInfo.CheckedChanged += new System.EventHandler(this.checkBoxInfo_CheckedChanged);
            // 
            // labelSign
            // 
            this.labelSign.AutoSize = true;
            this.labelSign.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSign.Location = new System.Drawing.Point(608, 67);
            this.labelSign.Name = "labelSign";
            this.labelSign.Size = new System.Drawing.Size(36, 20);
            this.labelSign.TabIndex = 16;
            this.labelSign.Text = "Sign";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(471, 68);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(61, 20);
            this.labelAmount.TabIndex = 15;
            this.labelAmount.Text = "Amount";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(309, 68);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(83, 20);
            this.labelDescription.TabIndex = 14;
            this.labelDescription.Text = "Description";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(157, 68);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(40, 20);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "Date";
            // 
            // comboBoxSearchSign
            // 
            this.comboBoxSearchSign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchSign.DropDownWidth = 150;
            this.comboBoxSearchSign.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchSign.FormattingEnabled = true;
            this.comboBoxSearchSign.Items.AddRange(new object[] {
            "Receive ( + )",
            "Spend ( - )"});
            this.comboBoxSearchSign.Location = new System.Drawing.Point(566, 90);
            this.comboBoxSearchSign.Name = "comboBoxSearchSign";
            this.comboBoxSearchSign.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxSearchSign.Size = new System.Drawing.Size(120, 31);
            this.comboBoxSearchSign.TabIndex = 12;
            // 
            // textBoxSearchAmount
            // 
            this.textBoxSearchAmount.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchAmount.Location = new System.Drawing.Point(435, 91);
            this.textBoxSearchAmount.Name = "textBoxSearchAmount";
            this.textBoxSearchAmount.Size = new System.Drawing.Size(125, 30);
            this.textBoxSearchAmount.TabIndex = 11;
            // 
            // comboBoxSearchDescription
            // 
            this.comboBoxSearchDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchDescription.DropDownWidth = 150;
            this.comboBoxSearchDescription.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchDescription.FormattingEnabled = true;
            this.comboBoxSearchDescription.Items.AddRange(new object[] {
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
            this.comboBoxSearchDescription.Location = new System.Drawing.Point(262, 91);
            this.comboBoxSearchDescription.Name = "comboBoxSearchDescription";
            this.comboBoxSearchDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxSearchDescription.Size = new System.Drawing.Size(167, 31);
            this.comboBoxSearchDescription.TabIndex = 10;
            // 
            // itemSearchTime
            // 
            this.itemSearchTime.Checked = false;
            this.itemSearchTime.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSearchTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.itemSearchTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.itemSearchTime.Location = new System.Drawing.Point(102, 91);
            this.itemSearchTime.Name = "itemSearchTime";
            this.itemSearchTime.Size = new System.Drawing.Size(154, 32);
            this.itemSearchTime.TabIndex = 9;
            this.itemSearchTime.TabStop = false;
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(102, 29);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(154, 30);
            this.textBoxId.TabIndex = 17;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(166, 6);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(22, 20);
            this.labelId.TabIndex = 18;
            this.labelId.Text = "ID";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(272, 210);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(85, 35);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(363, 210);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(82, 35);
            this.buttonClose.TabIndex = 20;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(139, 145);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(409, 20);
            this.labelNote.TabIndex = 21;
            this.labelNote.Text = "Note : Amount will be round to 2 decimal number to search";
            // 
            // labelNote2
            // 
            this.labelNote2.AutoSize = true;
            this.labelNote2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote2.Location = new System.Drawing.Point(157, 175);
            this.labelNote2.Name = "labelNote2";
            this.labelNote2.Size = new System.Drawing.Size(373, 20);
            this.labelNote2.TabIndex = 22;
            this.labelNote2.Text = "Search By Info does not require you to fill all the fields";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 253);
            this.Controls.Add(this.labelNote2);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelSign);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxSearchSign);
            this.Controls.Add(this.textBoxSearchAmount);
            this.Controls.Add(this.comboBoxSearchDescription);
            this.Controls.Add(this.itemSearchTime);
            this.Controls.Add(this.checkBoxInfo);
            this.Controls.Add(this.checkBoxID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.Text = "Search Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxID;
        private System.Windows.Forms.CheckBox checkBoxInfo;
        private System.Windows.Forms.Label labelSign;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox comboBoxSearchSign;
        private System.Windows.Forms.TextBox textBoxSearchAmount;
        private System.Windows.Forms.ComboBox comboBoxSearchDescription;
        private System.Windows.Forms.DateTimePicker itemSearchTime;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelNote2;
    }
}