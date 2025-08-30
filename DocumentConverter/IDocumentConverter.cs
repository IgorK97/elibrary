namespace DocumentConverter
{
    internal interface IDocumentConverter
    {
        bool Convert(string inputFilePath, string outputFilePath, DocumentConversionOptions? options);
    }
}
 