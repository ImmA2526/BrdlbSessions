using System;
using Basic__AllSession;

namespace NameSpaceTwo
{
    class NameSpacesTwo : S4__AccessModifiereAndKeyword //Child Class OR Derived Class
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Inside the Second NameSpace ***********");
            S4__AccessModifiereAndKeyword nameSpace2 = new S4__AccessModifiereAndKeyword();
            //nameSpace2.PublicArithmaticOperation();

            NameSpacesTwo name = new NameSpacesTwo();
            name.PublicArithmaticOperation();
            name.ProtectedOperation();
        }
    }
}
