using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;


namespace Exercice.Net_Atelier1
{
    public class TelechargerFichier
    {
        
        public  async Task téléchargement(string url, string fileName)
        {
            using (var web = new WebClient())
            {
                await web.DownloadFileTaskAsync(url, fileName);
            }
        }
    }
}