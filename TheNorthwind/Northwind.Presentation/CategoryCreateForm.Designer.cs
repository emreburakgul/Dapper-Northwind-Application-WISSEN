
namespace Northwind.Presentation
{
    partial class CategoryCreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryCreateForm));
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnCreateCat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSelectedCategory = new System.Windows.Forms.Label();
            this.lblSelectedCatID = new System.Windows.Forms.Label();
            this.lblSelectedDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(141, 59);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(153, 23);
            this.txtCategoryName.TabIndex = 0;
            // 
            // btnCreateCat
            // 
            this.btnCreateCat.Location = new System.Drawing.Point(141, 117);
            this.btnCreateCat.Name = "btnCreateCat";
            this.btnCreateCat.Size = new System.Drawing.Size(153, 23);
            this.btnCreateCat.TabIndex = 1;
            this.btnCreateCat.Text = "Create Category";
            this.btnCreateCat.UseVisualStyleBackColor = true;
            this.btnCreateCat.Click += new System.EventHandler(this.btnCreateCat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categories";
            // 
            // txtCatDescription
            // 
            this.txtCatDescription.Location = new System.Drawing.Point(141, 88);
            this.txtCatDescription.Name = "txtCatDescription";
            this.txtCatDescription.Size = new System.Drawing.Size(153, 23);
            this.txtCatDescription.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(536, 88);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(38, 15);
            this.lblCategoryID.TabIndex = 3;
            this.lblCategoryID.Text = "label3";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(536, 59);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(38, 15);
            this.lblCategoryName.TabIndex = 4;
            this.lblCategoryName.Text = "label3";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(536, 121);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(165, 84);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "label3";
            // 
            // lblSelectedCategory
            // 
            this.lblSelectedCategory.AutoSize = true;
            this.lblSelectedCategory.Location = new System.Drawing.Point(398, 59);
            this.lblSelectedCategory.Name = "lblSelectedCategory";
            this.lblSelectedCategory.Size = new System.Drawing.Size(111, 15);
            this.lblSelectedCategory.TabIndex = 6;
            this.lblSelectedCategory.Text = "Selected Category : ";
            // 
            // lblSelectedCatID
            // 
            this.lblSelectedCatID.AutoSize = true;
            this.lblSelectedCatID.Location = new System.Drawing.Point(398, 88);
            this.lblSelectedCatID.Name = "lblSelectedCatID";
            this.lblSelectedCatID.Size = new System.Drawing.Size(122, 15);
            this.lblSelectedCatID.TabIndex = 6;
            this.lblSelectedCatID.Text = "Selected Category ID :";
            // 
            // lblSelectedDescription
            // 
            this.lblSelectedDescription.AutoSize = true;
            this.lblSelectedDescription.Location = new System.Drawing.Point(398, 121);
            this.lblSelectedDescription.Name = "lblSelectedDescription";
            this.lblSelectedDescription.Size = new System.Drawing.Size(120, 15);
            this.lblSelectedDescription.TabIndex = 6;
            this.lblSelectedDescription.Text = "Selected Description :";
            // 
            // CategoryCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSelectedDescription);
            this.Controls.Add(this.lblSelectedCatID);
            this.Controls.Add(this.lblSelectedCategory);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblCategoryID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateCat);
            this.Controls.Add(this.txtCatDescription);
            this.Controls.Add(this.txtCategoryName);
            this.Name = "CategoryCreateForm";
            this.Text = "CategoryCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnCreateCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCatDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSelectedCategory;
        private System.Windows.Forms.Label lblSelectedCatID;
        private System.Windows.Forms.Label lblSelectedDescription;
    }
}