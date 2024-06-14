using CodeNet.Abstraction;
using CodeNet.Abstraction.Model;

namespace ExampleApi.Models;

[CollectionName("TestCollection")]
public class MongoModel : IBaseMongoDBModel
{
    public Guid _id { get; set; }
    public string Value { get; set; }
}
