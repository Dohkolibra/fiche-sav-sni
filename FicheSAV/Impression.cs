using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;

namespace FicheSAV
{
    class Impression
    {
        Fiche fiche = null;


        public Impression(Fiche f)
        {
            fiche = f;
        }

        public void Imprimer()
        {
            PrintDocument pd = new PrintDocument();

            // On définit un évènement qui sera déclenché juste avant l'impression afin d'obtenir un dessin.
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);

            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = pd;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Pour lancer l'impression, il suffit d'appeller la méthode suivante  
                pd.Print();
            }
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("PaperA4", 840, 1180);
            Graphics dc = e.Graphics;

            //dessine la marge de la feuille
            dc.DrawRectangle(new Pen(Color.Black, 0.5F), new Rectangle(6, 9, 773, 1120));

            //dessine les infos de la fiche
            dc.DrawImage(Image.FromFile("Resources/Logo.png"), new Rectangle(new Point(13, 13), new Size(76, 76)));
            dc.DrawString("Fiche SAV n° : " + fiche.numFiche, new Font("Arial", 15, FontStyle.Bold), new SolidBrush(Color.Black), new Point(350, 40));

            dc.DrawString("Date de dépôt : ", new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), new Point(10, 100));
            dc.DrawString(fiche.dateDepot, new Font("Arial", 9), new SolidBrush(Color.Black), new Point(150, 100));

            dc.DrawString("Client : ", new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), new Point(10, 130));
            dc.DrawString(fiche.client.nomClient, new Font("Arial", 9), new SolidBrush(Color.Black), new Point(150, 130));

            dc.DrawString("Tel : ", new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), new Point(10, 150));
            dc.DrawString(fiche.client.tel1Client + "       " + fiche.client.tel2Client, new Font("Arial", 9), new SolidBrush(Color.Black), new Point(150, 150));

            dc.DrawString("Adresse : ", new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), new Point(10, 170));
            dc.DrawString(fiche.client.adresseClient + " " + fiche.client.cpClient + " " + fiche.client.villeClient, new Font("Arial", 9), new SolidBrush(Color.Black), new Point(150, 170));

            dc.DrawLine(new Pen(Color.Black), new Point(6, 208), new Point(775, 208));

            dc.DrawString("Matériel : ", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), new Point(10, 210));
            dc.DrawString(fiche.materiel.type + " " + fiche.materiel.marque + " " + fiche.materiel.modele, new Font("Arial", 9), new SolidBrush(Color.Black), new Point(150, 210));

            dc.DrawString("Accessoires : ", new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), new Point(10, 230));
            dc.DrawString(fiche.accessoire, new Font("Arial", 9), new SolidBrush(Color.Black), new Point(150, 230));

            dc.DrawString("Mot de passe : ", new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), new Point(500, 210));
            dc.DrawString(fiche.pass, new Font("Arial", 9), new SolidBrush(Color.Black), new Point(650, 210));

            dc.DrawLine(new Pen(Color.Black), new Point(6, 248), new Point(775, 248));

            dc.DrawString("Decriptif panne : ", new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), new Point(10, 250));
            RectangleF rectF1 = new RectangleF(10, 270, 785, 80);
            dc.DrawString(fiche.panneMateriel, new Font("Arial", 9), Brushes.Black, rectF1);

            dc.DrawLine(new Pen(Color.Black), new Point(6, 358), new Point(775, 358));

            dc.DrawString("Travaux effectués :", new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), new Point(10, 360));
            RectangleF rectF2 = new RectangleF(10, 380, 765, 200);
            dc.DrawString(fiche.travaux, new Font("Arial", 9), Brushes.Black, rectF2);

            dc.DrawLine(new Pen(Color.Black), new Point(10, 530), new Point(820, 530));
            dc.DrawString("Les matériels qui nous sont confiés sont couvert par notre assurance. En cas de problème, nous ne serions être tenu pour responsable\nau-delà des garanties que nous avons contractées.\nLes fabricants des supports numériques ne garantissent pas la stabilités des données sur leur produit et conseillent l'utilisation\nd'un système de sauvegarde régulier. Nous déclinons toute resposabilité en cas de perte totale ou partielle des données qui nous sont confiées.", new Font("Arial", 7), new SolidBrush(Color.Black), new Point(10, 540));
            dc.DrawLine(new Pen(Color.Black), new Point(10, 590), new Point(820, 590));

            dc.DrawString("Signature du client :", new Font("Arial", 9), Brushes.Black, new Point(15, 600));
            dc.DrawString("Matériel repris le :", new Font("Arial", 9), Brushes.Black, new Point(400, 600));
            dc.DrawString("Réparé  -  Non réparé  -  Cédé  ", new Font("Arial", 9), Brushes.Black, new Point(400, 620));
            dc.DrawString("Signature du client :", new Font("Arial", 9), Brushes.Black, new Point(400, 640));


            //bordereau machine
            dc.DrawLine(new Pen(Color.Black), new Point(10, 690), new Point(780, 690));
            Rectangle rect = new Rectangle(10, 695, 100, 35);
            dc.DrawRectangle(new Pen(Color.Black, 0.5F), rect);
            Rectangle rect1 = new Rectangle(110, 695, 420, 35);
            dc.DrawRectangle(new Pen(Color.Black, 0.5F), rect1);
            Rectangle rect2 = new Rectangle(530, 695, 245, 35);
            dc.DrawRectangle(new Pen(Color.Black, 0.5F), rect2);
            dc.DrawString("n° : " + fiche.numFiche, new Font("Arial", 12, FontStyle.Bold), new SolidBrush(Color.Black), new Point(10, 700));
            dc.DrawString(fiche.client.nomClient, new Font("Arial", 12), new SolidBrush(Color.Black), new Point(110, 700));
            dc.DrawString(fiche.materiel.type + " " + fiche.materiel.marque + " " + fiche.materiel.modele, new Font("Arial", 12), new SolidBrush(Color.Black), new Point(530, 700));
            dc.DrawLine(new Pen(Color.Black), new Point(10, 745), new Point(780, 745));

            //partie client
            dc.DrawImage(Image.FromFile("Resources/Logo.png"), new Rectangle(new Point(13, 760), new Size(76, 76)));
            dc.DrawString("Sud-Nivernais Informatique", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Black), new Point(330, 760));
            dc.DrawString("17, boulevard Voltaire - 58300 decize", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Black), new Point(290, 780));
            dc.DrawString("Tel : 03 86 77 13 38 - sni@sninfo.fr", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Black), new Point(300, 800));
            dc.DrawString("Preuve de dépôt matériel pour réparation / entretien", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), new Point(200, 830));
            dc.DrawString("Fiche n°" + fiche.numFiche, new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), new Point(350, 850));
            dc.DrawString("Les matériels qui nous sont confiés sont couvert par notre assurance. En cas de problème, nous ne serions être tenu pour responsable\nau-delà des garanties que nous avons contractées.\nLes fabricants des supports numériques ne garantissent pas la stabilité des données sur leur produit et conseillent l'utilisation\nd'un système de sauvegarde régulier. Nous déclinons toute resposabilité en cas de perte totale ou partielle des donnéesqui nous sont confiées.", new Font("Arial", 7), new SolidBrush(Color.Black), new Point(10, 890));

            rect = new Rectangle(10, 940, 150, 30);
            dc.DrawRectangle(new Pen(Color.Black, 0.5F), rect);
            dc.DrawString("Date de dépôt : ", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), new Point(10, 945));
            rect = new Rectangle(160, 940, 150, 30);
            dc.DrawRectangle(new Pen(Color.Black, 0.5F), rect);
            dc.DrawString(fiche.dateDepot, new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Black), new Point(160, 945));

            rect = new Rectangle(10, 990, 150, 30);
            dc.DrawRectangle(new Pen(Color.Black, 0.5F), rect);
            dc.DrawString("Matériel : ", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), new Point(10, 995));
            rect = new Rectangle(160, 990, 615, 30);
            dc.DrawRectangle(new Pen(Color.Black, 0.5F), rect);
            dc.DrawString(fiche.materiel.type + " " + fiche.materiel.marque + " " + fiche.materiel.modele, new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Black), new Point(160, 995));

            rect = new Rectangle(10, 1020, 150, 30);
            dc.DrawRectangle(new Pen(Color.Black, 0.5F), rect);
            dc.DrawString("Accessoires : ", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), new Point(10, 1025));
            rect = new Rectangle(160, 1020, 615, 30);
            dc.DrawRectangle(new Pen(Color.Black, 0.5F), rect);
            dc.DrawString(fiche.accessoire, new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Black), new Point(160, 1025));

            rect = new Rectangle(10, 1050, 150, 70);
            dc.DrawRectangle(new Pen(Color.Black, 0.5F), rect);
            dc.DrawString("Panne : ", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), new Point(10, 1080));
            rect = new Rectangle(160, 1050, 615, 70);
            rectF1 = new RectangleF(160, 1050, 620, 70);
            dc.DrawRectangle(new Pen(Color.Black, 0.5F), rect);
            dc.DrawString(fiche.panneMateriel, new Font("Arial", 9, FontStyle.Regular), new SolidBrush(Color.Black), rectF1);
        }


    }
}
