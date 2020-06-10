using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RjGPSView.Models
{
    public class GpsInfo
    {

        public string Txt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double longitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double latitude { get; set; }

        public double longitude_bd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double latitude_bd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string satellites { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string speed { get; set; }
        public string date { get; set; }
        public string in_use { get; set; }
        public string bd_satellites { get; set; }
        public string bd_in_use { get; set; }
        public string groundCourse { get; set; }
        public string declination { get; set; }
        public string declinationDirection { get; set; }
        public string sn { get; set; }



    }
}
