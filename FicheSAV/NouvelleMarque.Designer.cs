namespace FicheSAV
{
    partial class NouvelleMarque
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Marque = new System.Windows.Forms.TextBox();
            this.verifier = new System.Windows.Forms.Button();
            this.reponseVerif = new System.Windows.Forms.Label();
            this.oui = new System.Windows.Forms.Button();
            this.non = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout d\'une nouvelle marque";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de la marque : ";
            // 
            // Marque
            // 
            this.Marque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Marque.Location = new System.Drawing.Point(135, 72);
            this.Marque.Name = "Marque";
            this.Marque.Size = new System.Drawing.Size(205, 20);
            this.Marque.TabIndex = 2;
            // 
            // verifier
            // 
            this.verifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.verifier.Location = new System.Drawing.Point(146, 121);
            this.verifier.Name = "verifier";
            this.verifier.Size = new System.Drawing.Size(75, 23);
            this.verifier.TabIndex = 3;
            this.verifier.Text = "Vérifier";
            this.verifier.UseVisualStyleBackColor = true;
            this.verifier.Click += new System.EventHandler(this.verifier_Click);
            // 
            // reponseVerif
            // 
            this.reponseVerif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.reponseVerif.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponseVerif.Location = new System.Drawing.Point(10, 166);
            this.reponseVerif.Name = "reponseVerif";
            this.reponseVerif.Size = new System.Drawing.Size(345, 30);
            this.reponseVerif.TabIndex = 4;
            this.reponseVerif.Text = "texte de vérification";
            this.reponseVerif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oui
            // 
            this.oui.Location = new System.Drawing.Point(59, 242);
            this.oui.Name = "oui";
            this.oui.Size = new System.Drawing.Size(75, 23);
            this.oui.TabIndex = 5;
            this.oui.Text = "Oui";
            this.oui.UseVisualStyleBackColor = true;
            this.oui.Click += new System.EventHandler(this.oui_Click);
            // 
            // non
            // 
            this.non.Location = new System.Drawing.Point(227, 242);
            this.non.Name = "non";
            this.non.Size = new System.Drawing.Size(75, 23);
            this.non.TabIndex = 6;
            this.non.Text = "Non";
            this.non.UseVisualStyleBackColor = true;
            this.non.Click += new System.EventHandler(this.non_Click);
            // 
            // question
            // 
            this.question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.question.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.ForeColor = System.Drawing.Color.Green;
            this.question.Location = new System.Drawing.Point(11, 204);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(345, 30);
            this.question.TabIndex = 7;
            this.question.Text = "Voulez vous l\'ajouter ?";
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NouvelleMarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 370);
            this.Controls.Add(this.question);
            this.Controls.Add(this.non);
            this.Controls.Add(this.oui);
            this.Controls.Add(this.reponseVerif);
            this.Controls.Add(this.verifier);
            this.Controls.Add(this.Marque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(383, 408);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(383, 408);
            this.Name = "NouvelleMarque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout d\'une marque";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Marque;
        private System.Windows.Forms.Button verifier;
        private System.Windows.Forms.Label reponseVerif;
        private System.Windows.Forms.Button oui;
        private System.Windows.Forms.Button non;
        private System.Windows.Forms.Label question;
    }
}