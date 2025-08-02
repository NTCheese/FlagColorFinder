using Google.Protobuf.WellKnownTypes;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Pipes;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace FlagColorFinder
{
    public class the_ocde
    {
        public string[] Sorter(int sortType)
        {
            ColorArrays colorArrays = new ColorArrays();

            string[] PREPREcolorNumbers = [colorArrays.Color("red"), colorArrays.Color("orange"), colorArrays.Color("yellow"), colorArrays.Color("green"), colorArrays.Color("blue"), colorArrays.Color("purple"), colorArrays.Color("black"), colorArrays.Color("white"), colorArrays.Color("brown"), colorArrays.Color("gray"), colorArrays.Color("pink")];
            string[] PREPREcolorNames = ["red", "orange", "yellow", "green", "blue", "purple", "black", "white", "brown", "gray", "pink"];


            string[] PREcolorNumbers = new string[PREPREcolorNumbers.Length];
            string[] PREcolorNames = new string[PREPREcolorNames.Length];

            for (int i = 0; i < PREPREcolorNumbers.Length; i++)
            {
                if (int.Parse(PREPREcolorNumbers[i]) >= welcomeScreen.smallNum)
                {
                    PREcolorNumbers[i] = PREPREcolorNumbers[i];
                    PREcolorNames[i] = PREPREcolorNames[i];
                }
            }

            string[] colorNumbers = PREcolorNumbers.Where(item => item != null).ToArray();
            string[] colorNames = PREcolorNames.Where(item => item != null).ToArray();
            string[] numsDOS = PREcolorNumbers.Where(item => item != null).ToArray();
            string[] namesDOS = PREcolorNames.Where(item => item != null).ToArray();



            int[] colorInts = new int[colorNumbers.Length];
            string output1 = "";
            string output2 = "";

            switch (sortType)
            {
                case 0:
                    //alphabetical
                    Array.Sort(colorNames, colorNumbers);
                    for (int i = 0; i < colorNames.Length; i++)
                    {
                        output1 += colorNames[i] + "\n";
                        output2 += colorNumbers[i] + "\n";
                    }
                    //add return values for each goddamn thinggggg
                    break;

                case 1:
                    //reverse alphabetical
                    Array.Sort(colorNames, colorNumbers);
                    Array.Reverse(colorNames);
                    Array.Reverse(colorNumbers);
                    for (int i = 0; i < colorNames.Length; i++)
                    {
                        output1 += colorNames[i] + "\n";
                        output2 += colorNumbers[i] + "\n";
                    }
                    //add return values for each goddamn thinggggg
                    break;

                case 2:
                    //number order small to large
                    for (int i = 0; i < colorNumbers.Length; i++)
                    {
                        colorInts[i] = int.Parse(colorNumbers[i]);
                    }
                    Array.Sort(colorInts, colorNames);
                    for (int i = 0; i < colorNames.Length; i++)
                    {
                        output1 += colorNames[i] + "\n";
                        output2 += colorInts[i] + "\n";
                    }
                    //add return values for each goddamn thinggggg
                    break;

                case 3:
                    //number order large to small
                    for (int i = 0; i < colorNumbers.Length; i++)
                    {
                        colorInts[i] = int.Parse(colorNumbers[i]);
                    }
                    Array.Sort(colorInts, colorNames);
                    Array.Reverse(colorInts);
                    Array.Reverse(colorNames);
                    for (int i = 0; i < colorNames.Length; i++)
                    {
                        output1 += colorNames[i] + "\n";
                        output2 += colorInts[i] + "\n";
                    }
                    //add return values for each goddamn thinggggg
                    break;

                case 4:
                    //color order
                    for (int i = 0; i < colorNumbers.Length; i++)
                    {
                        output1 += namesDOS[i] + "\n";
                        output2 += numsDOS[i] + "\n";
                    }
                    break;

                case 5:
                    //reverse color order
                    for (int i = colorNumbers.Length - 1; i >= 0; i--)
                    {
                        output1 += namesDOS[i] + "\n";
                        output2 += numsDOS[i] + "\n";
                    }
                    break;

            }

            string[] outputs = [output1, output2];
            return outputs;
        }

        public string[] DoubleSorter(int sortType)
        {
            ColorArrays colorArrays = new ColorArrays();
            string[] PREPREcolorNumbers = colorArrays.DoubleColorValues();
            string[] PREPREcolorNames = colorArrays.DoubleColorNames();

            string[] PREcolorNumbers = new string[PREPREcolorNumbers.Length];
            string[] PREcolorNames = new string[PREPREcolorNames.Length];

            for (int i = 0; i < PREPREcolorNumbers.Length; i++)
            {
                if (int.Parse(PREPREcolorNumbers[i]) >= welcomeScreen.smallNum)
                {
                    PREcolorNumbers[i] = PREPREcolorNumbers[i];
                    PREcolorNames[i] = PREPREcolorNames[i];
                }
            }

            string[] colorNumbers = PREcolorNumbers.Where(item => item != null).ToArray();
            string[] colorNames = PREcolorNames.Where(item => item != null).ToArray();
            string[] numsDOS = PREcolorNumbers.Where(item => item != null).ToArray();
            string[] namesDOS = PREcolorNames.Where(item => item != null).ToArray();
            int[] colorInts = new int[colorNumbers.Length];
            string output1 = "";
            string output2 = "";

            switch (sortType)
            {
                case 0:
                    //alphabetical
                    Array.Sort(colorNames, colorNumbers);
                    for (int i = 0; i < colorNames.Length; i++)
                    {
                        output1 += colorNames[i] + "\n";
                        output2 += colorNumbers[i] + "\n";
                    }
                    //add return values for each goddamn thinggggg
                    break;

                case 1:
                    //reverse alphabetical
                    Array.Sort(colorNames, colorNumbers);
                    Array.Reverse(colorNames);
                    Array.Reverse(colorNumbers);
                    for (int i = 0; i < colorNames.Length; i++)
                    {
                        output1 += colorNames[i] + "\n";
                        output2 += colorNumbers[i] + "\n";
                    }
                    //add return values for each goddamn thinggggg
                    break;

                case 2:
                    //number order small to large
                    for (int i = 0; i < colorNumbers.Length; i++)
                    {
                        colorInts[i] = int.Parse(colorNumbers[i]);
                    }
                    Array.Sort(colorInts, colorNames);
                    for (int i = 0; i < colorNames.Length; i++)
                    {
                        output1 += colorNames[i] + "\n";
                        output2 += colorInts[i] + "\n";
                    }
                    //add return values for each goddamn thinggggg
                    break;

                case 3:
                    //number order large to small
                    for (int i = 0; i < colorNumbers.Length; i++)
                    {
                        colorInts[i] = int.Parse(colorNumbers[i]);
                    }
                    Array.Sort(colorInts, colorNames);
                    Array.Reverse(colorInts);
                    Array.Reverse(colorNames);
                    for (int i = 0; i < colorNames.Length; i++)
                    {
                        output1 += colorNames[i] + "\n";
                        output2 += colorInts[i] + "\n";
                    }
                    //add return values for each goddamn thinggggg
                    break;

                case 4:
                    //color order
                    for (int i = 0; i < colorNumbers.Length; i++)
                    {
                        output1 += namesDOS[i] + "\n";
                        output2 += numsDOS[i] + "\n";
                    }
                    break;

                case 5:
                    //reverse color order
                    for (int i = colorNumbers.Length - 1; i >= 0; i--)
                    {
                        output1 += namesDOS[i] + "\n";
                        output2 += numsDOS[i] + "\n";
                    }
                    break;

            }
            string[] outputs = [output1, output2];
            return outputs;
        }
    }
}