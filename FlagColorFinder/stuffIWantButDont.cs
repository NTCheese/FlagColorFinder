using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagColorFinder
{
    internal class stuffIWantButDont
    {
        //        public string[][] flags = {

        //["black", "green", "red", "white"],
        //["red", "black"],
        //["green", "red", "white"],
        //["blue", "red","white"],
        //["blue", "red","yellow"],
        //["red", "black","yellow"],
        //["blue", "white"],
        //["red","black","blue","white","yellow"],
        //["blue","white"],
        //["red", "blue", "orange"], ["blue", "red","yellow"], ["blue", "red", "white"], ["red", "white"],
        //["blue",  "green",  "red"],
        //["black",  "blue",  "yellow"],
        //["red",  "white"],
        //["red",  "green"],
        //["blue",  "black",  "yellow"],
        //["red",  "green",  "white"],
        //["black",  "red",  "yellow"],
        //["blue",  "red",  "white"],
        //["green",  "red",  "yellow"],
        //["red"],
        //["yellow",  "white"],
        //["red",  "green",  "yellow"],
        //["blue",  "white",  "yellow"],
        //["blue",  "black",  "white"],
        //["blue",  "red",  "white"],
        //["green",  "blue",  "yellow"],
        //["yellow",  "black",  "red",  "white"],
        //["white",  "green",  "red"],
        //["red",  "green",  "yellow"],
        //["red",  "green",  "white"],
        //["blue",  "yellow",  "red",  "white"],
        //["red",  "blue",  "white"],
        //["red",  "green",  "yellow"],
        //["red",  "white"],
        //["blue", "red", "white", "green", "yellow"],
        //["blue",  "green",  "red",  "white",  "yellow"],
        //["blue",  "red",  "yellow"],
        //["red",  "blue",  "white"],
        //["red",  "yellow"],
        //["white", "blue", "green", "yellow"],
        //["green", "yellow", "brown"],
        //["yellow",  "blue",  "red"],
        //["yellow",  "blue",  "green",  "red",  "white"],
        //["blue",  "red",  "white"],
        //["blue",  "red",  "white"],
        //["red",  "blue",  "white"],
        //["blue",  "red",  "white"],
        //["blue",  "white",  "yellow"],
        //["green",  "orange",  "white"],
        //["blue",  "red",  "white"],
        //["orange",  "green",  "white"],
        //["blue",  "red",  "yellow"],
        //["red",  "white"],
        //["blue",  "green",  "red",  "white"],
        //["green",  "black",  "red",  "white",  "yellow"],
        //["blue",  "red",  "white"],
        //["yellow",  "blue",  "red"],
        //["black",  "yellow",  "red",  "white"],
        //["blue",  "yellow",  "white"],
        //["green",  "blue",  "red",  "white"],
        //["green",  "blue",  "red",  "yellow"],
        //["blue",  "black",  "white"],
        //["black",  "blue",  "red",  "white",  "yellow"],
        //["green",  "blue",  "red",  "yellow"],
        //["red", "blue", "white", "yellow", "green", "brown"],
        //["red", "blue", "white"],
        //["blue",  "yellow",  "blue",  "red",  "white"],
        //["white",  "blue"],
        //["blue",  "red",  "white"],
        //["yellow", "red", "green"],
        //["red",  "blue",  "yellow",  "white"],
        //["blue", "white", "red"],
        //["green",  "blue",  "yellow"],
        //["red",  "blue",  "green",  "white"],
        //["red",  "white"],
        //["black",  "yellow",  "red"],
        //["red",  "black",  "green",  "yellow"],
        //["yellow",  "red",  "white"],
        //["blue",  "white"],
        //["red", "white"],
        //["green",  "red",  "yellow"],
        //["yellow", "green", "blue"],
        //["red", "blue", "yellow", "green", "white", "brown"],
        //["blue",  "white"],
        //["red", "yellow", "white"],
        //["red",  "green",  "yellow"],
        //["red",  "black",  "green",  "yellow"],
        //["black",  "green",  "red",  "white",  "yellow"],
        //["red", "blue", "white"],
        //["blue",  "red"],
        //["yellow",  "white"],
        //["blue",  "white"],
        //["red", "white"],
        //["red",  "green",  "white"],
        //["blue",  "red",  "white"],
        //["blue",  "green",  "orange",  "white"],
        //["red",  "white"],
        //["green",  "red",  "white"],
        //["red",  "black",  "green",  "white"],
        //["green",  "orange",  "white"],
        //["red", "yellow", "white"],
        //["blue",  "white"],
        //["green",  "red",  "white"],
        //["green",  "black",  "yellow"],
        //["red",  "white"],
        //["red", "yellow", "white"],
        //["black",  "green",  "red",  "white"],
        //["blue",  "yellow"],
        //["black",  "green",  "red",  "white"],
        //["red",  "blue",  "yellow",  "white"],
        //["green",  "black",  "red",  "white"],
        //["red"],
        //["red",  "blue",  "white"],
        //["red",  "white"],
        //["red",  "green",  "white"],
        //["blue",  "black",  "green",  "white"],
        //["red",  "blue",  "white"],
        //["red",  "black",  "green",  "white"],
        //["blue",  "red"],
        //["yellow",  "green",  "red"],
        //["red",  "blue",  "white"],
        //["green", "white", "yellow"],
        //["red",  "green",  "white"],
        //["black",  "green",  "red"],
        //["red",  "blue",  "white",  "yellow"],
        //["red",  "white"],
        //["green",  "red",  "yellow"],
        //["red",  "white"],
        //["blue",  "orange",  "white"], ["blue", "white"],
        //["green",  "red",  "yellow"],
        //["red",  "blue",  "green",  "yellow"],
        //["red", "blue", "white", "green"],
        //["green",  "red",  "white"],
        //["blue",  "white"],
        //["blue",  "yellow",  "red",  "yellow"],
        //["red",  "white"],
        //["blue",  "red",  "yellow"],
        //["red",  "yellow"],
        //["red", "blue", "white", "green", "black", "brown"],
        //["red",  "green"],
        //["black",  "green",  "red",  "white",  "yellow"], ["yellow",  "green",  "red",  "white"],
        //["blue",  "green",  "red",  "white",  "yellow"],
        //["blue",  "white",  "yellow"],
        //["red",  "blue",  "white"],
        //["red",  "blue",  "white"],
        //["yellow", "black", "blue", "green", "red"],
        //["white",  "blue",  "red"],
        //["blue",  "white"],
        //["orange",  "green",  "white"],
        //["green",  "white"],
        //["red", "blue", "white", "yellow"],
        //["green",  "white"],
        //["red",  "blue",  "white"],
        //["red",  "yellow"],
        //["blue", "white", "purple", "yellow", "green", "red","gray"],
        //["red",  "blue",  "white"],
        //["red",  "green",  "white"],
        //["green",  "white"],
        //["yellow",  "blue"],
        //["black",  "green",  "red",  "white"],
        //["blue",  "red",  "white"],
        //["red",  "black",  "white",  "yellow"],
        //["red",  "blue",  "white"],
        //["red",  "white"],
        //["blue",  "red",  "white",  "yellow"],
        //["blue",  "black",  "brown",  "green",  "red",  "white",  "yellow"],
        //["white",  "red"],
        //["red",  "green",  "white"],
        //["blue", "red", "white"],
        //["red",  "white"],
        //["green",  "red",  "yellow"],
        //["blue",  "red",  "yellow"],
        //["white",  "blue",  "red"],
        //["blue",  "green",  "yellow"],
        //["red", "blue", "yellow"],
        //["yellow", "blue", "red", "white", "gray"],
        //["blue", "red", "white", "black", "brown"],
        //["green",  "red",  "white"],
        //["blue",  "black",  "white",  "yellow"],
        //["blue", "red", "white"],
        //["green", "red", "white", "black", "blue", "yellow"],
        //["blue",  "green",  "yellow"],
        //["red",  "blue",  "white"],
        //["white",  "blue"],
        //["green",  "black",  "red",  "yellow"],
        //["green",  "white"],
        //["green",  "red",  "yellow"],
        //["red",  "blue",  "white"],
        //["blue",  "green",  "red",  "white",  "yellow"],
        //["green",  "blue",  "white"],
        //["red",  "white"],
        //["yellow", "red", "white", "blue"],
        //["white", "yellow", "red", "blue", "green", "brown"],
        //["white",  "blue",  "red"],
        //["blue",  "red",  "white"],
        //["green",  "blue",  "yellow"],
        //["blue",  "white"],
        //["red",  "black",  "blue",  "yellow",  "green",  "white"],
        //["red", "white", "blue", "brown", "yellow", "black", "green", "orange", "gray", "purple"],
        //["white",  "black",  "blue",  "red"],
        //["black",  "blue",  "green",  "red",  "white",  "yellow"],
        //["red",  "yellow",  "pink"],
        //["red",  "yellow",  "green",  "orange"],
        //["red",  "black",  "green",  "white"],
        //["yellow",  "green",  "red",  "white"],
        //["red", "blue", "white"],
        //["blue",  "yellow"],
        //["red",  "white"],
        //["red",  "black",  "green",  "white"],
        //["blue", "white", "red"],
        //["yellow",  "green",  "red",  "white"],
        //["green",  "black",  "blue",  "yellow"],
        //["red",  "blue",  "white"],
        //["black", "white", "yellow", "red"],
        //["green",  "red",  "white",  "yellow"],
        //["white", "blue", "yellow"],
        //["red",  "white"],
        //["red",  "black",  "white"],
        //["red",  "white"],
        //["red",  "white"],
        //["green",  "white"],
        //["red", "blue", "white", "yellow", "green", "brown"],
        //["blue",  "yellow",  "red",  "blue",  "white"],
        //["blue",  "red",  "white",  "yellow"],
        //["blue",  "yellow"],
        //["red",  "black",  "green",  "white"],
        //["red",  "blue",  "white"],
        //["red",  "blue",  "white"],
        //["red", "white", "blue"],
        //["blue",  "white"],
        //["blue",  "green",  "red",  "white"],
        //["red",  "black",  "green",  "yellow"],
        //["yellow",  "blue",  "red"],
        //["red",  "yellow"],
        //["red", "blue", "white", "green", "yellow", "brown"],
        //["white", "yellow", "blue", "green", "red"],
        //["blue", "white", "red"],
        //["red", "green", "white", "black"],
        //["red",  "black",  "white"],
        //["green",  "black",  "orange",  "red"],
        //["green",  "black",  "red",  "white",  "yellow"],
        //["blue","yellow","red"]
        //};
    }
}


//{
//    for (int i = 0; i < flags.Length; i++)
//    {
//        for (int j = 0; j < flags[i].Length; j++)
//        {
//            switch (flags[i][j])
//            {
//                case "red":
//                    if (flags[i].Contains("orange"))
//                        redOrange++;
//                    if (flags[i].Contains("yellow"))
//                        redYellow++;
//                    if (flags[i].Contains("green"))
//                        redGreen++;
//                    if (flags[i].Contains("blue"))
//                        redBlue++;
//                    if (flags[i].Contains("purple"))
//                        redPurple++;
//                    if (flags[i].Contains("black"))
//                        redBlack++;
//                    if (flags[i].Contains("white"))
//                        redWhite++;
//                    if (flags[i].Contains("gray"))
//                        redGray++;
//                    if (flags[i].Contains("brown"))
//                        redBrown++;
//                    if (flags[i].Contains("brown"))
//                        redPink++;
//                    break;
//            }
//        }
//    }

//    Console.WriteLine($"{redOrange}\n{redYellow}\n{redGreen}\n{redBlue}\n{redPurple}\n{redBlack}\n{redWhite}\n{redGray}\n{redBrown}\n");


//    for (int i = 0; i < flags.Length; i++)
//    {
//        for (int j = 0; j < flags[i].Length; j++)
//        {
//            switch (flags[i][j])
//            {
//                case "orange":
//                    if (flags[i].Contains("yellow"))
//                        OY++;
//                    if (flags[i].Contains("green"))
//                        OG++;
//                    if (flags[i].Contains("blue"))
//                        OB++;
//                    if (flags[i].Contains("purple"))
//                        OPU++;
//                    if (flags[i].Contains("pink"))
//                        OPI++;
//                    if (flags[i].Contains("black"))
//                        OBL++;
//                    if (flags[i].Contains("white"))
//                        OW++;
//                    if (flags[i].Contains("gray"))
//                        OGY++;
//                    if (flags[i].Contains("brown"))
//                        OBR++;
//                    break;
//            }
//        }
//    }

//    Console.WriteLine($"{OY}\n{OG}\n{OB}\n{OPU}\n{OPI}\n{OBL}\n{OW}\n{OGY}\n{OBR}\n");


//    for (int i = 0; i < flags.Length; i++)
//    {
//        for (int j = 0; j < flags[i].Length; j++)
//        {
//            switch (flags[i][j])
//            {
//                case "yellow":
//                    if (flags[i].Contains("green"))
//                        YG++;
//                    if (flags[i].Contains("blue"))
//                        YB++;
//                    if (flags[i].Contains("purple"))
//                        YPU++;
//                    if (flags[i].Contains("pink"))
//                        YPI++;
//                    if (flags[i].Contains("black"))
//                        YBL++;
//                    if (flags[i].Contains("white"))
//                        YW++;
//                    if (flags[i].Contains("gray"))
//                        YGY++;
//                    if (flags[i].Contains("brown"))
//                        YBR++;
//                    break;
//            }
//        }
//    }

//    Console.WriteLine($"{YG}\n{YB}\n{YPU}\n{YPI}\n{YBL}\n{YW}\n{YGY}\n{YBR}\n");


//    for (int i = 0; i < flags.Length; i++)
//    {
//        for (int j = 0; j < flags[i].Length; j++)
//        {
//            switch (flags[i][j])
//            {
//                case "green":
//                    if (flags[i].Contains("blue"))
//                        GB++;
//                    if (flags[i].Contains("purple"))
//                        GPU++;
//                    if (flags[i].Contains("pink"))
//                        GPI++;
//                    if (flags[i].Contains("black"))
//                        GBL++;
//                    if (flags[i].Contains("white"))
//                        GW++;
//                    if (flags[i].Contains("gray"))
//                        GGY++;
//                    if (flags[i].Contains("brown"))
//                        GBR++;
//                    break;
//            }
//        }
//    }

//    Console.WriteLine($"{GB}\n{GPU}\n{GPI}\n{GBL}\n{GW}\n{GGY}\n{GBR}\n");


//    for (int i = 0; i < flags.Length; i++)
//    {
//        for (int j = 0; j < flags[i].Length; j++)
//        {
//            switch (flags[i][j])
//            {
//                case "blue":
//                    if (flags[i].Contains("purple"))
//                        BPU++;
//                    if (flags[i].Contains("pink"))
//                        BPI++;
//                    if (flags[i].Contains("black"))
//                        BBL++;
//                    if (flags[i].Contains("white"))
//                        BW++;
//                    if (flags[i].Contains("gray"))
//                        BGY++;
//                    if (flags[i].Contains("brown"))
//                        BBR++;
//                    break;
//            }
//        }
//    }

//    Console.WriteLine($"{BPU}\n{BPI}\n{BBL}\n{BW}\n{BGY}\n{BBR}\n");


//    for (int i = 0; i < flags.Length; i++)
//    {
//        for (int j = 0; j < flags[i].Length; j++)
//        {
//            switch (flags[i][j])
//            {
//                case "purple":
//                    if (flags[i].Contains("pink"))
//                        PPI++;
//                    if (flags[i].Contains("black"))
//                    PBL++;
//                if (flags[i].Contains("white"))
//                    PW++;
//                if (flags[i].Contains("gray"))
//                    PGY++;
//                if (flags[i].Contains("brown"))
//                    PBR++;
//                break;
//        }
//    }
//}

//Console.WriteLine($"{PPI}\n{PBL}\n{PW}\n{PGY}\n{PBR}\n");


//for (int i = 0; i < flags.Length; i++)
//{
//    for (int j = 0; j < flags[i].Length; j++)
//    {
//        switch (flags[i][j])
//        {
//            case "black":
//                if (flags[i].Contains("white"))
//                    BLW++;
//                if (flags[i].Contains("gray"))
//                    BLGY++;
//                if (flags[i].Contains("brown"))
//                    BLBR++;
//                if (flags[i].Contains("pink"))
//                    BLPI++;
//                break;
//        }
//    }
//}

//Console.WriteLine($"{BLW}\n{BLGY}\n{BLBR}\n{BLPI}\n");


//for (int i = 0; i < flags.Length; i++)
//{
//    for (int j = 0; j < flags[i].Length; j++)
//    {
//        switch (flags[i][j])
//        {
//            case "white":
//                if (flags[i].Contains("gray"))
//                    WGY++;
//                if (flags[i].Contains("brown"))
//                    WBR++;
//                if (flags[i].Contains("pink"))
//                    WPI++;
//                break;
//        }
//    }
//}

//Console.WriteLine($"{WGY}\n{WBR}\n{WPI}\n");

//for (int i = 0; i < flags.Length; i++)
//{
//    for (int j = 0; j < flags[i].Length; j++)
//    {
//        switch (flags[i][j])
//        {
//            case "gray":
//                if (flags[i].Contains("pink"))
//                    BRPI++;
//                if (flags[i].Contains("gray"))
//                    BRGY++;
//                break;

//        }
//    }
//}

//for (int i = 0; i < flags.Length; i++)
//{
//    for (int j = 0; j < flags[i].Length; j++)
//    {
//        switch (flags[i][j])
//        {
//            case "gray":
//                if (flags[i].Contains("pink"))
//                    GYPI++;
//                break;
//        }
//    }
//}

//Console.WriteLine($"{GYPI}\n");
//} //the arrays. dont look inside. please

// doubles

//int redOrange = 0;
//int redYellow = 0;
//int redGreen = 0;
//int redBlue = 0;
//int redPurple = 0;
//int redBlack = 0;
//int redWhite = 0;
//int redGray = 0;
//int redBrown = 0;
//int redPink = 0;

//int OY = 0;
//int OG = 0;
//int OB = 0;
//int OPU = 0;
//int OPI = 0;
//int OBL = 0;
//int OW = 0;
//int OGY = 0;
//int OBR = 0;

//int YG = 0;
//int YB = 0;
//int YPU = 0;
//int YPI = 0;
//int YBL = 0;
//int YW = 0;
//int YGY = 0;
//int YBR = 0;

//int GB = 0;
//int GPU = 0;
//int GPI = 0;
//int GBL = 0;
//int GW = 0;
//int GGY = 0;
//int GBR = 0;

//int BPU = 0;
//int BPI = 0;
//int BBL = 0;
//int BW = 0;
//int BGY = 0;
//int BBR = 0;

//int PPI = 0;
//int PBL = 0;
//int PW = 0;
//int PGY = 0;
//int PBR = 0;

//int BLW = 0;
//int BLGY = 0;
//int BLBR = 0;
//int BLPI = 0;

//int WGY = 0;
//int WBR = 0;
//int WPI = 0;

//int BRGY = 0;
//int BRPI = 0;

//int GYPI = 0;



//string[] PREPREcolorNumbers = {

//    redOrange.ToString(), redYellow.ToString(), redGreen.ToString(), redBlue.ToString(), redPurple.ToString(), redBlack.ToString(), redWhite.ToString(), redBrown.ToString(), redGray.ToString(), redPink.ToString(),
//    OY.ToString(), OG.ToString(), OB.ToString(), OPU.ToString(), OBL.ToString(), OW.ToString(), OBR.ToString(), OGY.ToString(), OPI.ToString(),
//    YG.ToString(), YB.ToString(), YPU.ToString(), YBL.ToString(), YW.ToString(), YBR.ToString(), YGY.ToString(), YPI.ToString(),
//    GB.ToString(), GPU.ToString(), GBL.ToString(), GW.ToString(), GBR.ToString(), GGY.ToString(), GPI.ToString(),
//    BPU.ToString(), BBL.ToString(), BW.ToString(), BBR.ToString(), BGY.ToString(), BPI.ToString(),
//    PBL.ToString(), PW.ToString(), PBR.ToString(), PGY.ToString(), PPI.ToString(),
//    BLW.ToString(), BLBR.ToString(), BLGY.ToString(), BLPI.ToString(),
//    WBR.ToString(), WGY.ToString(), WPI.ToString(),
//    BRGY.ToString(), BRPI.ToString(),
//    GYPI.ToString(),
//};

//string[] PREPREcolorNames = {
//    "red and orange", "red and yellow", "red and green", "red and blue", "red and purple", "red and black", "red and white", "red and brown", "red and gray", "red and pink",
//    "orange and yellow", "orange and green", "orange and blue", "orange and purple", "orange and black", "orange and white", "orange and brown", "orange and gray", "orange and pink",
//    "yellow and green", "yellow and blue", "yellow and purple", "yellow and black", "yellow and white", "yellow and brown", "yellow and gray", "yellow and pink",
//    "green and blue", "green and purple", "green and black", "green and white", "green and brown", "green and gray", "green and pink",
//    "blue and purple", "blue and black", "blue and white", "blue and brown", "blue and gray", "blue and pink",
//    "purple and black", "purple and white", "purple and brown", "purple and gray", "purple and pink",
//    "black and white", "black and brown", "black and gray", "black and pink",
//    "white and brown", "white and gray", "white and pink",
//    "brown and gray", "brown and pink",
//    "gray and pink"
//};



//for (int i = 0; i < doubleColorsFrontend.Length; i++)
//    Console.WriteLine($"{doubleColorsFrontend[i]}: {doubleColorValues[i]}");