using CodeNet.Abstraction.Model;
using MediatR;

namespace ExampleApi.Contract;

public class MongoDBGetValueRequest : IRequest<ResponseBase<MongoDBGetValueResponse>>, IBaseRequest
{
    public required Guid Id { get; set; }
}
