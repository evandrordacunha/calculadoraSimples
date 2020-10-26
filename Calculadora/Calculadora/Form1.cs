using System;
using System.Collections;
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
        bool exibirCalculo = false;
        double valorMemoria = 0;
        double calculo = 0;
        string operacao = "";
  

        //FUNÇÃO RESPONSÁVEL POR IDENTIFICAR NÚMERO ESCOLHIDO E ADICIONAR NO VISOR
        public void lerNumero(int n){

            //se eu não cliquei em nenhum botão de operação
            if (bt_operacao == false)
                //segue jogando o número recebido para o visor
                tb_ecram.Text += n.ToString();
            else
                //se for a primeira inserção então mostra no visor
                tb_ecram.Text = n.ToString();
            
            bt_operacao = false;
        }

        public void lerOperador(string op) {
            bt_operacao = true;
            if (exibirCalculo == true) 
                calcularResultado();
                this.operacao = op;
            valorMemoria = double.Parse(tb_ecram.Text);
            exibirCalculo = true;
        }

        private void calcularResultado() {

            //soma
            if (operacao == "+") {
                double v = double.Parse(tb_ecram.Text);
                calculo = (valorMemoria + v);
            }
            //subtração
            else if (operacao == "-") {
                double v = double.Parse(tb_ecram.Text);
                calculo = (valorMemoria - v);
            }
            //divisão
            else if (operacao == "/") {
                double v = double.Parse(tb_ecram.Text);
                calculo = (valorMemoria / v);
            }
            //multiplicação
            else if (operacao == "x") {
                double v = double.Parse(tb_ecram.Text);
                calculo = (valorMemoria * v);
            }
            //igualdade
            else if (operacao == "=") {
                calculo = double.Parse(tb_ecram.Text);
            }
            //quadrado
            else if (operacao == "quadrado") {
                double v = double.Parse(tb_ecram.Text);
                calculo = Math.Pow(v, 2);
            }            
            //raiz
            else if (operacao == "raiz") {
                double v = double.Parse(tb_ecram.Text);
                calculo = Math.Sqrt(v);
            //1/2
            } else if (operacao == "meio") {
                double v = double.Parse(tb_ecram.Text);
                calculo = v/2;
            }         
       
            // imprimindo calculo
            tb_ecram.Text = calculo.ToString();
            calculo = 0;
            valorMemoria = 0;
        }


        public Form1() {
            InitializeComponent();
        }

        //BOTAO 0
        private void button2_Click(object sender, EventArgs e) {
            lerNumero(0);
        }
        //BOTAO 1
        private void bt_1_Click(object sender, EventArgs e)
        {
            lerNumero(1);
        }
        //BOTAO 2
        private void bt_2_Click(object sender, EventArgs e)
        {
            lerNumero(2);
        }
        //BOTAO 3
        private void bt_3_Click(object sender, EventArgs e)
        {
            lerNumero(3);
        }
        //BOTAO 4
        private void bt_4_Click(object sender, EventArgs e)
        {
            lerNumero(4);
        }
        //BOTAO 5
        private void bt_5_Click(object sender, EventArgs e)
        {
            lerNumero(5);
        }
        //BOTAO 6
        private void bt_6_Click(object sender, EventArgs e) {
            lerNumero(6);
        }
        //BOTAO 7
        private void bt_7_Click(object sender, EventArgs e) {
            lerNumero(7);
        }
        //BOTAO 8
        private void bt_8_Click(object sender, EventArgs e) {
            lerNumero(8);
        }
        //BOTAO 9
        private void bt_9_Click(object sender, EventArgs e) {
            lerNumero(9);
        }

        //BOTÃO MAIS OU MENOS
        private void bt_mais_menos_Click(object sender, EventArgs e) {
            double numero = double.Parse(tb_ecram.Text) * (-1);
            tb_ecram.Text = numero.ToString();
        }
        //BOTÃO BACKSPACE
        private void button1_Click(object sender, EventArgs e) {
            int tamanhoCampo = tb_ecram.Text.Length;
            // se tiver algo escrito no visor
            if (tamanhoCampo > 0) {
                tb_ecram.Text = tb_ecram.Text.Substring(0, tamanhoCampo - 1);
            }
        }

        //BOTAO DIVISAO
        private void bt_div_Click(object sender, EventArgs e) {
            lerOperador("/");
        }
        //BOTAO DA MULTIPLICACAO
        private void bt_mult_Click(object sender, EventArgs e) {
            lerOperador("x");
        }
        //BOTAO SUBTRACAO
        private void bt_sub_Click(object sender, EventArgs e) {
            lerOperador("-");
        }
        //BOTAO SOMA
        private void bt_sum_Click(object sender, EventArgs e) {
            lerOperador("+");
        }
        //BOTAO IGUAL
        private void bt_equal_Click(object sender, EventArgs e) {
            lerOperador("=");
        }
        //BOTAO C
        private void bt_clear_Click(object sender, EventArgs e) {
            tb_ecram.Text = "0";
        }
        //BOTAO CE
        private void bt_ce_Click(object sender, EventArgs e) {
            double numero = valorMemoria;
            tb_ecram.Text = numero.ToString();
        }
        //BOTAO %
        private void bt_percent_Click(object sender, EventArgs e) {
            lerOperador("percent");
        }
        //BOTAO QUADRADO
        private void bt_quadrado_Click(object sender, EventArgs e) {
            lerOperador("quadrado");
        }
        //BOTAO 1/2
        private void bt_um_meio_Click(object sender, EventArgs e) {
            lerOperador("meio");
        }
        //BOTAO RAIZ
        private void bt_raiz_Click(object sender, EventArgs e) {
            lerOperador("raiz");
        }
        //BOTAO PONTO
        private void bt_virgula_Click(object sender, EventArgs e) {
            tb_ecram.Text += "."; 
        }
     
        private void Form1_Load(object sender, EventArgs e) {

        }

    }
}
