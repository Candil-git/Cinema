namespace CinemaApp.Cadastros
{
    partial class CadastroGenero
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
            txtIdGenero = new TextBox();
            txtNomeGenero = new TextBox();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtNomeGenero);
            tabPageCadastro.Controls.Add(txtIdGenero);
            tabPageCadastro.Size = new Size(786, 355);
            tabPageCadastro.Controls.SetChildIndex(txtIdGenero, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNomeGenero, 0);
            // 
            // txtIdGenero
            // 
            txtIdGenero.Location = new Point(22, 28);
            txtIdGenero.Name = "txtIdGenero";
            txtIdGenero.PlaceholderText = "ID";
            txtIdGenero.Size = new Size(100, 23);
            txtIdGenero.TabIndex = 2;
            // 
            // txtNomeGenero
            // 
            txtNomeGenero.Location = new Point(22, 70);
            txtNomeGenero.Name = "txtNomeGenero";
            txtNomeGenero.PlaceholderText = "Nome";
            txtNomeGenero.Size = new Size(100, 23);
            txtNomeGenero.TabIndex = 3;
           
            // 
            // CadastroGenero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroGenero";
            Text = "Cadastro Genero";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNomeGenero;
        private TextBox txtIdGenero;
    }
}