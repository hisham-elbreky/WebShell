using System;
using System.Collections.Generic;
using System.Text;
using WebShell.ClassLibrary.Interfaces;

namespace WebShell.ClassLibrary.Classes
{
    public class Result:IResult
    {
        private bool _success = false;
        private object _data = null;

        #region IResult Members

        public bool Success
        {
            get
            {
                return _success;
            }
            set
            {
                _success = value;
            }
        }

        public object Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        #endregion
    }
}
