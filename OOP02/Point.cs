using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal struct Point
    {
        #region Attribute
        //object member 
        public int x;
        public int y;
        #endregion
        ///Constructor :is a special function
        ///           1-[take the same name of its class or struct]
        ///           2-Has No Return Type
        ///Constructor in Struct Can not be private
        ///But in Constructor in class Access modifier can be any this from 6 [usually any thing except private ]
        ///but in Singleton pattern 
        ///Constructor use to initialization each and every attribute 
        ///C#11 make a default constructor 
        ///this refer to object i work on its
        /// In Struct ,Complier Will Always Generate  Parameterless Constructor 
        ///will initialize all attribute with the default value c#10 can write and update this[.net 6]

        //can implement interface
        #region Constructor
        public Point()
        {
        }
        public Point(int x,int y)
        {
            this.x= x; 
            this.y = y;
        }
        public Point(int x)
        {
            this.x = x;
            y = x;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"X: {x},Y: {y}";
        }
        #endregion



    }
}
