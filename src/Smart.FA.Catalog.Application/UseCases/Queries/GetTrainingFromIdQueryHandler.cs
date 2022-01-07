using Application.SeedWork;
using Core.Domain;
using Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Application.UseCases.Queries;

public class GetTrainingFromIdQueryHandler: IRequestHandler<GetTrainingFromIdRequest, GetTrainingFromIdResponse>
{
    private readonly ILogger<GetTrainingFromIdQueryHandler> _logger;
    private readonly Context _context;

    public GetTrainingFromIdQueryHandler(ILogger<GetTrainingFromIdQueryHandler> logger, Context context )
    {
        _logger = logger;
        _context = context;
    }
    public async Task<GetTrainingFromIdResponse> Handle(GetTrainingFromIdRequest request, CancellationToken cancellationToken)
    {
        GetTrainingFromIdResponse resp = new();

        try
        {
            var training = await _context.Trainings.FindAsync(request.TrainingId);
            resp.Training = training;
            resp.SetSuccess();
        }
        catch (Exception e)
        {
            _logger.LogError(e.StackTrace);
            throw;
        }

        return resp;

    }
}

public class GetTrainingFromIdRequest: IRequest<GetTrainingFromIdResponse>
{
    public int TrainingId { get; set; }
}

public class GetTrainingFromIdResponse : ResponseBase
{
    public Training Training { get; set; }
}
