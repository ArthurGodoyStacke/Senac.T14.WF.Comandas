namespace Comandas
{
    partial class FrmPrincipal
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
            gpxPrincipal = new GroupBox();
            btnUsuarios = new ReaLTaiizor.Controls.MaterialButton();
            btnPedidoCozinha = new ReaLTaiizor.Controls.MaterialButton();
            btnComanda = new ReaLTaiizor.Controls.MaterialButton();
            btnCardapio = new ReaLTaiizor.Controls.MaterialButton();
            gpxPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // gpxPrincipal
            // 
            gpxPrincipal.Controls.Add(btnUsuarios);
            gpxPrincipal.Controls.Add(btnPedidoCozinha);
            gpxPrincipal.Controls.Add(btnComanda);
            gpxPrincipal.Controls.Add(btnCardapio);
            gpxPrincipal.Location = new Point(12, 28);
            gpxPrincipal.Name = "gpxPrincipal";
            gpxPrincipal.Size = new Size(705, 344);
            gpxPrincipal.TabIndex = 0;
            gpxPrincipal.TabStop = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUsuarios.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUsuarios.Depth = 0;
            btnUsuarios.HighEmphasis = true;
            btnUsuarios.Icon = null;
            btnUsuarios.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnUsuarios.Location = new Point(7, 189);
            btnUsuarios.Margin = new Padding(4, 6, 4, 6);
            btnUsuarios.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.NoAccentTextColor = Color.Empty;
            btnUsuarios.Size = new Size(91, 36);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUsuarios.UseAccentColor = false;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuario_Click;
            // 
            // btnPedidoCozinha
            // 
            btnPedidoCozinha.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPedidoCozinha.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPedidoCozinha.Depth = 0;
            btnPedidoCozinha.HighEmphasis = true;
            btnPedidoCozinha.Icon = null;
            btnPedidoCozinha.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnPedidoCozinha.Location = new Point(7, 141);
            btnPedidoCozinha.Margin = new Padding(4, 6, 4, 6);
            btnPedidoCozinha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnPedidoCozinha.Name = "btnPedidoCozinha";
            btnPedidoCozinha.NoAccentTextColor = Color.Empty;
            btnPedidoCozinha.Size = new Size(140, 36);
            btnPedidoCozinha.TabIndex = 2;
            btnPedidoCozinha.Text = "Pedido Cozinha";
            btnPedidoCozinha.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPedidoCozinha.UseAccentColor = false;
            btnPedidoCozinha.UseVisualStyleBackColor = true;
            btnPedidoCozinha.Click += btnPedidoCozinha_Click;
            // 
            // btnComanda
            // 
            btnComanda.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnComanda.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnComanda.Depth = 0;
            btnComanda.HighEmphasis = true;
            btnComanda.Icon = null;
            btnComanda.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnComanda.Location = new Point(7, 93);
            btnComanda.Margin = new Padding(4, 6, 4, 6);
            btnComanda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnComanda.Name = "btnComanda";
            btnComanda.NoAccentTextColor = Color.Empty;
            btnComanda.Size = new Size(94, 36);
            btnComanda.TabIndex = 1;
            btnComanda.Text = "Comanda";
            btnComanda.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnComanda.UseAccentColor = false;
            btnComanda.UseVisualStyleBackColor = true;
            btnComanda.Click += btnComanda_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCardapio.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCardapio.Depth = 0;
            btnCardapio.HighEmphasis = true;
            btnCardapio.Icon = null;
            btnCardapio.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCardapio.Location = new Point(7, 45);
            btnCardapio.Margin = new Padding(4, 6, 4, 6);
            btnCardapio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCardapio.Name = "btnCardapio";
            btnCardapio.NoAccentTextColor = Color.Empty;
            btnCardapio.Size = new Size(93, 36);
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardápio";
            btnCardapio.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCardapio.UseAccentColor = false;
            btnCardapio.UseVisualStyleBackColor = true;
            btnCardapio.Click += btnCardapio_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gpxPrincipal);
            Name = "FrmPrincipal";
            Text = "Form1";
            gpxPrincipal.ResumeLayout(false);
            gpxPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpxPrincipal;
        private ReaLTaiizor.Controls.MaterialButton btnUsuarios;
        private ReaLTaiizor.Controls.MaterialButton btnPedidoCozinha;
        private ReaLTaiizor.Controls.MaterialButton btnComanda;
        private ReaLTaiizor.Controls.MaterialButton btnCardapio;
    }
}
