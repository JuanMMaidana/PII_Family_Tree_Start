namespace Library
{
    public class AgeCalculator : Visitor
    {
        public override void Visit(Node node)
        {
            this.TotalAge = node.Person.Age + this.TotalAge;
            foreach (Node item in node.Children)
            {
                this.Visit(item);
            }
        }
    }
}