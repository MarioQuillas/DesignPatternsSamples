using System.Collections.Generic;

namespace VisitorDemo
{
    public class Person : IAsset
    {
        public List<IAsset> Assets = new List<IAsset>();
        
        public void Accept(IVisitor visitor)
        {
            foreach(var asset in Assets)
                asset.Accept(visitor);
        }
    }
}