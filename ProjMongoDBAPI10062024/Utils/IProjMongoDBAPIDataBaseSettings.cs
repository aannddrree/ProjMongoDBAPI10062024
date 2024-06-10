namespace ProjMongoDBAPI10062024.Utils
{
    public interface IProjMongoDBAPIDataBaseSettings
    {
        string CustomerCollectionName { set; get; }
        string AddressCollectionName { set; get; }
        string ConnectionString { set; get; }
        string DatabaseName { set; get; }
    }
}
