namespace Comandas
{
    partial class FrmUsuario
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
            btnVoltar = new ReaLTaiizor.Controls.CyberButton();
            btnSalvar = new Button();
            btnNovo = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            labelEdit4 = new ReaLTaiizor.Controls.LabelEdit();
            labelEdit3 = new ReaLTaiizor.Controls.LabelEdit();
            labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            txtId = new ReaLTaiizor.Controls.CyberTextBox();
            txtEmail = new ReaLTaiizor.Controls.CyberTextBox();
            txtSenha = new ReaLTaiizor.Controls.CyberTextBox();
            txtNome = new ReaLTaiizor.Controls.CyberTextBox();
            dgvUsuarios = new DataGridView();
            btnEditar = new Button();
            cyberGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Alpha = 20;
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Background = true;
            btnVoltar.Background_WidthPen = 4F;
            btnVoltar.BackgroundPen = true;
            btnVoltar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnVoltar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnVoltar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnVoltar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnVoltar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnVoltar.Effect_1 = true;
            btnVoltar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnVoltar.Effect_1_Transparency = 25;
            btnVoltar.Effect_2 = true;
            btnVoltar.Effect_2_ColorBackground = Color.White;
            btnVoltar.Effect_2_Transparency = 20;
            btnVoltar.Font = new Font("Arial", 11F);
            btnVoltar.ForeColor = Color.FromArgb(245, 245, 245);
            btnVoltar.Lighting = false;
            btnVoltar.LinearGradient_Background = false;
            btnVoltar.LinearGradientPen = false;
            btnVoltar.Location = new Point(899, 36);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.PenWidth = 15;
            btnVoltar.Rounding = true;
            btnVoltar.RoundingInt = 70;
            btnVoltar.Size = new Size(195, 75);
            btnVoltar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnVoltar.TabIndex = 0;
            btnVoltar.Tag = "Cyber";
            btnVoltar.TextButton = "Voltar";
            btnVoltar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnVoltar.Timer_Effect_1 = 5;
            btnVoltar.Timer_RGB = 300;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ActiveCaption;
            btnSalvar.Location = new Point(526, 44);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = SystemColors.ActiveCaption;
            btnNovo.Location = new Point(263, 44);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(112, 34);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.ActiveCaption;
            btnExcluir.Location = new Point(644, 44);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 34);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.Location = new Point(762, 44);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // cyberGroupBox1
            // 
            cyberGroupBox1.Alpha = 20;
            cyberGroupBox1.BackColor = Color.Transparent;
            cyberGroupBox1.Background = true;
            cyberGroupBox1.Background_WidthPen = 3F;
            cyberGroupBox1.BackgroundPen = true;
            cyberGroupBox1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.Controls.Add(labelEdit4);
            cyberGroupBox1.Controls.Add(labelEdit3);
            cyberGroupBox1.Controls.Add(labelEdit2);
            cyberGroupBox1.Controls.Add(labelEdit1);
            cyberGroupBox1.Controls.Add(txtId);
            cyberGroupBox1.Controls.Add(txtEmail);
            cyberGroupBox1.Controls.Add(txtSenha);
            cyberGroupBox1.Controls.Add(txtNome);
            cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox1.Lighting = false;
            cyberGroupBox1.LinearGradient_Background = false;
            cyberGroupBox1.LinearGradientPen = false;
            cyberGroupBox1.Location = new Point(197, 117);
            cyberGroupBox1.Name = "cyberGroupBox1";
            cyberGroupBox1.PenWidth = 15;
            cyberGroupBox1.RGB = false;
            cyberGroupBox1.Rounding = true;
            cyberGroupBox1.RoundingInt = 60;
            cyberGroupBox1.Size = new Size(963, 393);
            cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox1.TabIndex = 5;
            cyberGroupBox1.Tag = "Cyber";
            cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox1.Timer_RGB = 300;
            // 
            // labelEdit4
            // 
            labelEdit4.AutoSize = true;
            labelEdit4.BackColor = Color.Transparent;
            labelEdit4.Font = new Font("Microsoft Sans Serif", 9F);
            labelEdit4.ForeColor = Color.FromArgb(116, 125, 132);
            labelEdit4.Location = new Point(85, 315);
            labelEdit4.Name = "labelEdit4";
            labelEdit4.Size = new Size(54, 22);
            labelEdit4.TabIndex = 9;
            labelEdit4.Text = "Email";
            // 
            // labelEdit3
            // 
            labelEdit3.AutoSize = true;
            labelEdit3.BackColor = Color.Transparent;
            labelEdit3.Font = new Font("Microsoft Sans Serif", 9F);
            labelEdit3.ForeColor = Color.FromArgb(116, 125, 132);
            labelEdit3.Location = new Point(84, 228);
            labelEdit3.Name = "labelEdit3";
            labelEdit3.Size = new Size(62, 22);
            labelEdit3.TabIndex = 8;
            labelEdit3.Text = "Senha";
            // 
            // labelEdit2
            // 
            labelEdit2.AutoSize = true;
            labelEdit2.BackColor = Color.Transparent;
            labelEdit2.Font = new Font("Microsoft Sans Serif", 9F);
            labelEdit2.ForeColor = Color.FromArgb(116, 125, 132);
            labelEdit2.Location = new Point(84, 139);
            labelEdit2.Name = "labelEdit2";
            labelEdit2.Size = new Size(57, 22);
            labelEdit2.TabIndex = 7;
            labelEdit2.Text = "Nome";
            // 
            // labelEdit1
            // 
            labelEdit1.AutoSize = true;
            labelEdit1.BackColor = Color.Transparent;
            labelEdit1.Font = new Font("Microsoft Sans Serif", 9F);
            labelEdit1.ForeColor = Color.FromArgb(116, 125, 132);
            labelEdit1.Location = new Point(101, 45);
            labelEdit1.Name = "labelEdit1";
            labelEdit1.Size = new Size(24, 22);
            labelEdit1.TabIndex = 6;
            labelEdit1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Alpha = 20;
            txtId.BackColor = Color.Transparent;
            txtId.Background_WidthPen = 3F;
            txtId.BackgroundPen = true;
            txtId.ColorBackground = Color.FromArgb(37, 52, 68);
            txtId.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtId.ColorLighting = Color.FromArgb(29, 200, 238);
            txtId.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtId.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtId.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtId.Font = new Font("Arial", 15F);
            txtId.ForeColor = Color.FromArgb(245, 245, 245);
            txtId.Lighting = false;
            txtId.LinearGradientPen = false;
            txtId.Location = new Point(162, 31);
            txtId.Name = "txtId";
            txtId.PenWidth = 15;
            txtId.RGB = false;
            txtId.Rounding = true;
            txtId.RoundingInt = 60;
            txtId.Size = new Size(669, 60);
            txtId.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtId.TabIndex = 3;
            txtId.Tag = "Cyber";
            txtId.TextButton = "1";
            txtId.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtId.Timer_RGB = 300;
            // 
            // txtEmail
            // 
            txtEmail.Alpha = 20;
            txtEmail.BackColor = Color.Transparent;
            txtEmail.Background_WidthPen = 3F;
            txtEmail.BackgroundPen = true;
            txtEmail.ColorBackground = Color.FromArgb(37, 52, 68);
            txtEmail.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtEmail.ColorLighting = Color.FromArgb(29, 200, 238);
            txtEmail.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtEmail.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtEmail.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Arial", 15F);
            txtEmail.ForeColor = Color.FromArgb(245, 245, 245);
            txtEmail.Lighting = false;
            txtEmail.LinearGradientPen = false;
            txtEmail.Location = new Point(162, 297);
            txtEmail.Name = "txtEmail";
            txtEmail.PenWidth = 15;
            txtEmail.RGB = false;
            txtEmail.Rounding = true;
            txtEmail.RoundingInt = 60;
            txtEmail.Size = new Size(669, 60);
            txtEmail.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtEmail.TabIndex = 2;
            txtEmail.Tag = "Cyber";
            txtEmail.TextButton = "4";
            txtEmail.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtEmail.Timer_RGB = 300;
            // 
            // txtSenha
            // 
            txtSenha.Alpha = 20;
            txtSenha.BackColor = Color.Transparent;
            txtSenha.Background_WidthPen = 3F;
            txtSenha.BackgroundPen = true;
            txtSenha.ColorBackground = Color.FromArgb(37, 52, 68);
            txtSenha.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtSenha.ColorLighting = Color.FromArgb(29, 200, 238);
            txtSenha.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtSenha.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtSenha.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtSenha.Enabled = false;
            txtSenha.Font = new Font("Arial", 15F);
            txtSenha.ForeColor = Color.FromArgb(245, 245, 245);
            txtSenha.Lighting = false;
            txtSenha.LinearGradientPen = false;
            txtSenha.Location = new Point(162, 211);
            txtSenha.Name = "txtSenha";
            txtSenha.PenWidth = 15;
            txtSenha.RGB = false;
            txtSenha.Rounding = true;
            txtSenha.RoundingInt = 60;
            txtSenha.Size = new Size(669, 60);
            txtSenha.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtSenha.TabIndex = 1;
            txtSenha.Tag = "Cyber";
            txtSenha.TextButton = "3";
            txtSenha.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtSenha.Timer_RGB = 300;
            // 
            // txtNome
            // 
            txtNome.Alpha = 20;
            txtNome.BackColor = Color.Transparent;
            txtNome.Background_WidthPen = 3F;
            txtNome.BackgroundPen = true;
            txtNome.ColorBackground = Color.FromArgb(37, 52, 68);
            txtNome.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtNome.ColorLighting = Color.FromArgb(29, 200, 238);
            txtNome.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtNome.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtNome.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtNome.Enabled = false;
            txtNome.Font = new Font("Arial", 15F);
            txtNome.ForeColor = Color.FromArgb(245, 245, 245);
            txtNome.Lighting = false;
            txtNome.LinearGradientPen = false;
            txtNome.Location = new Point(162, 126);
            txtNome.Name = "txtNome";
            txtNome.PenWidth = 15;
            txtNome.RGB = false;
            txtNome.Rounding = true;
            txtNome.RoundingInt = 60;
            txtNome.Size = new Size(669, 60);
            txtNome.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtNome.TabIndex = 0;
            txtNome.Tag = "Cyber";
            txtNome.TextButton = "2";
            txtNome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtNome.Timer_RGB = 300;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(172, 525);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.Size = new Size(1060, 194);
            dgvUsuarios.TabIndex = 6;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ActiveCaption;
            btnEditar.Location = new Point(399, 44);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 821);
            Controls.Add(btnEditar);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(btnVoltar);
            Controls.Add(btnNovo);
            Controls.Add(cyberGroupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuarios";
            Load += FrmUsuario_Load;
            cyberGroupBox1.ResumeLayout(false);
            cyberGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton btnVoltar;
        private Button btnSalvar;
        private Button btnNovo;
        private Button btnExcluir;
        private Button btnCancelar;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private ReaLTaiizor.Controls.CyberTextBox txtEmail;
        private ReaLTaiizor.Controls.CyberTextBox txtSenha;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit4;
        private ReaLTaiizor.Controls.LabelEdit labelEdit3;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private ReaLTaiizor.Controls.CyberTextBox txtId;
        private ReaLTaiizor.Controls.CyberTextBox txtNome;
        private DataGridView dgvUsuarios;
        private Button btnEditar;
    }
}