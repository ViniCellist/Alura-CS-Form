
namespace WinFormsApp1
{
    partial class Frm_HelloWorld
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
            lbl_Titulo = new Label();
            Btn_Sair = new Button();
            Btn_Modifica = new Button();
            Txt_ConteudoLabel = new TextBox();
            SuspendLayout();
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Titulo.Location = new Point(19, 13);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(182, 17);
            lbl_Titulo.TabIndex = 0;
            lbl_Titulo.Text = "Visual Studio .NET Version";
            // 
            // Btn_Sair
            // 
            Btn_Sair.Location = new Point(575, 415);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(213, 23);
            Btn_Sair.TabIndex = 1;
            Btn_Sair.Text = "Fechar a Aplicação";
            Btn_Sair.UseVisualStyleBackColor = true;
            Btn_Sair.Click += Btn_Sair_Click;
            // 
            // Btn_Modifica
            // 
            Btn_Modifica.Location = new Point(23, 33);
            Btn_Modifica.Name = "Btn_Modifica";
            Btn_Modifica.Size = new Size(178, 23);
            Btn_Modifica.TabIndex = 2;
            Btn_Modifica.Text = "Modifica Texto do Label";
            Btn_Modifica.UseVisualStyleBackColor = true;
            Btn_Modifica.Click += button1_Click;
            // 
            // Txt_ConteudoLabel
            // 
            Txt_ConteudoLabel.Location = new Point(22, 78);
            Txt_ConteudoLabel.Name = "Txt_ConteudoLabel";
            Txt_ConteudoLabel.Size = new Size(417, 23);
            Txt_ConteudoLabel.TabIndex = 3;
            // 
            // Frm_HelloWorld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Txt_ConteudoLabel);
            Controls.Add(Btn_Modifica);
            Controls.Add(Btn_Sair);
            Controls.Add(lbl_Titulo);
            Name = "Frm_HelloWorld";
            Text = "Hello World";
            Load += Form1_Load;
            Click += Frm_HelloWorld_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Frm_HelloWorld_Click(object sender, EventArgs e)
        {
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private Label lbl_Titulo;
        private Button Btn_Sair;
        private Button Btn_Modifica;
        private TextBox Txt_ConteudoLabel;
    }
}
