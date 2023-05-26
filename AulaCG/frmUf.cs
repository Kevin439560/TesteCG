using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaCG {
    public partial class frmUf : Form {
        public frmUf() {
            InitializeComponent();
        }


        private void frmUf_Load(object sender, EventArgs e) {

            HabilitaBotoesMenu(true);

            HabilitaTextoMenu(false);

        }

        //Esses métodos que trabalham com a manipulacao de elementos do
        //windows forms são chamadas procedures

        private void HabilitaBotoesMenu(bool habilitar) {

            barrabtnNovo.Enabled = habilitar;
            barrabtnEditar.Enabled = habilitar;
            barrabtnExcluir.Enabled = habilitar;
            barrabtnSalvar.Enabled = !habilitar;
            barrabtnCancelar.Enabled = !habilitar;
            barrabtnFechar.Enabled = habilitar;
        }

        private void HabilitaTextoMenu(bool habilitar) {

            txtNome.Enabled = habilitar;

            txtSigla.Enabled = habilitar;

            dadosUf.Enabled = !habilitar;

        }

        private void LimpaCamposDados() {

            txtNome.Clear();

            txtSigla.Text = "";

            //pode usar as duas formas para limpar um campo de texto

        }

        private bool VerificaDadosObrigatorios() {

            bool resultado = true;
            //verifica dados do nome
            //A funcao .Trim() remove os espacos em branco

            if (txtNome.Text.Trim().Length < 4) {

                resultado = false;

            }
            //Verifica dados da sigla
            if (txtSigla.Text.Trim().Length != 2) {

                resultado = false;

            }

            return resultado;
        }

        private void InsereUF() {

            HabilitaBotoesMenu(false);

            HabilitaTextoMenu(true);

            LimpaCamposDados();

        }
        private void EditaUF() {

            HabilitaBotoesMenu(false);

            HabilitaTextoMenu(true);

        }

        private void ExcluiUF() {

            DialogResult escolha = MessageBox.Show("Deseja Cancelar esta operação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (escolha == DialogResult.Yes) {

                LimpaCamposDados();

            }


        }

        private void SalvarUF() {

            if (VerificaDadosObrigatorios()) {

                HabilitaBotoesMenu(true);

                HabilitaTextoMenu(false);

                LimpaCamposDados();

            } else {

                MessageBox.Show("Dados Inválidos!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void CancelaUF() {

            DialogResult escolha = MessageBox.Show("Deseja Cancelar esta operação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (escolha == DialogResult.Yes) {

                HabilitaBotoesMenu(true);

                HabilitaTextoMenu(false);

                LimpaCamposDados();
            }



        }

        private void FecharUF() {

            DialogResult escolha = MessageBox.Show("Deseja Fechar Esta Janela?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (escolha == DialogResult.Yes) {
                this.Close();
            }


        }

        private void barrabtnNovo_Click(object sender, EventArgs e) {

            InsereUF();

        }

        private void barrabtnEditar_Click(object sender, EventArgs e) {

            EditaUF();

        }

        private void barrabtnExcluir_Click(object sender, EventArgs e) {

            ExcluiUF();

        }

        private void barrabtnSalvar_Click(object sender, EventArgs e) {

            SalvarUF();

        }

        private void barrabtnCancelar_Click(object sender, EventArgs e) {

            CancelaUF();

        }

        private void barrabtnFechar_Click(object sender, EventArgs e) {

            FecharUF();

        }
    }
}
