using TypeConversions.TypesForConversions;

namespace TypeConversions
{
    public static class UnboxingConversions
    {
        /// <summary>
        /// Performs an unboxing conversion <see cref="object"/> type to <see cref="Point"/> type by using 'cast expression' syntax.
        /// </summary>
        /// <param name="object"><see cref="object"/> object.</param>
        /// <returns><see cref="Point"/> object or null when unable to cast <see cref="object"/> type to <see cref="Point"/> type.</returns>
#pragma warning disable CA1720
        public static Point? CastExpressionFromObjectToPoint(object @object)
#pragma warning restore CA1720
        {
            Point? point = @object as Point?;
            return point;
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="object"/> type to <see cref="Point"/> type by using 'as operator' syntax.
        /// </summary>
        /// <param name="object"><see cref="object"/> object.</param>
        /// <returns><see cref="Point"/> object or null when unable to cast <see cref="object"/> type to <see cref="Point"/> type.</returns>
#pragma warning disable S4144
#pragma warning disable CA1720
        public static Point? AsOperatorFromObjectToPoint(object @object)
#pragma warning restore CA1720
#pragma warning restore S4144
        {
            Point? point = @object as Point?;
            return point;
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="object"/> type to <see cref="Point"/> type by using pattern matching.
        /// </summary>
        /// <param name="object"><see cref="object"/> object.</param>
        /// <returns><see cref="Point"/> object or null when unable to cast <see cref="object"/> type to <see cref="Point"/> type.</returns>
#pragma warning disable CA1720
        public static Point? PatternMatchingFromObjectToPoint(object @object)
#pragma warning restore CA1720
        {
            if (@object is Point point)
            {
                return point;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="ValueType"/> type to <see cref="Point"/> type by using 'cast expression' syntax.
        /// </summary>
        /// <param name="valueType"><see cref="ValueType"/> object.</param>
        /// <returns><see cref="Point"/> object or null when unable to cast <see cref="ValueType"/> type to <see cref="Point"/> type.</returns>
        public static Point? CastExpressionFromValueTypeToPoint(ValueType valueType)
        {
            Point? point = valueType as Point?;
            return point;
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="ValueType"/> type to <see cref="Point"/> type by using 'as operator' syntax.
        /// </summary>
        /// <param name="valueType"><see cref="ValueType"/> object.</param>
        /// <returns><see cref="Point"/> object or null when unable to cast <see cref="ValueType"/> type to <see cref="Point"/> type.</returns>
        public static Point? AsOperatorFromValueTypeToPoint(ValueType valueType)
        {
            if (valueType is Point point)
            {
                return point;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="ValueType"/> type to <see cref="Point"/> type by using 'pattern matching' syntax.
        /// </summary>
        /// <param name="valueType"><see cref="ValueType"/> object.</param>
        /// <returns><see cref="Point"/> object or null when unable to cast <see cref="ValueType"/> type to <see cref="Point"/> type.</returns>
        public static Point? PatternMatchingFromValueTypeToPoint(ValueType valueType)
        {
            if (valueType is Point point)
            {
                return point;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="IColorable"/> type to <see cref="Point"/> type by using 'cast expression' syntax.
        /// </summary>
        /// <param name="colorable"><see cref="IColorable"/> object.</param>
        /// <returns><see cref="Point"/> object or null when unable to cast <see cref="IColorable"/> type to <see cref="Point"/> type.</returns>
        public static Point? CastExpressionFromIColorableToPoint(IColorable colorable)
        {
            if (colorable is Point point)
            {
                return (Point?)point;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="IColorable"/> type to <see cref="Point"/> type by using 'as operator' syntax.
        /// </summary>
        /// <param name="colorable"><see cref="IColorable"/> object.</param>
        /// <returns><see cref="Point"/> object or null when unable to cast <see cref="IColorable"/> type to <see cref="Point"/> type.</returns>
        public static Point? AsOperatorFromIColorableToPoint(IColorable colorable)
        {
            if (colorable is Point point)
            {
                return point;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="IColorable"/> type to <see cref="Point"/> type by using 'pattern matching' syntax.
        /// </summary>
        /// <param name="colorable"><see cref="IColorable"/> object.</param>
        /// <returns><see cref="Point"/> object or null when unable to cast <see cref="IColorable"/> type to <see cref="Point"/> type.</returns>
        public static Point? PatternMatchingFromIColorableToPoint(IColorable colorable)
        {
            if (colorable is Point point)
            {
                return point;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="object"/> type to <see cref="Color"/> type by using 'cast expression' syntax.
        /// </summary>
        /// <param name="object"><see cref="object"/> object.</param>
        /// <returns><see cref="Color"/> object or null when unable to cast <see cref="object"/> type to <see cref="Color"/> type.</returns>
#pragma warning disable CA1720
        public static Color? CastExpressionFromObjectToColor(object @object)
#pragma warning restore CA1720
        {
            if (@object is Color point)
            {
                return point;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="object"/> type to <see cref="Color"/> type by using 'as operator' syntax.
        /// </summary>
        /// <param name="object"><see cref="object"/> object.</param>
        /// <returns><see cref="Color"/> object or null when unable to cast <see cref="object"/> type to <see cref="Color"/> type.</returns>
#pragma warning disable CA1720
        public static Color? AsOperatorFromObjectToColor(object @object)
#pragma warning restore CA1720
        {
            if (@object is Color color)
            {
                return color;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="object"/> type to <see cref="Color"/> type by using 'pattern matching'.
        /// </summary>
        /// <param name="object"><see cref="object"/> object.</param>
        /// <returns><see cref="Color"/> object or null when unable to cast <see cref="object"/> type to <see cref="Color"/> type.</returns>
#pragma warning disable CA1720
        public static Color? PatternMatchingFromObjectToColor(object @object)
#pragma warning restore CA1720
        {
            if (@object is Color color)
            {
                return color;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="ValueType"/> type to <see cref="Color"/> type by using 'cast expression' syntax.
        /// </summary>
        /// <param name="valueType"><see cref="object"/> object.</param>
        /// <returns><see cref="Color"/> object or null when unable to cast <see cref="ValueType"/> type to <see cref="Color"/> type.</returns>
        public static Color? CastExpressionFromValueTypeToColor(ValueType valueType)
        {
            if (valueType is Color color)
            {
                return color;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="ValueType"/> type to <see cref="Color"/> type by using 'as operator' syntax.
        /// </summary>
        /// <param name="valueType"><see cref="ValueType"/> object.</param>
        /// <returns><see cref="Color"/> object or null when unable to cast <see cref="object"/> type to <see cref="Color"/> type.</returns>
        public static Color? AsOperatorFromValueTypeToColor(ValueType valueType)
        {
            if (valueType is Color a)
            {
                return a;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="ValueType"/> type to <see cref="Color"/> type by using 'pattern matching'.
        /// </summary>
        /// <param name="valueType"><see cref="ValueType"/> object.</param>
        /// <returns><see cref="Color"/> object or null when unable to cast <see cref="ValueType"/> type to <see cref="Color"/> type.</returns>
        public static Color? PatternMatchingFromValueTypeToColor(ValueType valueType)
        {
            if (valueType is Color color)
            {
                return color;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="Enum"/> type to <see cref="Color"/> type by using 'cast expression' syntax.
        /// </summary>
        /// <param name="enum"><see cref="Enum"/> object.</param>
        /// <returns><see cref="Color"/> object or null when unable to cast <see cref="Enum"/> type to <see cref="Color"/> type.</returns>
        public static Color? CastExpressionFromEnumToColor(Enum @enum)
        {
            if (@enum is Color color)
            {
                return color;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="Enum"/> type to <see cref="Color"/> type by using 'as operator' syntax.
        /// </summary>
        /// <param name="enum"><see cref="Enum"/> object.</param>
        /// <returns><see cref="Color"/> object or null when unable to cast <see cref="Enum"/> type to <see cref="Color"/> type.</returns>
        public static Color? AsOperatorFromEnumToColor(Enum @enum)
        {
            if (@enum is Color color)
            {
                return color;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="Enum"/> type to <see cref="Color"/> type by using 'pattern matching'.
        /// </summary>
        /// <param name="enum"><see cref="Enum"/> object.</param>
        /// <returns><see cref="Color"/> object or null when unable to cast <see cref="Enum"/> type to <see cref="Color"/> type.</returns>
        public static Color? PatternMatchingFromEnumToColor(Enum @enum)
        {
            if (@enum is Color color)
            {
                return color;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="object"/> type to <see cref="int"/> type by using 'cast expression' syntax.
        /// </summary>
        /// <param name="object"><see cref="object"/> object.</param>
        /// <returns><see cref="int"/> object or null when unable to cast <see cref="object"/> type to <see cref="int"/> type.</returns>
#pragma warning disable CA1720
        public static int? CastExpressionFromObjectToInt32(object @object)
#pragma warning restore CA1720
        {
            if (@object is int color)
            {
                return color;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="object"/> type to <see cref="int"/> type by using 'as operator' syntax.
        /// </summary>
        /// <param name="object"><see cref="object"/> object.</param>
        /// <returns><see cref="int"/> object or null when unable to cast <see cref="object"/> type to <see cref="int"/> type.</returns>
#pragma warning disable CA1720
        public static int? AsOperatorFromObjectToInt32(object @object)
#pragma warning restore CA1720
        {
            if (@object is int c)
            {
                return c;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="object"/> type to <see cref="int"/> type by using pattern matching.
        /// </summary>
        /// <param name="object"><see cref="object"/> object.</param>
        /// <returns><see cref="int"/> object or null when unable to cast <see cref="object"/> type to <see cref="int"/> type.</returns>
#pragma warning disable CA1720
        public static int? PatternMatchingFromObjectToInt32(object @object)
#pragma warning restore CA1720
        {
            if (@object is int b)
            {
                return b;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="ValueType"/> type to <see cref="int"/> type by using 'cast expression' syntax.
        /// </summary>
        /// <param name="valueType"><see cref="ValueType"/> object.</param>
        /// <returns><see cref="int"/> object or null when unable to cast <see cref="ValueType"/> type to <see cref="int"/> type.</returns>
        public static int? CastExpressionFromValueTypeToInt32(ValueType valueType)
        {
            if (valueType is int color)
            {
                return color;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="ValueType"/> type to <see cref="int"/> type by using 'as operator' syntax.
        /// </summary>
        /// <param name="valueType"><see cref="ValueType"/> object.</param>
        /// <returns><see cref="int"/> object or null when unable to cast <see cref="ValueType"/> type to <see cref="int"/> type.</returns>
        public static int? AsOperatorFromValueTypeToInt32(ValueType valueType)
        {
            if (valueType is int @enum)
            {
                return @enum;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="ValueType"/> type to <see cref="int"/> type by using pattern matching.
        /// </summary>
        /// <param name="valueType"><see cref="ValueType"/> object.</param>
        /// <returns><see cref="int"/> object or null when unable to cast <see cref="ValueType"/> type to <see cref="int"/> type.</returns>
        public static int? PatternMatchingFromValueTypeToInt32(ValueType valueType)
        {
            if (valueType is int a)
            {
                return a;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="IFormattable"/> type to <see cref="int"/> type by using 'cast expression' syntax.
        /// </summary>
        /// <param name="formattable"><see cref="IFormattable"/> object.</param>
        /// <returns><see cref="int"/> object or null when unable to cast <see cref="IFormattable"/> type to <see cref="int"/> type.</returns>
        public static int? CastExpressionFromIFormattableToInt32(IFormattable formattable)
        {
            if (formattable is int value)
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="IFormattable"/> type to <see cref="int"/> type by using 'as operator' syntax.
        /// </summary>
        /// <param name="formattable"><see cref="IFormattable"/> object.</param>
        /// <returns><see cref="int"/> object or null when unable to cast <see cref="IFormattable"/> type to <see cref="int"/> type.</returns>
        public static int? AsOperatorFromIFormattableToInt32(IFormattable formattable)
        {
            if (formattable is int a)
            {
                return a;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an unboxing conversion <see cref="IFormattable"/> type to <see cref="int"/> type by using pattern matching.
        /// </summary>
        /// <param name="formattable"><see cref="IFormattable"/> object.</param>
        /// <returns><see cref="int"/> object or null when unable to cast <see cref="IFormattable"/> type to <see cref="int"/> type.</returns>
        public static int? PatternMatchingFromIFormattableToInt32(IFormattable formattable)
        {
            return formattable switch
            {
                int intValue => intValue,
                _ => null,
            };
        }
    }
}
