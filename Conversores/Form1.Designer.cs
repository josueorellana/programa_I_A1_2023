
namespace Conversores
{
    partial class Conversor
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
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.cboTipoConversor = new System.Windows.Forms.ComboBox();
            this.lblDeConversor = new System.Windows.Forms.Label();
            this.cboDeConversor = new System.Windows.Forms.ComboBox();
            this.lblAConversor = new System.Windows.Forms.Label();
            this.cboAConversor = new System.Windows.Forms.ComboBox();
            this.lblCantidadConversor = new System.Windows.Forms.Label();
            this.txtCantidadConversor = new System.Windows.Forms.TextBox();
            this.lblRespuestaConversor = new System.Windows.Forms.Label();
            this.btnConvertirConversor = new System.Windows.Forms.Button();
            this.lblTituloConversor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConversor.Location = new System.Drawing.Point(89, 54);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(53, 24);
            this.lblTipoConversor.TabIndex = 5;
            this.lblTipoConversor.Text = "Tipo:";
            // 
            // cboTipoConversor
            // 
            this.cboTipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoConversor.FormattingEnabled = true;
            this.cboTipoConversor.Items.AddRange(new object[] {
            "Monedas",
            "Masa ",
            "Volumen",
            "Longitud",
            "Almacenamiento",
            "Tiempo"});
            this.cboTipoConversor.Location = new System.Drawing.Point(158, 54);
            this.cboTipoConversor.Name = "cboTipoConversor";
            this.cboTipoConversor.Size = new System.Drawing.Size(168, 21);
            this.cboTipoConversor.TabIndex = 6;
            this.cboTipoConversor.SelectedIndexChanged += new System.EventHandler(this.cboTipoConversor_SelectedIndexChanged);
            // 
            // lblDeConversor
            // 
            this.lblDeConversor.AutoSize = true;
            this.lblDeConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeConversor.Location = new System.Drawing.Point(89, 106);
            this.lblDeConversor.Name = "lblDeConversor";
            this.lblDeConversor.Size = new System.Drawing.Size(39, 24);
            this.lblDeConversor.TabIndex = 7;
            this.lblDeConversor.Text = "De:";
            // 
            // cboDeConversor
            // 
            this.cboDeConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeConversor.FormattingEnabled = true;
            this.cboDeConversor.Location = new System.Drawing.Point(158, 109);
            this.cboDeConversor.Name = "cboDeConversor";
            this.cboDeConversor.Size = new System.Drawing.Size(168, 21);
            this.cboDeConversor.TabIndex = 8;
            // 
            // lblAConversor
            // 
            this.lblAConversor.AutoSize = true;
            this.lblAConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAConversor.Location = new System.Drawing.Point(100, 171);
            this.lblAConversor.Name = "lblAConversor";
            this.lblAConversor.Size = new System.Drawing.Size(28, 24);
            this.lblAConversor.TabIndex = 9;
            this.lblAConversor.Text = "A:";
            // 
            // cboAConversor
            // 
            this.cboAConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAConversor.FormattingEnabled = true;
            this.cboAConversor.Location = new System.Drawing.Point(158, 171);
            this.cboAConversor.Name = "cboAConversor";
            this.cboAConversor.Size = new System.Drawing.Size(168, 21);
            this.cboAConversor.TabIndex = 10;
            // 
            // lblCantidadConversor
            // 
            this.lblCantidadConversor.AutoSize = true;
            this.lblCantidadConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadConversor.Location = new System.Drawing.Point(43, 245);
            this.lblCantidadConversor.Name = "lblCantidadConversor";
            this.lblCantidadConversor.Size = new System.Drawing.Size(89, 24);
            this.lblCantidadConversor.TabIndex = 11;
            this.lblCantidadConversor.Text = "Cantidad:";
            // 
            // txtCantidadConversor
            // 
            this.txtCantidadConversor.Location = new System.Drawing.Point(138, 249);
            this.txtCantidadConversor.Name = "txtCantidadConversor";
            this.txtCantidadConversor.Size = new System.Drawing.Size(126, 20);
            this.txtCantidadConversor.TabIndex = 12;
            // 
            // lblRespuestaConversor
            // 
            this.lblRespuestaConversor.AutoSize = true;
            this.lblRespuestaConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaConversor.Location = new System.Drawing.Point(304, 331);
            this.lblRespuestaConversor.Name = "lblRespuestaConversor";
            this.lblRespuestaConversor.Size = new System.Drawing.Size(119, 24);
            this.lblRespuestaConversor.TabIndex = 13;
            this.lblRespuestaConversor.Text = "Respuesta: ?";
            // 
            // btnConvertirConversor
            // 
            this.btnConvertirConversor.Location = new System.Drawing.Point(84, 311);
            this.btnConvertirConversor.Name = "btnConvertirConversor";
            this.btnConvertirConversor.Size = new System.Drawing.Size(150, 69);
            this.btnConvertirConversor.TabIndex = 14;
            this.btnConvertirConversor.Text = "CONVERTIR";
            this.btnConvertirConversor.UseVisualStyleBackColor = true;
            this.btnConvertirConversor.Click += new System.EventHandler(this.btnConvertirConversor_Click);
            // 
            // lblTituloConversor
            // 
            this.lblTituloConversor.AutoSize = true;
            this.lblTituloConversor.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloConversor.Location = new System.Drawing.Point(224, 9);
            this.lblTituloConversor.Name = "lblTituloConversor";
            this.lblTituloConversor.Size = new System.Drawing.Size(87, 21);
            this.lblTituloConversor.TabIndex = 15;
            this.lblTituloConversor.Text = "Conversor";
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 412);
            this.Controls.Add(this.lblTituloConversor);
            this.Controls.Add(this.btnConvertirConversor);
            this.Controls.Add(this.lblRespuestaConversor);
            this.Controls.Add(this.txtCantidadConversor);
            this.Controls.Add(this.lblCantidadConversor);
            this.Controls.Add(this.cboAConversor);
            this.Controls.Add(this.lblAConversor);
            this.Controls.Add(this.cboDeConversor);
            this.Controls.Add(this.lblDeConversor);
            this.Controls.Add(this.cboTipoConversor);
            this.Controls.Add(this.lblTipoConversor);
            this.Name = "Conversor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTipoConversor;
        private System.Windows.Forms.ComboBox cboTipoConversor;
        private System.Windows.Forms.Label lblDeConversor;
        private System.Windows.Forms.ComboBox cboDeConversor;
        private System.Windows.Forms.Label lblAConversor;
        private System.Windows.Forms.ComboBox cboAConversor;
        private System.Windows.Forms.Label lblCantidadConversor;
        private System.Windows.Forms.TextBox txtCantidadConversor;
        private System.Windows.Forms.Label lblRespuestaConversor;
        private System.Windows.Forms.Button btnConvertirConversor;
        private System.Windows.Forms.Label lblTituloConversor;
    }
}

