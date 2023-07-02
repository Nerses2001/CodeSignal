using System;
using CodeSignal.Intro;
using CodeSignal.Intro.TheJourneyBegins;
using CodeSignal.TheCore;

//https://app.codesignal.com/profile/nerses_h_kdd

namespace CodeSignal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("************************* - INTRO - *************************");

            Console.WriteLine("\nThe Journey Begins");
            TheJourneyBegins journey = new TheJourneyBegins();

            int sum = journey.Add(2, 3);
            Console.WriteLine(sum);

            int century = journey.ceturyFromYear(1905);
            Console.WriteLine(century);

            bool isPalindrome = journey.CheckPalindrome("level");
            Console.WriteLine(isPalindrome);


            Console.WriteLine("\nEdge of the Ocean");

            EdgeOfTheOcean edgeOfTheOcean = new EdgeOfTheOcean();

            int[] inputArray = { 1, 2, 3, 4, 5 };
            int adjacentElementsProduct = edgeOfTheOcean.AdjecntElemetsProduct(inputArray);
            Console.WriteLine("Adjacent Elements Product: " + adjacentElementsProduct);

            int n = 4;
            int shapeArea = edgeOfTheOcean.SgapeArea(n);
            Console.WriteLine("Shape Area: " + shapeArea);

            int[] statues = { 6, 2, 3, 8 };
            int additionalStatues = edgeOfTheOcean.MakeArrayConsecutive2(statues);
            Console.WriteLine("Additional Statues: " + additionalStatues);

            int[] sequence = { 1, 3, 2 };
            bool isAlmostIncreasing = edgeOfTheOcean.AlmostIncreasingSequence(sequence);
            Console.WriteLine("Is Almost Increasing: " + isAlmostIncreasing);

            int[][] matrix = new int[][] {
                new int[] { 1, 1, 1, 0 },
                new int[] { 0, 5, 1, 1 },
                new int[] { 2, 1, 3, 10 }
            };
            int matrixElementsSum = edgeOfTheOcean.MatrixElementsSum(matrix);
            Console.WriteLine("Matrix Elements Sum: " + matrixElementsSum);

            Console.WriteLine("\nSmooth Sailing");

            SmoothSailing smoothSailing = new SmoothSailing();

            string[] stringArray = { "abc", "de", "fgh", "ijklm" };
            string[] longestStrings = smoothSailing.AllLongestStrings(stringArray);
            Console.WriteLine("Longest Strings: " + string.Join(", ", longestStrings));

            string string1 = "aabcc";
            string string2 = "adcaa";
            int commonCharacterCount = smoothSailing.CommonCharacterCount(string1, string2);
            Console.WriteLine("Common Character Count: " + commonCharacterCount);

            int ticketNumber = 1230;
            bool isLucky = smoothSailing.IsLucky(ticketNumber);
            Console.WriteLine("Is Lucky: " + isLucky);

            int[] heights = { -1, 150, 190, 170, -1, -1, 160, 180 };
            int[] sortedHeights = smoothSailing.SortByHeight(heights);
            Console.WriteLine("Sorted Heights: " + string.Join(", ", sortedHeights));

            string inputString = "(bar)";
            string reversedString = smoothSailing.ReverseInParentheses(inputString);
            Console.WriteLine("Reversed String: " + reversedString);

            Console.WriteLine("\nExploring the Waters");


             ExploringTheWaters explorer = new ExploringTheWaters();

            int[] startWeights = { 50, 60, 70, 80, 90 };
            int[] sums = explorer.AlternatingSums(startWeights);
            Console.WriteLine(sums[0]);
            Console.WriteLine(sums[1]);

            string[] startPicture = { "abc", "def", "ghi" };
            string[] borderedPicture = explorer.AddBorder(startPicture);
            foreach (string row in borderedPicture)
            {
                Console.WriteLine(row);
            }

            int[] startArrayA = { 1, 2, 3 };
            int[] startArrayB = { 3, 2, 1 };
            bool isSimilar = explorer.AreSimilar(startArrayA, startArrayB);
            Console.WriteLine(isSimilar);

            int[] startExplInputArray = { 1, 2, 3, 4, 5 };
            int minimalMoves = explorer.ArrayChange(startExplInputArray);
            Console.WriteLine(minimalMoves);

            string startInputString = "aab";
            bool canRearrange = explorer.PalindromeRearranging(startInputString);
            Console.WriteLine(canRearrange);


            Console.WriteLine("\nIsland of Knowledge");

            IslandOfKnowledge knowledge = new IslandOfKnowledge();

            int knowledgeYourLeft = 10;
            int knowledgeYourRight = 15;
            int knowledgeFriendsLeft = 15;
            int knowledgeFriendsRight = 10;
            bool knowledgeEquallyStrong = knowledge.AreEquallyStrong(knowledgeYourLeft, knowledgeYourRight, knowledgeFriendsLeft, knowledgeFriendsRight);
            Console.WriteLine(knowledgeEquallyStrong);

            int[] knowledgeInputArray = { 2, 4, 1, 0 };
            int knowledgeMaximalAdjacentDifference = knowledge.ArrayMaximalAdjacentDifference(knowledgeInputArray);
            Console.WriteLine(knowledgeMaximalAdjacentDifference);

            string knowledgeInputString = "192.168.0.1";
            bool knowledgeIsIPv4Address = knowledge.IsIPv4Address(knowledgeInputString);
            Console.WriteLine(knowledgeIsIPv4Address);

            int[] knowledgeObstacles = { 5, 3, 6, 9, 7 };
            int knowledgeMinimalJump = knowledge.AvoidObstacles(knowledgeObstacles);
            Console.WriteLine(knowledgeMinimalJump);

            int[][] knowledgeImage = new int[][]
            {
                new int[] { 1, 1, 1 },
                new int[] { 1, 7, 1 },
                new int[] { 1, 1, 1 }
            };
            int[][] knowledgeBlurredImage = knowledge.BoxBlur(knowledgeImage);
            foreach (int[] row in knowledgeBlurredImage)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            bool[][] knowledgeMinesMatrix = new bool[][]
            {
                new bool[] { true, false, false },
                new bool[] { false, true, false },
                new bool[] { false, false, false }
            };
            int[][] knowledgeHintsMatrix = knowledge.Minesweeper(knowledgeMinesMatrix);
            foreach (int[] row in knowledgeHintsMatrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            Console.WriteLine("\nRains of Reason");


            RainsOfReason rainsOfReason = new RainsOfReason();

            int[] rainsOfReasonInputArray = { 1, 2, 3, 4, 5 };
            int rainsOfReasonElemToReplace = 3;
            int rainsOfReasonSubstitutionElem = 7;
            int[] rainsOfReasonReplacedArray = rainsOfReason.ArrayReplace(rainsOfReasonInputArray, rainsOfReasonElemToReplace, rainsOfReasonSubstitutionElem);
            Console.WriteLine(string.Join(", ", rainsOfReasonReplacedArray));

            int rainsOfReasonNumber = 2468;
            bool rainsOfReasonEvenDigitsOnly = rainsOfReason.EvenDigitsOnly(rainsOfReasonNumber);
            Console.WriteLine(rainsOfReasonEvenDigitsOnly);

            string rainsOfReasonVariableName = "myVariable";
            bool rainsOfReasonIsValidVariableName = rainsOfReason.VariableName(rainsOfReasonVariableName);
            Console.WriteLine(rainsOfReasonIsValidVariableName);

            string rainsOfReasonInputString = "abc";
            string rainsOfReasonShiftedString = rainsOfReason.AlphabeticShift(rainsOfReasonInputString);
            Console.WriteLine(rainsOfReasonShiftedString);

            string rainsOfReasonCell1 = "A1";
            string rainsOfReasonCell2 = "C3";
            bool rainsOfReasonSameColor = rainsOfReason.ChessBoardCellColor(rainsOfReasonCell1, rainsOfReasonCell2);
            Console.WriteLine(rainsOfReasonSameColor);

            Console.WriteLine("\nThrough the Fog");


            ThroughTheFog throughTheFog = new ThroughTheFog();

            int throughTheFogN = 10;
            int throughTheFogFirstNumber = 3;
            int throughTheFogOppositeNumber = throughTheFog.CircleOfNumbers(throughTheFogN, throughTheFogFirstNumber);
            Console.WriteLine(throughTheFogOppositeNumber);

            int throughTheFogDeposit = 100;
            int throughTheFogRate = 20;
            int throughTheFogThreshold = 170;
            int throughTheFogYears = throughTheFog.DepositProfit(throughTheFogDeposit, throughTheFogRate, throughTheFogThreshold);
            Console.WriteLine(throughTheFogYears);

            int[] throughTheFogArray = { 1, 2, 4, 7 };
            int throughTheFogClosestElement = throughTheFog.AbsoluteValuesSumMinimization(throughTheFogArray);
            Console.WriteLine(throughTheFogClosestElement);

            string[] throughTheFogStringArray = { "aba", "bbb", "bab" };
            bool throughTheFogRearrangementPossible = throughTheFog.StringsRearrangement(throughTheFogStringArray);
            Console.WriteLine(throughTheFogRearrangementPossible);


            Console.WriteLine("\nDiving Deeper");


            DivingDeeper divingDeeper = new DivingDeeper();

            int[] divingDeeperInputArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int divingDeeperK = 3;
            int[] divingDeeperResult = divingDeeper.ExtractEachKth(divingDeeperInputArray, divingDeeperK);
            Console.WriteLine(string.Join(", ", divingDeeperResult));

            string divingDeeperInputString = "a1b2c3";
            char divingDeeperFirstDigit = divingDeeper.FirstDigit(divingDeeperInputString);
            Console.WriteLine(divingDeeperFirstDigit);

            string divingDeeperS = "abca";
            int divingDeeperDifferentSymbols = divingDeeper.DifferentSymbolsNaive(divingDeeperS);
            Console.WriteLine(divingDeeperDifferentSymbols);

            int[] divingDeeperInputArray2 = { 1, 3, 2, 4 };
            int divingDeeperK2 = 2;
            int divingDeeperMaxConsecutiveSum = divingDeeper.ArrayMaxConsecutiveSum(divingDeeperInputArray2, divingDeeperK2);
            Console.WriteLine(divingDeeperMaxConsecutiveSum);

            
            
            Console.WriteLine("\nDark Wilderness");


            DarkWilderness darkWilderness = new DarkWilderness();

            int darkWildernessUpSpeed = 5;
            int darkWildernessDownSpeed = 2;
            int darkWildernessDesiredHeight = 10;
            int darkWildernessDays = darkWilderness.GrowingPlant(darkWildernessUpSpeed, darkWildernessDownSpeed, darkWildernessDesiredHeight);
            Console.WriteLine(darkWildernessDays);

            int darkWildernessValue1 = 10;
            int darkWildernessWeight1 = 5;
            int darkWildernessValue2 = 6;
            int darkWildernessWeight2 = 4;
            int darkWildernessMaxW = 8;
            int darkWildernessMaxValue = darkWilderness.KnapsackLight(darkWildernessValue1, darkWildernessWeight1, darkWildernessValue2, darkWildernessWeight2, darkWildernessMaxW);
            Console.WriteLine(darkWildernessMaxValue);

            string darkWildernessInputString = "123abc456";
            string darkWildernessLongestPrefix = darkWilderness.LongestDigitsPrefix(darkWildernessInputString);
            Console.WriteLine(darkWildernessLongestPrefix);

            int darkWildernessN = 91;
            int darkWildernessDegree = darkWilderness.DigitDegree(darkWildernessN);
            Console.WriteLine(darkWildernessDegree);

            string darkWildernessBishop = "a1";
            string darkWildernessPawn = "c3";
            bool darkWildernessCanCapture = darkWilderness.BishopAndPawn(darkWildernessBishop, darkWildernessPawn);
            Console.WriteLine(darkWildernessCanCapture);


            Console.WriteLine("\nEruption of Light");


            EruptionOfLight eruptionOfLight = new EruptionOfLight();

            string eruptionOfLightInputString = "aabbb";
            bool eruptionOfLightIsBeautiful = eruptionOfLight.IsBeautifulString(eruptionOfLightInputString);
            Console.WriteLine(eruptionOfLightIsBeautiful);

            string eruptionOfLightAddress = "John.Smith@example.com";
            string eruptionOfLightDomain = eruptionOfLight.FindEmailDomain(eruptionOfLightAddress);
            Console.WriteLine(eruptionOfLightDomain);

            string eruptionOfLightSt = "abcd";
            string eruptionOfLightPalindrome = eruptionOfLight.BuildPalindrome(eruptionOfLightSt);
            Console.WriteLine(eruptionOfLightPalindrome);

            int[] eruptionOfLightVotes = { 2, 3, 5, 2 };
            int eruptionOfLightK = 3;
            int eruptionOfLightNumOfWinners = eruptionOfLight.ElectionsWinners(eruptionOfLightVotes, eruptionOfLightK);
            Console.WriteLine(eruptionOfLightNumOfWinners);

            string eruptionOfLightInputString1 = "01-23-45-67-89-AB";
            bool eruptionOfLightIsMAC48Address = eruptionOfLight.IsMAC48Address(eruptionOfLightInputString1);
            Console.WriteLine(eruptionOfLightIsMAC48Address);


            Console.WriteLine("\nRainbow of Clarity");

            RainbowOfClarity rainbowOfClarity = new RainbowOfClarity();

            char rainbowOfClaritySymbol = '9';
            bool rainbowOfClarityIsDigit = rainbowOfClarity.IsDigit(rainbowOfClaritySymbol);
            Console.WriteLine(rainbowOfClarityIsDigit);

            string rainbowOfClarityString = "aabbbc";
            string rainbowOfClarityEncodedString = rainbowOfClarity.LineEncoding(rainbowOfClarityString);
            Console.WriteLine(rainbowOfClarityEncodedString);

            string rainbowOfClarityCell = "c5";
            int rainbowOfClarityNumOfMoves = rainbowOfClarity.ChessKnight(rainbowOfClarityCell);
            Console.WriteLine(rainbowOfClarityNumOfMoves);

            int rainbowOfClarityN = 152;
            int rainbowOfClarityMaxNumber = rainbowOfClarity.DeleteDigit(rainbowOfClarityN);
            Console.WriteLine(rainbowOfClarityMaxNumber);

            
            
            Console.WriteLine("\nLand of Logic");


            LandOfLogic landOfLogic = new LandOfLogic();

            string landOfLogicText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            string landOfLogicLongestWord = landOfLogic.LongestWord(landOfLogicText);
            Console.WriteLine(landOfLogicLongestWord);

            string landOfLogicTime = "12:34";
            bool landOfLogicIsValidTime = landOfLogic.ValidTime(landOfLogicTime);
            Console.WriteLine(landOfLogicIsValidTime);

            string landOfLogicInputString = "Lorem 123 ipsum 456 dolor 789 sit amet.";
            int landOfLogicSum = landOfLogic.SumUpNumbers(landOfLogicInputString);
            Console.WriteLine(landOfLogicSum);

            int[][] landOfLogicMatrix = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };
            int landOfLogicNumOfSquares = landOfLogic.DifferentSquares(landOfLogicMatrix);
            Console.WriteLine(landOfLogicNumOfSquares);

            int landOfLogicProduct = 24;
            int landOfLogicSmallestInteger = landOfLogic.DigitsProduct(landOfLogicProduct);
            Console.WriteLine(landOfLogicSmallestInteger);

            string[] landOfLogicNames = new string[] { "file", "file", "file(1)", "file(2)", "file(1)", "file(3)" };
            string[] landOfLogicUniqueNames = landOfLogic.FileNaming(landOfLogicNames);
            Console.WriteLine(string.Join(", ", landOfLogicUniqueNames));

            string landOfLogicCode = "010010000110010101101100011011000110111100100001";
            string landOfLogicMessage = landOfLogic.MessageFromBinaryCode(landOfLogicCode);
            Console.WriteLine(landOfLogicMessage);

            int landOfLogicN = 4;
            int[][] landOfLogicSpiralMatrix = landOfLogic.SpiralNumbers(landOfLogicN);
            for (int i = 0; i < landOfLogicSpiralMatrix.Length; i++)
            {
                Console.WriteLine(string.Join(", ", landOfLogicSpiralMatrix[i]));
            }

            int[][] landOfLogicSudokuGrid = new int[][]
            {
                new int[] { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                new int[] { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
                new int[] { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
                new int[] { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
                new int[] { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
                new int[] { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
                new int[] { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
                new int[] { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
                new int[] { 3, 4, 5, 2, 8, 6, 1, 7, 9 }
            };
            bool landOfLogicIsSudokuCorrect = landOfLogic.Sudoku(landOfLogicSudokuGrid);
            Console.WriteLine(landOfLogicIsSudokuCorrect);


            Console.WriteLine("************************* - The Core - *************************");

            Console.WriteLine("\nIntro Gates");

            IntroGates intro = new IntroGates();

            int introSum = intro.AddTwoDigits(45);
            Console.WriteLine(introSum);

            int introLargest = intro.LargestNumber(3);
            Console.WriteLine(introLargest);

            int introTotalCandies = intro.Candies(5, 15);
            Console.WriteLine(introTotalCandies);

            int introSeatsLeft = intro.SeatsInTheater(16, 11, 5, 3);
            Console.WriteLine(introSeatsLeft);

            int introMaxMultiple = intro.MaxMultiple(3, 17);
            Console.WriteLine(introMaxMultiple);

            int introNeighborNum = intro.CircleOfNumbers(10, 2);
            Console.WriteLine(introNeighborNum);

            int introRideTime = intro.LateRide(120);
            Console.WriteLine(introRideTime);

            int introLongestCall = intro.PhoneCall(1, 2, 3, 20);
            Console.WriteLine(introLongestCall);


            Console.WriteLine("\nAt the Crossroads");

            AtTheCrossroads crossroads = new AtTheCrossroads();

            int crossroadsN = 23;
            int crossroadsK = 3;
            int result1 = crossroads.KillK_thBit(crossroadsN, crossroadsK);
            Console.WriteLine("KillK_thBit: " + result1);

            int[] crossroadsA = { 18, 52, 86, 120 };
            int result2 = crossroads.ArrayPacking(crossroadsA);
            Console.WriteLine("ArrayPacking: " + result2);

            int crossroadsA1 = 2;
            int crossroadsB1 = 7;
            int result3 = crossroads.RangeBitCount(crossroadsA1, crossroadsB1);
            Console.WriteLine("RangeBitCount: " + result3);

            int crossroadsA2 = 56;
            int result4 = crossroads.MirrorBits(crossroadsA2);
            Console.WriteLine("MirrorBits: " + result4);

            int crossroadsN1 = 37;
            int result5 = crossroads.SecondRightmostZeroBit(crossroadsN1);
            Console.WriteLine("SecondRightmostZeroBit: " + result5);

            int crossroadsN2 = 7;
            int crossroadsM = 10;
            int result6 = crossroads.DifferentRightmostBit(crossroadsN2, crossroadsM);
            Console.WriteLine("DifferentRightmostBit: " + result6);


            Console.WriteLine("\nLoop Tunnel");

            LoopTunnel loopTunnel = new LoopTunnel();
            int LoopN1 = 10;
            int LoopLeastFactorial1 = loopTunnel.LeastFactorial(LoopN1);
            Console.WriteLine($"Least factorial greater than or equal to {LoopN1}: {LoopLeastFactorial1}");

            int LoopN2 = 6;
            int LoopL2 = 2;
            int LoopR2 = 4;
            int LoopCount2 = loopTunnel.CountSumOfTwoRepresentations2(LoopN2, LoopL2, LoopR2);
            Console.WriteLine($"Number of ways to represent {LoopN2} as a sum of two integers between {LoopL2} and {LoopR2}: {LoopCount2}");

            int LoopA3 = 1;
            int LoopB3 = 2;
            int LoopN3 = 2;
            int LoopMoney3 = loopTunnel.MagicalWell(LoopA3, LoopB3, LoopN3);
            Console.WriteLine($"Total money made with {LoopN3} magic marbles: {LoopMoney3}");

            string LoopCommands4 = "LLARL";
            int LoopSameDirectionCount4 = loopTunnel.Lineup(LoopCommands4);
            Console.WriteLine($"Number of commands after which students face the same direction: {LoopSameDirectionCount4}");

            int LoopParam1 = 456;
            int LoopParam2 = 173;
            int LoopResult = loopTunnel.AdditionWithoutCarrying(LoopParam1, LoopParam2);
            Console.WriteLine($"Result of adding {LoopParam1} and {LoopParam2} without carrying: {LoopResult}");

            int LoopK6 = 5;
            int LoopAppleDifference6 = loopTunnel.AppleBoxes(LoopK6);
            Console.WriteLine($"Difference between the number of red and yellow apples: {LoopAppleDifference6}");

            int LoopN7 = 902200;
            bool LoopCanIncreaseRoundness7 = loopTunnel.IncreaseNumberRoundness(LoopN7);
            Console.WriteLine($"It is possible to increase the roundness of {LoopN7}: {LoopCanIncreaseRoundness7}");

            int LoopN8 = 1234;
            int LoopRoundedNumber8 = loopTunnel.Rounders(LoopN8);
            Console.WriteLine($"Rounded number: {LoopRoundedNumber8}");

            int LoopCandlesNumber9 = 5;
            int LoopMakeNew9 = 2;
            int LoopTotalCandles9 = loopTunnel.Candles(LoopCandlesNumber9, LoopMakeNew9);
            Console.WriteLine($"Total number of candles burned: {LoopTotalCandles9}");

            int LoopN10 = 3;
            int LoopM10 = 4;
            int LoopBlackCellCount10 = loopTunnel.CountBlackCells(LoopN10, LoopM10);
            Console.WriteLine($"Number of black cells in the grid: {LoopBlackCellCount10}");


            Console.WriteLine("\nList Forest Edge");

            ListForestEdge listForestEdge = new ListForestEdge();

            int[] listForestEdgeArray = listForestEdge.CreateArray(5);
            Console.WriteLine(string.Join(" ", listForestEdgeArray));

            int[] listForestEdgeInputArray = { 1, 2, 3, 2, 4 };
            int[] listForestEdgeReplacedArray = listForestEdge.ArrayReplace(listForestEdgeInputArray, 2, 5);
            Console.WriteLine(string.Join(" ", listForestEdgeReplacedArray));

            int[] listForestEdgeArr = { 1, 2, 3, 4, 5 };
            int[] listForestEdgeReversedArr = listForestEdge.FirstReverseTry(listForestEdgeArr);
            Console.WriteLine(string.Join(" ", listForestEdgeReversedArr));

            int[] listForestEdgeA = { 1, 2, 3 };
            int[] listForestEdgeB = { 4, 5, 6 };
            int[] listForestEdgeConcatenatedArray = listForestEdge.ConcatenateArrays(listForestEdgeA, listForestEdgeB);
            Console.WriteLine(string.Join(" ", listForestEdgeConcatenatedArray));

            int[] listForestEdgeInputArray2 = { 1, 2, 3, 4, 5 };
            int[] listForestEdgeRemovedArray = listForestEdge.RemoveArrayPart(listForestEdgeInputArray2, 1, 3);
            Console.WriteLine(string.Join(" ", listForestEdgeRemovedArray));

            int[] listForestEdgeSmoothArray = { 10, 5, 5, 10 };
            bool listForestEdgeIsSmooth = listForestEdge.IsSmooth(listForestEdgeSmoothArray);
            Console.WriteLine("IsSmooth: " + listForestEdgeIsSmooth);

            int[] listForestEdgeArrayToReplace = { 1, 2, 3, 4 };
            int[] listForestEdgeReplacedArray2 = listForestEdge.ReplaceMiddle(listForestEdgeArrayToReplace);
            Console.WriteLine(string.Join(" ", listForestEdgeReplacedArray2));

            int[] listForestEdgeStatus = { 6, 2, 3, 8 };
            int listForestEdgeAdditionalStatues = listForestEdge.solution(listForestEdgeStatus);
            Console.WriteLine("Additional statues needed: " + listForestEdgeAdditionalStatues);



            Console.WriteLine("\nLabyrinth of Nested Loops");

            LabyrinthOfNestedLoops labyrinthOfNestedLoops = new LabyrinthOfNestedLoops();

            bool isPower = labyrinthOfNestedLoops.IsPower(16);
            Console.WriteLine("IsPower: " + isPower);

            int sumCount = labyrinthOfNestedLoops.IsSumOfConsecutive2(15);
            Console.WriteLine("IsSumOfConsecutive2: " + sumCount);

            int sequenceLength = labyrinthOfNestedLoops.SquareDigitsSequence(16);
            Console.WriteLine("SquareDigitsSequence: " + sequenceLength);

            Console.ReadKey();
        }
    }
}
