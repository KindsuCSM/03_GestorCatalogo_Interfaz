namespace GestorCatalogoForm_CristinaSanchezMoreno
{
    partial class BuscarArtista
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
            lstArtistasBuscados = new ListBox();
            rbNo = new RadioButton();
            rbSi = new RadioButton();
            cbGenero = new ComboBox();
            btnAceptar = new Button();
            label2 = new Label();
            label6 = new Label();
            txtNumDiscos = new TextBox();
            label5 = new Label();
            txtDiscografica = new TextBox();
            lblDiscografica = new Label();
            txtAnioInicios = new TextBox();
            lblAnioInicios = new Label();
            txtNombreArtista = new TextBox();
            lblNombreArtista = new Label();
            lblTituloEliminar = new Label();
            gbActivo = new GroupBox();
            btnCancelar = new Button();
            gbActivo.SuspendLayout();
            SuspendLayout();
            // 
            // lstArtistasBuscados
            // 
            lstArtistasBuscados.FormattingEnabled = true;
            lstArtistasBuscados.HorizontalScrollbar = true;
            lstArtistasBuscados.ItemHeight = 15;
            lstArtistasBuscados.Location = new Point(512, 125);
            lstArtistasBuscados.Name = "lstArtistasBuscados";
            lstArtistasBuscados.ScrollAlwaysVisible = true;
            lstArtistasBuscados.Size = new Size(421, 304);
            lstArtistasBuscados.TabIndex = 86;
            // 
            // rbNo
            // 
            rbNo.AutoSize = true;
            rbNo.Location = new Point(6, 13);
            rbNo.Name = "rbNo";
            rbNo.Size = new Size(41, 19);
            rbNo.TabIndex = 85;
            rbNo.TabStop = true;
            rbNo.Text = "No";
            rbNo.UseVisualStyleBackColor = true;
            // 
            // rbSi
            // 
            rbSi.AutoSize = true;
            rbSi.Location = new Point(81, 13);
            rbSi.Name = "rbSi";
            rbSi.Size = new Size(34, 19);
            rbSi.TabIndex = 84;
            rbSi.TabStop = true;
            rbSi.Text = "Si";
            rbSi.UseVisualStyleBackColor = true;
            // 
            // cbGenero
            // 
            cbGenero.FormattingEnabled = true;
            cbGenero.Location = new Point(278, 274);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(163, 23);
            cbGenero.TabIndex = 83;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(278, 406);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(132, 23);
            btnAceptar.TabIndex = 82;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Darkcastle PERSONAL USE", 12F);
            label2.Location = new Point(61, 301);
            label2.Name = "label2";
            label2.Size = new Size(154, 40);
            label2.TabIndex = 76;
            label2.Text = "Se encuentra activo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Darkcastle PERSONAL USE", 12F);
            label6.Location = new Point(61, 262);
            label6.Name = "label6";
            label6.Size = new Size(127, 40);
            label6.TabIndex = 75;
            label6.Text = "Género musical:";
            // 
            // txtNumDiscos
            // 
            txtNumDiscos.Location = new Point(278, 235);
            txtNumDiscos.Name = "txtNumDiscos";
            txtNumDiscos.Size = new Size(163, 23);
            txtNumDiscos.TabIndex = 74;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Darkcastle PERSONAL USE", 12F);
            label5.Location = new Point(61, 223);
            label5.Name = "label5";
            label5.Size = new Size(144, 40);
            label5.TabIndex = 73;
            label5.Text = "Número de discos:";
            // 
            // txtDiscografica
            // 
            txtDiscografica.Location = new Point(278, 197);
            txtDiscografica.Name = "txtDiscografica";
            txtDiscografica.Size = new Size(163, 23);
            txtDiscografica.TabIndex = 72;
            // 
            // lblDiscografica
            // 
            lblDiscografica.AutoSize = true;
            lblDiscografica.Font = new Font("Darkcastle PERSONAL USE", 12F);
            lblDiscografica.Location = new Point(61, 185);
            lblDiscografica.Name = "lblDiscografica";
            lblDiscografica.Size = new Size(115, 40);
            lblDiscografica.TabIndex = 71;
            lblDiscografica.Text = "Discográfica: ";
            // 
            // txtAnioInicios
            // 
            txtAnioInicios.Location = new Point(278, 159);
            txtAnioInicios.Name = "txtAnioInicios";
            txtAnioInicios.Size = new Size(163, 23);
            txtAnioInicios.TabIndex = 70;
            // 
            // lblAnioInicios
            // 
            lblAnioInicios.AutoSize = true;
            lblAnioInicios.Font = new Font("Darkcastle PERSONAL USE", 12F);
            lblAnioInicios.Location = new Point(61, 147);
            lblAnioInicios.Name = "lblAnioInicios";
            lblAnioInicios.Size = new Size(119, 40);
            lblAnioInicios.TabIndex = 69;
            lblAnioInicios.Text = "Año de inicios:";
            // 
            // txtNombreArtista
            // 
            txtNombreArtista.Location = new Point(278, 122);
            txtNombreArtista.Name = "txtNombreArtista";
            txtNombreArtista.Size = new Size(163, 23);
            txtNombreArtista.TabIndex = 68;
            // 
            // lblNombreArtista
            // 
            lblNombreArtista.AutoSize = true;
            lblNombreArtista.Font = new Font("Darkcastle PERSONAL USE", 12F);
            lblNombreArtista.Location = new Point(61, 110);
            lblNombreArtista.Name = "lblNombreArtista";
            lblNombreArtista.Size = new Size(151, 40);
            lblNombreArtista.TabIndex = 67;
            lblNombreArtista.Text = "Nombre del artista:";
            // 
            // lblTituloEliminar
            // 
            lblTituloEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTituloEliminar.AutoSize = true;
            lblTituloEliminar.Font = new Font("Darkcastle PERSONAL USE", 25F);
            lblTituloEliminar.ImageAlign = ContentAlignment.TopCenter;
            lblTituloEliminar.Location = new Point(359, 37);
            lblTituloEliminar.Name = "lblTituloEliminar";
            lblTituloEliminar.Size = new Size(247, 85);
            lblTituloEliminar.TabIndex = 66;
            lblTituloEliminar.Text = "Buscar artista";
            // 
            // gbActivo
            // 
            gbActivo.Controls.Add(rbNo);
            gbActivo.Controls.Add(rbSi);
            gbActivo.Location = new Point(278, 303);
            gbActivo.Name = "gbActivo";
            gbActivo.Size = new Size(163, 38);
            gbActivo.TabIndex = 88;
            gbActivo.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(100, 406);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(132, 23);
            btnCancelar.TabIndex = 81;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // BuscarArtista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 511);
            Controls.Add(gbActivo);
            Controls.Add(lstArtistasBuscados);
            Controls.Add(cbGenero);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(txtNumDiscos);
            Controls.Add(label5);
            Controls.Add(txtDiscografica);
            Controls.Add(lblDiscografica);
            Controls.Add(txtAnioInicios);
            Controls.Add(lblAnioInicios);
            Controls.Add(txtNombreArtista);
            Controls.Add(lblNombreArtista);
            Controls.Add(lblTituloEliminar);
            Name = "BuscarArtista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuscarArtista";
            gbActivo.ResumeLayout(false);
            gbActivo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lstArtistasBuscados;
        private RadioButton rbNo;
        private RadioButton rbSi;
        private ComboBox cbGenero;
        private Button btnAceptar;
        private Label label2;
        private Label label6;
        private TextBox txtNumDiscos;
        private Label label5;
        private TextBox txtDiscografica;
        private Label lblDiscografica;
        private TextBox txtAnioInicios;
        private Label lblAnioInicios;
        private TextBox txtNombreArtista;
        private Label lblNombreArtista;
        private Label lblTituloEliminar;
        private GroupBox gbActivo;
        private Button btnCancelar;
    }
}