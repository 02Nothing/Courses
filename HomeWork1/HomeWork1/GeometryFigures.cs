using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class GeometryFigures
    {
        int type;// 1-коло, 2- трикутник, 3- чотирикутник
        float[] sides;
        public GeometryFigures(int type) 
        {
            this.type = type;
        }

        public bool setSides(float[] _sides)
       {
           
            if(_sides.Length>0)
            {
                foreach (var side in _sides) 
                { 
                    if(side == 0)
                    {
                        return false;
                    }
                }
                if (type==1)
                {
                    sides = _sides;
                    return true;
                }
                else if (_sides.Length >= 3)
                {
                    float tmp = 0;
                    foreach (var side in _sides)
                    {
                        tmp += side;
                     }
                    foreach(var side in _sides)
                    {
                        if (side >= tmp - side)
                        {
                            return false;
                        }
                    }
                    sides = _sides;
                    return true;
                }
            }
            return false;
        }

       
        public string getPerim()
        {
            string res="";
           if(type==1)
                    res =2 * sides[0] +"PI"+"/ "+2*sides[0]*Math.PI;
            else
            {
                float sum=0;
              for(int i=0; i<sides.Length; i++)
                {
                    sum += sides[i];
                }
              res = sum.ToString();
            }
            return res;
        }
        public string getArea()
        {
            string res="";
            bool parse = float.TryParse(getPerim(), out float perim);
            float subres = 1;
            if (parse)
                foreach (var item in sides)
                {
                    subres *= perim / 2 - item;
                }
            switch (type)
            {

                case 1:
                    res = Math.Pow(sides[0], 2) + "PI / " + Math.Pow(sides[0], 2) * Math.PI;
                break;
                case 2:
                  res = Math.Sqrt(subres*(perim/2)).ToString();
                    break;
                case 3:
                    res = Math.Sqrt(subres).ToString();
                    break;
                default: res = "Помилка";
                    break;
            }
            return res;
        }
    }
}
