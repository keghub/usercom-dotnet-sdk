using System;
using UserCom.Model.Users;

namespace UserCom.Model.Segments
{
    public class Segment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Lazy<PaginatedResult<User>> Users { get; set; }
    }
}