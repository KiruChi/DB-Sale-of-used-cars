﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Classes
{
    public class Materials
    {
        private int id;
        private string name;

        public Materials(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
