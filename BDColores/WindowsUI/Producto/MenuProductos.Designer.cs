namespace WindowsUI
{
    partial class MenuProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuProductos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoríaProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoríaProductoToolStripMenuItem,
            this.productoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 95);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoríaProductoToolStripMenuItem
            // 
            this.categoríaProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem1,
            this.agregarToolStripMenuItem1,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem2});
            this.categoríaProductoToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.categoríaProductoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.categoríaProductoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categoríaProductoToolStripMenuItem.Image")));
            this.categoríaProductoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.categoríaProductoToolStripMenuItem.Name = "categoríaProductoToolStripMenuItem";
            this.categoríaProductoToolStripMenuItem.Size = new System.Drawing.Size(213, 91);
            this.categoríaProductoToolStripMenuItem.Text = "Categoría Producto";
            this.categoríaProductoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.categoríaProductoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mostrarToolStripMenuItem1
            // 
            this.mostrarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("mostrarToolStripMenuItem1.Image")));
            this.mostrarToolStripMenuItem1.Name = "mostrarToolStripMenuItem1";
            this.mostrarToolStripMenuItem1.Size = new System.Drawing.Size(178, 28);
            this.mostrarToolStripMenuItem1.Text = "Mostrar";
            this.mostrarToolStripMenuItem1.Click += new System.EventHandler(this.mostrarToolStripMenuItem1_Click);
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("agregarToolStripMenuItem1.Image")));
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(178, 28);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem.Image")));
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(178, 28);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem2
            // 
            this.eliminarToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem2.Image")));
            this.eliminarToolStripMenuItem2.Name = "eliminarToolStripMenuItem2";
            this.eliminarToolStripMenuItem2.Size = new System.Drawing.Size(178, 28);
            this.eliminarToolStripMenuItem2.Text = "Eliminar";
            this.eliminarToolStripMenuItem2.Click += new System.EventHandler(this.eliminarToolStripMenuItem2_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem2,
            this.agregarToolStripMenuItem2,
            this.modificarToolStripMenuItem1,
            this.eliminarToolStripMenuItem3});
            this.productoToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.productoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.productoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productoToolStripMenuItem.Image")));
            this.productoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(109, 91);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.productoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mostrarToolStripMenuItem2
            // 
            this.mostrarToolStripMenuItem2.Name = "mostrarToolStripMenuItem2";
            this.mostrarToolStripMenuItem2.Size = new System.Drawing.Size(216, 28);
            this.mostrarToolStripMenuItem2.Text = "Mostrar";
            // 
            // agregarToolStripMenuItem2
            // 
            this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
            this.agregarToolStripMenuItem2.Size = new System.Drawing.Size(216, 28);
            this.agregarToolStripMenuItem2.Text = "Agregar";
            this.agregarToolStripMenuItem2.Click += new System.EventHandler(this.agregarToolStripMenuItem2_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(216, 28);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem3
            // 
            this.eliminarToolStripMenuItem3.Name = "eliminarToolStripMenuItem3";
            this.eliminarToolStripMenuItem3.Size = new System.Drawing.Size(216, 28);
            this.eliminarToolStripMenuItem3.Text = "Eliminar";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 608);
            this.panel1.TabIndex = 3;
            // 
            // MenuProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuProductos";
            this.Text = "MenuProductos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem categoríaProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem3;
    }
}