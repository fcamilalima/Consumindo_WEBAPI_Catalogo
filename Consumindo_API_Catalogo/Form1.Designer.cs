
namespace Consumindo_API_Catalogo
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            txtURI = new TextBox();
            btnAutenticar = new Button();
            dgvDados = new DataGridView();
            btnObterProdutos = new Button();
            btnProdutosPorId = new Button();
            btnIncluirProduto = new Button();
            btnAtualizarProduto = new Button();
            btnDeletarProdutos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 40);
            label1.Name = "label1";
            label1.Size = new Size(174, 26);
            label1.TabIndex = 0;
            label1.Text = "URI - Web API : ";
            label1.Click += label1_Click;
            // 
            // txtURI
            // 
            txtURI.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtURI.Location = new Point(193, 37);
            txtURI.Name = "txtURI";
            txtURI.Size = new Size(813, 28);
            txtURI.TabIndex = 1;
            txtURI.Text = "http://localhost:7300/api/v1/Produtos/";
            // 
            // btnAutenticar
            // 
            btnAutenticar.BackColor = Color.RoyalBlue;
            btnAutenticar.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutenticar.ForeColor = SystemColors.ActiveCaptionText;
            btnAutenticar.Location = new Point(1027, 27);
            btnAutenticar.Name = "btnAutenticar";
            btnAutenticar.Padding = new Padding(4);
            btnAutenticar.Size = new Size(204, 46);
            btnAutenticar.TabIndex = 2;
            btnAutenticar.Text = "Autenticar";
            btnAutenticar.UseVisualStyleBackColor = false;
            btnAutenticar.Click += btnAutenticar_Click;
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvDados.DefaultCellStyle = dataGridViewCellStyle1;
            dgvDados.Location = new Point(32, 102);
            dgvDados.Name = "dgvDados";
            dgvDados.RowHeadersWidth = 62;
            dgvDados.Size = new Size(1200, 423);
            dgvDados.TabIndex = 3;
            // 
            // btnObterProdutos
            // 
            btnObterProdutos.BackColor = Color.DeepSkyBlue;
            btnObterProdutos.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObterProdutos.ForeColor = SystemColors.ActiveCaptionText;
            btnObterProdutos.Location = new Point(32, 551);
            btnObterProdutos.Name = "btnObterProdutos";
            btnObterProdutos.Padding = new Padding(4);
            btnObterProdutos.Size = new Size(223, 112);
            btnObterProdutos.TabIndex = 4;
            btnObterProdutos.Text = "Retornar Produtos";
            btnObterProdutos.UseVisualStyleBackColor = false;
            btnObterProdutos.Click += btnObterProdutos_Click;
            // 
            // btnProdutosPorId
            // 
            btnProdutosPorId.BackColor = Color.SlateGray;
            btnProdutosPorId.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProdutosPorId.ForeColor = SystemColors.ActiveCaptionText;
            btnProdutosPorId.Location = new Point(276, 551);
            btnProdutosPorId.Name = "btnProdutosPorId";
            btnProdutosPorId.Padding = new Padding(4);
            btnProdutosPorId.Size = new Size(223, 112);
            btnProdutosPorId.TabIndex = 5;
            btnProdutosPorId.Text = "Obter Produto Por ID";
            btnProdutosPorId.UseVisualStyleBackColor = false;
            // 
            // btnIncluirProduto
            // 
            btnIncluirProduto.BackColor = Color.DeepSkyBlue;
            btnIncluirProduto.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIncluirProduto.ForeColor = SystemColors.ActiveCaptionText;
            btnIncluirProduto.Location = new Point(520, 551);
            btnIncluirProduto.Name = "btnIncluirProduto";
            btnIncluirProduto.Padding = new Padding(4);
            btnIncluirProduto.Size = new Size(223, 112);
            btnIncluirProduto.TabIndex = 6;
            btnIncluirProduto.Text = "Incluir Produto";
            btnIncluirProduto.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarProduto
            // 
            btnAtualizarProduto.BackColor = Color.SlateGray;
            btnAtualizarProduto.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtualizarProduto.ForeColor = SystemColors.ActiveCaptionText;
            btnAtualizarProduto.Location = new Point(764, 551);
            btnAtualizarProduto.Name = "btnAtualizarProduto";
            btnAtualizarProduto.Padding = new Padding(4);
            btnAtualizarProduto.Size = new Size(223, 112);
            btnAtualizarProduto.TabIndex = 7;
            btnAtualizarProduto.Text = "Atualizar Produto";
            btnAtualizarProduto.UseVisualStyleBackColor = false;
            btnAtualizarProduto.Click += button4_Click;
            // 
            // btnDeletarProdutos
            // 
            btnDeletarProdutos.BackColor = Color.DeepSkyBlue;
            btnDeletarProdutos.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeletarProdutos.ForeColor = SystemColors.ActiveCaptionText;
            btnDeletarProdutos.Location = new Point(1008, 551);
            btnDeletarProdutos.Name = "btnDeletarProdutos";
            btnDeletarProdutos.Padding = new Padding(4);
            btnDeletarProdutos.Size = new Size(223, 112);
            btnDeletarProdutos.TabIndex = 8;
            btnDeletarProdutos.Text = "Deletar Produtos";
            btnDeletarProdutos.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 691);
            Controls.Add(btnDeletarProdutos);
            Controls.Add(btnAtualizarProduto);
            Controls.Add(btnIncluirProduto);
            Controls.Add(btnProdutosPorId);
            Controls.Add(btnObterProdutos);
            Controls.Add(dgvDados);
            Controls.Add(btnAutenticar);
            Controls.Add(txtURI);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Consumindo a WEB API";
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        private Label label1;
        private TextBox txtURI;
        private Button btnAutenticar;
        private DataGridView dgvDados;
        private Button btnObterProdutos;
        private Button btnProdutosPorId;
        private Button btnIncluirProduto;
        private Button btnAtualizarProduto;
        private Button btnDeletarProdutos;
    }
}
