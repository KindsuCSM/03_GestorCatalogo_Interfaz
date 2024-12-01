namespace GestorCatalogoForm_CristinaSanchezMoreno
{
    partial class ListarOrdenados
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
            lblTituloListar = new Label();
            lstBoxArtistas = new ListBox();
            btnAnioInicios = new Button();
            btnDiscografica = new Button();
            btnNumDiscos = new Button();
            btnGenero = new Button();
            btnActivo = new Button();
            btnNombreGrupo = new Button();
            SuspendLayout();
            // 
            // lblTituloListar
            // 
            lblTituloListar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTituloListar.AutoSize = true;
            lblTituloListar.Font = new Font("Darkcastle PERSONAL USE", 25F);
            lblTituloListar.ImageAlign = ContentAlignment.TopCenter;
            lblTituloListar.Location = new Point(261, 0);
            lblTituloListar.Name = "lblTituloListar";
            lblTituloListar.Size = new Size(276, 85);
            lblTituloListar.TabIndex = 58;
            lblTituloListar.Text = "Ordenar artistas";
            // 
            // lstBoxArtistas
            // 
            lstBoxArtistas.FormattingEnabled = true;
            lstBoxArtistas.HorizontalScrollbar = true;
            lstBoxArtistas.ItemHeight = 15;
            lstBoxArtistas.Location = new Point(35, 90);
            lstBoxArtistas.Name = "lstBoxArtistas";
            lstBoxArtistas.ScrollAlwaysVisible = true;
            lstBoxArtistas.Size = new Size(733, 154);
            lstBoxArtistas.TabIndex = 59;
            // 
            // btnAnioInicios
            // 
            btnAnioInicios.Location = new Point(263, 305);
            btnAnioInicios.Name = "btnAnioInicios";
            btnAnioInicios.Size = new Size(127, 23);
            btnAnioInicios.TabIndex = 61;
            btnAnioInicios.Text = "Año de inicios";
            btnAnioInicios.UseVisualStyleBackColor = true;
            btnAnioInicios.Click += btnAnioInicios_Click;
            // 
            // btnDiscografica
            // 
            btnDiscografica.Location = new Point(415, 305);
            btnDiscografica.Name = "btnDiscografica";
            btnDiscografica.Size = new Size(127, 23);
            btnDiscografica.TabIndex = 62;
            btnDiscografica.Text = "Discográfica";
            btnDiscografica.UseVisualStyleBackColor = true;
            btnDiscografica.Click += btnDiscografica_Click;
            // 
            // btnNumDiscos
            // 
            btnNumDiscos.Location = new Point(567, 305);
            btnNumDiscos.Name = "btnNumDiscos";
            btnNumDiscos.Size = new Size(127, 23);
            btnNumDiscos.TabIndex = 63;
            btnNumDiscos.Text = "Número de discos";
            btnNumDiscos.UseVisualStyleBackColor = true;
            btnNumDiscos.Click += btnNumDiscos_Click;
            // 
            // btnGenero
            // 
            btnGenero.Location = new Point(263, 360);
            btnGenero.Name = "btnGenero";
            btnGenero.Size = new Size(127, 23);
            btnGenero.TabIndex = 64;
            btnGenero.Text = "Genero musical";
            btnGenero.UseVisualStyleBackColor = true;
            btnGenero.Click += btnGenero_Click;
            // 
            // btnActivo
            // 
            btnActivo.Location = new Point(415, 360);
            btnActivo.Name = "btnActivo";
            btnActivo.Size = new Size(127, 23);
            btnActivo.TabIndex = 65;
            btnActivo.Text = "Activo";
            btnActivo.UseVisualStyleBackColor = true;
            btnActivo.Click += btnActivo_Click;
            // 
            // btnNombreGrupo
            // 
            btnNombreGrupo.Location = new Point(113, 305);
            btnNombreGrupo.Name = "btnNombreGrupo";
            btnNombreGrupo.Size = new Size(127, 23);
            btnNombreGrupo.TabIndex = 66;
            btnNombreGrupo.Text = "Nombre del grupo";
            btnNombreGrupo.UseVisualStyleBackColor = true;
            btnNombreGrupo.Click += btnNombreGrupo_Click;
            // 
            // ListarOrdenados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNombreGrupo);
            Controls.Add(btnActivo);
            Controls.Add(btnGenero);
            Controls.Add(btnNumDiscos);
            Controls.Add(btnDiscografica);
            Controls.Add(btnAnioInicios);
            Controls.Add(lstBoxArtistas);
            Controls.Add(lblTituloListar);
            Name = "ListarOrdenados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listar ordenados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloListar;
        private ListBox lstBoxArtistas;
        private Button btnAnioInicios;
        private Button btnDiscografica;
        private Button btnNumDiscos;
        private Button btnGenero;
        private Button btnActivo;
        private Button btnNombreGrupo;
    }
}