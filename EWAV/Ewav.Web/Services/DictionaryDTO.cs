﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDC.ISB.EIDEV.Web.Services
{
    /// <summary>
    /// Class created to mimic Dicitionary kind of functionality.
    /// </summary>
    public class DictionaryDTO
    {
        private MyString key;

        public MyString Key
        {
            get { return key; }
            set { key = value; }
        }

        private MyString value;

        public MyString Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public DictionaryDTO()
        {

        }

        public DictionaryDTO(string name, string value)
        {
            key.VarName = name;
            Value.VarName = value;
        }

        public DictionaryDTO(MyString name, MyString value)
        {
            key = name;
            Value = value;
        }
    }
}