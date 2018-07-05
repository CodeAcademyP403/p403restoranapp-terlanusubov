namespace Restoran_Full_App
{
    partial class Moderator
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
            this.cmbx_ofisinats = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.data_order = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_order)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbx_ofisinats
            // 
            this.cmbx_ofisinats.FormattingEnabled = true;
            this.cmbx_ofisinats.Location = new System.Drawing.Point(173, 219);
            this.cmbx_ofisinats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbx_ofisinats.Name = "cmbx_ofisinats";
            this.cmbx_ofisinats.Size = new System.Drawing.Size(140, 24);
            this.cmbx_ofisinats.TabIndex = 0;
            this.cmbx_ofisinats.SelectedIndexChanged += new System.EventHandler(this.cmbx_ofisinats_SelectedIndexChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_cancel.Location = new System.Drawing.Point(791, 454);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(111, 46);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // data_order
            // 
            this.data_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_order.Location = new System.Drawing.Point(384, 86);
            this.data_order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_order.Name = "data_order";
            this.data_order.Size = new System.Drawing.Size(537, 346);
            this.data_order.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Ofisiant";
            // 
            // Moderator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_order);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cmbx_ofisinats);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Moderator";
            this.Text = "Moderator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Moderator_FormClosing);
            this.Load += new System.EventHandler(this.Moderator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbx_ofisinats;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView data_order;
        private System.Windows.Forms.Label label1;
    }
}