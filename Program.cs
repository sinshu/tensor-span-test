using NumFlat;
using System.Numerics;
using System.Numerics.Tensors;
using System.Runtime.CompilerServices;

Mat<double> mat = new(2, 2);
mat[0, 0] = 1;
mat[0, 1] = 2;
mat[1, 0] = 3;
mat[1, 1] = 4;

TensorSpan<double> tensorSpan = mat.ToTensorSpan();

Console.WriteLine($"matrix: {mat.RowCount}x{mat.ColCount}");
Console.WriteLine($"tensor shape: [{string.Join(", ", tensorSpan.Lengths.ToArray())}]");
Console.WriteLine($"tensor[1, 0] = {tensorSpan[1, 0]}");

[InlineArray(2)]
struct Nint2
{
    private nint _element0;
}

static class MatTensorSpanExtensions
{
    public static TensorSpan<T> ToTensorSpan<T>(this Mat<T> mat)
        where T : unmanaged, INumberBase<T>
    {
        Nint2 lengths = default;
        lengths[0] = mat.RowCount;
        lengths[1] = mat.ColCount;

        Nint2 strides = default;
        strides[0] = 1;
        strides[1] = mat.Stride;

        return new TensorSpan<T>(mat.Memory.Span, lengths, strides);
    }
}
