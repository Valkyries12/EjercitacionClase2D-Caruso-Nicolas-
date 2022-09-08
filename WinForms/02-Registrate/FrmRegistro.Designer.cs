namespace _02_Registrate
{
    partial class FrmRegistro
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
            this.GrbDetallesUsuario = new System.Windows.Forms.GroupBox();
            this.nmdDireccion = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grbGenero = new System.Windows.Forms.GroupBox();
            this.radGeneroNoBinario = new System.Windows.Forms.RadioButton();
            this.radGeneroFemenino = new System.Windows.Forms.RadioButton();
            this.radGeneroMasculino = new System.Windows.Forms.RadioButton();
            this.grbCursos = new System.Windows.Forms.GroupBox();
            this.chkCursoJS = new System.Windows.Forms.CheckBox();
            this.chkCursoCplus = new System.Windows.Forms.CheckBox();
            this.chkCursoC = new System.Windows.Forms.CheckBox();
            this.lstPais = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.GrbDetallesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmdDireccion)).BeginInit();
            this.grbGenero.SuspendLayout();
            this.grbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbDetallesUsuario
            // 
            this.GrbDetallesUsuario.Controls.Add(this.nmdDireccion);
            this.GrbDetallesUsuario.Controls.Add(this.txtDireccion);
            this.GrbDetallesUsuario.Controls.Add(this.lblEdad);
            this.GrbDetallesUsuario.Controls.Add(this.lblDireccion);
            this.GrbDetallesUsuario.Controls.Add(this.txtNombre);
            this.GrbDetallesUsuario.Controls.Add(this.lblNombre);
            this.GrbDetallesUsuario.Location = new System.Drawing.Point(26, 41);
            this.GrbDetallesUsuario.Name = "GrbDetallesUsuario";
            this.GrbDetallesUsuario.Size = new System.Drawing.Size(237, 145);
            this.GrbDetallesUsuario.TabIndex = 0;
            this.GrbDetallesUsuario.TabStop = false;
            this.GrbDetallesUsuario.Text = "Detalles del usuario";
            this.GrbDetallesUsuario.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nmdDireccion
            // 
            this.nmdDireccion.Location = new System.Drawing.Point(94, 106);
            this.nmdDireccion.Name = "nmdDireccion";
            this.nmdDireccion.Size = new System.Drawing.Size(100, 23);
            this.nmdDireccion.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(94, 64);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtDireccion.TabIndex = 4;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(10, 106);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(10, 67);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // grbGenero
            // 
            this.grbGenero.Controls.Add(this.radGeneroNoBinario);
            this.grbGenero.Controls.Add(this.radGeneroFemenino);
            this.grbGenero.Controls.Add(this.radGeneroMasculino);
            this.grbGenero.Location = new System.Drawing.Point(332, 41);
            this.grbGenero.Name = "grbGenero";
            this.grbGenero.Size = new System.Drawing.Size(181, 100);
            this.grbGenero.TabIndex = 1;
            this.grbGenero.TabStop = false;
            this.grbGenero.Text = "Género";
            // 
            // radGeneroNoBinario
            // 
            this.radGeneroNoBinario.AutoSize = true;
            this.radGeneroNoBinario.Location = new System.Drawing.Point(21, 74);
            this.radGeneroNoBinario.Name = "radGeneroNoBinario";
            this.radGeneroNoBinario.Size = new System.Drawing.Size(81, 19);
            this.radGeneroNoBinario.TabIndex = 2;
            this.radGeneroNoBinario.TabStop = true;
            this.radGeneroNoBinario.Text = "No binario";
            this.radGeneroNoBinario.UseVisualStyleBackColor = true;
            // 
            // radGeneroFemenino
            // 
            this.radGeneroFemenino.AutoSize = true;
            this.radGeneroFemenino.Location = new System.Drawing.Point(21, 49);
            this.radGeneroFemenino.Name = "radGeneroFemenino";
            this.radGeneroFemenino.Size = new System.Drawing.Size(78, 19);
            this.radGeneroFemenino.TabIndex = 1;
            this.radGeneroFemenino.TabStop = true;
            this.radGeneroFemenino.Text = "Femenino";
            this.radGeneroFemenino.UseVisualStyleBackColor = true;
            // 
            // radGeneroMasculino
            // 
            this.radGeneroMasculino.AutoSize = true;
            this.radGeneroMasculino.Location = new System.Drawing.Point(21, 24);
            this.radGeneroMasculino.Name = "radGeneroMasculino";
            this.radGeneroMasculino.Size = new System.Drawing.Size(80, 19);
            this.radGeneroMasculino.TabIndex = 0;
            this.radGeneroMasculino.TabStop = true;
            this.radGeneroMasculino.Text = "Masculino";
            this.radGeneroMasculino.UseVisualStyleBackColor = true;
            // 
            // grbCursos
            // 
            this.grbCursos.Controls.Add(this.chkCursoJS);
            this.grbCursos.Controls.Add(this.chkCursoCplus);
            this.grbCursos.Controls.Add(this.chkCursoC);
            this.grbCursos.Location = new System.Drawing.Point(332, 166);
            this.grbCursos.Name = "grbCursos";
            this.grbCursos.Size = new System.Drawing.Size(181, 100);
            this.grbCursos.TabIndex = 2;
            this.grbCursos.TabStop = false;
            this.grbCursos.Text = "Cursos";
            // 
            // chkCursoJS
            // 
            this.chkCursoJS.AutoSize = true;
            this.chkCursoJS.Location = new System.Drawing.Point(21, 72);
            this.chkCursoJS.Name = "chkCursoJS";
            this.chkCursoJS.Size = new System.Drawing.Size(78, 19);
            this.chkCursoJS.TabIndex = 2;
            this.chkCursoJS.Text = "JavaScript";
            this.chkCursoJS.UseVisualStyleBackColor = true;
            // 
            // chkCursoCplus
            // 
            this.chkCursoCplus.AutoSize = true;
            this.chkCursoCplus.Location = new System.Drawing.Point(21, 47);
            this.chkCursoCplus.Name = "chkCursoCplus";
            this.chkCursoCplus.Size = new System.Drawing.Size(50, 19);
            this.chkCursoCplus.TabIndex = 1;
            this.chkCursoCplus.Text = "C++";
            this.chkCursoCplus.UseVisualStyleBackColor = true;
            // 
            // chkCursoC
            // 
            this.chkCursoC.AutoSize = true;
            this.chkCursoC.Location = new System.Drawing.Point(21, 22);
            this.chkCursoC.Name = "chkCursoC";
            this.chkCursoC.Size = new System.Drawing.Size(41, 19);
            this.chkCursoC.TabIndex = 0;
            this.chkCursoC.Text = "C#";
            this.chkCursoC.UseVisualStyleBackColor = true;
            // 
            // lstPais
            // 
            this.lstPais.FormattingEnabled = true;
            this.lstPais.ItemHeight = 15;
            this.lstPais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.lstPais.Location = new System.Drawing.Point(26, 228);
            this.lstPais.Name = "lstPais";
            this.lstPais.Size = new System.Drawing.Size(237, 94);
            this.lstPais.TabIndex = 3;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(26, 210);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "País";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(378, 291);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(135, 31);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 358);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lstPais);
            this.Controls.Add(this.grbCursos);
            this.Controls.Add(this.grbGenero);
            this.Controls.Add(this.GrbDetallesUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.GrbDetallesUsuario.ResumeLayout(false);
            this.GrbDetallesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmdDireccion)).EndInit();
            this.grbGenero.ResumeLayout(false);
            this.grbGenero.PerformLayout();
            this.grbCursos.ResumeLayout(false);
            this.grbCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox GrbDetallesUsuario;
        private NumericUpDown nmdDireccion;
        private TextBox txtDireccion;
        private Label lblEdad;
        private Label lblDireccion;
        private TextBox txtNombre;
        private Label lblNombre;
        private GroupBox grbGenero;
        private RadioButton radGeneroNoBinario;
        private RadioButton radGeneroFemenino;
        private RadioButton radGeneroMasculino;
        private GroupBox grbCursos;
        private CheckBox chkCursoJS;
        private CheckBox chkCursoCplus;
        private CheckBox chkCursoC;
        private ListBox lstPais;
        private Label lblPais;
        private Button btnIngresar;
    }
}