using CodeNet.Abstraction;
using CodeNet.Abstraction.Model;
using ExampleApi.Contract;
using ExampleApi.Models;
using MediatR;

namespace ExampleApi.Handler;

public class MongoDBGetValueRequestHandler(IMongoDBRepository<MongoModel> mongoDBRepository) : IRequestHandler<MongoDBGetValueRequest, ResponseBase<MongoDBGetValueResponse>>
{
    public async Task<ResponseBase<MongoDBGetValueResponse>> Handle(MongoDBGetValueRequest request, CancellationToken cancellationToken)
    {
        var response = await mongoDBRepository.GetByIdAsync(c => c._id == request.Id, cancellationToken);
        return new ResponseBase<MongoDBGetValueResponse>(new MongoDBGetValueResponse { Value = response.Value });
    }
}
