namespace Store.SAL.BAS
{
    partial class FrmProperties
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
            if(disposing && (components != null))
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
            this.grdProperties = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProperties
            // 
            this.grdProperties.AllowUserToAddRows = false;
            this.grdProperties.AllowUserToDeleteRows = false;
            this.grdProperties.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProperties.Location = new System.Drawing.Point(57, 12);
            this.grdProperties.Name = "grdProperties";
            this.grdProperties.ReadOnly = true;
            this.grdProperties.Size = new System.Drawing.Size(369, 424);
            this.grdProperties.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(39, 35);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "R";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 442);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(152, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 43);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(292, 442);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(134, 43);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "جدید";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FrmProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 494);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grdProperties);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmProperties";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مشخصات کالا";
            this.Load += new System.EventHandler(this.FrmProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdProperties;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnNew;
    }
}