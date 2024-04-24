namespace DatosPostulante
{
    partial class Datos
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
            System.Windows.Forms.Label lblNroDoc;
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            txtNombre = new System.Windows.Forms.TextBox();
            txtApellido = new System.Windows.Forms.TextBox();
            lblNombre = new System.Windows.Forms.Label();
            lblApellido = new System.Windows.Forms.Label();
            lblTipoDoc = new System.Windows.Forms.Label();
            cboIDType = new System.Windows.Forms.ComboBox();
            txtNroDoc = new System.Windows.Forms.TextBox();
            lblTitle = new System.Windows.Forms.Label();
            lblNroDoc = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblNroDoc
            // 
            lblNroDoc.AutoSize = true;
            lblNroDoc.BackColor = System.Drawing.Color.Transparent;
            lblNroDoc.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNroDoc.ForeColor = System.Drawing.Color.White;
            lblNroDoc.Location = new System.Drawing.Point(328, 280);
            lblNroDoc.Name = "lblNroDoc";
            lblNroDoc.Size = new System.Drawing.Size(126, 20);
            lblNroDoc.TabIndex = 9;
            lblNroDoc.Text = "Nro. Documento";
            // 
            // btnOK
            // 
            btnOK.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 192, 255);
            btnOK.FlatAppearance.BorderSize = 8;
            btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            btnOK.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOK.Location = new System.Drawing.Point(193, 348);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(85, 35);
            btnOK.TabIndex = 0;
            btnOK.Text = "Aceptar";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += BtnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 192, 255);
            btnCancel.FlatAppearance.BorderSize = 8;
            btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.Location = new System.Drawing.Point(533, 348);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(85, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Limpiar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // txtNombre
            // 
            txtNombre.AcceptsReturn = true;
            txtNombre.AcceptsTab = true;
            txtNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNombre.Location = new System.Drawing.Point(193, 174);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(425, 26);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.AcceptsReturn = true;
            txtApellido.AcceptsTab = true;
            txtApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtApellido.Location = new System.Drawing.Point(193, 221);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(425, 26);
            txtApellido.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = System.Drawing.Color.Transparent;
            lblNombre.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNombre.ForeColor = System.Drawing.Color.White;
            lblNombre.Location = new System.Drawing.Point(42, 177);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(67, 20);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = System.Drawing.Color.Transparent;
            lblApellido.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblApellido.ForeColor = System.Drawing.Color.White;
            lblApellido.Location = new System.Drawing.Point(42, 227);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(67, 20);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido";
            // 
            // lblTipoDoc
            // 
            lblTipoDoc.AutoSize = true;
            lblTipoDoc.BackColor = System.Drawing.Color.Transparent;
            lblTipoDoc.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTipoDoc.ForeColor = System.Drawing.Color.White;
            lblTipoDoc.Location = new System.Drawing.Point(42, 281);
            lblTipoDoc.Name = "lblTipoDoc";
            lblTipoDoc.Size = new System.Drawing.Size(126, 20);
            lblTipoDoc.TabIndex = 7;
            lblTipoDoc.Text = "Tipo Documento";
            // 
            // cboIDType
            // 
            cboIDType.AllowDrop = true;
            cboIDType.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboIDType.FormattingEnabled = true;
            cboIDType.Items.AddRange(new object[] { "DNI ", "DNI Extranjero", "Pasaporte" });
            cboIDType.Location = new System.Drawing.Point(193, 276);
            cboIDType.Name = "cboIDType";
            cboIDType.Size = new System.Drawing.Size(115, 27);
            cboIDType.TabIndex = 8;
            // 
            // txtNroDoc
            // 
            txtNroDoc.AcceptsReturn = true;
            txtNroDoc.AcceptsTab = true;
            txtNroDoc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNroDoc.Location = new System.Drawing.Point(460, 276);
            txtNroDoc.Name = "txtNroDoc";
            txtNroDoc.Size = new System.Drawing.Size(158, 26);
            txtNroDoc.TabIndex = 10;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = System.Drawing.Color.Transparent;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(180, 54);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(443, 42);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "IFTS Nº 29 - Inscripción 2024";
            // 
            // Datos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Portada_IFTS_para_form;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(761, 440);
            Controls.Add(lblTitle);
            Controls.Add(txtNroDoc);
            Controls.Add(lblNroDoc);
            Controls.Add(cboIDType);
            Controls.Add(lblTipoDoc);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            DoubleBuffered = true;
            HelpButton = true;
            Name = "Datos";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Datos del postulante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cboIDType;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.Label lblTitle;
    }
        
}


