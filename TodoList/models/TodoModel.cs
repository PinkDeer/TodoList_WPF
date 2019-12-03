﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.models
{
    class TodoModel
    {
        private bool _isDone;
        private string _text;
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public bool MyProperty
        {
            get { return _isDone; }
            set { _isDone = value; }
        }

        public string MyProperty
        {
            get { return _text; }
            set { _text = value; }
        }


    }
}
