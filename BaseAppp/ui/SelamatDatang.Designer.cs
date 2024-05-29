namespace BaseAppp.ui
{
    partial class SelamatDatang
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
            this.lanjutkan_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lanjutkan_btn
            // 
            this.lanjutkan_btn.Location = new System.Drawing.Point(334, 226);
            this.lanjutkan_btn.Name = "lanjutkan_btn";
            this.lanjutkan_btn.Size = new System.Drawing.Size(75, 23);
            this.lanjutkan_btn.TabIndex = 0;
            this.lanjutkan_btn.Text = "lanjutkan";
            this.lanjutkan_btn.UseVisualStyleBackColor = true;
            this.lanjutkan_btn.Click += new System.EventHandler(this.lanjutkan_btn_Click);
            // 
            // SelamatDatang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lanjutkan_btn);
            this.Name = "SelamatDatang";
            this.Text = "SelamatDatang";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lanjutkan_btn;
    }
}