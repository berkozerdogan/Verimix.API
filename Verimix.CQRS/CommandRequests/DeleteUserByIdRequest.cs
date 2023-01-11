﻿namespace Verimix.Services.Concretes
{
    public class DeleteUserByIdRequest : IRequest<bool>
    {
        public DeleteUserByIdRequest(int id, bool forceDelete)
        {
            Id = id;
            ForceDelete = forceDelete;
        }

        public int Id { get; set; }
        public bool ForceDelete { get; set; }
    }
}