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

        // Works the same as typical IndexOf functions, gets int index and returns -1 if DNE
        public int IndexOf(Allergen allergen)
        {
            for (int i = 0; i < Count; i++)
                if (this[i] == allergen)
                    return i;
            
            return -1;
        }

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

        // Removing Allergens
        public void Remove(AllergenIngredients ingredient)
        {
            allergens.Remove(new Allergen(ingredient));
        }
        public void Remove(Allergen allergen)
        {
            RemoveAt(IndexOf(allergen));
        }
        public void RemoveAt(int index)
        {
            allergens.RemoveAt(index);
        }
        public void Clear()
        {
            allergens.Clear();
        }

        public string ToString(string separator)
        {
            string[] items = new string[allergens.Count];
            for (int i = 0; i < allergens.Count; i++)
                items[i] = allergens[i].ToString();
            return DataManagement.DisplayListText(items, separator);
        }
    }
}
