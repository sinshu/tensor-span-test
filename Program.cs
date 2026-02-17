using NumFlat;
using System;
using System.Numerics.Tensors;

public static class Program
{
    public static void Main()
    {
        VecTest();
        MatTest();
    }

    public static void VecTest()
    {
        Vec<double> a = [1, 2, 3];

        Vec<double> b = [3, 2, 1];

        var c = new Vec<double>(3);

        // Use a TensorSpan method.
        Tensor.Multiply(a.AsTensorSpan(), b.AsTensorSpan(), c.AsTensorSpan());

        Console.WriteLine(c);
    }

    public static void MatTest()
    {
        Mat<double> a =
        [
            [1, 2, 3],
            [4, 5, 6],
            [7, 8, 9],
        ];

        Mat<double> b =
        [
            [9, 8, 7],
            [6, 5, 4],
            [3, 2, 1],
        ];

        var c = new Mat<double>(3, 3);

        // Use a TensorSpan method.
        Tensor.Multiply(a.AsTensorSpan(), b.AsTensorSpan(), c.AsTensorSpan());

        Console.WriteLine(c);
    }
}
