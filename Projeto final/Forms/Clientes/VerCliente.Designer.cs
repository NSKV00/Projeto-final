//namespace Projeto_final.Forms.Clientes
//{
//    partial class VerCliente
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Text = "VerCliente";
//        }

//        #endregion
//    }
//}
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Projeto_final.Forms.Clientes
{
    partial class VerCliente
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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            dataGridViewClientes = new DataGridView();
            btnCarregarClientes = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LawnGreen;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 158);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(281, 44);
            label2.Name = "label2";
            label2.Size = new Size(207, 65);
            label2.TabIndex = 1;
            label2.Text = "Clientes";
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClientes.ColumnHeadersHeight = 34;
            dataGridViewClientes.Location = new Point(1, 148);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersWidth = 62;
            dataGridViewClientes.Size = new Size(799, 307);
            dataGridViewClientes.TabIndex = 4;
            dataGridViewClientes.CellContentClick += dataGridViewClientes_CellContentClick;
            // 
            // btnCarregarClientes
            // 
            btnCarregarClientes.Anchor = AnchorStyles.None;
            btnCarregarClientes.BackColor = SystemColors.Control;
            btnCarregarClientes.Location = new Point(282, 386);
            btnCarregarClientes.Name = "btnCarregarClientes";
            btnCarregarClientes.Size = new Size(222, 34);
            btnCarregarClientes.TabIndex = 3;
            btnCarregarClientes.Text = "listar clientes";
            btnCarregarClientes.UseVisualStyleBackColor = false;
            btnCarregarClientes.Click += btnCarregarClientes_Click;
            // 
            // FormListagemDeClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCarregarClientes);
            Controls.Add(dataGridViewClientes);
            Controls.Add(panel1);
            Name = "FormListagemDeClientes";
            Text = "FormListagemDeClientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dataGridViewClientes;
        private Button btnCarregarClientes;
        private Label label2;
    }
}