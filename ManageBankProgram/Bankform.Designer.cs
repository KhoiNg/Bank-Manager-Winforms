namespace ManageBankProgram
{
    partial class Bankform
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsExcelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsTextTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listItemView = new System.Windows.Forms.ListView();
            this.itemPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemSign = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonInsert = new System.Windows.Forms.Button();
            this.panelLeftTop = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.panelLeftBot = new System.Windows.Forms.Panel();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.comboBoxFilterDate = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterAmount = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterDescription = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.menuStrip1.SuspendLayout();
            this.panelLeftTop.SuspendLayout();
            this.panelLeftBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.functionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTextToolStripMenuItem,
            this.saveTextToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openTextToolStripMenuItem
            // 
            this.openTextToolStripMenuItem.Name = "openTextToolStripMenuItem";
            this.openTextToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.openTextToolStripMenuItem.Text = "Open (Text)";
            this.openTextToolStripMenuItem.Click += new System.EventHandler(this.openTextToolStripMenuItem_Click);
            // 
            // saveTextToolStripMenuItem
            // 
            this.saveTextToolStripMenuItem.Name = "saveTextToolStripMenuItem";
            this.saveTextToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.saveTextToolStripMenuItem.Text = "Save (Text)";
            this.saveTextToolStripMenuItem.Click += new System.EventHandler(this.saveTextToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveAsExcelFileToolStripMenuItem,
            this.saveAsTextTableToolStripMenuItem,
            this.accountSummaryToolStripMenuItem});
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.functionToolStripMenuItem.Text = "Function";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.newToolStripMenuItem.Text = "Make New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveAsExcelFileToolStripMenuItem
            // 
            this.saveAsExcelFileToolStripMenuItem.Name = "saveAsExcelFileToolStripMenuItem";
            this.saveAsExcelFileToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.saveAsExcelFileToolStripMenuItem.Text = "Save As Excel File";
            this.saveAsExcelFileToolStripMenuItem.Click += new System.EventHandler(this.saveAsExcelFileToolStripMenuItem_Click);
            // 
            // saveAsTextTableToolStripMenuItem
            // 
            this.saveAsTextTableToolStripMenuItem.Name = "saveAsTextTableToolStripMenuItem";
            this.saveAsTextTableToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.saveAsTextTableToolStripMenuItem.Text = "Save As Text Table";
            this.saveAsTextTableToolStripMenuItem.Click += new System.EventHandler(this.saveAsTextTableToolStripMenuItem_Click);
            // 
            // accountSummaryToolStripMenuItem
            // 
            this.accountSummaryToolStripMenuItem.Name = "accountSummaryToolStripMenuItem";
            this.accountSummaryToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.accountSummaryToolStripMenuItem.Text = "Account Summary";
            this.accountSummaryToolStripMenuItem.Click += new System.EventHandler(this.accountSummaryToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutThisToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutThisToolStripMenuItem
            // 
            this.aboutThisToolStripMenuItem.Name = "aboutThisToolStripMenuItem";
            this.aboutThisToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.aboutThisToolStripMenuItem.Text = "About";
            this.aboutThisToolStripMenuItem.Click += new System.EventHandler(this.aboutThisToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.contactToolStripMenuItem.Text = "Contact && Support";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // listItemView
            // 
            this.listItemView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemPosition,
            this.itemId,
            this.itemDate,
            this.itemDescription,
            this.itemAmount,
            this.itemSign});
            this.listItemView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listItemView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listItemView.FullRowSelect = true;
            this.listItemView.GridLines = true;
            this.listItemView.HoverSelection = true;
            this.listItemView.Location = new System.Drawing.Point(132, 27);
            this.listItemView.Name = "listItemView";
            this.listItemView.Size = new System.Drawing.Size(683, 328);
            this.listItemView.TabIndex = 1;
            this.listItemView.TileSize = new System.Drawing.Size(168, 30);
            this.listItemView.UseCompatibleStateImageBehavior = false;
            this.listItemView.View = System.Windows.Forms.View.Details;
            // 
            // itemPosition
            // 
            this.itemPosition.Text = "  ";
            this.itemPosition.Width = 50;
            // 
            // itemId
            // 
            this.itemId.Text = "ID";
            this.itemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemId.Width = 128;
            // 
            // itemDate
            // 
            this.itemDate.Text = "Date";
            this.itemDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemDate.Width = 204;
            // 
            // itemDescription
            // 
            this.itemDescription.Text = "Description";
            this.itemDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemDescription.Width = 132;
            // 
            // itemAmount
            // 
            this.itemAmount.Text = "Amount";
            this.itemAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemAmount.Width = 115;
            // 
            // itemSign
            // 
            this.itemSign.Text = "Sign";
            this.itemSign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemSign.Width = 50;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(3, 3);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(108, 39);
            this.buttonInsert.TabIndex = 2;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // panelLeftTop
            // 
            this.panelLeftTop.Controls.Add(this.buttonSearch);
            this.panelLeftTop.Controls.Add(this.buttonChange);
            this.panelLeftTop.Controls.Add(this.buttonInsert);
            this.panelLeftTop.Location = new System.Drawing.Point(12, 27);
            this.panelLeftTop.Name = "panelLeftTop";
            this.panelLeftTop.Size = new System.Drawing.Size(114, 137);
            this.panelLeftTop.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(3, 93);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(108, 39);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.Location = new System.Drawing.Point(3, 48);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(108, 39);
            this.buttonChange.TabIndex = 4;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // panelLeftBot
            // 
            this.panelLeftBot.Controls.Add(this.labelAmount);
            this.panelLeftBot.Controls.Add(this.labelDescription);
            this.panelLeftBot.Controls.Add(this.labelDate);
            this.panelLeftBot.Controls.Add(this.comboBoxFilterDate);
            this.panelLeftBot.Controls.Add(this.comboBoxFilterAmount);
            this.panelLeftBot.Controls.Add(this.comboBoxFilterDescription);
            this.panelLeftBot.Controls.Add(this.label1);
            this.panelLeftBot.Location = new System.Drawing.Point(11, 170);
            this.panelLeftBot.Name = "panelLeftBot";
            this.panelLeftBot.Size = new System.Drawing.Size(115, 185);
            this.panelLeftBot.TabIndex = 4;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(20, 136);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(80, 20);
            this.labelAmount.TabIndex = 16;
            this.labelAmount.Text = "By Amount";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(8, 89);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(103, 20);
            this.labelDescription.TabIndex = 15;
            this.labelDescription.Text = "By Description";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(25, 42);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(60, 20);
            this.labelDate.TabIndex = 14;
            this.labelDate.Text = "By Date";
            // 
            // comboBoxFilterDate
            // 
            this.comboBoxFilterDate.FormattingEnabled = true;
            this.comboBoxFilterDate.Items.AddRange(new object[] {
            "Ascending",
            "Descending ",
            "Specific Day",
            "None"});
            this.comboBoxFilterDate.Location = new System.Drawing.Point(7, 65);
            this.comboBoxFilterDate.Name = "comboBoxFilterDate";
            this.comboBoxFilterDate.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFilterDate.TabIndex = 7;
            this.comboBoxFilterDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterDate_SelectedIndexChanged);
            // 
            // comboBoxFilterAmount
            // 
            this.comboBoxFilterAmount.FormattingEnabled = true;
            this.comboBoxFilterAmount.Items.AddRange(new object[] {
            "Less than 100",
            "From 100 to 500",
            "From 500 to 1000",
            "More than 1000",
            "None"});
            this.comboBoxFilterAmount.Location = new System.Drawing.Point(7, 160);
            this.comboBoxFilterAmount.Name = "comboBoxFilterAmount";
            this.comboBoxFilterAmount.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFilterAmount.TabIndex = 6;
            this.comboBoxFilterAmount.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterAmount_SelectedIndexChanged);
            // 
            // comboBoxFilterDescription
            // 
            this.comboBoxFilterDescription.FormattingEnabled = true;
            this.comboBoxFilterDescription.Items.AddRange(new object[] {
            "Income/Wage ",
            "Bonus Money ",
            "Housing",
            "Food/Grogeries ",
            "Transportation  ",
            "Health/Insurance",
            "Education",
            "Buying things",
            "Entertainment",
            "Others ",
            "None"});
            this.comboBoxFilterDescription.Location = new System.Drawing.Point(7, 112);
            this.comboBoxFilterDescription.Name = "comboBoxFilterDescription";
            this.comboBoxFilterDescription.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFilterDescription.TabIndex = 3;
            this.comboBoxFilterDescription.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterDescription_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Bankform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 363);
            this.Controls.Add(this.panelLeftBot);
            this.Controls.Add(this.panelLeftTop);
            this.Controls.Add(this.listItemView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Bankform";
            this.Text = "Bank Control Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bankform_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bankform_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelLeftTop.ResumeLayout(false);
            this.panelLeftBot.ResumeLayout(false);
            this.panelLeftBot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListView listItemView;
        private System.Windows.Forms.ColumnHeader itemDate;
        private System.Windows.Forms.ColumnHeader itemDescription;
        private System.Windows.Forms.ColumnHeader itemAmount;
        private System.Windows.Forms.ColumnHeader itemSign;
        private System.Windows.Forms.ColumnHeader itemId;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Panel panelLeftTop;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Panel panelLeftBot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFilterAmount;
        private System.Windows.Forms.ComboBox comboBoxFilterDescription;
        private System.Windows.Forms.ColumnHeader itemPosition;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxFilterDate;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ToolStripMenuItem aboutThisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsExcelFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsTextTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSummaryToolStripMenuItem;
        private System.Diagnostics.EventLog eventLog1;
    }
}

