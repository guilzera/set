using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Entities
{
    class Students
    {
        public int Id { get; set; }

        public Students(int id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Students))
            {
                return false;
            }

            Students other = obj as Students;
            return Id.Equals(other.Id);
        }
    }
}
