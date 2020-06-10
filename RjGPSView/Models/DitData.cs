using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RjGPSView.Models
{
    public class DitData : Dictionary<string, GpsInfo>
    {

        static System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("([^:]+):(.+)");
        public void TryFill(string txt)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt))
                {
                    return;
                }
                var model = new GpsInfo();
                model.Txt = txt;
                var mths = reg.Matches(txt);
                foreach (Match item in mths)
                {
                    switch (item.Groups[1].Value.Trim())
                    {
                        case "sn":
                            model.sn = item.Groups[2].Value.Trim();
                            break;
                        case "status":
                            model.status = item.Groups[2].Value.Trim();
                            break;
                        case "latitude":
                            model.latitude = Convert.ToDouble(item.Groups[2].Value.Trim());
                            break;
                        case "longitude":
                            model.longitude = Convert.ToDouble(item.Groups[2].Value.Trim());
                            break;
                        case "date":
                            model.date = item.Groups[2].Value.Trim();
                            break;
                        case "speed":
                            model.speed = item.Groups[2].Value.Trim();
                            break;
                        case "height":
                            model.height = item.Groups[2].Value.Trim();
                            break;
                        case "satellites":
                            model.satellites = item.Groups[2].Value.Trim();
                            break;
                        case "in use":
                            model.in_use = item.Groups[2].Value.Trim();
                            break;
                        case "bd satellites":
                            model.bd_satellites = item.Groups[2].Value.Trim();
                            break;
                        case "bd in use":
                            model.bd_in_use = item.Groups[2].Value.Trim();
                            break;
                        case "groundCourse":
                            model.groundCourse = item.Groups[2].Value.Trim();
                            break;
                        case "declination":
                            model.declination = item.Groups[2].Value.Trim();
                            break;
                        case "declinationDirection":
                            model.declinationDirection = item.Groups[2].Value.Trim();
                            break;

                    }
                }
                if (model.latitude != 0 && model.longitude != 0)
                {
                    SQ.Base.GPSHelper.EvilTransform.transform(model.latitude, model.longitude, out var lat, out var lon);
                    SQ.Base.GPSHelper.EvilTransform.bd_encrypt(lon, lat, out lon, out lat);
                    model.latitude_bd = lat;
                    model.longitude_bd = lon;
                }
                this[model.sn] = model;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
