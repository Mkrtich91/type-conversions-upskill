using NUnit.Framework;
using TypeConversions.TypesForConversions;
using static TypeConversions.ExplicitReferenceConversions;

namespace TypeConversions.Tests
{
    public class ExplicitReferenceConversionsTests
    {
#pragma warning disable IDE0044
        private static string circleName = "Circle";
#pragma warning restore IDE0044
#pragma warning disable IDE0044
        private static string squareName = "Square";
#pragma warning restore IDE0044
#pragma warning disable IDE0044
        private static double side = 1.1;
#pragma warning restore IDE0044
#pragma warning disable IDE0044
        private static double radius = 2.3;
#pragma warning restore IDE0044
#pragma warning disable IDE0044
        private static Color color = Color.Blue;
#pragma warning restore IDE0044

        public static IEnumerable<TestCaseData> ObjectToCircleTestCases
        {
            get
            {
                yield return new TestCaseData(new Circle(circleName, radius), new Func<object, Circle?>(CastExpressionFromObjectToCircle));
                yield return new TestCaseData(new Circle(circleName, radius), new Func<object, Circle?>(AsOperatorFromObjectToCircle));
                yield return new TestCaseData(new Circle(circleName, radius), new Func<object, Circle?>(PatternMatchingFromObjectToCircle));
            }
        }

        public static IEnumerable<TestCaseData> ObjectToCircleFailedTestCases
        {
            get
            {
                yield return new TestCaseData(new Square(squareName, side), new Func<object, Circle?>(CastExpressionFromObjectToCircle));
                yield return new TestCaseData(new Square(squareName, side), new Func<object, Circle?>(AsOperatorFromObjectToCircle));
                yield return new TestCaseData(new Square(squareName, side), new Func<object, Circle?>(PatternMatchingFromObjectToCircle));
            }
        }

        public static IEnumerable<TestCaseData> ObjectToSquareTestCases
        {
            get
            {
                yield return new TestCaseData(new Square(squareName, side), new Func<object, Square?>(CastExpressionFromObjectToSquare));
                yield return new TestCaseData(new Square(squareName, side), new Func<object, Square?>(AsOperatorFromObjectToSquare));
                yield return new TestCaseData(new Square(squareName, side), new Func<object, Square?>(PatternMatchingFromObjectToSquare));
            }
        }

        public static IEnumerable<TestCaseData> ObjectToSquareFailedTestCases
        {
            get
            {
                yield return new TestCaseData(new Circle(circleName, radius), new Func<object, Square?>(CastExpressionFromObjectToSquare));
                yield return new TestCaseData(new Circle(circleName, radius), new Func<object, Square?>(AsOperatorFromObjectToSquare));
                yield return new TestCaseData(new Circle(circleName, radius), new Func<object, Square?>(PatternMatchingFromObjectToSquare));
            }
        }

        public static IEnumerable<TestCaseData> ObjectToShapeTestCases
        {
            get
            {
                yield return new TestCaseData(new Circle(circleName, radius), new Func<object, Shape?>(CastExpressionFromObjectToShape));
                yield return new TestCaseData(new Circle(circleName, radius), new Func<object, Shape?>(AsOperatorFromObjectToShape));
                yield return new TestCaseData(new Circle(circleName, radius), new Func<object, Shape?>(PatternMatchingFromObjectToShape));
                yield return new TestCaseData(new Square(squareName, side), new Func<object, Shape?>(CastExpressionFromObjectToShape));
                yield return new TestCaseData(new Square(squareName, side), new Func<object, Shape?>(AsOperatorFromObjectToShape));
                yield return new TestCaseData(new Square(squareName, side), new Func<object, Shape?>(PatternMatchingFromObjectToShape));
            }
        }

        public static IEnumerable<TestCaseData> ShapeToCircleTestCases
        {
            get
            {
                yield return new TestCaseData(new Circle(circleName, radius), new Func<Shape, Circle?>(CastExpressionShapeToCircle));
                yield return new TestCaseData(new Circle(circleName, radius), new Func<Shape, Circle?>(AsOperatorFromShapeToCircle));
                yield return new TestCaseData(new Circle(circleName, radius), new Func<Shape, Circle?>(PatternMatchingFromShapeToCircle));
            }
        }

        public static IEnumerable<TestCaseData> ShapeToCircleFailedTestCases
        {
            get
            {
                yield return new TestCaseData(new Square(squareName, side), new Func<Shape, Circle?>(CastExpressionShapeToCircle));
                yield return new TestCaseData(new Square(squareName, side), new Func<Shape, Circle?>(AsOperatorFromShapeToCircle));
                yield return new TestCaseData(new Square(squareName, side), new Func<Shape, Circle?>(PatternMatchingFromShapeToCircle));
            }
        }

        public static IEnumerable<TestCaseData> ShapeToSquareTestCases
        {
            get
            {
                yield return new TestCaseData(new Square(squareName, side), new Func<Shape, Square?>(CastExpressionFromShapeToSquare));
                yield return new TestCaseData(new Square(squareName, side), new Func<Shape, Square?>(AsOperatorFromShapeToSquare));
                yield return new TestCaseData(new Square(squareName, side), new Func<Shape, Square?>(PatternMatchingFromShapeToSquare));
            }
        }

        public static IEnumerable<TestCaseData> ShapeToSquareFailedTestCases
        {
            get
            {
                yield return new TestCaseData(new Circle(circleName, radius), new Func<Shape, Square?>(CastExpressionFromShapeToSquare));
                yield return new TestCaseData(new Circle(circleName, radius), new Func<Shape, Square?>(AsOperatorFromShapeToSquare));
                yield return new TestCaseData(new Circle(circleName, radius), new Func<Shape, Square?>(PatternMatchingFromShapeToSquare));
            }
        }

        public static IEnumerable<TestCaseData> ColorableToSquareTestCases
        {
            get
            {
                yield return new TestCaseData(new Square(squareName, side), new Func<IColorable, Square?>(CastExpressionFromIColorableToSquare));
                yield return new TestCaseData(new Square(squareName, side), new Func<IColorable, Square?>(AsOperatorFromIColorableToSquare));
                yield return new TestCaseData(new Square(squareName, side), new Func<IColorable, Square?>(PatternMatchingFromIColorableToSquare));
            }
        }

        [TestCaseSource(nameof(ObjectToCircleTestCases))]
        [Category("Explicit Reference Conversions")]
        public void Convert_FromObject_ReturnCircle(object obj, Func<object, Circle?> converter)
        {
            Circle circle = converter(obj)!;
            Assert.That(circle == obj);
            Assert.That(circle.GetType() == obj.GetType());
            Assert.That(circle.Name == circleName);
            Assert.That(Math.Abs(circle.Radius - radius) < double.Epsilon);
        }

        [TestCaseSource(nameof(ObjectToCircleFailedTestCases))]
        [Category("Explicit Reference Conversions")]
        public void Convert_FromObjectToCircle_ReturnNull(object obj, Func<object, Circle?> converter)
        {
            Assert.That(converter(obj) is null);
        }

        [TestCaseSource(nameof(ObjectToSquareTestCases))]
        [Category("Explicit Reference Conversions")]
        public void Convert_FromObject_ReturnSquare(object obj, Func<object, Square?> converter)
        {
            var square = converter(obj)!;
            Assert.That(square == obj);
            Assert.That(square.GetType() == obj.GetType());
            Assert.That(square.Name == squareName);
            Assert.That(Math.Abs(square.Side - side) < double.Epsilon);
        }

        [TestCaseSource(nameof(ObjectToSquareFailedTestCases))]
        [Category("Explicit Reference Conversions")]
        public void Convert_FromObjectToSquare_ReturnNull(object obj, Func<object, Square?> converter)
        {
            Assert.That(converter(obj) is null);
        }

        [TestCaseSource(nameof(ObjectToShapeTestCases))]
        [Category("Explicit Reference Conversions")]
        public void Convert_FromObject_ReturnShape(object obj, Func<object, Shape?> converter)
        {
            Shape shape = converter(obj)!;
            Assert.That(shape.GetType() == obj.GetType());
            Assert.That(shape.Name == squareName || shape.Name == circleName);
        }

        [TestCaseSource(nameof(ShapeToCircleTestCases))]
        [Category("Explicit Reference Conversions")]
        public void Convert_FromShape_ReturnCircle(Shape shape, Func<Shape, Circle?> converter)
        {
            var circle = converter(shape)!;
            Assert.That(circle.GetType() == shape.GetType());
            Assert.That(circle.Name == circleName);
            Assert.That(Math.Abs(circle.Radius - radius) < double.Epsilon);
        }

        [TestCaseSource(nameof(ShapeToCircleFailedTestCases))]
        [Category("Explicit Reference Conversions")]
        public void Convert_FromShapeToCircle_ReturnNull(Shape shape, Func<Shape, Circle?> converter)
        {
            Assert.That(converter(shape) is null);
        }

        [TestCaseSource(nameof(ShapeToSquareTestCases))]
        [Category("Explicit Reference Conversions")]
        public void Convert_FromShape_ReturnSquare(Shape shape, Func<Shape, Square?> converter)
        {
            var square = converter(shape)!;
            Assert.That(square.GetType() == shape.GetType());
            Assert.That(square.Name == squareName);
            Assert.That(Math.Abs(square.Side - side) < double.Epsilon);
        }

        [TestCaseSource(nameof(ShapeToSquareFailedTestCases))]
        [Category("Explicit Reference Conversions")]
        public void Convert_FromShapeToSquare_ReturnNull(Shape shape, Func<Shape, Square?> converter)
        {
            Assert.That(converter(shape) is null);
        }

        [TestCaseSource(nameof(ColorableToSquareTestCases))]
        [Category("Explicit Reference Conversions")]
        public void Convert_FromIColorable_ReturnSquare(IColorable colorable, Func<IColorable, Square?> converter)
        {
            var square = converter(colorable)!;
            colorable.Colorize(color);
            Assert.That(square.GetType() == colorable.GetType());
            Assert.That(square.Name == squareName);
            Assert.That(square.Color == color);
            Assert.That(Math.Abs(square.Side - side) < double.Epsilon);
        }
    }
}
