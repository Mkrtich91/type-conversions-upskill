using TypeConversions.TypesForConversions;

namespace TypeConversions
{
    public static class BoxingConversions
    {
        /// <summary>
        /// Performs an boxing conversion custom <see cref="Point"/> struct to <see cref="object"/> class.
        /// </summary>
        /// <param name="point"><see cref="Point"/> object.</param>
        /// <returns><see cref="object"/> object.</returns>
        public static object BoxToObject(Point point)
        {
            object boxedPoint = point;
            return boxedPoint;
        }

        /// <summary>
        /// Performs an boxing conversion build-in <see cref="int"/> struct to <see cref="object"/> class.
        /// </summary>
        /// <param name="value"><see cref="int"/> object.</param>
        /// <returns><see cref="object"/> object.</returns>
        public static object BoxToObject(int value) => value;

        /// <summary>
        /// Performs an boxing conversion custom <see cref="Color"/> enum to <see cref="object"/> class.
        /// </summary>
        /// <param name="color"><see cref="Color"/> object.</param>
        /// <returns><see cref="object"/> object.</returns>
        public static object BoxToObject(Color color) => color;

        /// <summary>
        /// Performs an boxing conversion custom <see cref="Point"/> struct to <see cref="ValueType"/> class.
        /// </summary>
        /// <param name="point"><see cref="Point"/> object.</param>
        /// <returns><see cref="ValueType"/> object.</returns>
        public static ValueType BoxToValueType(Point point)
        {
            ValueType vtype = point;
            return vtype;
        }

        /// <summary>
        /// Performs an boxing conversion build-in <see cref="int"/> struct to <see cref="ValueType"/> class.
        /// </summary>
        /// <param name="value"><see cref="int"/> object.</param>
        /// <returns><see cref="ValueType"/> object.</returns>
        public static ValueType BoxToValueType(int value)
        {
            ValueType valueType = value;
            return valueType;
        }

        /// <summary>
        /// Performs an boxing conversion custom <see cref="Color"/> enum to <see cref="ValueType"/> class.
        /// </summary>
        /// <param name="color"><see cref="int"/> object.</param>
        /// <returns><see cref="ValueType"/> object.</returns>
        public static ValueType BoxToValueType(Color color)
        {
            ValueType valueType = color;
            return valueType;
        }

        /// <summary>
        /// Performs an boxing conversion custom <see cref="Point"/> struct to <see cref="IColorable"/> interface.
        /// </summary>
        /// <param name="point"><see cref="Point"/> object.</param>
        /// <returns><see cref="IColorable"/> object.</returns>
        public static IColorable BoxToIColorable(Point point)
        {
            IColorable colorable = point;
            return colorable;
        }

        /// <summary>
        /// Performs an boxing conversion build-in <see cref="int"/> struct to <see cref="IFormattable"/> interface.
        /// </summary>
        /// <param name="value"><see cref="int"/> object.</param>
        /// <returns><see cref="IFormattable"/> object.</returns>
        public static IFormattable BoxToIFormattable(int value) => value;

        /// <summary>
        /// Performs an boxing conversion custom <see cref="Color"/> enum to <see cref="Enum"/> class.
        /// </summary>
        /// <param name="color"><see cref="Color"/> object.</param>
        /// <returns><see cref="Enum"/> object.</returns>
        public static Enum BoxToEnum(Color color)
        {
            Enum a = color;
            return a;
        }
    }
}
