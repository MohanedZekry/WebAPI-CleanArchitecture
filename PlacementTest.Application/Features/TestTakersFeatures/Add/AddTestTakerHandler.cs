using AutoMapper;
using MediatR;
using PlacementTest.Application.Repository;
using PlacementTest.Application.Repository.TestTakersRepository;
using PlacementTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacementTest.Application.Features.TestTakersFeatures
{
    public sealed class AddTestTakerHandler : IRequestHandler<AddTestTakerRequest, AddTestTakerResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITestTakerRepository _testTakerRepository;
        private readonly IMapper _mapper;

        public AddTestTakerHandler(IUnitOfWork unitOfWork, 
            ITestTakerRepository testTakerRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _testTakerRepository = testTakerRepository;
            _mapper = mapper;
        }

        public async Task<AddTestTakerResponse> Handle(AddTestTakerRequest request,
            CancellationToken cancellationToken)
        {
            var user = _mapper.Map<TestTakers>(request);
            _testTakerRepository.Create(user);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<AddTestTakerResponse>(user);
        }


    }
}
