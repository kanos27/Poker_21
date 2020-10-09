using System;
using System.Collections.Generic;

namespace VsProjectPoker21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public class Jeu
        {
            public class Carte
            {
                static string name = "";
                static int value;
            }

            public class Banque
            {
                public List<Carte> deck;

            }
            
            public class Mains
            {
                public List<Carte> main;
                public int valMain;
            }

            public void Initialisation()
            {
                string hauteur = "";
                string couleur = "";
                for (int i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 0:
                            couleur = "pique";
                            break;
                        case 1:
                            couleur = "carreau";
                            break;
                        case 2:
                            couleur = "coeur";
                            break;
                        case 3:
                            couleur = "trefle";
                            break;
                    }
                    
                    for (int num = 1; num < 14; num++) // attention remettre en place pour l'as
                    {
                        if (num < 11)
                        {
                            hauteur = num.ToString();
                            //cree la carte avec valeur num et nom (hauteur + " de " + couleur)
                        }
                        else
                        {
                            switch (num)
                            {
                                case 11:
                                    hauteur = "valet";
                                    break;
                                case 12:
                                    hauteur = "dame";
                                    break;
                                case 13:
                                    hauteur = "roi";
                                    break;
                            }
                            //cree la carte avec valeur dix et nom (hauteur + " de " + couleur) 
                        }
                        
                    }
                }
            }

            public void debutDePartie()
            {
                //deux cartes sont piochées pour le joueur, et une pour la banque
                //mise à jour du total de point des mains ?
            }

            public void pioche(Mains mainADistribuer)
            {
                //prend du deck une carte au hasard et la donne à la main
                //faire attention à si l'as est pioché
                //mise à jour du total de point de la main ?
            }

            public void finDePartie()
            {
                //récupération des cartes dans les mains
                //remise à zéro du total de point de carte des mains
                //ajout d'un score si mis en place
            }

            public void jeuDeLaBanque()
            {
                //distribution() de cartes jusqu'à ce que la valeur totale atteingne 16
            }
        }
        
    }
}
