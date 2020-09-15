namespace Delfin.Principal.Mantenimientos.MAN009Entidad
{
    partial class MAN009ViewTipoSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAN009ViewTipoSocio));
            this.btnCliente = new DevExpress.XtraEditors.SimpleButton();
            this.btnProveedor = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnCliente.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCliente.ImageOptions.ImageToTextIndent = 10;
            this.btnCliente.Location = new System.Drawing.Point(42, 20);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(96, 79);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnProveedor.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnProveedor.ImageOptions.ImageToTextIndent = 10;
            this.btnProveedor.Location = new System.Drawing.Point(172, 20);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(96, 79);
            this.btnProveedor.TabIndex = 0;
            this.btnProveedor.Text = "Proveedor";
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // MAN009ViewTipoSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 119);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MAN009ViewTipoSocio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccionar Tipo Socio de Negocio (SAP)";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCliente;
        private DevExpress.XtraEditors.SimpleButton btnProveedor;
    }
}