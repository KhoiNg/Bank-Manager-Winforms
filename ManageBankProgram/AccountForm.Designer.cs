namespace ManageBankProgram
{
    partial class AccountForm
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
            this.listItemView = new System.Windows.Forms.ListView();
            this.itemPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemSign = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBoxReceive = new System.Windows.Forms.CheckBox();
            this.checkBoxSpending = new System.Windows.Forms.CheckBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.listItemView.Location = new System.Drawing.Point(146, 12);
            this.listItemView.Name = "listItemView";
            this.listItemView.Size = new System.Drawing.Size(686, 268);
            this.listItemView.TabIndex = 2;
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
            // checkBoxReceive
            // 
            this.checkBoxReceive.AutoSize = true;
            this.checkBoxReceive.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxReceive.Location = new System.Drawing.Point(12, 61);
            this.checkBoxReceive.Name = "checkBoxReceive";
            this.checkBoxReceive.Size = new System.Drawing.Size(120, 26);
            this.checkBoxReceive.TabIndex = 3;
            this.checkBoxReceive.Text = "By Receiving";
            this.checkBoxReceive.UseVisualStyleBackColor = true;
            this.checkBoxReceive.CheckedChanged += new System.EventHandler(this.checkBoxReceive_CheckedChanged);
            // 
            // checkBoxSpending
            // 
            this.checkBoxSpending.AutoSize = true;
            this.checkBoxSpending.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSpending.Location = new System.Drawing.Point(12, 93);
            this.checkBoxSpending.Name = "checkBoxSpending";
            this.checkBoxSpending.Size = new System.Drawing.Size(115, 26);
            this.checkBoxSpending.TabIndex = 4;
            this.checkBoxSpending.Text = "By Spending";
            this.checkBoxSpending.UseVisualStyleBackColor = true;
            this.checkBoxSpending.CheckedChanged += new System.EventHandler(this.checkBoxSpending_CheckedChanged);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSum.Location = new System.Drawing.Point(609, 287);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(49, 27);
            this.labelSum.TabIndex = 5;
            this.labelSum.Text = "Sum";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(29, 170);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(84, 54);
            this.labelBalance.TabIndex = 6;
            this.labelBalance.Text = "Total \r\nBalance";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBalance.Location = new System.Drawing.Point(7, 227);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(125, 30);
            this.textBoxBalance.TabIndex = 7;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSum.Location = new System.Drawing.Point(664, 286);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(116, 30);
            this.textBoxSum.TabIndex = 8;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(366, 333);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(108, 39);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 380);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.checkBoxSpending);
            this.Controls.Add(this.checkBoxReceive);
            this.Controls.Add(this.listItemView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountForm";
            this.Text = "Account Summary Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listItemView;
        private System.Windows.Forms.ColumnHeader itemPosition;
        private System.Windows.Forms.ColumnHeader itemId;
        private System.Windows.Forms.ColumnHeader itemDate;
        private System.Windows.Forms.ColumnHeader itemDescription;
        private System.Windows.Forms.ColumnHeader itemAmount;
        private System.Windows.Forms.ColumnHeader itemSign;
        private System.Windows.Forms.CheckBox checkBoxReceive;
        private System.Windows.Forms.CheckBox checkBoxSpending;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Button buttonClose;
    }
}