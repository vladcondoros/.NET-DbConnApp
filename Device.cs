using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnTest
{
    public class Device
    {
        public int DeviceId { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public string OS { get; set; }
        public string OSv { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string FullDeviceInfo
        {
            get
            {
                return $"{ Name } { Manufacturer }, { Type }, { OS }, { OSv }, { CPU }, { RAM }";
            }
        }
    }
}
