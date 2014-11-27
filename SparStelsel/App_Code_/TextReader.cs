using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace SparStelsel
{
    public class TextReader
    {
        private static readonly List<string> searchWords = new List<string>(){ "Inv No","REF #","Typ Numbe","Seq.No","GRV Book","GRV Date","Inv. Da","Supplier Name",
                                                                                "Excl. VAT","VAT  Incl.","VAT Value","VAT","Retail","GP%" };
        public void ReadFile()
        {
            int counter = 0;
            int headerline = 0;
            string line;
            string headerstring = "";

            // Read the file and find headerline
            System.IO.StreamReader file =  new System.IO.StreamReader("C:/dev/test.txt");
            while ((line = file.ReadLine()) != null)
            {
                if(line.Contains(searchWords[0]))
                {
                    headerline = counter;
                    headerstring = line;
                    break;
                }
                counter++;
            }

            file.Close();

            //Get index of each header element
            List<int> headerindex = new List<int>();
            foreach (string header in searchWords)
            {
                headerindex.Add(headerstring.IndexOf(header));
            }

            //Fix VAT
            headerindex[11] = headerindex[10] + searchWords[10].Length;


        }
    }
}