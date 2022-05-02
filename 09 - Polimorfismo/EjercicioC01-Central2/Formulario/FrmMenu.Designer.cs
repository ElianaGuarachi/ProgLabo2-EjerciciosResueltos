
namespace Formulario
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerarLlamada = new System.Windows.Forms.Button();
            this.btnFacTotal = new System.Windows.Forms.Button();
            this.btnFacLocal = new System.Windows.Forms.Button();
            this.btnFacProvincial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarLlamada
            // 
            this.btnGenerarLlamada.Location = new System.Drawing.Point(23, 12);
            this.btnGenerarLlamada.Name = "btnGenerarLlamada";
            this.btnGenerarLlamada.Size = new System.Drawing.Size(227, 52);
            this.btnGenerarLlamada.TabIndex = 0;
            this.btnGenerarLlamada.Text = "Generar Llamada";
            this.btnGenerarLlamada.UseVisualStyleBackColor = true;
            this.btnGenerarLlamada.Click += new System.EventHandler(this.btnGenerarLlamada_Click);
            // 
            // btnFacTotal
            // 
            this.btnFacTotal.Location = new System.Drawing.Point(23, 79);
            this.btnFacTotal.Name = "btnFacTotal";
            this.btnFacTotal.Size = new System.Drawing.Size(227, 52);
            this.btnFacTotal.TabIndex = 1;
            this.btnFacTotal.Text = "Facturacion Total";
            this.btnFacTotal.UseVisualStyleBackColor = true;
            this.btnFacTotal.Click += new System.EventHandler(this.btnFacTotal_Click);
            // 
            // btnFacLocal
            // 
            this.btnFacLocal.Location = new System.Drawing.Point(23, 147);
            this.btnFacLocal.Name = "btnFacLocal";
            this.btnFacLocal.Size = new System.Drawing.Size(227, 52);
            this.btnFacLocal.TabIndex = 2;
            this.btnFacLocal.Text = "Facturacion Local";
            this.btnFacLocal.UseVisualStyleBackColor = true;
            this.btnFacLocal.Click += new System.EventHandler(this.btnFacLocal_Click);
            // 
            // btnFacProvincial
            // 
            this.btnFacProvincial.Location = new System.Drawing.Point(23, 214);
            this.btnFacProvincial.Name = "btnFacProvincial";
            this.btnFacProvincial.Size = new System.Drawing.Size(227, 52);
            this.btnFacProvincial.TabIndex = 3;
            this.btnFacProvincial.Text = "Facturacion Provincial";
            this.btnFacProvincial.UseVisualStyleBackColor = true;
            this.btnFacProvincial.Click += new System.EventHandler(this.btnFacProvincial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(23, 282);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(227, 52);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 364);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacProvincial);
            this.Controls.Add(this.btnFacLocal);
            this.Controls.Add(this.btnFacTotal);
            this.Controls.Add(this.btnGenerarLlamada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefonica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarLlamada;
        private System.Windows.Forms.Button btnFacTotal;
        private System.Windows.Forms.Button btnFacLocal;
        private System.Windows.Forms.Button btnFacProvincial;
        private System.Windows.Forms.Button btnSalir;
    }
}

