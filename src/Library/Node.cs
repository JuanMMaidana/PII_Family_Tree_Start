using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {

        private Person person;

        private List<Node> children = new List<Node>();


        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Person person)
        {
            this.Person = person;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public int GetAgeTotal() 
        {
            Visitor visitor = new AgeCalculator();
            this.Accept(visitor);
            return visitor.AgeTotal;
        }

        public string GetLongestName() 
        {
            Visitor visitor = new NameComparator();
            this.Accept(visitor);
            return visitor.LongestName;
        }

        public int GetOldSonAge() 
        {
            Visitor visitor = new OldestSon();
            this.Accept(visitor);
            return visitor.OldSon;
        }

        public Person Person
        {
            get
            {
                return this.person;
            }
            private set
            {
                this.person = value;
            }
        }
        
    }
}
