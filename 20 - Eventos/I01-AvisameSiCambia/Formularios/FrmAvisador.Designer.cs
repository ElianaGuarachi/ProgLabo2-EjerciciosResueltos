
namespace Formularios
{
    partial class FrmAvisador
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
            this.btn_Crear = new System.Windows.Forms.Button();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_NombreCompleto = new System.Windows.Forms.Label();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.txb_Apellido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Crear
            // 
            this.btn_Crear.Location = new System.Drawing.Point(57, 165);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(157, 24);
            this.btn_Crear.TabIndex = 0;
            this.btn_Crear.Text = "Crear";
            this.btn_Crear.UseVisualStyleBackColor = true;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(47, 50);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(54, 15);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(47, 104);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(54, 15);
            this.lbl_Apellido.TabIndex = 2;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // lbl_NombreCompleto
            // 
            this.lbl_NombreCompleto.AutoSize = true;
            this.lbl_NombreCompleto.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NombreCompleto.Location = new System.Drawing.Point(2, 213);
            this.lbl_NombreCompleto.Name = "lbl_NombreCompleto";
            this.lbl_NombreCompleto.Size = new System.Drawing.Size(257, 40);
            this.lbl_NombreCompleto.TabIndex = 3;
            this.lbl_NombreCompleto.Text = "Nombre completo";
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(116, 47);
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(100, 23);
            this.txb_Nombre.TabIndex = 4;
            // 
            // txb_Apellido
            // 
            this.txb_Apellido.Location = new System.Drawing.Point(116, 101);
            this.txb_Apellido.Name = "txb_Apellido";
            this.txb_Apellido.Size = new System.Drawing.Size(100, 23);
            this.txb_Apellido.TabIndex = 5;
            // 
            // FrmAvisador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(262, 295);
            this.Controls.Add(this.txb_Apellido);
            this.Controls.Add(this.txb_Nombre);
            this.Controls.Add(this.lbl_NombreCompleto);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.btn_Crear);
            this.Name = "FrmAvisador";
            this.Text = "El Avisador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_NombreCompleto;
        private System.Windows.Forms.TextBox txb_Nombre;
        private System.Windows.Forms.TextBox txb_Apellido;
    }
}

