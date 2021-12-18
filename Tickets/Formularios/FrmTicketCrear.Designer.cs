
namespace Tickets.Formularios
{
    partial class FrmTicketCrear
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
            this.TxtIDUsuario = new System.Windows.Forms.TextBox();
            this.LblClienteNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CboxCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtIDUsuario
            // 
            this.TxtIDUsuario.BackColor = System.Drawing.Color.Gold;
            this.TxtIDUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIDUsuario.Location = new System.Drawing.Point(115, 25);
            this.TxtIDUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtIDUsuario.Name = "TxtIDUsuario";
            this.TxtIDUsuario.Size = new System.Drawing.Size(132, 26);
            this.TxtIDUsuario.TabIndex = 0;
            this.TxtIDUsuario.TextChanged += new System.EventHandler(this.TxtIDUsuario_TextChanged);
            this.TxtIDUsuario.DoubleClick += new System.EventHandler(this.TxtIDUsuario_DoubleClick);
            // 
            // LblClienteNombre
            // 
            this.LblClienteNombre.AutoSize = true;
            this.LblClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClienteNombre.Location = new System.Drawing.Point(256, 28);
            this.LblClienteNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblClienteNombre.Name = "LblClienteNombre";
            this.LblClienteNombre.Size = new System.Drawing.Size(68, 20);
            this.LblClienteNombre.TabIndex = 1;
            this.LblClienteNombre.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // CboxCategoria
            // 
            this.CboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxCategoria.FormattingEnabled = true;
            this.CboxCategoria.Location = new System.Drawing.Point(115, 74);
            this.CboxCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboxCategoria.Name = "CboxCategoria";
            this.CboxCategoria.Size = new System.Drawing.Size(355, 33);
            this.CboxCategoria.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoría";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(712, 23);
            this.DtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(335, 22);
            this.DtpFecha.TabIndex = 5;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitulo.Location = new System.Drawing.Point(21, 146);
            this.TxtTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(1025, 30);
            this.TxtTitulo.TabIndex = 6;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(21, 217);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDescripcion.Size = new System.Drawing.Size(1025, 184);
            this.TxtDescripcion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "TITULO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "DESCRIPCION";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.Green;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(135, 422);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(215, 58);
            this.BtnAceptar.TabIndex = 10;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Maroon;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(712, 422);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(185, 58);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmTicketCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 508);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboxCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblClienteNombre);
            this.Controls.Add(this.TxtIDUsuario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTicketCrear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Ticket";
            this.Load += new System.EventHandler(this.FrmTicketCrear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIDUsuario;
        private System.Windows.Forms.Label LblClienteNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboxCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}