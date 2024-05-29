namespace BaseAppp.ui
{
    partial class DetailTiket
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
            this.labelKotaKeberangkatan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKotaKeberangkatan
            // 
            this.labelKotaKeberangkatan.AutoSize = true;
            this.labelKotaKeberangkatan.Location = new System.Drawing.Point(152, 86);
            this.labelKotaKeberangkatan.Name = "labelKotaKeberangkatan";
            this.labelKotaKeberangkatan.Size = new System.Drawing.Size(44, 16);
            this.labelKotaKeberangkatan.TabIndex = 0;
            this.labelKotaKeberangkatan.Text = "label1";
            // 
            // DetailTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelKotaKeberangkatan);
            this.Name = "DetailTiket";
            this.Text = "DetailTiket";
            this.Load += new System.EventHandler(this.DetailTiket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKotaKeberangkatan;
    }
}