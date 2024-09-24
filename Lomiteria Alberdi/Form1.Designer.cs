namespace Lomiteria_Alberdi
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtEleccion = new System.Windows.Forms.TextBox();
            this.checkTomate = new System.Windows.Forms.CheckBox();
            this.checkLechuga = new System.Windows.Forms.CheckBox();
            this.checkQueso = new System.Windows.Forms.CheckBox();
            this.checkJamon = new System.Windows.Forms.CheckBox();
            this.checkHuevo = new System.Windows.Forms.CheckBox();
            this.lblAgregados = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblmsj = new System.Windows.Forms.Label();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.btvolver = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(211, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(646, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bienvenido a Lomiteria Alberdi";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(359, 115);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(270, 168);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Que desea ordenar: \r\n1- Sanguche de lomito \r\n2- Sanguche de milanesa \r\n3- Hamburg" +
    "uesa \r\n4- Papas Fritas \r\n9- Salir";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(264, 129);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 6;
            // 
            // txtEleccion
            // 
            this.txtEleccion.Location = new System.Drawing.Point(375, 320);
            this.txtEleccion.Name = "txtEleccion";
            this.txtEleccion.Size = new System.Drawing.Size(100, 22);
            this.txtEleccion.TabIndex = 7;
            // 
            // checkTomate
            // 
            this.checkTomate.AutoSize = true;
            this.checkTomate.Location = new System.Drawing.Point(65, 60);
            this.checkTomate.Name = "checkTomate";
            this.checkTomate.Size = new System.Drawing.Size(76, 20);
            this.checkTomate.TabIndex = 8;
            this.checkTomate.Text = "Tomate";
            this.checkTomate.UseVisualStyleBackColor = true;
            this.checkTomate.Visible = false;
            // 
            // checkLechuga
            // 
            this.checkLechuga.AutoSize = true;
            this.checkLechuga.Location = new System.Drawing.Point(65, 86);
            this.checkLechuga.Name = "checkLechuga";
            this.checkLechuga.Size = new System.Drawing.Size(81, 20);
            this.checkLechuga.TabIndex = 9;
            this.checkLechuga.Text = "Lechuga";
            this.checkLechuga.UseVisualStyleBackColor = true;
            this.checkLechuga.Visible = false;
            // 
            // checkQueso
            // 
            this.checkQueso.AutoSize = true;
            this.checkQueso.Location = new System.Drawing.Point(65, 113);
            this.checkQueso.Name = "checkQueso";
            this.checkQueso.Size = new System.Drawing.Size(69, 20);
            this.checkQueso.TabIndex = 10;
            this.checkQueso.Text = "Queso";
            this.checkQueso.UseVisualStyleBackColor = true;
            this.checkQueso.Visible = false;
            // 
            // checkJamon
            // 
            this.checkJamon.AutoSize = true;
            this.checkJamon.Location = new System.Drawing.Point(65, 140);
            this.checkJamon.Name = "checkJamon";
            this.checkJamon.Size = new System.Drawing.Size(70, 20);
            this.checkJamon.TabIndex = 11;
            this.checkJamon.Text = "Jamon";
            this.checkJamon.UseVisualStyleBackColor = true;
            this.checkJamon.Visible = false;
            // 
            // checkHuevo
            // 
            this.checkHuevo.AutoSize = true;
            this.checkHuevo.Location = new System.Drawing.Point(65, 167);
            this.checkHuevo.Name = "checkHuevo";
            this.checkHuevo.Size = new System.Drawing.Size(69, 20);
            this.checkHuevo.TabIndex = 12;
            this.checkHuevo.Text = "Huevo";
            this.checkHuevo.UseVisualStyleBackColor = true;
            this.checkHuevo.Visible = false;
            // 
            // lblAgregados
            // 
            this.lblAgregados.AutoSize = true;
            this.lblAgregados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregados.Location = new System.Drawing.Point(65, 18);
            this.lblAgregados.Name = "lblAgregados";
            this.lblAgregados.Size = new System.Drawing.Size(184, 25);
            this.lblAgregados.TabIndex = 13;
            this.lblAgregados.Text = "Elegi tus agregados";
            this.lblAgregados.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(92, 204);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 33);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(554, 319);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblAgregados);
            this.panel.Controls.Add(this.checkTomate);
            this.panel.Controls.Add(this.btnAgregar);
            this.panel.Controls.Add(this.checkLechuga);
            this.panel.Controls.Add(this.checkQueso);
            this.panel.Controls.Add(this.checkHuevo);
            this.panel.Controls.Add(this.checkJamon);
            this.panel.Location = new System.Drawing.Point(364, 145);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(290, 272);
            this.panel.TabIndex = 16;
            this.panel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblmsj);
            this.panel1.Controls.Add(this.btFinalizar);
            this.panel1.Controls.Add(this.btvolver);
            this.panel1.Location = new System.Drawing.Point(303, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 100);
            this.panel1.TabIndex = 17;
            // 
            // lblmsj
            // 
            this.lblmsj.AutoSize = true;
            this.lblmsj.Location = new System.Drawing.Point(157, 16);
            this.lblmsj.Name = "lblmsj";
            this.lblmsj.Size = new System.Drawing.Size(114, 16);
            this.lblmsj.TabIndex = 2;
            this.lblmsj.Text = "Desea otra cosa?";
            // 
            // btFinalizar
            // 
            this.btFinalizar.Location = new System.Drawing.Point(215, 46);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(190, 23);
            this.btFinalizar.TabIndex = 1;
            this.btFinalizar.Text = "Finalizar compra";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // btvolver
            // 
            this.btvolver.Location = new System.Drawing.Point(25, 46);
            this.btvolver.Name = "btvolver";
            this.btvolver.Size = new System.Drawing.Size(166, 23);
            this.btvolver.TabIndex = 0;
            this.btvolver.Text = "Agregar otro producto";
            this.btvolver.UseVisualStyleBackColor = true;
            this.btvolver.Click += new System.EventHandler(this.btvolver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1015, 583);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtEleccion);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtEleccion;
        private System.Windows.Forms.CheckBox checkTomate;
        private System.Windows.Forms.CheckBox checkLechuga;
        private System.Windows.Forms.CheckBox checkQueso;
        private System.Windows.Forms.CheckBox checkJamon;
        private System.Windows.Forms.CheckBox checkHuevo;
        private System.Windows.Forms.Label lblAgregados;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btvolver;
        private System.Windows.Forms.Label lblmsj;
        private System.Windows.Forms.Button btFinalizar;
    }
}

