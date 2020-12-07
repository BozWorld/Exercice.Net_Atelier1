using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Exercice.Net_Atelier1
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new TelechargerFichier();
            var nomFichier = "fichier_";
            Console.WriteLine("vos téléchargements sont en cours");
            for (int i = 0; i < args.Length; i++)
            {
                Task.WaitAll((t.téléchargement(args[i],@"C:\Users\mondo\Downloads\"+nomFichier+i)));  
            }
            Console.WriteLine("votre téléchargement est maintenant terminée");
            
        }
        
        
    }
}