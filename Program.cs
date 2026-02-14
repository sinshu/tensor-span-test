using NumFlat;

Mat<double> mat = new(2, 2);
mat[0, 0] = 1;
mat[0, 1] = 2;
mat[1, 0] = 3;
mat[1, 1] = 4;

Console.WriteLine($"{mat.RowCount}x{mat.ColCount}");
Console.WriteLine($"[1, 0] = {mat[1, 0]}");
