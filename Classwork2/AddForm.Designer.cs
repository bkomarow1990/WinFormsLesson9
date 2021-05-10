
namespace Classwork2
{
    partial class AddForm
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
            this.nameTb = new System.Windows.Forms.TextBox();
            this.priceNUP = new System.Windows.Forms.NumericUpDown();
            this.countNUP = new System.Windows.Forms.NumericUpDown();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNUP)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(29, 12);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(218, 23);
            this.nameTb.TabIndex = 0;
            // 
            // priceNUP
            // 
            this.priceNUP.Location = new System.Drawing.Point(29, 56);
            this.priceNUP.Name = "priceNUP";
            this.priceNUP.Size = new System.Drawing.Size(218, 23);
            this.priceNUP.TabIndex = 1;
            // 
            // countNUP
            // 
            this.countNUP.Location = new System.Drawing.Point(29, 96);
            this.countNUP.Name = "countNUP";
            this.countNUP.Size = new System.Drawing.Size(218, 23);
            this.countNUP.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(29, 199);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(218, 53);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(29, 139);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(121, 23);
            this.groupComboBox.TabIndex = 4;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.countNUP);
            this.Controls.Add(this.priceNUP);
            this.Controls.Add(this.nameTb);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceNUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNUP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.NumericUpDown priceNUP;
        private System.Windows.Forms.NumericUpDown countNUP;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox groupComboBox;
    }
}