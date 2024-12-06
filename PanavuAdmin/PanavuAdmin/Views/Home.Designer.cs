namespace PanavuAdmin.Views
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.tsTitle = new System.Windows.Forms.ToolStripLabel();
            this.tsLogo = new System.Windows.Forms.PictureBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSales = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsPurchases = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsProduct = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.AutoSize = false;
            this.toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTitle,
            this.toolStripSeparator1,
            this.tsSales,
            this.toolStripSeparator2,
            this.tsPurchases,
            this.toolStripSeparator3,
            this.tsProduct,
            this.toolStripButton1});
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.MaximumSize = new System.Drawing.Size(1370, 500);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(1370, 50);
            this.toolbar.TabIndex = 0;
            this.toolbar.Text = "toolStrip1";
            // 
            // tsTitle
            // 
            this.tsTitle.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsTitle.ForeColor = System.Drawing.Color.White;
            this.tsTitle.Margin = new System.Windows.Forms.Padding(70, 1, 0, 2);
            this.tsTitle.Name = "tsTitle";
            this.tsTitle.Size = new System.Drawing.Size(210, 47);
            this.tsTitle.Text = "PanavuAdmin";
            // 
            // tsLogo
            // 
            this.tsLogo.Image = ((System.Drawing.Image)(resources.GetObject("tsLogo.Image")));
            this.tsLogo.Location = new System.Drawing.Point(29, 0);
            this.tsLogo.Name = "tsLogo";
            this.tsLogo.Size = new System.Drawing.Size(53, 50);
            this.tsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsLogo.TabIndex = 1;
            this.tsLogo.TabStop = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // tsSales
            // 
            this.tsSales.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsSales.ForeColor = System.Drawing.Color.White;
            this.tsSales.Name = "tsSales";
            this.tsSales.Size = new System.Drawing.Size(109, 47);
            this.tsSales.Text = "Ventas";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // tsPurchases
            // 
            this.tsPurchases.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsPurchases.ForeColor = System.Drawing.Color.White;
            this.tsPurchases.Name = "tsPurchases";
            this.tsPurchases.Size = new System.Drawing.Size(139, 47);
            this.tsPurchases.Text = "Compras";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
            // 
            // tsProduct
            // 
            this.tsProduct.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsProduct.ForeColor = System.Drawing.Color.White;
            this.tsProduct.Name = "tsProduct";
            this.tsProduct.Size = new System.Drawing.Size(154, 47);
            this.tsProduct.Text = "Productos";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(98, 47);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.tsLogo);
            this.Controls.Add(this.toolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripLabel tsTitle;
        private System.Windows.Forms.PictureBox tsLogo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsSales;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tsPurchases;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tsProduct;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}