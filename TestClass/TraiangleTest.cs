using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TriangleTest
{
    public class TraiangleTest
    {
        [TestFixture]

        public class TriangleTest1
        {

            //ValidTriangle_Input60and60an60_OutputValidTriangle
            //one(1) test for a valid equilateral triangle
            [Test]

            public void ValidEquilateralTriangle_Input3and3and3_OutputValidEquilateralTriangle()//test 1
            {
                //Arrange
                int firstSide = 3;
                int secondSide = 3;
                int thirdSide = 3;

                string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";


                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);


                //Assert
                Assert.AreEqual(expected, actual);
            }

            //Three(3) tests for a valid isosceles triangle
            [Test]

            public void ValidIsoscelesTriangle_Input3and3and4_OutputValidIsoscelesTriangle() //test 2
            {
                //Arrange
                int firstSide = 3;
                int secondSide = 3;
                int thirdSide = 4;

                string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void ValidIsoscelesTriangle_Input3and4and3_OutputValidIsoscelesTriangle()//test 3
            {
                //Arrange
                int firstSide = 3;
                int secondSide = 4;
                int thirdSide = 3;

                string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void ValidIsoscelesTriangle_Input4and3ang3_OutputValidIsoscelesTriangle() // test 4
            {
                //Arrange
                int firstSide = 4;
                int secondSide = 3;
                int thirdSide = 3;

                string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            //Five (5) tests for a valid scalene triangle
            [Test]

            public void ValidScaleneTriangle_Input5and4and3_OutputValidScaleneTriangle() // test 5
            {
                //Arrange
                int firstSide = 5;
                int secondSide = 4;
                int thirdSide = 3;

                string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void ValidScaleneTriangle_Input5and3and4_OutputValidScaleneTriangle() // test 6
            {
                //Arrange
                int firstSide = 5;
                int secondSide = 3;
                int thirdSide = 4;

                string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]

            public void ValidScaleneTriangle_Input4and5and3_OutputValidScaleneTriangle() // test 7
            {
                //Arrange
                int firstSide = 4;
                int secondSide = 5;
                int thirdSide = 3;

                string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }


            [Test]

            public void ValidScaleneTriangle_Input4and3and5_OutputValidScaleneTriangle() // test 8
            {
                //Arrange
                int firstSide = 4;
                int secondSide = 3;
                int thirdSide = 5;

                string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }


            [Test]

            public void ValidScaleneTriangle_Input3and4and5_OutputScaleneTriangle() // test 9
            {
                //Arrange
                int firstSide = 3;
                int secondSide = 4;
                int thirdSide = 5;

                string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            ////Three (3) tests for verifying a zero length for one or more sides
            //[Test]

            //public void InvalidZeroLengthTriangle_Input0and4and5_OutputInvalidTriangle() // test 10
            //{
            //    //Arrange
            //    int firstSide = 0;
            //    int secondSide = 4;
            //    int thirdSide = 5;

            //    string expected = "At least one side of your triangle has a zero length and is thus invalid";

            //    //Act
            //    string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //    //Assert
            //    Assert.AreEqual(expected, actual);
            //}

            //[Test]

            //public void InvalidZeroLengthTriangle_Input0and0and5_OutputInvalidTriangle() // test 11
            //{
            //    //Arrange
            //    int firstSide = 0;
            //    int secondSide = 0;
            //    int thirdSide = 5;

            //    string expected = "At least one side of your triangle has a zero length and is thus invalid";

            //    //Act
            //    string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //    //Assert
            //    Assert.AreEqual(expected, actual);
            //}

            //[Test]

            //public void InvalidZeroLengthTriangle3_Input0and0and0_OutputInvalidTriangle() // test 12
            //{
            //    //Arrange
            //    int firstSide = 0;
            //    int secondSide = 0;
            //    int thirdSide = 0;

            //    string expected = "At least one side of your triangle has a zero length and is thus invalid";

            //    //Act
            //    string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //    //Assert
            //    Assert.AreEqual(expected, actual);
            //}

            ////Three (3) tests for verifying an invalid response (other than a zero length)
            //[Test]

            //public void InvalidLengthTriangle_Input3and4and8_OutputInvalidTriangle() // test 13
            //{
            //    //Arrange
            //    int firstSide = 3;
            //    int secondSide = 4;
            //    int thirdSide = 8;

            //    string expected = "Based on the values entered, the triangle is INVALID";

            //    //Act
            //    string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //    //Assert
            //    Assert.AreEqual(expected, actual);
            //}

            //[Test]

            //public void InvalidLengthTriangle_Input8and4and3_OutputInvalidTriangle() // test 14
            //{
            //    //Arrange
            //    int firstSide = 8;
            //    int secondSide = 4;
            //    int thirdSide = 3;

            //    string expected = "Based on the values entered, the triangle is INVALID";

            //    //Act
            //    string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //    //Assert
            //    Assert.AreEqual(expected, actual);
            //}

            //[Test]

            //public void InvalidLengthTriangle_Input3and8and4_OutputInvalidTriangle() // test 15
            //{
            //    //Arrange
            //    int firstSide = 3;
            //    int secondSide = 8;
            //    int thirdSide = 4;

            //    string expected = "Based on the values entered, the triangle is INVALID";

            //    //Act
            //    string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //    //Assert
            //    Assert.AreEqual(expected, actual);
            //}

        }
    }
    
}
