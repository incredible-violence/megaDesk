using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace MegaDesk_3_BradKellogg
{
    class DeskQuote
    {
        #region Object member variables
        private string CustomerName { get; set; }
        private DateTime QuoteDate = DateTime.Today;
        private Desk newDesk = new Desk();
        private int RushDays { get; set; }
        private int QuoteAmount = 0;
        #endregion

        #region local variables
        private int SurfaceArea = 0;

        #endregion

        #region constants
        private const int PRICE_BASE = 200;
        private const int SIZE_THRESHOLD = 1000;
        private const int PRICE_SURFACEAREA = 1;
        private const int PRICE_DRAWER = 50;
        #endregion
        public DeskQuote()
        {

        }

        public DeskQuote(int width,
            int depth, int drawers,
            Material material, int rushDays,
            string customer)
        {
            // variables from parameters
            newDesk.Width = width;
            newDesk.Depth = depth;
            newDesk.numDrawers = drawers;
            newDesk.deskMaterial = material;
            RushDays = rushDays;
            CustomerName = customer;

            // calculated variables
            SurfaceArea = (newDesk.Width * newDesk.Depth);
            QuoteAmount = CalculateQuoteTotal(SurfaceArea, RushDays, (int)material);
        }

        // aggregate costs into one number
        public int CalculateQuoteTotal(int surfaceArea, int rushDays, int matCost)
        {
            return PRICE_BASE + DrawerCost() + matCost
                + RushCost(surfaceArea, rushDays) + SurfaceAreaCost(surfaceArea);
        }

        // calculate cost of drawers
        private int DrawerCost()
        {
            return newDesk.numDrawers * PRICE_DRAWER;
        }

        // Calculate Rush Cost
        private int RushCost(int surfaceArea, int days)
        {
            StreamReader reader = new StreamReader(@"rushOrder.txt");

            // James' Attempt
            int[,] priceMap = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Int32.TryParse(reader.ReadLine(), out priceMap[i, j]);
                    /*
                    MessageBox.Show(
                        "i: " + i + "\t" +
                        "j: " + j + "\t" +
                        "Value:" + priceMap[i, j]);
                    */
                }
            }

            reader.Close();

            switch (days)
            {
                case 3:
                    if (surfaceArea < 1000)
                        return priceMap[0, 0];
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                        return priceMap[0, 1];
                    else if (surfaceArea > 2000)
                        return priceMap[0, 2];
                    break;
                case 5:
                    if (surfaceArea < 1000)
                        return priceMap[1, 0];
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                        return priceMap[1, 1];
                    else if (surfaceArea > 2000)
                        return priceMap[1, 2];
                    break;
                case 7:
                    if (surfaceArea < 1000)
                        return priceMap[2, 0];
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                        return priceMap[2, 1];
                    else if (surfaceArea > 2000)
                        return priceMap[2, 2];
                    break;
                case 0:
                    return 0;
                default:
                    break;
            }
            return 0;
        }
    
           
        // calculate cost of surface area
        private int SurfaceAreaCost(int size)
        {
            if (size < 1000)
                return 0;
            else if (size > 1000)
                return size - 1000;
            else
                return 1;
        }

        public void outputToFile(string filePath, DeskQuote quote)
        {
            string output = 
                quote.CustomerName              + '\t' 
                + quote.QuoteAmount             + '\t'
                + quote.newDesk.deskMaterial    + '\t'
                + quote.QuoteDate               + '\t'
                + quote.newDesk.getWidth()      + '\t'
                + quote.newDesk.getDepth()      + '\t'
                + quote.newDesk.getNumDrawers() + '\t'
                + quote.RushDays                + '\n';

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
                System.IO.File.AppendAllText(filePath, output);
       
            }
            else if (File.Exists(filePath))
            {
                System.IO.File.AppendAllText(@filePath, output);
            }
        }

        public void outputToJson(string filePath, DeskQuote desk)
        {
            List<DeskQuote> listBoi = new List<DeskQuote>
            {
                desk
            };
            
            // Assisted Attempt
            string jsonFile = JsonConvert.SerializeObject(listBoi, Formatting.Indented);

            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(@filePath))
                {
                    // done
                }
            }

            using (StreamWriter sw = File.AppendText(@filePath))
            {
                sw.WriteLine(jsonFile);
            }
            
        }
    }


}
