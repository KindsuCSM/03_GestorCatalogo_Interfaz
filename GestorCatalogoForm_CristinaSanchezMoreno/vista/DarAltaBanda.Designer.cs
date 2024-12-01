namespace GestorCatalogoForm_CristinaSanchezMoreno
{
    partial class DarAltaBanda
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtNumIntegrantes = new TextBox();
            label4 = new Label();
            txtLstMiembros = new TextBox();
            label3 = new Label();
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
            lblTituloDarAlta = new Label();
            cbGenero = new ComboBox();
            gbActivo = new GroupBox();
            rbNo = new RadioButton();
            rbSi = new RadioButton();
            btnCargarImagen = new Button();
            pbImagen = new PictureBox();
            ofdCuadroArchivos = new OpenFileDialog();
            gbActivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(270, 457);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(132, 23);
            btnAceptar.TabIndex = 57;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(97, 457);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(132, 23);
            btnCancelar.TabIndex = 56;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNumIntegrantes
            // 
            txtNumIntegrantes.Location = new Point(270, 391);
            txtNumIntegrantes.Margin = new Padding(4, 3, 4, 3);
            txtNumIntegrantes.Name = "txtNumIntegrantes";
            txtNumIntegrantes.Size = new Size(163, 23);
            txtNumIntegrantes.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Darkcastle PERSONAL USE", 12F);
            label4.Location = new Point(52, 379);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(177, 40);
            label4.TabIndex = 54;
            label4.Text = "Número de integrantes:";
            // 
            // txtLstMiembros
            // 
            txtLstMiembros.Location = new Point(270, 350);
            txtLstMiembros.Margin = new Padding(4, 3, 4, 3);
            txtLstMiembros.Name = "txtLstMiembros";
            txtLstMiembros.Size = new Size(163, 23);
            txtLstMiembros.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Darkcastle PERSONAL USE", 12F);
            label3.Location = new Point(52, 338);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 40);
            label3.TabIndex = 52;
            label3.Text = "Lista de miembros: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Darkcastle PERSONAL USE", 12F);
            label2.Location = new Point(52, 301);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 40);
            label2.TabIndex = 50;
            label2.Text = "Se encuentra activo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Darkcastle PERSONAL USE", 12F);
            label6.Location = new Point(52, 261);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(127, 40);
            label6.TabIndex = 48;
            label6.Text = "Género musical:";
            // 
            // txtNumDiscos
            // 
            txtNumDiscos.Location = new Point(270, 235);
            txtNumDiscos.Margin = new Padding(4, 3, 4, 3);
            txtNumDiscos.Name = "txtNumDiscos";
            txtNumDiscos.Size = new Size(163, 23);
            txtNumDiscos.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Darkcastle PERSONAL USE", 12F);
            label5.Location = new Point(52, 223);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(144, 40);
            label5.TabIndex = 46;
            label5.Text = "Número de discos:";
            // 
            // txtDiscografica
            // 
            txtDiscografica.Location = new Point(270, 196);
            txtDiscografica.Margin = new Padding(4, 3, 4, 3);
            txtDiscografica.Name = "txtDiscografica";
            txtDiscografica.Size = new Size(163, 23);
            txtDiscografica.TabIndex = 45;
            // 
            // lblDiscografica
            // 
            lblDiscografica.AutoSize = true;
            lblDiscografica.Font = new Font("Darkcastle PERSONAL USE", 12F);
            lblDiscografica.Location = new Point(52, 184);
            lblDiscografica.Margin = new Padding(4, 0, 4, 0);
            lblDiscografica.Name = "lblDiscografica";
            lblDiscografica.Size = new Size(115, 40);
            lblDiscografica.TabIndex = 44;
            lblDiscografica.Text = "Discográfica: ";
            // 
            // txtAnioInicios
            // 
            txtAnioInicios.Location = new Point(270, 158);
            txtAnioInicios.Margin = new Padding(4, 3, 4, 3);
            txtAnioInicios.Name = "txtAnioInicios";
            txtAnioInicios.Size = new Size(163, 23);
            txtAnioInicios.TabIndex = 43;
            // 
            // lblAnioInicios
            // 
            lblAnioInicios.AutoSize = true;
            lblAnioInicios.Font = new Font("Darkcastle PERSONAL USE", 12F);
            lblAnioInicios.Location = new Point(52, 146);
            lblAnioInicios.Margin = new Padding(4, 0, 4, 0);
            lblAnioInicios.Name = "lblAnioInicios";
            lblAnioInicios.Size = new Size(119, 40);
            lblAnioInicios.TabIndex = 42;
            lblAnioInicios.Text = "Año de inicios:";
            // 
            // txtNombreArtista
            // 
            txtNombreArtista.Location = new Point(270, 122);
            txtNombreArtista.Margin = new Padding(4, 3, 4, 3);
            txtNombreArtista.Name = "txtNombreArtista";
            txtNombreArtista.Size = new Size(163, 23);
            txtNombreArtista.TabIndex = 41;
            // 
            // lblNombreArtista
            // 
            lblNombreArtista.AutoSize = true;
            lblNombreArtista.Font = new Font("Darkcastle PERSONAL USE", 12F);
            lblNombreArtista.Location = new Point(52, 110);
            lblNombreArtista.Margin = new Padding(4, 0, 4, 0);
            lblNombreArtista.Name = "lblNombreArtista";
            lblNombreArtista.Size = new Size(151, 40);
            lblNombreArtista.TabIndex = 40;
            lblNombreArtista.Text = "Nombre del artista:";
            // 
            // lblTituloDarAlta
            // 
            lblTituloDarAlta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTituloDarAlta.AutoSize = true;
            lblTituloDarAlta.Font = new Font("Darkcastle PERSONAL USE", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloDarAlta.ImageAlign = ContentAlignment.TopCenter;
            lblTituloDarAlta.Location = new Point(280, 38);
            lblTituloDarAlta.Margin = new Padding(4, 0, 4, 0);
            lblTituloDarAlta.Name = "lblTituloDarAlta";
            lblTituloDarAlta.Size = new Size(264, 83);
            lblTituloDarAlta.TabIndex = 39;
            lblTituloDarAlta.Text = "Dar alta: Banda";
            // 
            // cbGenero
            // 
            cbGenero.FormattingEnabled = true;
            cbGenero.Location = new Point(270, 273);
            cbGenero.Margin = new Padding(4, 3, 4, 3);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(163, 23);
            cbGenero.TabIndex = 62;
            // 
            // gbActivo
            // 
            gbActivo.Controls.Add(rbNo);
            gbActivo.Controls.Add(rbSi);
            gbActivo.Location = new Point(270, 300);
            gbActivo.Margin = new Padding(4, 3, 4, 3);
            gbActivo.Name = "gbActivo";
            gbActivo.Padding = new Padding(4, 3, 4, 3);
            gbActivo.Size = new Size(163, 38);
            gbActivo.TabIndex = 89;
            gbActivo.TabStop = false;
            // 
            // rbNo
            // 
            rbNo.AutoSize = true;
            rbNo.Location = new Point(6, 13);
            rbNo.Margin = new Padding(4, 3, 4, 3);
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
            rbSi.Location = new Point(80, 13);
            rbSi.Margin = new Padding(4, 3, 4, 3);
            rbSi.Name = "rbSi";
            rbSi.Size = new Size(34, 19);
            rbSi.TabIndex = 84;
            rbSi.TabStop = true;
            rbSi.Text = "Si";
            rbSi.UseVisualStyleBackColor = true;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.Location = new Point(560, 364);
            btnCargarImagen.Margin = new Padding(4, 2, 4, 2);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(132, 23);
            btnCargarImagen.TabIndex = 91;
            btnCargarImagen.Text = "Cargar imagen";
            btnCargarImagen.UseVisualStyleBackColor = true;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(492, 123);
            pbImagen.Margin = new Padding(4, 2, 4, 2);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(262, 225);
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagen.TabIndex = 92;
            pbImagen.TabStop = false;
            // 
            // ofdCuadroArchivos
            // 
            ofdCuadroArchivos.FileName = "openFileDialog1";
            // 
            // DarAltaBanda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 512);
            Controls.Add(pbImagen);
            Controls.Add(btnCargarImagen);
            Controls.Add(gbActivo);
            Controls.Add(cbGenero);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNumIntegrantes);
            Controls.Add(label4);
            Controls.Add(txtLstMiembros);
            Controls.Add(label3);
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
            Controls.Add(lblTituloDarAlta);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DarAltaBanda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dar alta: Banda";
            gbActivo.ResumeLayout(false);
            gbActivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtNumIntegrantes;
        private Label label4;
        private TextBox txtLstMiembros;
        private Label label3;
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
        private Label lblTituloDarAlta;
        private ComboBox cbGenero;
        private GroupBox gbActivo;
        private RadioButton rbNo;
        private RadioButton rbSi;
        private Button btnCargarImagen;
        private PictureBox pbImagen;
        private OpenFileDialog ofdCuadroArchivos;
    }
}