using Lucene.Net.Analysis.Standard;
using Lucene.Net.Index;
using Lucene.Net.Store;
using System;
using LuceneProject.DatabaseDataSetTableAdapters;
using System.Data;
using Lucene.Net.Documents;
using LVersion = Lucene.Net.Util.Version;


namespace LuceneProject
{
    public class Indexer : IDisposable
    {
        private IndexWriter writer;
        public String IndexDirectory = "Index";
        public String DataDirectory = "Data";

        public Indexer()
        {
            Setup();
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

        //Retrieves the list of file names in the “data” folder(line 31) and creates the index of the documents
        //will be called from the main form
        public int Index()
        {
            //String[] files = System.IO.Directory.GetFileSystemEntries(DataDirectory);
            LemmaMediaTableAdapter lemmaMediaTableAdapter = new LemmaMediaTableAdapter();
            DataTable dataTable = lemmaMediaTableAdapter.GetAllDataFromLemmaAndMedia();

            foreach (DataRow name in dataTable.Rows)
            {
                IndexFile(name);
            }

            return writer.NumDocs();
        }

        //Creates document from GetDocument() function and calls AddDocument method of IndexWriter.
        private void IndexFile(DataRow name)
        {
            Document doc = GetDocument(name);
            writer.AddDocument(doc);
        }

        //Creates a Document instance and adds Field instances to the document
        private Document GetDocument(DataRow name)
        {
            Document doc = new Document();

            doc.Add(new Field("title", name["LemmaTitle"].ToString(), Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("Content", name["content"].ToString(), Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("MID", name["MediaID"].ToString(), Field.Store.YES, Field.Index.NO));
            doc.Add(new Field("dataType", name["type"].ToString(), Field.Store.YES, Field.Index.ANALYZED));

            return doc;
        }
    }
}
