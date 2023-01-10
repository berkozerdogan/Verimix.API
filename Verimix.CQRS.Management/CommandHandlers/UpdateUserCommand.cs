﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verimix.CQRS.Management.CommandHandlers
{
    internal class UpdateUserCommand : IRequestHandler<UpdateUserRequest, bool>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public UpdateUserCommand(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<bool> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<User>();
            var entity = await repository.Get(f => f.Id == request.Data.Id, cancellationToken);
            if (entity is null)
            {
                return false;
            }
            var mapped = mapper.Map(request.Data, entity);
            repository.Update(mapped);
            var result = await unitOfWork.SaveChanges(cancellationToken);
            return result > 0;
        }
    }
}