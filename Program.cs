using NumFlat;
using System.Numerics;
using System.Numerics.Tensors;

Mat<double> mat = new(2, 2);
mat[0, 0] = 1;
mat[0, 1] = 2;
mat[1, 0] = 3;
mat[1, 1] = 4;

TensorSpan<double> tensorSpan = mat.ToTensorSpan();

Console.WriteLine($"matrix: {mat.RowCount}x{mat.ColCount}");
Console.WriteLine($"tensor shape: [{string.Join(", ", tensorSpan.Lengths.ToArray())}]");
Console.WriteLine($"tensor[1, 0] = {tensorSpan[new nint[] { 1, 0 }]}");

static class MatTensorSpanExtensions
{
    public static TensorSpan<T> ToTensorSpan<T>(this Mat<T> mat)
        where T : unmanaged, INumberBase<T>
    {
        nint[] lengths = [mat.RowCount, mat.ColCount];
        nint[] strides = [1, mat.Stride];
        return new TensorSpan<T>(mat.Memory.Span, lengths, strides);
    }
}
