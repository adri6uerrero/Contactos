namespace Contactos
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAñadirContacto = new System.Windows.Forms.Button();
            this.btnActualizarContacto = new System.Windows.Forms.Button();
            this.btnEliminarContacto = new System.Windows.Forms.Button();
            this.btnBuscarContacto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstContactos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(57, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(57, 107);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero";
            // 
            // btnAñadirContacto
            // 
            this.btnAñadirContacto.Location = new System.Drawing.Point(57, 171);
            this.btnAñadirContacto.Name = "btnAñadirContacto";
            this.btnAñadirContacto.Size = new System.Drawing.Size(120, 23);
            this.btnAñadirContacto.TabIndex = 4;
            this.btnAñadirContacto.Text = "Añadir contacto";
            this.btnAñadirContacto.UseVisualStyleBackColor = true;
            this.btnAñadirContacto.Click += new System.EventHandler(this.btnAnadirContacto_Click);
            // 
            // btnActualizarContacto
            // 
            this.btnActualizarContacto.Location = new System.Drawing.Point(57, 200);
            this.btnActualizarContacto.Name = "btnActualizarContacto";
            this.btnActualizarContacto.Size = new System.Drawing.Size(120, 23);
            this.btnActualizarContacto.TabIndex = 5;
            this.btnActualizarContacto.Text = "Actualizar contacto";
            this.btnActualizarContacto.UseVisualStyleBackColor = true;
            this.btnActualizarContacto.Click += new System.EventHandler(this.btnActualizarContacto_Click);
            // 
            // btnEliminarContacto
            // 
            this.btnEliminarContacto.Location = new System.Drawing.Point(183, 171);
            this.btnEliminarContacto.Name = "btnEliminarContacto";
            this.btnEliminarContacto.Size = new System.Drawing.Size(107, 23);
            this.btnEliminarContacto.TabIndex = 6;
            this.btnEliminarContacto.Text = "Eliminar contacto";
            this.btnEliminarContacto.UseVisualStyleBackColor = true;
            this.btnEliminarContacto.Click += new System.EventHandler(this.btnEliminarContacto_Click);
            // 
            // btnBuscarContacto
            // 
            this.btnBuscarContacto.Location = new System.Drawing.Point(183, 200);
            this.btnBuscarContacto.Name = "btnBuscarContacto";
            this.btnBuscarContacto.Size = new System.Drawing.Size(107, 23);
            this.btnBuscarContacto.TabIndex = 7;
            this.btnBuscarContacto.Text = "Buscar contacto";
            this.btnBuscarContacto.UseVisualStyleBackColor = true;
            this.btnBuscarContacto.Click += new System.EventHandler(this.btnBuscarContacto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(60, 258);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lstContactos
            // 
            this.lstContactos.FormattingEnabled = true;
            this.lstContactos.Location = new System.Drawing.Point(318, 49);
            this.lstContactos.Name = "lstContactos";
            this.lstContactos.Size = new System.Drawing.Size(216, 212);
            this.lstContactos.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 302);
            this.Controls.Add(this.lstContactos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarContacto);
            this.Controls.Add(this.btnEliminarContacto);
            this.Controls.Add(this.btnActualizarContacto);
            this.Controls.Add(this.btnAñadirContacto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAñadirContacto;
        private System.Windows.Forms.Button btnActualizarContacto;
        private System.Windows.Forms.Button btnEliminarContacto;
        private System.Windows.Forms.Button btnBuscarContacto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstContactos;
    }
}

