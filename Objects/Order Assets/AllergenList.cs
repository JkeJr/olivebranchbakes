using System;
using System.Collections.Generic;
using System.Text;

namespace OliveBranchBakes.Objects
{
    public class AllergenList
    {
        private List<Allergen> allergens;
        public int Count => allergens.Count;

        // Constructors
        public AllergenList()
        {
            this.allergens = new();
            this.Add(AllergenIngredients.None);
        }
        public AllergenList(Allergen allergen)
        {
            this.allergens = new();
            this.Add(allergen);
        }
        public AllergenList(string allergen)
        {
            this.allergens = new();
            this.Add(allergen);
        }
        public AllergenList(string[] allergens)
        {
            this.allergens = new();
            foreach (string allergen in allergens)
            {
                this.Add(allergen);
            }
        }

        // custom indexer 
        public Allergen this[int i] => allergens[i];

        // For adding allergens
        public void Add(Allergen allergen)
        {
            allergens.Add(allergen);
        }
        public void Add(AllergenIngredients ingredient)
        {
            allergens.Add(new Allergen(ingredient));
        }
        public void Add(string allergen)
        {
            allergens.Add(new Allergen(allergen));
        }
        public static AllergenList operator + (AllergenList allergens, Allergen allergen)
        {
            allergens.Add(allergen);
            return allergens;
        }

        public string GetDisplayText(string separator)
        {
            string result = "";
            foreach (Allergen a in allergens)
            {
                result += a.ToString();
                if (allergens.IndexOf(a) < allergens.Count - 1)
                    result += separator;
            }

            return result;
        }
    }
}
