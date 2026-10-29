using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CinemaApp.Base
{
    public partial class CadastroBase : MaterialForm
    {
        protected bool IsEditMode = false;
        public CadastroBase()
        {
            InitializeComponent();
        }

        private void CadastroBase_Load(object sender, EventArgs e)
        {

        }

        protected virtual void Salvar()
        {
            throw new NotImplementedException();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja Realmente Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LimparCampos();
                TabControlCadastro.SelectedIndex = 1;
            }
        }

        private void LimparCampos()
        {
            IsEditMode = false;

            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                    ((MaterialTextBoxEdit)control).Clear();
                if (control is MaterialMaskedTextBox)
                    ((MaterialMaskedTextBox)control).Clear();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Deseja realmente excluir o registro selecionado?", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var id = (int)dataGridView.SelectedRows[0].Cells[0].Value;

                    Deletar(id);
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
