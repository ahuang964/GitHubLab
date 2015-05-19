namespace Exercise18_3
{
    partial class v
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
            this.lbl_Sales_Amount = new System.Windows.Forms.Label();
            this.lbl_Sales_Tax = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.numUpDow_Tax = new System.Windows.Forms.NumericUpDown();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDow_Tax)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Sales_Amount
            // 
            this.lbl_Sales_Amount.AutoSize = true;
            this.lbl_Sales_Amount.Location = new System.Drawing.Point(13, 13);
            this.lbl_Sales_Amount.Name = "lbl_Sales_Amount";
            this.lbl_Sales_Amount.Size = new System.Drawing.Size(72, 13);
            this.lbl_Sales_Amount.TabIndex = 0;
            this.lbl_Sales_Amount.Text = "Sales Amount";
            // 
            // lbl_Sales_Tax
            // 
            this.lbl_Sales_Tax.AutoSize = true;
            this.lbl_Sales_Tax.Location = new System.Drawing.Point(13, 41);
            this.lbl_Sales_Tax.Name = "lbl_Sales_Tax";
            this.lbl_Sales_Tax.Size = new System.Drawing.Size(54, 13);
            this.lbl_Sales_Tax.TabIndex = 1;
            this.lbl_Sales_Tax.Text = "Sales Tax";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(121, 5);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(100, 20);
            this.txt_Amount.TabIndex = 2;
            this.txt_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numUpDow_Tax
            // 
            this.numUpDow_Tax.DecimalPlaces = 2;
            this.numUpDow_Tax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numUpDow_Tax.Location = new System.Drawing.Point(121, 41);
            this.numUpDow_Tax.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numUpDow_Tax.Name = "numUpDow_Tax";
            this.numUpDow_Tax.Size = new System.Drawing.Size(73, 20);
            this.numUpDow_Tax.TabIndex = 4;
            this.numUpDow_Tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(121, 87);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(202, 87);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(16, 134);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(0, 13);
            this.lbl_Result.TabIndex = 7;
            // 
            // v
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.numUpDow_Tax);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.lbl_Sales_Tax);
            this.Controls.Add(this.lbl_Sales_Amount);
            this.Name = "v";
            this.Text = "Tax Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDow_Tax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Sales_Amount;
        private System.Windows.Forms.Label lbl_Sales_Tax;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.NumericUpDown numUpDow_Tax;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_Result;
    }
}

