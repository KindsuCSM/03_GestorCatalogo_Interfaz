namespace GestorCatalogoForm_CristinaSanchezMoreno
{
    partial class FrmPrincipal
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            menúToolStripMenuItem = new ToolStripMenuItem();
            darAltaToolStripMenuItem = new ToolStripMenuItem();
            bandaToolStripMenuItem = new ToolStripMenuItem();
            solistaToolStripMenuItem = new ToolStripMenuItem();
            buscarArtistaToolStripMenuItem = new ToolStripMenuItem();
            eliminarArtistaToolStripMenuItem = new ToolStripMenuItem();
            listarOrdenadosToolStripMenuItem = new ToolStripMenuItem();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            lblTituloListar = new Label();
            gbActivo = new GroupBox();
            rbNo = new RadioButton();
            rbSi = new RadioButton();
            cbGenero = new ComboBox();
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
            btnAnterior = new Button();
            btnSiguiente = new Button();
            txtAux2 = new TextBox();
            lblAux2 = new Label();
            txtAux1 = new TextBox();
            lblAux1 = new Label();
            bindingSource1 = new BindingSource(components);
            pbImagen = new PictureBox();
            menuStrip1.SuspendLayout();
            gbActivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menúToolStripMenuItem, archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            menúToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darAltaToolStripMenuItem, buscarArtistaToolStripMenuItem, eliminarArtistaToolStripMenuItem, listarOrdenadosToolStripMenuItem });
            menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            menúToolStripMenuItem.Size = new Size(50, 20);
            menúToolStripMenuItem.Text = "Menú";
            // 
            // darAltaToolStripMenuItem
            // 
            darAltaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bandaToolStripMenuItem, solistaToolStripMenuItem });
            darAltaToolStripMenuItem.Name = "darAltaToolStripMenuItem";
            darAltaToolStripMenuItem.Size = new Size(161, 22);
            darAltaToolStripMenuItem.Text = "Dar alta";
            // 
            // bandaToolStripMenuItem
            // 
            bandaToolStripMenuItem.Name = "bandaToolStripMenuItem";
            bandaToolStripMenuItem.Size = new Size(108, 22);
            bandaToolStripMenuItem.Text = "Banda";
            bandaToolStripMenuItem.Click += darAltaBanda_Click;
            // 
            // solistaToolStripMenuItem
            // 
            solistaToolStripMenuItem.Name = "solistaToolStripMenuItem";
            solistaToolStripMenuItem.Size = new Size(108, 22);
            solistaToolStripMenuItem.Text = "Solista";
            solistaToolStripMenuItem.Click += darAltaSolista_Click;
            // 
            // buscarArtistaToolStripMenuItem
            // 
            buscarArtistaToolStripMenuItem.Name = "buscarArtistaToolStripMenuItem";
            buscarArtistaToolStripMenuItem.Size = new Size(161, 22);
            buscarArtistaToolStripMenuItem.Text = "Buscar artista";
            buscarArtistaToolStripMenuItem.Click += buscarArtista_Click;
            // 
            // eliminarArtistaToolStripMenuItem
            // 
            eliminarArtistaToolStripMenuItem.Name = "eliminarArtistaToolStripMenuItem";
            eliminarArtistaToolStripMenuItem.Size = new Size(161, 22);
            eliminarArtistaToolStripMenuItem.Text = "Eliminar artista";
            eliminarArtistaToolStripMenuItem.Click += eliminarArtista_Click;
            // 
            // listarOrdenadosToolStripMenuItem
            // 
            listarOrdenadosToolStripMenuItem.Name = "listarOrdenadosToolStripMenuItem";
            listarOrdenadosToolStripMenuItem.Size = new Size(161, 22);
            listarOrdenadosToolStripMenuItem.Text = "Listar ordenados";
            listarOrdenadosToolStripMenuItem.Click += listarOrdenados_Click;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { guardarToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(116, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // lblTituloListar
            // 
            lblTituloListar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTituloListar.AutoSize = true;
            lblTituloListar.Font = new Font("Darkcastle PERSONAL USE", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloListar.ImageAlign = ContentAlignment.TopCenter;
            lblTituloListar.Location = new Point(305, 24);
            lblTituloListar.Name = "lblTituloListar";
            lblTituloListar.Size = new Size(156, 83);
            lblTituloListar.TabIndex = 59;
            lblTituloListar.Text = "Artistas";
            // 
            // gbActivo
            // 
            gbActivo.Controls.Add(rbNo);
            gbActivo.Controls.Add(rbSi);
            gbActivo.Location = new Point(298, 270);
            gbActivo.Name = "gbActivo";
            gbActivo.Size = new Size(163, 38);
            gbActivo.TabIndex = 100;
            gbActivo.TabStop = false;
            // 
            // rbNo
            // 
            rbNo.AutoSize = true;
            rbNo.Enabled = false;
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
            rbSi.Enabled = false;
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
            cbGenero.Enabled = false;
            cbGenero.FormattingEnabled = true;
            cbGenero.Location = new Point(298, 243);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(163, 23);
            cbGenero.TabIndex = 99;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Darkcastle PERSONAL USE", 12F);
            label2.Location = new Point(80, 270);
            label2.Name = "label2";
            label2.Size = new Size(154, 40);
            label2.TabIndex = 98;
            label2.Text = "Se encuentra activo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Darkcastle PERSONAL USE", 12F);
            label6.Location = new Point(80, 231);
            label6.Name = "label6";
            label6.Size = new Size(127, 40);
            label6.TabIndex = 97;
            label6.Text = "Género musical:";
            // 
            // txtNumDiscos
            // 
            txtNumDiscos.BackColor = Color.White;
            txtNumDiscos.Enabled = false;
            txtNumDiscos.Location = new Point(298, 205);
            txtNumDiscos.Name = "txtNumDiscos";
            txtNumDiscos.Size = new Size(163, 23);
            txtNumDiscos.TabIndex = 96;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Darkcastle PERSONAL USE", 12F);
            label5.Location = new Point(80, 193);
            label5.Name = "label5";
            label5.Size = new Size(144, 40);
            label5.TabIndex = 95;
            label5.Text = "Número de discos:";
            // 
            // txtDiscografica
            // 
            txtDiscografica.BackColor = Color.White;
            txtDiscografica.Enabled = false;
            txtDiscografica.Location = new Point(298, 166);
            txtDiscografica.Name = "txtDiscografica";
            txtDiscografica.ReadOnly = true;
            txtDiscografica.Size = new Size(163, 23);
            txtDiscografica.TabIndex = 94;
            // 
            // lblDiscografica
            // 
            lblDiscografica.AutoSize = true;
            lblDiscografica.Font = new Font("Darkcastle PERSONAL USE", 12F);
            lblDiscografica.Location = new Point(80, 154);
            lblDiscografica.Name = "lblDiscografica";
            lblDiscografica.Size = new Size(115, 40);
            lblDiscografica.TabIndex = 93;
            lblDiscografica.Text = "Discográfica: ";
            // 
            // txtAnioInicios
            // 
            txtAnioInicios.BackColor = Color.White;
            txtAnioInicios.Enabled = false;
            txtAnioInicios.Location = new Point(298, 128);
            txtAnioInicios.Name = "txtAnioInicios";
            txtAnioInicios.ReadOnly = true;
            txtAnioInicios.Size = new Size(163, 23);
            txtAnioInicios.TabIndex = 92;
            // 
            // lblAnioInicios
            // 
            lblAnioInicios.AutoSize = true;
            lblAnioInicios.Font = new Font("Darkcastle PERSONAL USE", 12F);
            lblAnioInicios.Location = new Point(80, 116);
            lblAnioInicios.Name = "lblAnioInicios";
            lblAnioInicios.Size = new Size(119, 40);
            lblAnioInicios.TabIndex = 91;
            lblAnioInicios.Text = "Año de inicios:";
            // 
            // txtNombreArtista
            // 
            txtNombreArtista.BackColor = Color.White;
            txtNombreArtista.Enabled = false;
            txtNombreArtista.Location = new Point(298, 92);
            txtNombreArtista.Name = "txtNombreArtista";
            txtNombreArtista.ReadOnly = true;
            txtNombreArtista.Size = new Size(163, 23);
            txtNombreArtista.TabIndex = 90;
            // 
            // lblNombreArtista
            // 
            lblNombreArtista.AutoSize = true;
            lblNombreArtista.Font = new Font("Darkcastle PERSONAL USE", 12F);
            lblNombreArtista.Location = new Point(80, 80);
            lblNombreArtista.Name = "lblNombreArtista";
            lblNombreArtista.Size = new Size(151, 40);
            lblNombreArtista.TabIndex = 89;
            lblNombreArtista.Text = "Nombre del artista:";
            // 
            // btnAnterior
            // 
            btnAnterior.Enabled = false;
            btnAnterior.Location = new Point(217, 505);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(132, 23);
            btnAnterior.TabIndex = 101;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Enabled = false;
            btnSiguiente.Location = new Point(414, 505);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(132, 23);
            btnSiguiente.TabIndex = 102;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // txtAux2
            // 
            txtAux2.BackColor = Color.White;
            txtAux2.Enabled = false;
            txtAux2.Location = new Point(298, 436);
            txtAux2.Name = "txtAux2";
            txtAux2.ReadOnly = true;
            txtAux2.Size = new Size(163, 23);
            txtAux2.TabIndex = 106;
            txtAux2.Visible = false;
            // 
            // lblAux2
            // 
            lblAux2.AutoSize = true;
            lblAux2.Font = new Font("Darkcastle PERSONAL USE", 12F);
            lblAux2.Location = new Point(80, 439);
            lblAux2.Name = "lblAux2";
            lblAux2.Size = new Size(21, 40);
            lblAux2.TabIndex = 105;
            lblAux2.Text = " ";
            // 
            // txtAux1
            // 
            txtAux1.BackColor = Color.White;
            txtAux1.Enabled = false;
            txtAux1.Location = new Point(298, 330);
            txtAux1.Multiline = true;
            txtAux1.Name = "txtAux1";
            txtAux1.ReadOnly = true;
            txtAux1.Size = new Size(163, 88);
            txtAux1.TabIndex = 104;
            txtAux1.Visible = false;
            // 
            // lblAux1
            // 
            lblAux1.AutoSize = true;
            lblAux1.Font = new Font("Darkcastle PERSONAL USE", 12F);
            lblAux1.Location = new Point(80, 318);
            lblAux1.Name = "lblAux1";
            lblAux1.Size = new Size(21, 40);
            lblAux1.TabIndex = 103;
            lblAux1.Text = " ";
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(501, 93);
            pbImagen.Margin = new Padding(3, 2, 3, 2);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(262, 225);
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagen.TabIndex = 107;
            pbImagen.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 612);
            Controls.Add(pbImagen);
            Controls.Add(txtAux2);
            Controls.Add(lblAux2);
            Controls.Add(txtAux1);
            Controls.Add(lblAux1);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(gbActivo);
            Controls.Add(cbGenero);
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
            Controls.Add(lblTituloListar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de artistas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gbActivo.ResumeLayout(false);
            gbActivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menúToolStripMenuItem;
        private ToolStripMenuItem darAltaToolStripMenuItem;
        private ToolStripMenuItem bandaToolStripMenuItem;
        private ToolStripMenuItem solistaToolStripMenuItem;
        private ToolStripMenuItem buscarArtistaToolStripMenuItem;
        private ToolStripMenuItem eliminarArtistaToolStripMenuItem;
        private ToolStripMenuItem listarOrdenadosToolStripMenuItem;
        private Label lblTituloListar;
        private GroupBox gbActivo;
        private RadioButton rbNo;
        private RadioButton rbSi;
        private ComboBox cbGenero;
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
        private Button btnAnterior;
        private Button btnSiguiente;
        private TextBox txtAux2;
        private Label lblAux2;
        private TextBox txtAux1;
        private Label lblAux1;
        private BindingSource bindingSource1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private PictureBox pbImagen;
    }
}