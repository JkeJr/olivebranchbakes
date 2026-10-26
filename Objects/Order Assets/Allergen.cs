using System;
using System.Collections.Generic;
using System.Text;

namespace OliveBranchBakes.Objects
{
    public enum AllergenIngredients
    {
        Milk,
        Egg,
        Peanut,
        Soy,
        Wheat,
        Treenut,
        Shellfish,
        Fish,
        Sesame,
        None
    }

    public class Allergen
    {
        public AllergenIngredients type;
        
        // Takes Enum value directly | not sure if this will be that useful
        public Allergen(AllergenIngredients allergen)
        {
            type = allergen;
        }
        // Overloaded constructor converts string to Enum
        public Allergen(string allergen)
        {
            type = (AllergenIngredients)Enum.Parse(typeof(AllergenIngredients), allergen);
        }

        public override string ToString()
        {
            return type.ToString();
        }
    }
}
