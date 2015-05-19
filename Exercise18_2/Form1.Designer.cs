namespace Exercise18_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblGreet = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.tmSwitch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblGreet
            // 
            this.lblGreet.AutoSize = true;
            this.lblGreet.Location = new System.Drawing.Point(13, 13);
            this.lblGreet.Name = "lblGreet";
            this.lblGreet.Size = new System.Drawing.Size(31, 13);
            this.lblGreet.TabIndex = 0;
            this.lblGreet.Text = "Hello";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(16, 43);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Press Me";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // tmSwitch
            // 
            this.tmSwitch.Tick += new System.EventHandler(this.tmSwitch_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblGreet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreet;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Timer tmSwitch;
    }
}

