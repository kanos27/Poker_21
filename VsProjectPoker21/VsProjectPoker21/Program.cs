using System;
using System.Collections.Generic;
using System.Linq;

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
            public Banque banque = new Banque();

            public Mains mainJoueur = new Mains();

            public Mains mainBanque = new Mains();

            public Random random = new Random();

            //public Carte carte = new Carte();

            //définit une carte, possèdant une valeur de point et un nom
            public class Carte
            {
                public string name = "";
                public int value = 0;

                public Carte(string cardName, int number)
                {
                    name = cardName;
                    value = number;
                }
                public Carte()
                {

                }
            }

            //classe représentant groupier, distribueur de carte. Possède le deck de jeu
            public class Banque
            {
                public List<Carte> deck;

            }
            
            //classe représentant le jeu de carte possedant chaque joueur.
            public class Mains
            {
                public List<Carte> main;
                public int valMain = 0;
            }

            //A pour but d'inititialiser le deck, en le remplissant d'un jeu de 52 (?) cartes habituelles
            public void Initialisation()
            {
                //Banque banque = new Banque();

                string hauteur = "";
                string couleur = "";
                for (int i = 0; i < 4; i++)
                {
                    //on définit d'abord le signe de la carte, stockée dans la variable couleur
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
                    //on définit ensuite le type de carte du signe, allant de l'as au roi
                    for (int num = 1; num < 14; num++) // attention remettre en place pour l'as
                    {
                        //si la carte est en dessous de valet, sa valeur correspond à sa hauteur
                        if (num < 11)
                        {
                            hauteur = num.ToString();
                            //cree la carte avec valeur num et nom (hauteur + " de " + couleur)
                            banque.deck.Add(new Carte(hauteur + " de " + couleur, num));
                        }
                        else
                        {
                            //dans le cas ou il s'agit d'une tête, on y assigne la valeur 10 et le nom de la tête en tant que hauteur
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
                                default:
                                    break;
                            }
                            //cree la carte avec valeur dix et nom (hauteur + " de " + couleur)
                            
                            banque.deck.Add(new Carte(hauteur + " de " + couleur, num));
                        }

                    }
                }
            }

            public void debutDePartie()
            {
                //deux cartes sont piochées pour le joueur, et une pour la banque
                pioche(mainJoueur);
                pioche(mainJoueur);
                pioche(mainBanque);
                //mise à jour du total de point des mains ?

            }

            public void pioche(Mains mainADistribuer)
            {
                //prend du deck une carte au hasard et la donne à la main
                Carte objectToMove = banque.deck.ElementAt(random.Next(0, mainBanque.main.Count() - 1));
                mainADistribuer.main.Add(objectToMove);
                banque.deck.Remove(objectToMove);
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

            //met à jour le nombre de point total des mains données
            public void MAJPointsMains(Mains mainAMettreAJour)
            {
                for(int i = 0; i < mainAMettreAJour.main.Count() - 1; i++)
                {
                    Carte carteEnCours = mainAMettreAJour.main.ElementAt(i);
                    
                    mainAMettreAJour.valMain += carteEnCours.value;
                    
                }
            }
        }
        
    }
}
