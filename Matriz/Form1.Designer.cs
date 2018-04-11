namespace Matriz
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
            this.txtMostrar = new System.Windows.Forms.RichTextBox();
            this.btnLlenarColumnas = new System.Windows.Forms.Button();
            this.btnLlenar = new System.Windows.Forms.Button();
            this.btnLlenarInverso = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnDiagonalPrincipal = new System.Windows.Forms.Button();
            this.btnDiagonalSecundaria = new System.Windows.Forms.Button();
            this.btnTrianguloBajoPrincipal = new System.Windows.Forms.Button();
            this.btnTrianguloArribaSecundaria = new System.Windows.Forms.Button();
            this.btnInvertirDiagonalPrincipal = new System.Windows.Forms.Button();
            this.btnInvertirPorSecundaria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(12, 14);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(410, 376);
            this.txtMostrar.TabIndex = 0;
            this.txtMostrar.Text = "";
            // 
            // btnLlenarColumnas
            // 
            this.btnLlenarColumnas.AutoSize = true;
            this.btnLlenarColumnas.Location = new System.Drawing.Point(483, 50);
            this.btnLlenarColumnas.Name = "btnLlenarColumnas";
            this.btnLlenarColumnas.Size = new System.Drawing.Size(138, 33);
            this.btnLlenarColumnas.TabIndex = 1;
            this.btnLlenarColumnas.Text = "Llenar Columnas";
            this.btnLlenarColumnas.UseVisualStyleBackColor = true;
            this.btnLlenarColumnas.Click += new System.EventHandler(this.btnLlenarColumnas_Click);
            // 
            // btnLlenar
            // 
            this.btnLlenar.Location = new System.Drawing.Point(483, 11);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(88, 33);
            this.btnLlenar.TabIndex = 2;
            this.btnLlenar.Text = "Llenar";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // btnLlenarInverso
            // 
            this.btnLlenarInverso.AutoSize = true;
            this.btnLlenarInverso.Location = new System.Drawing.Point(483, 89);
            this.btnLlenarInverso.Name = "btnLlenarInverso";
            this.btnLlenarInverso.Size = new System.Drawing.Size(119, 33);
            this.btnLlenarInverso.TabIndex = 3;
            this.btnLlenarInverso.Text = "Llenar Inverso";
            this.btnLlenarInverso.UseVisualStyleBackColor = true;
            this.btnLlenarInverso.Click += new System.EventHandler(this.btnLlenarInverso_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(483, 148);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(88, 33);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnDiagonalPrincipal
            // 
            this.btnDiagonalPrincipal.AutoSize = true;
            this.btnDiagonalPrincipal.Location = new System.Drawing.Point(483, 198);
            this.btnDiagonalPrincipal.Name = "btnDiagonalPrincipal";
            this.btnDiagonalPrincipal.Size = new System.Drawing.Size(144, 33);
            this.btnDiagonalPrincipal.TabIndex = 5;
            this.btnDiagonalPrincipal.Text = "Diagonal principal";
            this.btnDiagonalPrincipal.UseVisualStyleBackColor = true;
            this.btnDiagonalPrincipal.Click += new System.EventHandler(this.btnDiagonalPrincipal_Click);
            // 
            // btnDiagonalSecundaria
            // 
            this.btnDiagonalSecundaria.AutoSize = true;
            this.btnDiagonalSecundaria.Location = new System.Drawing.Point(483, 254);
            this.btnDiagonalSecundaria.Name = "btnDiagonalSecundaria";
            this.btnDiagonalSecundaria.Size = new System.Drawing.Size(164, 33);
            this.btnDiagonalSecundaria.TabIndex = 6;
            this.btnDiagonalSecundaria.Text = "Diagonal secundaria";
            this.btnDiagonalSecundaria.UseVisualStyleBackColor = true;
            this.btnDiagonalSecundaria.Click += new System.EventHandler(this.btnDiagonalSecundaria_Click);
            // 
            // btnTrianguloBajoPrincipal
            // 
            this.btnTrianguloBajoPrincipal.AutoSize = true;
            this.btnTrianguloBajoPrincipal.Location = new System.Drawing.Point(483, 302);
            this.btnTrianguloBajoPrincipal.Name = "btnTrianguloBajoPrincipal";
            this.btnTrianguloBajoPrincipal.Size = new System.Drawing.Size(180, 33);
            this.btnTrianguloBajoPrincipal.TabIndex = 7;
            this.btnTrianguloBajoPrincipal.Text = "Triángulo bajo principal";
            this.btnTrianguloBajoPrincipal.UseVisualStyleBackColor = true;
            this.btnTrianguloBajoPrincipal.Click += new System.EventHandler(this.btnTrianguloBajoPrincipal_Click);
            // 
            // btnTrianguloArribaSecundaria
            // 
            this.btnTrianguloArribaSecundaria.AutoSize = true;
            this.btnTrianguloArribaSecundaria.Location = new System.Drawing.Point(483, 357);
            this.btnTrianguloArribaSecundaria.Name = "btnTrianguloArribaSecundaria";
            this.btnTrianguloArribaSecundaria.Size = new System.Drawing.Size(210, 33);
            this.btnTrianguloArribaSecundaria.TabIndex = 8;
            this.btnTrianguloArribaSecundaria.Text = "Triángulo arriba secundaria";
            this.btnTrianguloArribaSecundaria.UseVisualStyleBackColor = true;
            this.btnTrianguloArribaSecundaria.Click += new System.EventHandler(this.btnTrianguloArribaSecundaria_Click);
            // 
            // btnInvertirDiagonalPrincipal
            // 
            this.btnInvertirDiagonalPrincipal.AutoSize = true;
            this.btnInvertirDiagonalPrincipal.Location = new System.Drawing.Point(12, 405);
            this.btnInvertirDiagonalPrincipal.Name = "btnInvertirDiagonalPrincipal";
            this.btnInvertirDiagonalPrincipal.Size = new System.Drawing.Size(220, 33);
            this.btnInvertirDiagonalPrincipal.TabIndex = 9;
            this.btnInvertirDiagonalPrincipal.Text = "Invertir por diagonal principal";
            this.btnInvertirDiagonalPrincipal.UseVisualStyleBackColor = true;
            this.btnInvertirDiagonalPrincipal.Click += new System.EventHandler(this.btnInvertirDiagonalPrincipal_Click);
            // 
            // btnInvertirPorSecundaria
            // 
            this.btnInvertirPorSecundaria.AutoSize = true;
            this.btnInvertirPorSecundaria.Location = new System.Drawing.Point(259, 405);
            this.btnInvertirPorSecundaria.Name = "btnInvertirPorSecundaria";
            this.btnInvertirPorSecundaria.Size = new System.Drawing.Size(240, 33);
            this.btnInvertirPorSecundaria.TabIndex = 10;
            this.btnInvertirPorSecundaria.Text = "Invertir por diagonal secundaria";
            this.btnInvertirPorSecundaria.UseVisualStyleBackColor = true;
            this.btnInvertirPorSecundaria.Click += new System.EventHandler(this.btnInvertirPorSecundaria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 483);
            this.Controls.Add(this.btnInvertirPorSecundaria);
            this.Controls.Add(this.btnInvertirDiagonalPrincipal);
            this.Controls.Add(this.btnTrianguloArribaSecundaria);
            this.Controls.Add(this.btnTrianguloBajoPrincipal);
            this.Controls.Add(this.btnDiagonalSecundaria);
            this.Controls.Add(this.btnDiagonalPrincipal);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnLlenarInverso);
            this.Controls.Add(this.btnLlenar);
            this.Controls.Add(this.btnLlenarColumnas);
            this.Controls.Add(this.txtMostrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Matriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMostrar;
        private System.Windows.Forms.Button btnLlenarColumnas;
        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.Button btnLlenarInverso;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnDiagonalPrincipal;
        private System.Windows.Forms.Button btnDiagonalSecundaria;
        private System.Windows.Forms.Button btnTrianguloBajoPrincipal;
        private System.Windows.Forms.Button btnTrianguloArribaSecundaria;
        private System.Windows.Forms.Button btnInvertirDiagonalPrincipal;
        private System.Windows.Forms.Button btnInvertirPorSecundaria;
    }
}

