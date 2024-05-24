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
            btnCardapio = new ReaLTaiizor.Controls.MaterialButton();
            btnComanda = new ReaLTaiizor.Controls.MaterialButton();
            btnPedidoCozinha = new ReaLTaiizor.Controls.MaterialButton();
            btnUsuario = new ReaLTaiizor.Controls.MaterialButton();
            gpxPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // gpxPrincipal
            // 
            gpxPrincipal.Controls.Add(btnUsuario);
            gpxPrincipal.Controls.Add(btnPedidoCozinha);
            gpxPrincipal.Controls.Add(btnComanda);
            gpxPrincipal.Controls.Add(btnCardapio);
            gpxPrincipal.Location = new Point(12, 28);
            gpxPrincipal.Name = "gpxPrincipal";
            gpxPrincipal.Size = new Size(705, 344);
            gpxPrincipal.TabIndex = 0;
            gpxPrincipal.TabStop = false;
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
            // 
            // btnUsuario
            // 
            btnUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUsuario.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUsuario.Depth = 0;
            btnUsuario.HighEmphasis = true;
            btnUsuario.Icon = null;
            btnUsuario.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnUsuario.Location = new Point(7, 189);
            btnUsuario.Margin = new Padding(4, 6, 4, 6);
            btnUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnUsuario.Name = "btnUsuario";
            btnUsuario.NoAccentTextColor = Color.Empty;
            btnUsuario.Size = new Size(158, 36);
            btnUsuario.TabIndex = 3;
            btnUsuario.Text = "Usuários";
            btnUsuario.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUsuario.UseAccentColor = false;
            btnUsuario.UseVisualStyleBackColor = true;
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
        private ReaLTaiizor.Controls.MaterialButton btnUsuario;
        private ReaLTaiizor.Controls.MaterialButton btnPedidoCozinha;
        private ReaLTaiizor.Controls.MaterialButton btnComanda;
        private ReaLTaiizor.Controls.MaterialButton btnCardapio;
    }
}
