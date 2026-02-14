using System.Numerics.Tensors;

int[] values = [1, 2, 3, 4];
TensorSpan<int> tensorSpan = new(values, [2, 2]);

Console.WriteLine($"Rank: {tensorSpan.Rank}");
Console.WriteLine($"[1, 0] = {tensorSpan[1, 0]}");
