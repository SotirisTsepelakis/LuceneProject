using System;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Index;
using Lucene.Net.Store;
using LVersion = Lucene.Net.Util.Version;
using Lucene.Net.Documents;
using System.Windows.Forms;

namespace LuceneProject
{
    public class Indexer : IDisposable
    {
        private IndexWriter writer;
        public String IndexDirectory { get; set; }
        public String DataDirectory { get; set; }

        public Indexer() {
            Setup();
            Index();
        }

        public void Setup()
        {
            Directory dir = FSDirectory.Open(IndexDirectory);

            try
            {
                writer = new IndexWriter(dir, new StandardAnalyzer(LVersion.LUCENE_30), IndexWriter.MaxFieldLength.UNLIMITED);
            }
            catch (Lucene.Net.Store.LockObtainFailedException exc)
            {
                Console.WriteLine(exc.Message);
            }
            
        }

        public void Dispose()
        {
            writer.Dispose();
        }

        public int Index()
        {
            String[] files = System.IO.Directory.GetFileSystemEntries(DataDirectory);

            foreach(String name in files)
            {
                IndexFile(name);
            }

            return writer.NumDocks();
        }

        private void IndexFile(string name)
        {
            Document doc = GetDocument(name);
            writer.AddDocument(doc);
        }

        //Gcreates a Document instance and adds Field instances to the document
        private Document GetDocument(string name)
        {
            Document doc = new Document();

            System.IO.StreamReader reader = new System.IO.StreamReader(name, System.Text.Encoding.Default);
            string text = reader.ReadToEnd();


            return doc;
        }
    }
}
