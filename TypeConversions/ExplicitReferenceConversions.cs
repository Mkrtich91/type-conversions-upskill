using TypeConversions.TypesForConversions;

namespace TypeConversions
{
    public static class ExplicitReferenceConversions
    {
        /// <summary>
        /// Performs an explicit conversion <see cref="object"/> type to <see cref="Circle"/> type by using 'cast expression' syntax.
        /// </summary>
        /// <param name="object"><see cref="object"/> object.</param>
        /// <returns><see cref="Circle"/> object or null when unable to cast <see cref="object"/> type to <see cref="Circle"/> type.</returns>
#pragma warning disable CA1720
        public static Circle? CastExpressionFromObjectToCircle(object @object) => @object as Circle;
#pragma warning restore CA1720

        /// <summary>
        /// Performs an explicit conversion <see cref="object"/> type to <see cref="Square"/> type by using 'cast expression' syntax.
        /// </summary>
        /// <param name="object"><see cref="object"/> object.</param>
        /// <returns><see cref="Square"/> object or null when unable to cast <see cref="object"/> type to <see cref="Square"/> type.</returns>
#pragma warning disable CA1720
        public static Square? CastExpressionFromObjectToSquare(object @object)
#pragma warning restore CA1720
        {
            return @object as Square;
        }

        /// <summary>
        /// Performs an explicit conversion <see cref="object"/> type to <see cref="Shape"/> type by using 'cast expression' syntax.
        /// </summary>
        /// <param name="object"><see cref="object"/> object.</param>
        /// <returns><see cref="Shape"/> object or null when unable to cast <see cref="object"/> type to <see cref="Shape"/> type.</returns>
#pragma warning disable CA1720
        public static Shape? CastExpressionFromObjectToShape(object @object)
#pragma warning restore CA1720
        {
            if (@object is Shape sh)
            {
                return sh;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Performs an explicit conversion <see cref="Shape"/> type to <see cref="Circle"/> type by using 'cast expression' syntax.
        /// </summary>
        /// <param name="shape"><see cref="Shape"/> object.</param>
        /// <returns><see cref="Circle"/> object or null when unable to cast <see cref="Shape"/> type to <see cref="Circle"/> type.</returns>
        public static Circle? CastExpressionShapeToCircle(Shape shape)
        {
            return shape as Circle;
        }

        /// <summary>
        /// Performs an explicit conversion <see cref="Shape"/> type to <see cref="Square"/> type by using 'cast expression' syntax.
        /// </summary>
        /// <param name="shape"><see cref="Shape"/> object.</param>
        /// <returns><see cref="Square"/> object or null when unable to cast <see cref="Shape"/> type to <see cref="Square"/> type.</returns>
        public static Square? CastExpressionFromShapeToSquare(Shape shape)
        {
            return shape as Square;
        }

        /// <summary>
        /// Performs an explicit conversion <see cref="IColorable"/> type to <see cref="Square"/> type by using 'cast expression' syntax.
        /// </summary>
        /// <param name="colorable"><see cref="IColorable"/> object.</param>
        /// <returns><see cref="Square"/> object or null when unable to cast <see cref="IColorable"/> type to <see cref="Square"/> type.</returns>
        public static Square? CastExpressionFromIColorableToSquare(IColorable colorable) => colorable as Square;

        /// <summary>
        /// Performs an explicit conversion <see cref="object"/> type to <see cref="Shape"/> type by using 'as operator' syntax.
        /// </summary>
        /// <param name="object"><see cref="object"/> object.</param>
        /// <returns><see cref="Shape"/> object or null when unable to cast <see cref="object"/> type to <see cref="Shape"/> type.</returns>
#pragma warning disable CA1720 // Identifier contains type name
        public static Shape? AsOperatorFromObjectToShape(object @object) => @object as Shape;
#pragma warning restore CA1720 // Identifier contains type name

        /// <summary>
        /// Performs an explicit conversion <see cref="object"/> type to <see cref="Square"/> type by using 'as operator' syntax.
        /// </summary>
        /// <param name="object"><see cref="object"/> object.</param>
        /// <returns><see cref="Square"/> object or null when unable to cast <see cref="object"/> type to <see cref="Square"/> type.</returns>
#pragma warning disable CA1720
        public static Square? AsOperatorFromObjectToSquare(object @object)
#pragma warning restore CA1720
        {
            return @object as Square;
        }

        /// <summary>
        /// Performs an explicit conversion <see cref="object"/> type to <see cref="Circle"/> type by using 'as operator' syntax.
        /// </summary>
        /// <param name="object"><see cref="object"/> object.</param>
        /// <returns><see cref="Circle"/> object or null when unable to cast <see cref="object"/> type to <see cref="Circle"/> type.</returns>
#pragma warning disable CA1720
        public static Circle? AsOperatorFromObjectToCircle(object @object)
#pragma warning restore CA1720
        {
            return @object as Circle;
        }

        /// <summary>
        /// Performs an explicit conversion <see cref="Shape"/> type to <see cref="Square"/> type by using 'as operator' syntax.
        /// </summary>
        /// <param name="shape"><see cref="Shape"/> object.</param>
        /// <returns><see cref="Square"/> object or null when unable to cast <see cref="object"/> type to <see cref="Square"/> type.</returns>
        public static Square? AsOperatorFromShapeToSquare(Shape shape)
        {
            return shape as Square;
        }

        /// <summary>
        /// Performs an explicit conversion <see cref="Shape"/> type to <see cref="Circle"/> type by using 'as operator' syntax.
        /// </summary>
        /// <param name="shape"><see cref="Shape"/> object.</param>
        /// <returns><see cref="Circle"/> object or null when unable to cast <see cref="Shape"/> type to <see cref="Circle"/> type.</returns>
        public static Circle? AsOperatorFromShapeToCircle(Shape shape)
        {
            return shape as Circle;
        }

        /// <summary>
        /// Performs an explicit conversion <see cref="Shape"/> type to <see cref="Circle"/> type by using 'as operator' syntax.
        /// </summary>
        /// <param name="colorable"><see cref="IColorable"/> object.</param>
        /// <returns><see cref="Square"/> object or null when unable to cast <see cref="IColorable"/> type to <see cref="Square"/> type.</returns>
        public static Square? AsOperatorFromIColorableToSquare(IColorable colorable)
        {
            return colorable as Square;
        }

        /// <summary>
        /// Performs an explicit conversion <see cref="object"/> type to <see cref="Shape"/> type by using 'pattern matching'.
        /// </summary>
        /// <param name="object"><see cref="object"/> object.</param>
        /// <returns><see cref="Shape"/> object or null when unable to cast <see cref="object"/> type to <see cref="Shape"/> type.</returns>
#pragma warning disable CA1720
        public static Shape? PatternMatchingFromObjectToShape(object @object)
#pragma warning restore CA1720
        {
            return @object as Shape;
        }

        /// <summary>
        /// Performs an explicit conversion <see cref="object"/> type to <see cref="Square"/> type by using 'pattern matching'.
        /// </summary>
        /// <param name="object"><see cref="object"/> object.</param>
        /// <returns><see cref="Square"/> object or null when unable to cast <see cref="object"/> type to <see cref="Square"/> type.</returns>
#pragma warning disable CA1720
        public static Square? PatternMatchingFromObjectToSquare(object @object)
#pragma warning restore CA1720
        {
            return @object as Square;
        }

        /// <summary>
        /// Performs an explicit conversion <see cref="object"/> type to <see cref="Circle"/> type by using 'pattern matching'.
        /// </summary>
        /// <param name="object"><see cref="object"/> object.</param>
        /// <returns><see cref="Circle"/> object or null when unable to cast <see cref="object"/> type to <see cref="Circle"/> type.</returns>
#pragma warning disable CA1720
        public static Circle? PatternMatchingFromObjectToCircle(object @object)
#pragma warning restore CA1720
        {
            return @object as Circle;
        }

        /// <summary>
        /// Performs an explicit conversion <see cref="Shape"/> type to <see cref="Square"/> type by using 'pattern matching'.
        /// </summary>
        /// <param name="shape"><see cref="Shape"/> object.</param>
        /// <returns><see cref="Square"/> object or null when unable to cast <see cref="object"/> type to <see cref="Square"/> type.</returns>
        public static Square? PatternMatchingFromShapeToSquare(Shape shape)
        {
            return shape as Square;
        }

        /// <summary>
        /// Performs an explicit conversion <see cref="Shape"/> type to <see cref="Circle"/> type by using 'pattern matching'.
        /// </summary>
        /// <param name="shape"><see cref="Shape"/> object.</param>
        /// <returns><see cref="Circle"/> object or null when unable to cast <see cref="Shape"/> type to <see cref="Circle"/> type.</returns>
        public static Circle? PatternMatchingFromShapeToCircle(Shape shape)
        {
            return shape as Circle;
        }

        /// <summary>
        /// Performs an explicit conversion <see cref="Shape"/> type to <see cref="Circle"/> type by using 'pattern matching'.
        /// </summary>
        /// <param name="colorable"><see cref="IColorable"/> object.</param>
        /// <returns><see cref="Square"/> object or null when unable to cast <see cref="IColorable"/> type to <see cref="Square"/> type.</returns>
        public static Square? PatternMatchingFromIColorableToSquare(IColorable colorable)
        {
            return colorable as Square;
        }
    }
}
