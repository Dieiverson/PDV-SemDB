using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] nomeProduto = new string[100];
        decimal[] precoProduto = new decimal[100];
        int[] qntdProduto = new int[100];
        bool produtoCadastrado = false;
        int qntdProdutosCadastrados = 0;
        decimal precoprodutoAtual = 0;
        string nomeprodutoAtual = " ";
        decimal subtotal = 0;
        decimal totalCompras = 0;
        bool comprasNoCarrinho = false;
        
               

        


        private void btn_Cadastrar_Click(object sender, EventArgs e) //Serve para cadastrar os produtos;
        {
            produtoCadastrado = false;
            if (txt_nome.Text != "" && txt_Preco.Text != "" && txt_Quantidade.Text != "")
            {
                for (int i = 0; i < nomeProduto.Length; i++)
                {
                    if (nomeProduto[i] == " " || nomeProduto[i] == null)
                    {
                        nomeProduto[i] = txt_nome.Text;
                        precoProduto[i] = Convert.ToDecimal(txt_Preco.Text);
                        qntdProduto[i] = Convert.ToInt32(txt_Quantidade.Text);
                        produtoCadastrado = true;
                        qntdProdutosCadastrados++;
                        break;
                    }
                }



               
                    if (produtoCadastrado == true)
                    {
                    
                    lbl_Cadastro.Text = "Produto cadastrado com sucesso!";
                    lbl_Produtos_Cadastrados.Text = "Produtos Cadastrados: " +   qntdProdutosCadastrados;
                    progressBar1.Value = qntdProdutosCadastrados;
                    lbl_maximoProdutos.Text = (qntdProdutosCadastrados + " de" + nomeProduto.Length + " de espaços usados");


               }
                    else
                    {

                   lbl_Cadastro.Text = "Não há mais espaços disponíveis \n para cadastrar novos produtos.";
                   
                  
                }

                }
            else
            {
                    MessageBox.Show("Um ou mais espaços vazios");
                }
            }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            lbl_Cadastro.Text = " ";
        }

        private void txt_Quantidade_TextChanged(object sender, EventArgs e)
        {
            lbl_Cadastro.Text = " ";
        }

        private void txt_Preco_TextChanged(object sender, EventArgs e)
        {
            lbl_Cadastro.Text = " ";
        }









        private void button1_Click(object sender, EventArgs e) // Serve para excluir os produtos
        {
            if (txt_buscaparaExclusao.Text != "")
            {
                 for (int i = 0; i < nomeProduto.Length; i++)
                {
                    if (txt_buscaparaExclusao.Text == Convert.ToString(i))
                    {
                        if (nomeProduto[Convert.ToInt32(txt_buscaparaExclusao.Text)] != " " & nomeProduto[Convert.ToInt32(txt_buscaparaExclusao.Text)] != null)
                        {
                            if (MessageBox.Show("Deseja excluir o produto " + nomeProduto[i] + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                           
                                nomeProduto[i] = " ";
                                precoProduto[i] = 0;
                                qntdProduto[i] = 0;
                                qntdProdutosCadastrados--;
                                lbl_Produtos_Cadastrados.Text = "Produtos Cadastrados: " + qntdProdutosCadastrados;
                                progressBar1.Value = qntdProdutosCadastrados;
                                lbl_maximoProdutos.Text = (qntdProdutosCadastrados + " de" + nomeProduto.Length + " de espaços usados");
                                
                                MessageBox.Show("Produto excluído com sucesso!");


                                break;
                            }
                            
                            
                        }
                        else
                        {
                            MessageBox.Show("Erro. Produto não cadastrado.");
                             break;
                        }
                    }
                   

                }
               
            }
            else
            {
                MessageBox.Show("Digite o índice do produto que deseja excluir!");
            }
        }




        private void button2_Click(object sender, EventArgs e) //Serve Para listar os produtos
        {
            listBox1.Items.Clear();
            listBox1.Items.Add( "ID---NOME--------ESTOQUE-----PREÇO");
            for (int i = 0; i < nomeProduto.Length; i++)
                if (nomeProduto[i] != " " && nomeProduto[i] != null)
                {
                    listBox1.Items.Add(i + "--" + nomeProduto[i] + " ------- " + qntdProduto[i] + " ---- " + precoProduto[i]);
                }
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //TEXTBOX ID PRODUTO
        {
            textBox1.Text = null;
            for (int i = 0; i < nomeProduto.Length; i++)
            {
                if (textBox2.Text == Convert.ToString(i))
                {
                    nomeprodutoAtual = nomeProduto[i];
                    precoprodutoAtual = precoProduto[i];

                }
            }
           
        }




        private void textBox1_TextChanged(object sender, EventArgs e)//TEXTBOX QUANTIDADE PRODUTO
        {
            if (textBox1.Text == "")
            {
                lbl_produtoCompra.Text = " ";
            }
            else
            {
                lbl_produtoCompra.Text = textBox1.Text + "X " + nomeprodutoAtual + " R$ " + (precoprodutoAtual * Convert.ToInt32(textBox1.Text));

            }



        }

        private void btn_adicionarCarrinho_Click(object sender, EventArgs e)//Serve para adicionar a mercadoria no carinho
        {   
            
            if (textBox1.Text != "" & textBox2.Text != null)
            {
                
                    if (nomeProduto[Convert.ToInt32(textBox2.Text)] != " " & nomeProduto[Convert.ToInt32(textBox2.Text)] != null)
                    {
                        if (qntdProduto[Convert.ToInt32(textBox2.Text)] > 0)
                        {
                            if (Convert.ToInt32(textBox1.Text) <= qntdProduto[Convert.ToInt32(textBox2.Text)])
                            {
                             
                               subtotal = (Convert.ToDecimal(textBox1.Text) * precoprodutoAtual);
                              lbox_carrinho.Items.Add(textBox1.Text +"X" +  "--" + nomeprodutoAtual +  "   =   " + "R$"+subtotal);
                               qntdProduto[Convert.ToInt32(textBox2.Text)] = qntdProduto[Convert.ToInt32(textBox2.Text)]  -  Convert.ToInt32(textBox1.Text);                            
                                totalCompras = totalCompras + subtotal;
                            comprasNoCarrinho = true;
                              subtotal = 0;
                              lbl_Total.Text = " Total: " + Convert.ToString(totalCompras);
                               
                            }
                            else
                            {
                                MessageBox.Show("NÃO TEMOS ESSA QUANTIDADE EM ESTOQUE.");
                               
                            }
                        }
                        else
                        {
                            MessageBox.Show("PRODUTO FORA DE ESTOQUE NO MOMENTO.");
                           
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Esse produto não está cadastrado.");
                        
                    }
                
               
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void lbox_carrinho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_finalizarCompra_Click(object sender, EventArgs e)
        {
            if (comprasNoCarrinho == false)
            {
                MessageBox.Show("Adicione pelo menos um produto para finalizar a compra!");
            }
            else
            {
                lbox_carrinho.Items.Clear();
                lbl_Total.Text = " ";
                textBox1.Text = null;
                textBox2.Text = null;
                lbl_produtoCompra.Text = " ";
                MessageBox.Show("Compra finalizada.");
                comprasNoCarrinho = false;
            }
           

        }
    }
    }

        
    

