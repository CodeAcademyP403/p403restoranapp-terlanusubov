namespace Restoran_Full_App
{
    partial class Admin
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
            this.cmbx_moderator = new System.Windows.Forms.ComboBox();
            this.data_order = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_ofisiant = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_order)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbx_moderator
            // 
            this.cmbx_moderator.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbx_moderator.FormattingEnabled = true;
            this.cmbx_moderator.Location = new System.Drawing.Point(215, 221);
            this.cmbx_moderator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbx_moderator.Name = "cmbx_moderator";
            this.cmbx_moderator.Size = new System.Drawing.Size(140, 25);
            this.cmbx_moderator.TabIndex = 0;
            this.cmbx_moderator.SelectedIndexChanged += new System.EventHandler(this.cmbx_moderator_SelectedIndexChanged);
            // 
            // data_order
            // 
            this.data_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_order.Location = new System.Drawing.Point(376, 121);
            this.data_order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_order.Name = "data_order";
            this.data_order.Size = new System.Drawing.Size(537, 275);
            this.data_order.TabIndex = 6;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_cancel.Location = new System.Drawing.Point(783, 418);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(111, 46);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose Moderator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose Ofisiant";
            // 
            // cmbx_ofisiant
            // 
            this.cmbx_ofisiant.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbx_ofisiant.FormattingEnabled = true;
            this.cmbx_ofisiant.Location = new System.Drawing.Point(215, 273);
            this.cmbx_ofisiant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbx_ofisiant.Name = "cmbx_ofisiant";
            this.cmbx_ofisiant.Size = new System.Drawing.Size(140, 25);
            this.cmbx_ofisiant.TabIndex = 8;
            this.cmbx_ofisiant.SelectedIndexChanged += new System.EventHandler(this.cmbx_ofisiant_SelectedIndexChanged);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbx_ofisiant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_order);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cmbx_moderator);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbx_moderator;
        private System.Windows.Forms.DataGridView data_order;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_ofisiant;
    }
}