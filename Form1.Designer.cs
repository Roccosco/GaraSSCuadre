namespace GaraSSCuadre
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
            labelTempo = new Label();
            tabellone = new Panel();
            SuspendLayout();
            // 
            // labelTempo
            // 
            labelTempo.AutoSize = true;
            labelTempo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTempo.Location = new Point(713, 22);
            labelTempo.Name = "labelTempo";
            labelTempo.Size = new Size(65, 28);
            labelTempo.TabIndex = 0;
            labelTempo.Text = "label1";
            // 
            // tabellone
            // 
            tabellone.BorderStyle = BorderStyle.FixedSingle;
            tabellone.Location = new Point(38, 65);
            tabellone.Name = "tabellone";
            tabellone.Size = new Size(1419, 590);
            tabellone.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 688);
            Controls.Add(tabellone);
            Controls.Add(labelTempo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTempo;
        private Panel tabellone;
    }
}