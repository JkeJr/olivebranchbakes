using System;
using System.Collections.Generic;
using System.Text;

namespace OliveBranchBakes.Objects.OrderItem_Types
{
    public abstract class AbstractTest
    {
        public int Count { get; set; }
        protected AbstractTest(int countNum)
        {
            Count = countNum;
        }
    }

    public class DeriveTest : AbstractTest
    {
        public string Name { get; set; }

        public DeriveTest(int countNum, string nameInput) : base(countNum)
        {
            Name = nameInput;
        }
    }
}
