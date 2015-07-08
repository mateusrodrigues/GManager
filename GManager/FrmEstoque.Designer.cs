namespace GManager
{
    partial class FrmEstoque
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
            this.dataGridEstoque = new System.Windows.Forms.DataGridView();
            this.gbxActions = new System.Windows.Forms.GroupBox();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.tbTotalPotentialValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotalStockValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotalProducts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstoque)).BeginInit();
            this.gbxActions.SuspendLayout();
            this.gbxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridEstoque
            // 
            this.dataGridEstoque.AllowUserToAddRows = false;
            this.dataGridEstoque.AllowUserToDeleteRows = false;
            this.dataGridEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstoque.Location = new System.Drawing.Point(12, 12);
            this.dataGridEstoque.Name = "dataGridEstoque";
            this.dataGridEstoque.ReadOnly = true;
            this.dataGridEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEstoque.Size = new System.Drawing.Size(682, 457);
            this.dataGridEstoque.TabIndex = 0;
            // 
            // gbxActions
            // 
            this.gbxActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxActions.Controls.Add(this.btnEditProduct);
            this.gbxActions.Controls.Add(this.btnRemoveProduct);
            this.gbxActions.Controls.Add(this.btnAddProduct);
            this.gbxActions.Location = new System.Drawing.Point(700, 6);
            this.gbxActions.Name = "gbxActions";
            this.gbxActions.Size = new System.Drawing.Size(180, 160);
            this.gbxActions.TabIndex = 1;
            this.gbxActions.TabStop = false;
            this.gbxActions.Text = "Ações";
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(6, 107);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(168, 38);
            this.btnEditProduct.TabIndex = 2;
            this.btnEditProduct.Text = "Editar";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(6, 63);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(168, 38);
            this.btnRemoveProduct.TabIndex = 1;
            this.btnRemoveProduct.Text = "Remover";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(6, 19);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(168, 38);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Adicionar";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // gbxInfo
            // 
            this.gbxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxInfo.Controls.Add(this.tbTotalPotentialValue);
            this.gbxInfo.Controls.Add(this.label3);
            this.gbxInfo.Controls.Add(this.tbTotalStockValue);
            this.gbxInfo.Controls.Add(this.label2);
            this.gbxInfo.Controls.Add(this.tbTotalProducts);
            this.gbxInfo.Controls.Add(this.label1);
            this.gbxInfo.Location = new System.Drawing.Point(700, 173);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(180, 296);
            this.gbxInfo.TabIndex = 2;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Informações";
            // 
            // tbTotalPotentialValue
            // 
            this.tbTotalPotentialValue.Location = new System.Drawing.Point(10, 124);
            this.tbTotalPotentialValue.Name = "tbTotalPotentialValue";
            this.tbTotalPotentialValue.ReadOnly = true;
            this.tbTotalPotentialValue.Size = new System.Drawing.Size(158, 20);
            this.tbTotalPotentialValue.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor Potencial de Venda:";
            // 
            // tbTotalStockValue
            // 
            this.tbTotalStockValue.Location = new System.Drawing.Point(10, 80);
            this.tbTotalStockValue.Name = "tbTotalStockValue";
            this.tbTotalStockValue.ReadOnly = true;
            this.tbTotalStockValue.Size = new System.Drawing.Size(161, 20);
            this.tbTotalStockValue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor em Estoque:";
            // 
            // tbTotalProducts
            // 
            this.tbTotalProducts.Location = new System.Drawing.Point(10, 37);
            this.tbTotalProducts.Name = "tbTotalProducts";
            this.tbTotalProducts.ReadOnly = true;
            this.tbTotalProducts.Size = new System.Drawing.Size(164, 20);
            this.tbTotalProducts.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de Produtos:";
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 481);
            this.Controls.Add(this.gbxInfo);
            this.Controls.Add(this.gbxActions);
            this.Controls.Add(this.dataGridEstoque);
            this.Name = "FrmEstoque";
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstoque)).EndInit();
            this.gbxActions.ResumeLayout(false);
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEstoque;
        private System.Windows.Forms.GroupBox gbxActions;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.TextBox tbTotalPotentialValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTotalStockValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTotalProducts;
        private System.Windows.Forms.Label label1;
    }
}