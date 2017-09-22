using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]

        public void AddPositiveIntegersToAList()
        {
            //Arrange
            CustomList<int> Numbers = new CustomList<int>();
            int ExpectedResult1 = 4;
            int ExpectedResult2 = 7;

            //Act
            Numbers.Add(ExpectedResult1);
            Numbers.Add(ExpectedResult2);

            //Assert
            Assert.AreEqual(ExpectedResult1, Numbers[0]);
        }

        public void AddLotsOfPositiveIntegarsToAList()
        {
            //Arrange
            CustomList<int> Numbers = new CustomList<int>();
            int ExpectedResult1 = 9;
            int ExpectedResult2 = 4;
            int ExpectedResult3 = 10;
            int ExpectedResult4 = 13;
            int ExpectedResult5 = 2;
            int ExpectedResult6 = 0;
            int ExpectedResult7 = 6;
            int ExpectedResult8 = 3;
            int ExpectedResult9 = 17;
            int ExpectedResult10 = 5;
            int ExpectedResult11 = 19;
            int ExpectedResult12 = 12;
            int ExpectedResult13 = 7;
            int ExpectedResult14 = 8;
            int ExpectedResult15 = 14;
            int ExpectedResult16 = 1;

            //Act
            Numbers.Add(ExpectedResult1);
            Numbers.Add(ExpectedResult2);
            Numbers.Add(ExpectedResult3);
            Numbers.Add(ExpectedResult4);
            Numbers.Add(ExpectedResult5);
            Numbers.Add(ExpectedResult6);
            Numbers.Add(ExpectedResult7);
            Numbers.Add(ExpectedResult8);
            Numbers.Add(ExpectedResult9);
            Numbers.Add(ExpectedResult10);
            Numbers.Add(ExpectedResult11);
            Numbers.Add(ExpectedResult12);
            Numbers.Add(ExpectedResult13);
            Numbers.Add(ExpectedResult14);
            Numbers.Add(ExpectedResult15);
            Numbers.Add(ExpectedResult16);

            //Assert
            Assert.AreEqual(ExpectedResult1, Numbers[0]);
        }

        public void AddANegativeNumberToAZeroIndex()
        {
            //Arrange
            CustomList<int> Numbers = new CustomList<int>();
            int ExpectedResult = -5;

            //Act
            Numbers.Add(ExpectedResult);

            //Assert
            Assert.AreEqual(ExpectedResult, Numbers[0]);
        }

        public void AddADecimalNumberToZeroIndex()
        {
            //Arrange
            CustomList<double> Numbers = new CustomList<double>();
            double ExpectedResult = .19;

            //Act
            Numbers.Add(ExpectedResult);

            //Assert
            Assert.AreEqual(ExpectedResult, Numbers[0]);
        }

        public void AddLettersToAList()
        {
            //Arrange
            CustomList<string> Letters = new CustomList<string>();
            string ExpectedResult1 = "x";
            string ExpectedResult2 = "y";
            string ExpectedResult3 = "z";

            //Act
            Letters.Add(ExpectedResult1);
            Letters.Add(ExpectedResult2);
            Letters.Add(ExpectedResult3);

            //Assert
            Assert.AreEqual(ExpectedResult3, Letters[2]);
        }
    }
    //    public void RemoveANumberFromAList()
    //    {
    //        //Arrange
    //        CustomList<int> Numbers = new CustomList<int>();
    //        int ExpectedResult = 8;
    //        int ExpectedResult1 = 11;
    //        Numbers.Add(8);
    //        Numbers.Add(11);

    //        //Act
    //        Numbers.Remove(ExpectedResult);

    //        //Assert
    //        Assert.AreEqual(ExpectedResult1, Numbers[0]);
    //    }

    //    public void RemoveNegativeNumbersFromAList()
    //    {
    //        //Arrange
    //        CustomList<double> numbers = new CustomList<double>();
    //        double ExpectedResult1 = -.1;
    //        double ExpectedResult2 = -.6;
    //        numbers.Add(ExpectedResult1);
    //        numbers.Add(ExpectedResult2);

    //        //Act
    //        numbers.Remove(ExpectedResult2);

    //        //Assert
    //        Assert.AreEqual(ExpectedResult1, numbers[0]);
    //    }

    //    public void RemoveNegativeDecimalNumbersFromAList()
    //    {
    //        //Arrange
    //        CustomList<double> Numbers = new CustomList<double>();
    //        double ExpectedResult1 = (-4.6);
    //        double ExpectedResult2 = (-.3);
    //        double ExpectedResult3 = (-.05);
    //        Numbers.Add(ExpectedResult1);
    //        Numbers.Add(ExpectedResult2);
    //        Numbers.Add(ExpectedResult3);

    //        //Act
    //        Numbers.Remove(ExpectedResult1);
    //        Numbers.Remove(ExpectedResult2);

    //        //Assert
    //        Assert.AreEqual(ExpectedResult3, Numbers[0]);
    //    }

    //    public void RemoveStringsFromAList()
    //    {
    //        //Arrange
    //        CustomList<string> Letters = new CustomList<string>();
    //        string ExpectedResult = "q";
    //        string ExpectedResult1 = "y";
    //        Letters.Add("q");
    //        Letters.Add("y");

    //        //Act
    //        Letters.Remove("q");

    //        //Assert
    //        Assert.AreEqual(ExpectedResult1, Letters[0]);
    //    }

    //    public void RemoveLettersAndNumbersFromAList()
    //    {
    //        //Arrange
    //        CustomList<string> LettersAndNumbers = new CustomList<string>();
    //        string ExpectedResult1 = "4";
    //        string ExpectedResult2 = "7";
    //        string ExpectedResult3 = "k";
    //        string ExpectedResult4 = "i";
    //        LettersAndNumbers.Add(ExpectedResult1);
    //        LettersAndNumbers.Add(ExpectedResult2);
    //        LettersAndNumbers.Add(ExpectedResult3);
    //        LettersAndNumbers.Add(ExpectedResult4);

    //        //Act
    //        LettersAndNumbers.Remove(ExpectedResult1);
    //        LettersAndNumbers.Remove(ExpectedResult2);
    //        LettersAndNumbers.Remove(ExpectedResult3);

    //        //Assert
    //        Assert.AreEqual(ExpectedResult4, LettersAndNumbers[1]);
    //    }

    //    public void ZipTestWithIntegers()
    //    {//TODO : Fix Test
    //        //Arrange
    //        CustomList<int> ZipList1 = new CustomList<int>() { 1, 3, 5 };
    //        CustomList<int> ZipList2 = new CustomList<int>() { 2, 4, 6 };

    //        //Act
    //        CustomList<int> ExpectedResult = ZipList1.Zip(ZipList2);

    //        //Assert
    //        Assert.AreEqual();
    //    }

    //    public void ZipTestWithLetters()
    //    {
    //        //TODO Use string list and add strings
    //        //Arrange
    //        CustomList<int> ZipList1 = new CustomList<int>() { P, C, E, S };
    //        CustomList<int> ZipList2 = new CustomList<<int> () { A, K, R };

    //        //Act
    //        CustomList<int> ExpectedResult = ZipList1.Zip(ZipList2);

    //        //Assert
    //        Assert.AreEqual(5);
    //    }

    //    public void ZipTestWithNegativeNumbers()
    //    {
    //        //Arrange
    //        CustomList<int> ZipList1 = new CustomList<int>() { -1, -5, -9 };
    //        CustomList<int> ZipList2 = new CustomList<int> () { -2, -6, -10 };

    //        //Act
    //        CustomList<int> ExpectedResult = ZipList1.Zip(ZipList2);

    //        //Assert
    //        Assert.AreEqual(2);
    //    }

    //public void AddAListOfDecimalsToAList()
    //{
    //    //Arrange
    //    CustomList<double> List1 = new CustomList<double>() { .1, .2, .3, .4, .5, .6, .7 };
    //    CustomList<double> List2 = new CustomList<double>() { .8, .9, 1.0, 1.1, 1.2, 1.3, 1.4 };
    //    CustomList<double> List3 = new CustomList<double>();
    //    //CustomList<double> ExpectedResult = new CustomList<double>() { .1, .2, .3, .4, .5, .6, .7, .8, .9, 1.0, 1.1, 1.2, 1.3, 1.4 };

    //    //Act
    //    List3 = List1 + List2;

    //    //Assert
    //    Assert.AreEqual(List2[0], List3[7]);

    //public void AddAListofStringsToAList()
    //{
    //    //Arrange
    //    CustomList<string> List1 = new CustomList<string>() { "a", "b", "c", "d" };
    //    CustomList<string> List2 = new CustomList<string>() { "e", "f", "g", "h" };
    //    CustomList<string> List3 = new CustomList<string>();
    //    CustomList<string> ExpectedResult = new CustomList<string>() { "a", "b", "c", "d", "e", "f", "g", "h" };

    //    //Act
    //    List3 = List1 + List2;

    //    //Assert
    //    Assert.AreEqual(ExpectedResult, List3);

    // public void SubtractAListOfIntegersFromAList()
    //{
    //    //Arrange
    //    CustomList<int> List1 = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //    CustomList<int> List2 = new CustomList<int>() { 1, 2, 3, 4, 5 };
    //    CustomList<int> List3 = new CustomList<int>();
    //    CustomList<int> ExpectedResult = new CustomList<int>() { 6, 7, 8, 9, 10 };

    //    //Act
    //    List3 = List1 - List2;

    //    //Assert
    //    Assert.AreEqual(ExpectedResult, List3);
    //}

    //public void SubtractAListOfStringsFromAList()
    //{
    //    //Arrange
    //    CustomList<string> List1 = new CustomList<string>() { "S", "N", "O", "W", "M", "E", "N" };
    //    CustomList<string> List2 = new CustomList<string>() { "S", "N", "W" };
    //    CustomList<string> List3 = new CustomList<string>();
    //    CustomList<string> ExpectedResult = new CustomList<string>() { "O", "M", "E", "N" };

    //    //Act
    //    List3 = List1 - List2;

    //    //Assert
    //    Assert.AreEqual(ExpectedResult, List3);
    //}

    //public void CountPropertyImplementationWithIntegers()
    //{
    //    //Arrange
    //    CustomList<int> List = new CustomList<int>();

    //    //Act
    //    List.Add(67);
    //    int Expected = 1;

    //    Assert.AreEqual(Expected, List.Count);
    //}

    //public void CountPropertyImplementationWithDecimals()
    //{
    //    //Arrange
    //    CustomList<double> List = new CustomList<double>();

    //    //Act
    //    List.Add(.2);
    //    List.Add(.9);
    //    List.Add(.6);
    //    List.Add(.3);
    //    int Expected = 4;

    //    Assert.AreEqual(Expected, List.Count);
    //}

    //public void CountPropertyImplementationWithStrings()
    //{
    //    //Arrange
    //    CustomList<string> List = new CustomList<string>();

    //    //Act
    //    List.Add("P");
    //    List.Add("A");
    //    List.Add("C");
    //    List.Add("K");
    //    List.Add("E");
    //    List.Add("R");
    //    List.Add("S");
    //    int Expected = 7;

    //    Assert.AreEqual(Expected, List.Count);
    //}

    //public void IteratingAListOfPositiveNumbers()
    //{
    //    //Arrange
    //    CustomList<int> Numbers = new CustomList<int>()
    //    CustomList<int> OriginalNumberList { 1, 2, 3, 4, 5 }
    //    CustomList<int> ExpectedResult  { 2, 4, 6, 8, 10 }
        

    //    //Act 
    //    ExpectedResult = OriginalNumberList * 2;

    //    //Assert
    //    Assert.AreEqual(ExpectedResult, 2, 4, 6, 8, 10);
    //}

    //public void IteratingAListOfNegativeNumbers()
    //{
    //    //Arrange
    //    CustomList<int> Numbers = new CustomList<int>()
    //    CustomList<int> OriginalNumberList { -1, -2, -3, -4, -5 }
    //    CustomList<int> ExpectedResult  { 2, 4, 6, 8, 10 }
    //    int -2;

    //    //Act 
    //    ExpectedResult = OriginalNumberList * -2;

    //    //Assert
    //    Assert.AreEqual(ExpectedResult, 2, 4, 6, 8, 10);
    //}

    //public void OverrideToStringMethodWithIntegers()
    //{
    //    //Arrange
    //    CustomList<int> List = new CustomList<int>();
    //    List.Add(2);
    //    List.Add(4);
    //    List.Add(6);
    //    string Expected = "246";

    //    //Act
    //    string Result = List.ToString();

    //    //Assert
    //    Assert.AreEqual(Expected, Result);
    //}

    //public void OverrideToStringMethodWithLetters()
    //{
    //    //Arrange
    //    CustomList<string> List = new CustomList<string>();
    //    List.Add("so");
    //    List.Add("cc");
    //    List.Add("er");
    //    List.Add("ba");
    //    List.Add("ll");
    //    string Expected = "soccerball";

    //    //Act
    //    string Result = List.ToString();

    //    //Assert
    //    Assert.AreEqual(Expected, Result);
    //}

    //public void SortingAlgorithm()
    //{

    //}
}