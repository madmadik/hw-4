using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public partial class AirPlane
    {
        private int speed;
        private double size;
        private string name;
        private float fuel;
        private bool IsMilitary;
        static int wing=0;
        static bool IsPlane = true;
        public AirPlane()
        {
            speed = 0;
            size = 0;
            name = null;
            fuel = 0;
        }
        public AirPlane(int speed)
        {
            this.speed = speed;
        }
        public AirPlane(string name)
        {
            this.name = name;
        }
        public AirPlane(int speed,string name)
        {
            this.speed = speed;
            this.name = name;
        }
        static AirPlane()
        {
           wing = 2;
        }
        public int GetSpeed()
        {
            return speed;
        }
        public double GetSize()
        {
            return size;
        }
        public string GetName()
        {
            return name;
        }
        public float GetFuel()
        {
            return fuel;
        }
        public bool GetIsMilitary()
        {
            return IsMilitary;
        }
        public void SetAll(int speed,double size,string name,float fuel,bool IsMilitary)
        {
            this.speed = speed;
            this.size = size;
            this.name = name;
            this.fuel = fuel;
            this.IsMilitary = IsMilitary;
        }

    }
}
