using System;
using Iteration3;

namespace Iteration3
{
    public abstract class Game_Object : Identifiable_object
    {
        private string _description;
        private string _name;
        public Game_Object(string[] ids, string name, string desc) : base(ids)
        {
            _name = name;
            _description = desc;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string ShortDescription
        {
            get
            {
                return "a " + _name + " " + "(" + FirstId + ")";
            }
        }
        public virtual string FullDescription
        {
            get
            {
                return _description;
            }
        }
    }
}

