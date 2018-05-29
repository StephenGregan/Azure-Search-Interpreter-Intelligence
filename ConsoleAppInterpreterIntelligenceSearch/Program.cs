

namespace ConsoleAppInterpreterIntelligence
{
    using System;
    using System.Linq;
    using System.Threading;
    using Microsoft.Azure.Search;
    using Microsoft.Azure.Search.Models;
    using Microsoft.Extensions.Configuration;

    using Microsoft.Spatial;

    class Program
    {
        // This sample shows how to delete, create, upload documents and query an index
        static void Main(string[] args)
        {

            //var shows = LoginAndDeserializeJson();
            //Console.WriteLine(shows);

            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            IConfigurationRoot configuration = builder.Build();

            SearchServiceClient serviceClient = CreateSearchServiceClient(configuration);

            Console.WriteLine("{0}", "Deleting index...\n");
            DeleteHotelsIndexIfExists(serviceClient);

            Console.WriteLine("{0}", "Creating index...\n");
            CreateHotelsIndex(serviceClient);

            ISearchIndexClient indexClient = serviceClient.Indexes.GetClient("hotel");

            Console.WriteLine("{0}", "Uploading documents...\n");
            UploadDocuments(indexClient);

            ISearchIndexClient indexClientForQueries = CreateSearchIndexClient(configuration);

            RunQueries(indexClientForQueries);

            Console.WriteLine("{0}", "Complete.  Press any key to end application...\n");
            Console.ReadKey();
        }

        private static SearchServiceClient CreateSearchServiceClient(IConfigurationRoot configuration)
        {
            string searchServiceName = configuration["SearchServiceName"];
            string adminApiKey = configuration["SearchServiceAdminApiKey"];

            SearchServiceClient serviceClient = new SearchServiceClient(searchServiceName, new SearchCredentials(adminApiKey));
            return serviceClient;
        }

        private static SearchIndexClient CreateSearchIndexClient(IConfigurationRoot configuration)
        {
            string searchServiceName = configuration["ronansearch"];
            string queryApiKey = configuration["SearchServiceQueryApiKey"];

            SearchIndexClient indexClient = new SearchIndexClient(searchServiceName, "hotel", new SearchCredentials(queryApiKey));
            return indexClient;
        }

        private static void DeleteHotelsIndexIfExists(SearchServiceClient serviceClient)
        {
            if (serviceClient.Indexes.Exists("hotel"))
            {
                serviceClient.Indexes.Delete("hotel");
            }
        }

        private static void CreateHotelsIndex(SearchServiceClient serviceClient)
        {
            var definition = new Index()
            {
                Name = "hotel",
                Fields = FieldBuilder.BuildForType<Welcome>()
            };

            serviceClient.Indexes.Create(definition);
        }


        private static void UploadDocuments(ISearchIndexClient indexClient)
        {
            var hotel = new Welcome[]
            {
                new Welcome()
                {


                } };


            var batch = IndexBatch.Upload(hotel);

            try
            {
                indexClient.Documents.Index(batch);
            }
            catch (IndexBatchException e)
            {
                // Sometimes when your Search service is under load, indexing will fail for some of the documents in
                // the batch. Depending on your application, you can take compensating actions like delaying and
                // retrying. For this simple demo, we just log the failed document keys and continue.
                Console.WriteLine(
                    "Failed to index some of the documents: {0}",
                    String.Join(", ", e.IndexingResults.Where(r => !r.Succeeded).Select(r => r.Key)));
            }

            Console.WriteLine("Waiting for documents to be indexed...\n");
            Thread.Sleep(2000);
        }

        private static void RunQueries(ISearchIndexClient indexClient)
        {
            SearchParameters parameters;
            DocumentSearchResult<Welcome> results;

            Console.WriteLine("Search the entire index for the term 'budget' and return only the hotelName field:\n");

            parameters =
                new SearchParameters()
                {
                    Select = new[] { "hotelName" }
                };

            results = indexClient.Documents.Search<Welcome>("budget", parameters);

            WriteDocuments(results);

            Console.Write("Apply a filter to the index to find hotels cheaper than $150 per night, ");
            Console.WriteLine("and return the hotelId and description:\n");

            parameters =
                new SearchParameters()
                {
                    Filter = "baseRate lt 150",
                    Select = new[] { "hotelId", "description" }
                };

            results = indexClient.Documents.Search<Welcome>("*", parameters);

            WriteDocuments(results);

            Console.Write("Search the entire index, order by a specific field (lastRenovationDate) ");
            Console.Write("in descending order, take the top two results, and show only hotelName and ");
            Console.WriteLine("lastRenovationDate:\n");

            parameters =
                new SearchParameters()
                {
                    OrderBy = new[] { "lastRenovationDate desc" },
                    Select = new[] { "hotelName", "lastRenovationDate" },
                    Top = 2
                };

            results = indexClient.Documents.Search<Welcome>("*", parameters);

            WriteDocuments(results);

            Console.WriteLine("Search the entire index for the term 'motel':\n");

            parameters = new SearchParameters();
            results = indexClient.Documents.Search<Welcome>("motel", parameters);

            WriteDocuments(results);
        }

        private static void WriteDocuments(DocumentSearchResult<Welcome> searchResults)
        {
            foreach (SearchResult<Welcome> result in searchResults.Results)
            {
                Console.WriteLine(result.Document);
            }

            Console.WriteLine();
        }
    }
}