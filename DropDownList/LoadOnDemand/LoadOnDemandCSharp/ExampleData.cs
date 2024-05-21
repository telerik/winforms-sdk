using System;
using System.Collections.Generic;

namespace LoadOnDemand
{

    /// <summary>
    /// Example data to populate the load on demand RadDropDownList
    /// </summary>
    /// <remarks></remarks>
    public class ExampleData
    {

        /// <summary>
        /// The property displayed in the dropdownlist
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string ExampleDisplayMember
        {
            get { return _exampleDisplayMember; }
            set { _exampleDisplayMember = value; }
        }

        private string _exampleDisplayMember;
        /// <summary>
        /// The value of the ExampleData object
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public Guid ExampleValueMember
        {
            get { return _exampleValueMember; }
            set { _exampleValueMember = value; }
        }

        private Guid _exampleValueMember;
        /// <summary>
        /// Any other properties of your objects are irrelevant
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string WhateverOtherProps
        {
            get { return _whateverOtherProps; }
            set { _whateverOtherProps = value; }
        }

        private string _whateverOtherProps;


        /// <summary>
        /// Required to initialize new ExampleData objects
        /// </summary>
        /// <param name="display">Text to display in the dropdownlist</param>
        /// <param name="value">Value of the created ExampleData object</param>
        /// <param name="other">Another property, no specific purpose</param>
        /// <remarks></remarks>
        public ExampleData(string display, Guid value, string other)
        {
            _exampleDisplayMember = display;
            _exampleValueMember = value;
            _whateverOtherProps = other;
        }

        public ExampleData() : this("?", Guid.Empty, "?") { }


        /// <summary>
        /// Create an object list populated with ExampleData objects
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public static List<ExampleData> CreateList()
        {

            List<string> chars = new List<string>(new string[] {
			                                                        "abc",
			                                                        "def",
			                                                        "ghi",
			                                                        "jkl",
			                                                        "mno",
			                                                        "pqr",
			                                                        "stu",
			                                                        "vwx",
			                                                        "yz"
		                                                        });
            List<string> numbers = new List<string>(new string[] {
			                                                        "123",
			                                                        "456",
			                                                        "789",
			                                                        "012",
			                                                        "345",
			                                                        "678"
		                                                        });
            List<ExampleData> result = new List<ExampleData>();

            foreach (string chr in chars)
            {
                foreach (string nr in numbers)
                {
                    result.Add(new ExampleData(chr+nr,Guid.NewGuid(),chr+"-"+nr));
                }
            }

            return result;

        }


        public override string ToString()
        {
            return this.WhateverOtherProps;
        }

    }
}


//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik, @toddanglin
//Facebook: facebook.com/telerik
//=======================================================
