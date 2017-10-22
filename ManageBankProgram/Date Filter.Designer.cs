namespace ManageBankProgram
{
    partial class SpecificDateFilter
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
            this.labelNote = new System.Windows.Forms.Label();
            this.itemFilterTime = new System.Windows.Forms.DateTimePicker();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(46, 9);
            this.labelNote.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(138, 24);
            this.labelNote.TabIndex = 0;
            this.labelNote.Text = "Enter The Date";
            // 
            // itemFilterTime
            // 
            this.itemFilterTime.Checked = false;
            this.itemFilterTime.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemFilterTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.itemFilterTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.itemFilterTime.Location = new System.Drawing.Point(39, 36);
            this.itemFilterTime.Name = "itemFilterTime";
            this.itemFilterTime.Size = new System.Drawing.Size(154, 32);
            this.itemFilterTime.TabIndex = 1;
            this.itemFilterTime.TabStop = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(64, 74);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(99, 35);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // SpecificDateFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 114);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.itemFilterTime);
            this.Controls.Add(this.labelNote);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SpecificDateFilter";
            this.Text = "Date Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.DateTimePicker itemFilterTime;
        private System.Windows.Forms.Button buttonOK;
    }
}