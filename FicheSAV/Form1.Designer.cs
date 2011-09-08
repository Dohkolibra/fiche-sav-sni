namespace FicheSAV
{
    partial class NouveauType
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
            this.label3 = new System.Windows.Forms.Label();
            this.Materiel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.verifier = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Label();
            this.non = new System.Windows.Forms.Button();
            this.oui = new System.Windows.Forms.Button();
            this.reponseVerif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ajout d\'un nouveau type de matériel";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Materiel
            // 
            this.Materiel.Location = new System.Drawing.Point(107, 66);
            this.Materiel.Name = "Materiel";
            this.Materiel.Size = new System.Drawing.Size(223, 20);
            this.Materiel.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nom du matériel :";
            // 
            // verifier
            // 
            this.verifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.verifier.Location = new System.Drawing.Point(139, 102);
            this.verifier.Name = "verifier";
            this.verifier.Size = new System.Drawing.Size(75, 23);
            this.verifier.TabIndex = 16;
            this.verifier.Text = "Vérifier";
            this.verifier.UseVisualStyleBackColor = true;
            this.verifier.Click += new System.EventHandler(this.verifier_Click);
            // 
            // question
            // 
            this.question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.question.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.ForeColor = System.Drawing.Color.Green;
            this.question.Location = new System.Drawing.Point(4, 185);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(345, 30);
            this.question.TabIndex = 20;
            this.question.Text = "Voulez vous l\'ajouter ?";
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // non
            // 
            this.non.Location = new System.Drawing.Point(220, 223);
            this.non.Name = "non";
            this.non.Size = new System.Drawing.Size(75, 23);
            this.non.TabIndex = 19;
            this.non.Text = "Non";
            this.non.UseVisualStyleBackColor = true;
            this.non.Click += new System.EventHandler(this.non_Click);
            // 
            // oui
            // 
            this.oui.Location = new System.Drawing.Point(52, 223);
            this.oui.Name = "oui";
            this.oui.Size = new System.Drawing.Size(75, 23);
            this.oui.TabIndex = 18;
            this.oui.Text = "Oui";
            this.oui.UseVisualStyleBackColor = true;
            this.oui.Click += new System.EventHandler(this.oui_Click);
            // 
            // reponseVerif
            // 
            this.reponseVerif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.reponseVerif.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponseVerif.Location = new System.Drawing.Point(3, 147);
            this.reponseVerif.Name = "reponseVerif";
            this.reponseVerif.Size = new System.Drawing.Size(345, 30);
            this.reponseVerif.TabIndex = 17;
            this.reponseVerif.Text = "texte de vérification";
            this.reponseVerif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NouveauType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 341);
            this.Controls.Add(this.question);
            this.Controls.Add(this.non);
            this.Controls.Add(this.oui);
            this.Controls.Add(this.reponseVerif);
            this.Controls.Add(this.verifier);
            this.Controls.Add(this.Materiel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "NouveauType";
            this.Text = "Nouveau type de matériel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Materiel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button verifier;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button non;
        private System.Windows.Forms.Button oui;
        private System.Windows.Forms.Label reponseVerif;
    }
}