﻿using Entities.Abstract;
namespace Entities.Concrete
{
    public class JobPosition : IEntity
    {
        public int Id { get; set; }
        public string JobName { get; set; }
    }
}
