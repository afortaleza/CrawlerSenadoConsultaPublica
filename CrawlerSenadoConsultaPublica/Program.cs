using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using CsQuery;

namespace CrawlerSenadoConsultaPublica
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer t = new Timer(ConsultarWebsite, null, 0, 60000);
            Console.WriteLine("Pressione qualquer tecla para parar a leitura...");
            Console.Read();
        }

        private static void ConsultarWebsite(Object o)
        {
            var id = "119431";
            var url = string.Format("https://www12.senado.leg.br/ecidadania/visualizacaomateria?id={0}", 119431);
            var dom = CQ.CreateFromUrl(url);

            var selection = dom.Select(".bloco-result-votos").Filter("span");

            var aFavor = dom.Select(".bloco-result-votos > span")[0].InnerHTML;
            var contra = dom.Select(".bloco-result-votos > span")[1].InnerHTML;
            var contabilizacao = HttpUtility.HtmlDecode(dom.Select("#msg-contabilizacao-voto").Html());

            var dataAtual = DateTime.Now;
            var textoLinha = string.Format("[{0}]\t{1}\t{2}\t{3}", dataAtual.ToString("s"), aFavor, contra, contabilizacao);
            Console.WriteLine("Escrevendo {0}", textoLinha);
            File.AppendAllText(string.Format("ConsultaPublica{0}.txt", id), textoLinha + Environment.NewLine);
        }
    }
}
