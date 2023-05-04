namespace Store.Forms
{
    partial class ProductCreation
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
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblProductPrice = new Label();
            txtPrice = new TextBox();
            btnCreateProduct = new Button();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(73, 84);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(117, 20);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "lblProductName";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(222, 81);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(404, 27);
            txtProductName.TabIndex = 1;
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Location = new Point(73, 149);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(109, 20);
            lblProductPrice.TabIndex = 2;
            lblProductPrice.Text = "lblProductPrice";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(222, 146);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(404, 27);
            txtPrice.TabIndex = 3;
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.Location = new Point(432, 250);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Size = new Size(194, 29);
            btnCreateProduct.TabIndex = 4;
            btnCreateProduct.Text = "btnCreateProduct";
            btnCreateProduct.UseVisualStyleBackColor = true;
            btnCreateProduct.Click += btnCreateProduct_Click;
            // 
            // ProductCreation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateProduct);
            Controls.Add(txtPrice);
            Controls.Add(lblProductPrice);
            Controls.Add(txtProductName);
            Controls.Add(lblProductName);
            Name = "ProductCreation";
            Text = "ProductCreation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductName;
        private TextBox txtProductName;
        private Label lblProductPrice;
        private TextBox txtPrice;
        private Button btnCreateProduct;
    }
}