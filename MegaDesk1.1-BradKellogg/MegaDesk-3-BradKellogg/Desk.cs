using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_BradKellogg
{
    enum Material {
        Laminate = 100,
        Oak = 200,
        Rosewood = 300,
        Veneer = 125,
        Pine = 50 };

    class Desk
    {
        public int Width;
        public int Depth;
        public int numDrawers;
        public Material deskMaterial;

        public Desk()
        {

        }

        public Desk(int width, int depth, int numDrawers)
        {
            this.Width = width;
            this.Depth = depth;
            this.numDrawers = numDrawers;
        }

        public int getWidth()
        {
            return Width;
        }

        public int getDepth()
        {
            return Depth;
        }

        public int getNumDrawers()
        {
            return numDrawers;
        }

        public Material getDeskMaterial()
        {
            return deskMaterial;
        }

        public void setWidth(int width)
        {
            this.Width = width;
        }

        public void setDepth(int depth)
        {
            this.Depth = depth;
        }

        public void setNumDrawers(int number)
        {
            this.numDrawers = number;
        }

        public float calcDeskPrice()
        {
            float price = 200;

            if (Width * Depth > 1000)
            {
                price += Width * Depth;
            }

            price += numDrawers * 50;

            switch (deskMaterial) 
            {
                case Material.Oak:
                    price += 200;
                    break;
                case Material.Laminate:
                    price += 100;
                    break;
                case Material.Pine:
                    price += 50;
                    break;
                case Material.Rosewood:  
                    price += 300;
                    break;
                case Material.Veneer:
                    price += 125;
                    break;
                default:
                    Console.WriteLine("Invalid desk material");
                    break;
            }

            return price;
       }
    }
}
