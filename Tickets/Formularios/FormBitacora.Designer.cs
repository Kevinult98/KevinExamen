
namespace Tickets.Formularios
{
    partial class FormBitacora
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
            this.DgvBitacora = new System.Windows.Forms.DataGridView();
            this.CAccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvBitacora
            // 
            this.DgvBitacora.AllowUserToAddRows = false;
            this.DgvBitacora.AllowUserToDeleteRows = false;
            this.DgvBitacora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CAccion,
            this.CFechaHora});
            this.DgvBitacora.Location = new System.Drawing.Point(12, 22);
            this.DgvBitacora.Name = "DgvBitacora";
            this.DgvBitacora.ReadOnly = true;
            this.DgvBitacora.RowHeadersVisible = false;
            this.DgvBitacora.RowHeadersWidth = 51;
            this.DgvBitacora.RowTemplate.Height = 24;
            this.DgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBitacora.Size = new System.Drawing.Size(879, 416);
            this.DgvBitacora.TabIndex = 0;
            this.DgvBitacora.VirtualMode = true;
            // 
            // CAccion
            // 
            this.CAccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CAccion.DataPropertyName = "Accion";
            this.CAccion.HeaderText = "Accion";
            this.CAccion.MinimumWidth = 6;
            this.CAccion.Name = "CAccion";
            this.CAccion.ReadOnly = true;
            // 
            // CFechaHora
            // 
            this.CFechaHora.DataPropertyName = "FechaHora";
            this.CFechaHora.HeaderText = "Fecha y Hora";
            this.CFechaHora.MinimumWidth = 6;
            this.CFechaHora.Name = "CFechaHora";
            this.CFechaHora.ReadOnly = true;
            this.CFechaHora.Width = 125;
            // 
            // FormBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 480);
            this.Controls.Add(this.DgvBitacora);
            this.Name = "FormBitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBitacora";
            this.Load += new System.EventHandler(this.FormBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBitacora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaHora;
    }
}