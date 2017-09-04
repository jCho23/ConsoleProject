using System;
namespace ConsoleProject

//Two different Types

    //Structures (Value Types):
        //Allocated on Stack, Memory management done automatically
            //Primitive
                //Small, lightweight
            //Custom Structures

    //Classes (Reference Types):
        //You need to allocate memory youself! ( new operator)
        //Memory allocated on HEAP (more sustainable then Stack) won't be removed immediately
        //Garbage collected by CLR that takes care of the HEAP
            //Once in a while, CLR looks at the objects that are no longer used and removes them
                //Arrays
                //Strings
                //Custom classes

{
    public class ReferenceTypesAndValueTypes
    {
        public ReferenceTypesAndValueTypes()
        {
        }
    }
}
