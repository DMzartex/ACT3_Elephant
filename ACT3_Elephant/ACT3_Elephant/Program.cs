using System;

namespace ACT3_Elephant
{
    internal class Program
    {
        public static string triElephant(Elephant[] troupe)
        {
            uint tailleResult = troupe[0].TailleOreilles;
            string nom = troupe[0].Nom;


            for (int i = 0; i < troupe.Length; i++)
            {

                if (troupe[i].TailleOreilles > tailleResult)
                {
                    tailleResult = troupe[i].TailleOreilles;
                    nom = troupe[i].Nom;
                }

            }

            return "L'éléphant qui a les plus grandes oreilles est : " + nom + " avec " + tailleResult + " cm";
        }

        static void Main(string[] args)
        {
            int choixMenu;
            string continu = "Y";
            Functions mesFunction = new Functions();
            Elephant zazou = new Elephant("Zazou", 15);
            Elephant Titi = new Elephant("Titi", 22);

            Elephant[] troupeElephants = new Elephant[7];
            troupeElephants[0] = new Elephant("grilou", 154);
            troupeElephants[1] = new Elephant("soufi", 152);
            troupeElephants[2] = new Elephant("theri", 15);
            troupeElephants[3] = new Elephant("jumbo", 252);
            troupeElephants[4] = new Elephant("file", 150);
            troupeElephants[5] = new Elephant("doub", 151);
            troupeElephants[6] = new Elephant("dodi", 269);

            Console.WriteLine("Le cirque des éléphants");
            Console.WriteLine("Tapez :");
            Console.WriteLine("1 pour afficher les informations de Zazou");
            Console.WriteLine("2 pour Titi");
            Console.WriteLine("3 pour les échanger");
            Console.WriteLine("4 pour voir le transfert d'un message de Zazou à Titi");
            Console.WriteLine("5 pour réviser la notion de tableaux et l'appliquer à des objets");

            while (continu == "Y")
            {
                if (int.TryParse(Console.ReadLine(), out choixMenu) && choixMenu <= 6) {}
                switch (choixMenu)
                {
                    case 1:
                        Console.WriteLine(zazou.AfficheQuiJeSuis());
                        break;
                    case 2:
                        Console.WriteLine(Titi.AfficheQuiJeSuis());
                        break;
                    case 3:
                        string nomReplace = Titi.Nom;
                        Titi.Nom = zazou.Nom;
                        zazou.Nom = nomReplace;
                        uint tailleReplace = Titi.TailleOreilles;
                        Titi.TailleOreilles = zazou.TailleOreilles;
                        zazou.TailleOreilles = tailleReplace;
                        Console.WriteLine("Zazou :\n" + zazou.AfficheQuiJeSuis());
                        Console.WriteLine("Titi :\n" + Titi.AfficheQuiJeSuis());
                        break;
                    case 4:
                        zazou.EnvoiMessage("Coucou titi !", Titi);
                        break;
                    case 5:
                        Console.WriteLine(triElephant(troupeElephants));
                        Console.WriteLine("Voulez vous recommencer Y:oui / N: non !");
                        continu = Console.ReadLine();
                        break;

                }

            }


            Console.ReadLine();
        }
    }
}
