using System;
using System.Collections.Generic;
using System.Text;

namespace NormalFactory
{
    /// <summary>
    /// Test class to store user information
    /// </summary>
    public class TestInfo
    {
        #region Private Properties

        /// <summary>
        /// User entered name
        /// </summary>
        private string _name;

        /// <summary>
        /// User provided age in years
        /// </summary>
        private int _age;

        #endregion



        #region Constructor

        /// <summary>
        /// Creates a new instance and sets the default values
        /// </summary>
        public TestInfo()
        {
            _name = string.Empty;
            _age = 18;
        }

        #endregion



        #region Public Properties

        /// <summary>
        /// user provided age in years
        /// </summary>
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        /// <summary>
        /// User entered name
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

    }
}
