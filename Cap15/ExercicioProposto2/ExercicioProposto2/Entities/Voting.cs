using System;

namespace ExercicioProposto2.Entities
{
    internal class Voting
    {
        public string Name { get; set; }
        public int Voti { get; set; }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Voting))
            {
                return false;
            }
            else
            {
                Voting other = obj as Voting;
                return Name.Equals(other.Name);
            }

        }
              
    }
}
