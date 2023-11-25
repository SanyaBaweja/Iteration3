using System;
namespace Iteration3
{
    public class Identifiable_object
    {



        private List<string> _identifiers = new List<string>(); //in initialising a new list


        public Identifiable_object(string[] idents)  //this is the constructor taking in a single argument 
        {
            //Console.WriteLine("Constructor");
            //         Console.ReadLine();
            foreach (string ide in idents)
            {
                Addidentifier(ide);
            }
            //_identifiers.AddRange(idents);


        }
        public bool AreYou(string id)  //method taking in string parameter 
        {
            foreach (string identify in _identifiers) // loop looping through each string 
            {
                if (identify == id)  //condition to compare the variable identify and id which returns true if they match.
                {
                    return true;
                }
                //else
                //{
                //                return false;
                //            }
            }
            return false;  // exits the loop

        }


        public string FirstId
        {
            get  //read only property
            {
                if (_identifiers.Count > 0)  //checks if there is atleast 1 identifier and returns the first identifier from list.
                {
                    return _identifiers.First();
                }
                else
                {
                    return ("");  //if there are no identifier returns an empty string.
                }
            }


        }
        public void Addidentifier(string id)
        {
            id = id.ToLower();  //converts the id to lowercase for uniformity
            _identifiers.Add(id);  //adds the id to the list.
        }

    }
}

