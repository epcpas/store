namespace Store.SAL.BAS
{
    partial class FrmProductGroup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductGroup));
            this.treProductGroups = new System.Windows.Forms.TreeView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treProductGroups
            // 
            this.treProductGroups.Location = new System.Drawing.Point(63, 12);
            this.treProductGroups.Name = "treProductGroups";
            this.treProductGroups.RightToLeftLayout = true;
            this.treProductGroups.Size = new System.Drawing.Size(258, 444);
            this.treProductGroups.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ImageKey = "file-8.png";
            this.btnRefresh.ImageList = this.imageList1;
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 44);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "file.png");
            this.imageList1.Images.SetKeyName(1, "file-1.png");
            this.imageList1.Images.SetKeyName(2, "file-2.png");
            this.imageList1.Images.SetKeyName(3, "file-4.png");
            this.imageList1.Images.SetKeyName(4, "file-5.png");
            this.imageList1.Images.SetKeyName(5, "file-6.png");
            this.imageList1.Images.SetKeyName(6, "file-7.png");
            this.imageList1.Images.SetKeyName(7, "file-9.png");
            this.imageList1.Images.SetKeyName(8, "file-11.png");
            this.imageList1.Images.SetKeyName(9, "file-13.png");
            this.imageList1.Images.SetKeyName(10, "file-14.png");
            this.imageList1.Images.SetKeyName(11, "file-15.png");
            this.imageList1.Images.SetKeyName(12, "file-18.png");
            this.imageList1.Images.SetKeyName(13, "file-19.png");
            this.imageList1.Images.SetKeyName(14, "file-8.png");
            // 
            // btnNew
            // 
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.ImageKey = "file.png";
            this.btnNew.ImageList = this.imageList1;
            this.btnNew.Location = new System.Drawing.Point(222, 462);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(99, 46);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "ثبت";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.ImageKey = "file-4.png";
            this.btnEdit.ImageList = this.imageList1;
            this.btnEdit.Location = new System.Drawing.Point(117, 462);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 46);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.ImageKey = "file-13.png";
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(12, 462);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 46);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // FrmProductGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 520);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.treProductGroups);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmProductGroup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گروه کالا";
            this.Load += new System.EventHandler(this.FrmProductGroup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treProductGroups;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}