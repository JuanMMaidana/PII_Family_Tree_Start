using System.Collections.Generic;

namespace Library
{
    public class OldestSon : Visitor
    {
        public override void Visit(Node node)
        {
            
            if (node.Children.Count == 0) 
            {
                if (node.Person.Age >= this.OldSonAge)
                {
                    this.OldSonAge = node.Person.Age; 
                }
            }else
            {
                foreach (Node item in node.Children)
                {
                    this.Visit(item);
                }
            }
        }
    }
}