using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ESGI.DesignPattern.Composite
{
    
    public class Folder: IElement
    {
        public string Name { get; set; }
        public readonly List<IElement> Elements = new List<IElement>();
        public Folder(string s)
        {
            Name = s;
            Elements.Add(this);
        }

        public List<IElement> GetElements()
        {
            return Elements;
        }
        
        public void Add(IElement element)
        {
            Elements.AddRange(element.GetElements());
        }

        public IEnumerable<string> List()
        { 
            return from num in Elements select num.Name;
        }
    }

    public class File: IElement
    {
        public string Name { get; set; }
        public List<IElement> Elements = new List<IElement>();
        public File(string s)
        {
            Name = s;
            Elements.Add(this);
        }

        public void Add(IElement element)
        {
            throw new Exception();
        }

        public IEnumerable<string> List()
        {
            return from num in Elements select num.Name;
        }

        public List<IElement> GetElements()
        {
            return Elements;
        }

    }
    
    public interface IElement
    {
        string Name { get; set; }
        void Add(IElement folder){}
        IEnumerable<string> List();
        public List<IElement> GetElements();
    }
}
