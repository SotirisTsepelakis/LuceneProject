using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net;
using Lucene.Net.Store;
using Lucene.Net.Index;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Util;
using LVersion = Lucene.Net.Util.Version;
using Lucene.Net.Documents;

namespace LuceneProject
{
    class Indexer1 : IDisposable
    {

        public String IndexDirectory { get; set; }
        public String DataDirectory { get; set; }

        public Indexer1()
        {
        }

        public void Setup()
        {
            Directory dir = FSDirectory.Open(IndexDirectory);
            writer = new IndexWriter(dir, new StandardAnalyzer(LVersion.LUCENE_30), IndexWriter.MaxFieldLength.UNLIMITED);
        }

        public void Dispose()
        {
            writer.Dispose();
        }

        public int Index()
        {
            String[] files = System.IO.Directory.GetFileSystemEntries(DataDirectory);
            foreach (String name in files)
            {
                IndexFile(name);
            }
            return writer.NumDocs();
        }

        private void IndexFile(string name)
        {
            Document document = GetDocument(name);
            writer.AddDocument(document);
        }

        private Document GetDocument(string name)
        {
            Document d = new Document();

            System.IO.StreamReader r = new System.IO.StreamReader(name, System.Text.Encoding.Default);
            string text = r.ReadToEnd();

            d.Add(new Field("content", text, Field.Store.NO, Field.Index.ANALYZED));
            d.Add(new Field("filename", name, Field.Store.YES, Field.Index.NOT_ANALYZED));
            System.IO.FileInfo info = new System.IO.FileInfo(name);
            d.Add(new Field("fullPath", info.FullName, Field.Store.YES, Field.Index.NOT_ANALYZED));

            return d;

        }

        private IndexWriter writer;

    }
}
