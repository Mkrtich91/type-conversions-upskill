using NUnit.Framework;
using TypeConversions.TypesForConversions;
using static TypeConversions.BoxingConversions;

namespace TypeConversions.Tests
{
    public class BoxingConversionsTests
    {
        public static IEnumerable<TestCaseData> PointTestCases
        {
            get
            {
                yield return new TestCaseData(new Point { X = 1, Y = 4 });
                yield return new TestCaseData(new Point { X = -11, Y = 4 });
                yield return new TestCaseData(new Point { X = 0, Y = 12 });
                yield return new TestCaseData(new Point { X = 11, Y = 44 });
            }
        }

        [TestCaseSource(nameof(PointTestCases))]
        [Category("Boxing Conversions")]
        public void Boxing_FromPoint_ReturnObject(Point point)
        {
            object obj = BoxToObject(point);
            (point.X, point.Y) = (++point.X, ++point.Y);
#pragma warning disable IDE0038
            Point pointAgain = obj is Point ? (Point)obj : default;
#pragma warning restore IDE0038
            Assert.IsFalse(pointAgain.Equals(point));
        }

        [TestCaseSource(nameof(PointTestCases))]
        [Category("Boxing Conversions")]
        public void Boxing_FromPoint_ReturnValueType(Point point)
        {
            object obj = BoxToValueType(point);
            (point.X, point.Y) = (++point.X, ++point.Y);
#pragma warning disable IDE0038
            Point pointAgain = obj is Point ? (Point)obj : default;
#pragma warning restore IDE0038
            Assert.IsFalse(pointAgain.Equals(point));
        }

        [TestCaseSource(nameof(PointTestCases))]
        [Category("Boxing Conversions")]
        public void Boxing_FromPoint_ReturnIColorable(Point point)
        {
            IColorable obj = BoxToIColorable(point);
            point.Colorize(Color.Purple);
#pragma warning disable IDE0038
            Point pointAgain = obj is Point ? (Point)obj : default;
#pragma warning restore IDE0038
            Assert.IsFalse(pointAgain.Equals(point));
        }

        [TestCase(1)]
        [TestCase(-981)]
        [Category("Boxing Conversions")]
        public void Boxing_FromInt32_ReturnObject(int value)
        {
            object obj = BoxToObject(value);
            value = default;
#pragma warning disable IDE0038
            int valueAgain = obj is int ? (int)obj : default;
#pragma warning restore IDE0038
            Assert.IsFalse(value.Equals(valueAgain));
        }

        [TestCase(1)]
        [TestCase(-124)]
        [Category("Boxing Conversions")]
        public void Boxing_FromInt32_ReturnValueType(int value)
        {
            ValueType valueType = BoxToValueType(value);
            value = default;
#pragma warning disable IDE0038
            int valueAgain = valueType is int ? (int)valueType : default;
#pragma warning restore IDE0038
            Assert.IsFalse(value.Equals(valueAgain));
        }

        [TestCase(1)]
        [TestCase(-100)]
        [Category("Boxing Conversions")]
        public void Boxing_FromInt32_ReturnIFormattable(int value)
        {
            IFormattable formattable = BoxToIFormattable(value);
            value = default;
#pragma warning disable IDE0038
            int valueAgain = formattable is int ? (int)formattable : default;
#pragma warning restore IDE0038
            Assert.IsFalse(value.Equals(valueAgain));
        }

        [TestCase(Color.Green)]
        [TestCase(Color.Orange)]
        [Category("Boxing Conversions")]
        public void Boxing_FromColor_ReturnObject(Color color)
        {
            object obj = BoxToObject(color);
            color = Color.Yellow;
#pragma warning disable IDE0038
            Color colorAgain = obj is Color ? (Color)obj : default;
#pragma warning restore IDE0038
            Assert.IsFalse(color.Equals(colorAgain));
        }

        [TestCase(Color.Green)]
        [TestCase(Color.Orange)]
        [Category("Boxing Conversions")]
        public void Boxing_FromColor_ReturnValueType(Color color)
        {
            ValueType valueType = BoxToValueType(color);
            color = Color.Yellow;
#pragma warning disable IDE0038
            Color colorAgain = valueType is Color ? (Color)valueType : default;
#pragma warning restore IDE0038
            Assert.IsFalse(color.Equals(colorAgain));
        }

        [TestCase(Color.Green)]
        [TestCase(Color.Orange)]
        [Category("Boxing Conversions")]
        public void Boxing_FromColor_ReturnEnum(Color color)
        {
            Enum @enum = BoxToEnum(color);
            color = Color.Yellow;
#pragma warning disable IDE0038
            Color colorAgain = @enum is Color ? (Color)@enum : default;
#pragma warning restore IDE0038
            Assert.IsFalse(color.Equals(colorAgain));
        }
    }
}
