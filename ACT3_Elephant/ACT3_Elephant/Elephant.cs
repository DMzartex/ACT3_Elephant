using System;
using System.Collections.Generic;
using System.Text;

namespace ACT3_Elephant
{
    internal class Elephant
    {
		private string _nom;
		public  string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}

		private uint _TailleOreilles;

		public  uint TailleOreilles
		{
			get { return _TailleOreilles; }
			set { _TailleOreilles = value; }
		}

		public Elephant(string nom,uint tailleOreilles)
		{
			_nom = nom;
			_TailleOreilles = tailleOreilles;
		}

		public string AfficheQuiJeSuis()
		{
			return "Je m'appelle " + Nom + " mes oreilles mesurent " + TailleOreilles + " cm";
		}

		public void EcouteMessage(string message, Elephant QuiDit)
		{
			Console.WriteLine(Nom + " a entendu un message \n" + QuiDit.Nom + " a dit : " + message);
		}

		public void EnvoiMessage(string message, Elephant QuiRecoit)
		{
			QuiRecoit.EcouteMessage(message, this);
		}

	
	}
}
