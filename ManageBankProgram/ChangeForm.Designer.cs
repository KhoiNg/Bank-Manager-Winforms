namespace ManageBankProgram
{
    partial class ChangeForm
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(12, 33);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(154, 35);
            this.textBoxId.TabIndex = 18;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(187, 33);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(85, 35);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.Location = new System.Drawing.Point(278, 33);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(85, 35);
            this.buttonChange.TabIndex = 21;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(153, 88);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(85, 35);
            this.buttonClose.TabIndex = 22;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(84, 10);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(22, 20);
            this.labelId.TabIndex = 23;
            this.labelId.Text = "ID";
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 136);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeForm";
            this.Text = "Delete And Change Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelId;
    }
}