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
        Vec<double> x = [1, 2, 3];

        Vec<double> y = [3, 2, 1];

        var ans = new Vec<double>(3);

        // Use a TensorSpan method.
        Tensor.Add(x.AsTensorSpan(), y.AsTensorSpan(), ans.AsTensorSpan());

        Console.WriteLine(ans);
    }

    public static void MatTest()
    {
        Mat<double> x =
        [
            [1, 2, 3],
            [4, 5, 6],
            [7, 8, 9],
        ];

        Mat<double> y =
        [
            [9, 8, 7],
            [6, 5, 4],
            [3, 2, 1],
        ];

        var ans = new Mat<double>(3, 3);

        // You can use methods designed for TensorSpan<T>.
        Tensor.Add(x.AsTensorSpan(), y.AsTensorSpan(), ans.AsTensorSpan());

        Console.WriteLine(ans);
    }
}
