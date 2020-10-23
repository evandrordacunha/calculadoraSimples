using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora{
    public partial class Form1 : Form{

        bool bt_operacao = false;

        //FUNÇÃO RESPONSÁVEL POR IDENTIFICAR NÚMERO ESCOLHIDO E ADICIONAR NO VISOR
        public void lerNumero(int n){

            
            //se eu não cliquei em nenhum botão de operãção
            if (bt_operacao == false){
                //segue jogando o número recebido para o visor
                tb_ecram.Text += n;

            }else{
                //se for a primeira inserção então mostra no visor
                tb_ecram.Text = n.ToString();
            }

        }

        public void lerOperador(string tecla, int valor) {

          
                

        }
        public Form1() {
            InitializeComponent();
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            lerNumero(1);


        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            lerNumero(2);
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            lerNumero(3);
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            lerNumero(4);
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            lerNumero(5);
        }

        private void button2_Click(object sender, EventArgs e) {
            lerNumero(0);
        }

        private void bt_6_Click(object sender, EventArgs e) {
            lerNumero(6);
        }

        private void bt_7_Click(object sender, EventArgs e) {
            lerNumero(7);
        }

        private void bt_8_Click(object sender, EventArgs e) {
            lerNumero(8);
        }

        private void bt_9_Click(object sender, EventArgs e) {
            lerNumero(9);
        }
    }
}
