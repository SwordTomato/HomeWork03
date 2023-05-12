using System;

class Program {
    static void Main(string[] args) {
        int[,] matrix = null;

        Console.Write("Enter '+' or '-' to continue or any other key to exit: ");
            char input = Console.ReadKey().KeyChar;

            if (input == '+' || input == '-') {
            Console.WriteLine("\nEnter the size of the matrix:");
                int width = int.Parse(Console.ReadLine());
                int length = int.Parse(Console.ReadLine());

        while (true) {
            if (input == '+' || input == '-') {
                int[,] newMatrix = new int[width, length];

                Console.WriteLine("Enter the members of the matrix:");
                for (int i = 0; i < width; i++) {
                    for (int j = 0; j < length; j++) {
                        newMatrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                if (matrix == null) {
                    matrix = newMatrix;
                } else {
                    matrix = input == '+' ? AddMatrices(matrix, newMatrix) : SubtractMatrices(matrix, newMatrix);
                }

                Console.WriteLine("Matrix:");
                for (int i = 0; i < width; i++) {
                    for (int j = 0; j < length; j++) {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }

            } else {
                Environment.Exit(0);;
            }
        }
    } else {
                Environment.Exit(0);;
            }
}

    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2) {
        int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++) {
            for (int j = 0; j < matrix1.GetLength(1); j++) {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2) {
        int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++) {
            for (int j = 0; j < matrix1.GetLength(1); j++) {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return result;
    }
}