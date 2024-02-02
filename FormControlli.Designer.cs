namespace GaraSSCuadre
{
    partial class FormControlli
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
            buttonStart = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxPAdd = new TextBox();
            textBoxSAdd = new TextBox();
            textBoxSoluzione = new TextBox();
            label3 = new Label();
            buttonSoluzione = new Button();
            buttonJolly = new Button();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(364, 28);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 213);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 1;
            label1.Text = "Numero problema";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 171);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 2;
            label2.Text = "Numero squadra";
            // 
            // textBoxPAdd
            // 
            textBoxPAdd.Location = new Point(407, 213);
            textBoxPAdd.Name = "textBoxPAdd";
            textBoxPAdd.Size = new Size(125, 27);
            textBoxPAdd.TabIndex = 3;
            // 
            // textBoxSAdd
            // 
            textBoxSAdd.Location = new Point(407, 171);
            textBoxSAdd.Name = "textBoxSAdd";
            textBoxSAdd.Size = new Size(125, 27);
            textBoxSAdd.TabIndex = 4;
            // 
            // textBoxSoluzione
            // 
            textBoxSoluzione.Location = new Point(407, 257);
            textBoxSoluzione.Name = "textBoxSoluzione";
            textBoxSoluzione.Size = new Size(125, 27);
            textBoxSoluzione.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 260);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 5;
            label3.Text = "Soluzione";
            // 
            // buttonSoluzione
            // 
            buttonSoluzione.Location = new Point(133, 323);
            buttonSoluzione.Name = "buttonSoluzione";
            buttonSoluzione.Size = new Size(258, 51);
            buttonSoluzione.TabIndex = 7;
            buttonSoluzione.Text = "Aggiungi soluzione";
            buttonSoluzione.UseVisualStyleBackColor = true;
            buttonSoluzione.Click += buttonSoluzione_Click;
            // 
            // buttonJolly
            // 
            buttonJolly.Location = new Point(453, 323);
            buttonJolly.Name = "buttonJolly";
            buttonJolly.Size = new Size(258, 51);
            buttonJolly.TabIndex = 8;
            buttonJolly.Text = "Aggiungi jolly";
            buttonJolly.UseVisualStyleBackColor = true;
            buttonJolly.Click += buttonJolly_Click;
            // 
            // FormControlli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonJolly);
            Controls.Add(buttonSoluzione);
            Controls.Add(textBoxSoluzione);
            Controls.Add(label3);
            Controls.Add(textBoxSAdd);
            Controls.Add(textBoxPAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonStart);
            Name = "FormControlli";
            Text = "FormControlli";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Label label1;
        private Label label2;
        private TextBox textBoxPAdd;
        private TextBox textBoxSAdd;
        private TextBox textBoxSoluzione;
        private Label label3;
        private Button buttonSoluzione;
        private Button buttonJolly;
    }
}