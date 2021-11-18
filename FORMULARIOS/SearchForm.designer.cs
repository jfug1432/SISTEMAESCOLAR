namespace SISTEMAESCOLAR.FORMULARIOS
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.cmbMatch = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbLookIn = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtFindWhat = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(690, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 51);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(391, 465);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 51);
            this.btnOK.TabIndex = 30;
            this.btnOK.Text = "Aceptar";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClearSearch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearch.ForeColor = System.Drawing.Color.Black;
            this.btnClearSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnClearSearch.Image")));
            this.btnClearSearch.Location = new System.Drawing.Point(548, 465);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(95, 51);
            this.btnClearSearch.TabIndex = 32;
            this.btnClearSearch.Text = "Limpiar";
            this.btnClearSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClearSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClearSearch.UseVisualStyleBackColor = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // cmbMatch
            // 
            this.cmbMatch.BackColor = System.Drawing.Color.White;
            this.cmbMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMatch.Items.AddRange(new object[] {
            "Cualquier parte del Campo",
            "Total del Campo",
            "Inicio del campo"});
            this.cmbMatch.Location = new System.Drawing.Point(555, 75);
            this.cmbMatch.Name = "cmbMatch";
            this.cmbMatch.Size = new System.Drawing.Size(230, 26);
            this.cmbMatch.TabIndex = 27;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.CadetBlue;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(489, 77);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(56, 21);
            this.Label3.TabIndex = 26;
            this.Label3.Text = "Filtro :";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(811, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 69);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbLookIn
            // 
            this.cmbLookIn.BackColor = System.Drawing.Color.White;
            this.cmbLookIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLookIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLookIn.Location = new System.Drawing.Point(180, 75);
            this.cmbLookIn.Name = "cmbLookIn";
            this.cmbLookIn.Size = new System.Drawing.Size(296, 26);
            this.cmbLookIn.TabIndex = 25;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.CadetBlue;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(86, 77);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 21);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "Buscar en:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFindWhat
            // 
            this.txtFindWhat.BackColor = System.Drawing.Color.White;
            this.txtFindWhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindWhat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFindWhat.Location = new System.Drawing.Point(180, 28);
            this.txtFindWhat.Name = "txtFindWhat";
            this.txtFindWhat.Size = new System.Drawing.Size(605, 24);
            this.txtFindWhat.TabIndex = 23;
            this.txtFindWhat.TextChanged += new System.EventHandler(this.txtFindWhat_TextChanged);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.CadetBlue;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(46, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(128, 21);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "Dato a Buscar :";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dg
            // 
            this.dg.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(25, 122);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.Size = new System.Drawing.Size(1035, 322);
            this.dg.TabIndex = 33;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 541);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.cmbMatch);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbLookIn);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtFindWhat);
            this.Controls.Add(this.Label1);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSQUEDA EXPERTA";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Button btnClearSearch;
        internal System.Windows.Forms.ComboBox cmbMatch;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.ComboBox cmbLookIn;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtFindWhat;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridView dg;
    }
}