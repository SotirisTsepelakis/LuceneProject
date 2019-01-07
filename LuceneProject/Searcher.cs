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
using Lucene.Net.Index;

namespace LuceneProject
{
    public class Searcher
    {
        public void Search(string query)
        {
            string indexDir = "Index";

            using (Directory dir = FSDirectory.Open(indexDir))
            using (IndexSearcher searcher = new IndexSearcher(dir))
            {
                string query2="";
                char[] chars = query.ToCharArray();

                string[] splitted;
                Term term;
                WildcardQuery wc_q;
                BooleanQuery bool_q = new BooleanQuery();

                //check if more than 1 keywords are inserted
                if (query2.Split(' ').Length>1)
                {
                    splitted = query2.Split(' ');

                    for (int z=0;z<splitted.Length;z++)
                    {
                        term = new Term("Content", "*" + splitted[z] + "*");
                        wc_q = new WildcardQuery(term);
                        bool_q.Add(wc_q, Occur.SHOULD);
                    }
                }
                else
                {
                    term = new Term("Content", "*" + query2 + "*");
                    wc_q = new WildcardQuery(term);
                    bool_q.Add(wc_q, Occur.MUST);
                }

                TopDocs hits = searcher.Search(bool_q, 10);

                Console.WriteLine("Found " + hits.TotalHits + " documents matched query '" + bool_q + "':");

                foreach (ScoreDoc d in hits.ScoreDocs)
                {
                    Document doc = searcher.Doc(d.Doc);
                    Console.WriteLine(doc.Get("filename"));
                }
            }
        }
    }
}
