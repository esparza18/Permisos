
namespace PresentacionesPermisos
{
    partial class FrmVistasHerramientas
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
            this.dtgHerramientas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHerramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgHerramientas
            // 
            this.dtgHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHerramientas.Location = new System.Drawing.Point(33, 62);
            this.dtgHerramientas.Margin = new System.Windows.Forms.Padding(6);
            this.dtgHerramientas.Name = "dtgHerramientas";
            this.dtgHerramientas.Size = new System.Drawing.Size(578, 380);
            this.dtgHerramientas.TabIndex = 0;
            this.dtgHerramientas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHerramientas_CellDoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(663, 230);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(233, 36);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "eliminar herramientas";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(663, 62);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(233, 36);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar herramientas";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(663, 385);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(233, 36);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmVistasHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 475);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtgHerramientas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmVistasHerramientas";
            this.Text = "FrmVistasHerramientas";
            this.Load += new System.EventHandler(this.FrmVistasHerramientas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHerramientas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.DataGridView dtgHerramientas;
    }
}