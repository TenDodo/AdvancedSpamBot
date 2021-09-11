using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSpamBot
{
    public class ErrorData
    {
        public ErrorData(int type, string description, int index)
        {
            _type = type;
            _description = description;
            _index = index;
        }

        private int _type;

        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


        private int _index;

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

    }
}
