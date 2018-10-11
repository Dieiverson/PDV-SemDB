namespace PDV
{
    partial class Form1
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.txt_Preco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.lbl_Cadastro = new System.Windows.Forms.Label();
            this.lbl_Produtos_Cadastrados = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txt_buscaparaExclusao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_maximoProdutos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_produtoCompra = new System.Windows.Forms.Label();
            this.btn_adicionarCarrinho = new System.Windows.Forms.Button();
            this.lbox_carrinho = new System.Windows.Forms.ListBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btn_finalizarCompra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(12, 87);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(177, 20);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o nome do produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite a quantidade do produto:";
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Location = new System.Drawing.Point(12, 153);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(177, 20);
            this.txt_Quantidade.TabIndex = 3;
            this.txt_Quantidade.TextChanged += new System.EventHandler(this.txt_Quantidade_TextChanged);
            // 
            // txt_Preco
            // 
            this.txt_Preco.Location = new System.Drawing.Point(12, 218);
            this.txt_Preco.Name = "txt_Preco";
            this.txt_Preco.Size = new System.Drawing.Size(177, 20);
            this.txt_Preco.TabIndex = 4;
            this.txt_Preco.TextChanged += new System.EventHandler(this.txt_Preco_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digite o preço do produto:";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.Location = new System.Drawing.Point(12, 258);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(177, 30);
            this.btn_Cadastrar.TabIndex = 6;
            this.btn_Cadastrar.Text = "CADASTRAR";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // lbl_Cadastro
            // 
            this.lbl_Cadastro.AutoSize = true;
            this.lbl_Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cadastro.Location = new System.Drawing.Point(9, 304);
            this.lbl_Cadastro.Name = "lbl_Cadastro";
            this.lbl_Cadastro.Size = new System.Drawing.Size(0, 18);
            this.lbl_Cadastro.TabIndex = 7;
            // 
            // lbl_Produtos_Cadastrados
            // 
            this.lbl_Produtos_Cadastrados.AutoSize = true;
            this.lbl_Produtos_Cadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Produtos_Cadastrados.Location = new System.Drawing.Point(12, 411);
            this.lbl_Produtos_Cadastrados.Name = "lbl_Produtos_Cadastrados";
            this.lbl_Produtos_Cadastrados.Size = new System.Drawing.Size(162, 18);
            this.lbl_Produtos_Cadastrados.TabIndex = 8;
            this.lbl_Produtos_Cadastrados.Text = "Produtos Cadastrados:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(0, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cadastro de Produtos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(259, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Exclusão de produtos";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 432);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(177, 23);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Tag = "";
            // 
            // txt_buscaparaExclusao
            // 
            this.txt_buscaparaExclusao.Location = new System.Drawing.Point(275, 92);
            this.txt_buscaparaExclusao.Name = "txt_buscaparaExclusao";
            this.txt_buscaparaExclusao.Size = new System.Drawing.Size(177, 20);
            this.txt_buscaparaExclusao.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Digite o índice do produto:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(275, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_maximoProdutos
            // 
            this.lbl_maximoProdutos.AutoSize = true;
            this.lbl_maximoProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maximoProdutos.Location = new System.Drawing.Point(13, 458);
            this.lbl_maximoProdutos.Name = "lbl_maximoProdutos";
            this.lbl_maximoProdutos.Size = new System.Drawing.Size(0, 18);
            this.lbl_maximoProdutos.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(268, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Listagem de itens";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(261, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 30);
            this.button2.TabIndex = 18;
            this.button2.Text = "ATUALIZAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(261, 283);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 82);
            this.listBox1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(594, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Compras";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(568, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(565, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Digite a quantidade do produto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(576, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Digite o ID do produto:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(568, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 20);
            this.textBox2.TabIndex = 22;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_produtoCompra
            // 
            this.lbl_produtoCompra.AutoSize = true;
            this.lbl_produtoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produtoCompra.Location = new System.Drawing.Point(576, 177);
            this.lbl_produtoCompra.Name = "lbl_produtoCompra";
            this.lbl_produtoCompra.Size = new System.Drawing.Size(0, 18);
            this.lbl_produtoCompra.TabIndex = 26;
            // 
            // btn_adicionarCarrinho
            // 
            this.btn_adicionarCarrinho.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionarCarrinho.Location = new System.Drawing.Point(568, 215);
            this.btn_adicionarCarrinho.Name = "btn_adicionarCarrinho";
            this.btn_adicionarCarrinho.Size = new System.Drawing.Size(209, 56);
            this.btn_adicionarCarrinho.TabIndex = 27;
            this.btn_adicionarCarrinho.Text = "ADICIONAR AO CARRINHO";
            this.btn_adicionarCarrinho.UseVisualStyleBackColor = true;
            this.btn_adicionarCarrinho.Click += new System.EventHandler(this.btn_adicionarCarrinho_Click);
            // 
            // lbox_carrinho
            // 
            this.lbox_carrinho.FormattingEnabled = true;
            this.lbox_carrinho.Location = new System.Drawing.Point(568, 282);
            this.lbox_carrinho.Name = "lbox_carrinho";
            this.lbox_carrinho.Size = new System.Drawing.Size(209, 82);
            this.lbox_carrinho.TabIndex = 28;
            this.lbox_carrinho.SelectedIndexChanged += new System.EventHandler(this.lbox_carrinho_SelectedIndexChanged);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(576, 374);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(0, 18);
            this.lbl_Total.TabIndex = 30;
            // 
            // btn_finalizarCompra
            // 
            this.btn_finalizarCompra.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizarCompra.Location = new System.Drawing.Point(568, 396);
            this.btn_finalizarCompra.Name = "btn_finalizarCompra";
            this.btn_finalizarCompra.Size = new System.Drawing.Size(209, 49);
            this.btn_finalizarCompra.TabIndex = 32;
            this.btn_finalizarCompra.Text = "FINALIZAR COMPRA";
            this.btn_finalizarCompra.UseVisualStyleBackColor = true;
            this.btn_finalizarCompra.Click += new System.EventHandler(this.btn_finalizarCompra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 513);
            this.Controls.Add(this.btn_finalizarCompra);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbox_carrinho);
            this.Controls.Add(this.btn_adicionarCarrinho);
            this.Controls.Add(this.lbl_produtoCompra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_maximoProdutos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_buscaparaExclusao);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Produtos_Cadastrados);
            this.Controls.Add(this.lbl_Cadastro);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Preco);
            this.Controls.Add(this.txt_Quantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.TextBox txt_Preco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Label lbl_Cadastro;
        private System.Windows.Forms.Label lbl_Produtos_Cadastrados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txt_buscaparaExclusao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_maximoProdutos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_produtoCompra;
        private System.Windows.Forms.Button btn_adicionarCarrinho;
        private System.Windows.Forms.ListBox lbox_carrinho;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Button btn_finalizarCompra;
    }
}

