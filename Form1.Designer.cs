
namespace SISTEMAESCOLAR
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cATALOGOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOVIMIENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIBRERIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cARRERASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cATALOGOSToolStripMenuItem,
            this.mOVIMIENTOSToolStripMenuItem,
            this.lIBRERIASToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cATALOGOSToolStripMenuItem
            // 
            this.cATALOGOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cARRERASToolStripMenuItem});
            this.cATALOGOSToolStripMenuItem.Name = "cATALOGOSToolStripMenuItem";
            this.cATALOGOSToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.cATALOGOSToolStripMenuItem.Text = "CATALOGOS";
            // 
            // mOVIMIENTOSToolStripMenuItem
            // 
            this.mOVIMIENTOSToolStripMenuItem.Name = "mOVIMIENTOSToolStripMenuItem";
            this.mOVIMIENTOSToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.mOVIMIENTOSToolStripMenuItem.Text = "MOVIMIENTOS";
            // 
            // lIBRERIASToolStripMenuItem
            // 
            this.lIBRERIASToolStripMenuItem.Name = "lIBRERIASToolStripMenuItem";
            this.lIBRERIASToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.lIBRERIASToolStripMenuItem.Text = "LIBRERIAS";
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            // 
            // cARRERASToolStripMenuItem
            // 
            this.cARRERASToolStripMenuItem.Name = "cARRERASToolStripMenuItem";
            this.cARRERASToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cARRERASToolStripMenuItem.Text = "CARRERAS";
            this.cARRERASToolStripMenuItem.Click += new System.EventHandler(this.cARRERASToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cATALOGOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cARRERASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOVIMIENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIBRERIASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
    }
}

