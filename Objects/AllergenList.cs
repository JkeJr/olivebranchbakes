using System;
using System.Collections.Generic;
using System.Text;

namespace OliveBranchBakes.Objects
{
    public class AllergenList
    {
        private List<Allergen> allergens;

        public AllergenList(string[] allergens)
        {
            this.allergens = new();
            foreach (string allergen in allergens)
            {
                this.allergens.Add(new Allergen(allergen));
            }
        }

        // For adding allergens
        public void Add(Allergen allergen)
        {
            allergens.Add(allergen);
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
