using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace PAdmin.Function;

public class FileAddedToUnprocessedReceipts
{
    private readonly ILogger _logger;

    public FileAddedToUnprocessedReceipts(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<FileAddedToUnprocessedReceipts>();
    }

    [Function("FileAddedToUnprocessedReceipts")]
    public void Run([BlobTrigger("receipts/unprocessed/{name}", Connection = "padminstorage_STORAGE")] string myBlob, string name)
    {
        _logger.LogInformation($"C# Blob trigger function Processed blob\n Name: {name} \n Data: {myBlob}");
    }
}
