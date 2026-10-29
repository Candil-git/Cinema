using CinemaApp.Base;
using CinemaDomain;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CinemaApp.Cadastros
{
    public partial class CadastroGenero : CadastroBase
    {
        public CadastroGenero()
        {
            _generoService
            InitializeComponent();
        }

        private void PreencherObjeto(Genero genero)
        {
            genero.Nome = txtNomeGenero.Text;
        }
        private void PreencherTela(Genero genero)
        {
            txtNomeGenero.Text = genero.Nome;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsEditMode)
                {
                    var genero = _generoService.GetById(id);
                    PreencherObjeto(genero);
                    _generoService.Update(genero);
                }
                else {
                    var genero = new Genero();
                    PreencherObjeto(genero);
                    _generoService.Create<Genero, Genero, GeneroValidator>(genero);
                }

                TabControlCadastro.SelectedIndex = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _generoService.Deletar(id);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) ;

            }
        }

        protected override void CarregarGrid()
        {
            _genero = _generoService.ReadAll<Genero>().ToList();
            DataGridView
        }
    }
}
