
namespace Classwork2
{
    partial class EditForm
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
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.countNUP = new System.Windows.Forms.NumericUpDown();
            this.priceNUP = new System.Windows.Forms.NumericUpDown();
            this.nameTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.countNUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(31, 172);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(121, 23);
            this.groupComboBox.TabIndex = 9;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(31, 232);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(218, 53);
            this.editBtn.TabIndex = 8;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // countNUP
            // 
            this.countNUP.Location = new System.Drawing.Point(31, 129);
            this.countNUP.Name = "countNUP";
            this.countNUP.Size = new System.Drawing.Size(218, 23);
            this.countNUP.TabIndex = 7;
            // 
            // priceNUP
            // 
            this.priceNUP.Location = new System.Drawing.Point(31, 89);
            this.priceNUP.Name = "priceNUP";
            this.priceNUP.Size = new System.Drawing.Size(218, 23);
            this.priceNUP.TabIndex = 6;
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(31, 45);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(218, 23);
            this.nameTb.TabIndex = 5;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.countNUP);
            this.Controls.Add(this.priceNUP);
            this.Controls.Add(this.nameTb);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countNUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.NumericUpDown countNUP;
        private System.Windows.Forms.NumericUpDown priceNUP;
        private System.Windows.Forms.TextBox nameTb;
    }
}