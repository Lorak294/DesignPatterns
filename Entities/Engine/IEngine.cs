using DesignPatterns.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Entities.Engine
{
    public interface IEngine
    {
        int Power { get; set; }
        void MakeSound();
        void Save(ISaveEntitiyVisitor visitor) { visitor.Visit(this); }
    }
}
