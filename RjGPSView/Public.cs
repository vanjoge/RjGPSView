using RjGPSView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RjGPSView
{
    public class Public
    {
        Public()
        {
            Data = new DitData();
        }
        public static Public Instance = new Public();
        public DitData Data { get; set; }

    }
}
