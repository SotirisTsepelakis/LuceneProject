using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Store;
using LVersion = Lucene.Net.Util.Version;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuceneProject
{
    public class Searcher
    {
        public void Search(string indexDir, string query)
        {
            using (Directory dir = FSDirectory.Open(indexDir))
            using (IndexSearcher searcher = new IndexSearcher(dir))
            {
                QueryParser parser = new QueryParser(LVersion.LUCENE_30, "content", new StandardAnalyzer(LVersion.LUCENE_30));
                Query q = parser.Parse(query);
                TopDocs hits = searcher.Search(q, 10);

                Console.WriteLine("Found " + hits.TotalHits + " documents matched query '" + query + "':");

                foreach (ScoreDoc d in hits.ScoreDocs)
                {
                    Document doc = searcher.Doc(d.Doc);
                    Console.WriteLine(doc.Get("filename"));
                }
            }
        }
    }
}
