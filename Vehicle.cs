using System;
using System.Collections.Generic;
using System.Text;
using POO_TarefaInterfaces.Entities;

namespace POO_TarefaInterfaces.Entities
{
    class Vehicle
    {
        public string Model { get; set; }
        public Vehicle(string model)
        {
            Model = model;
        }
    }

}

