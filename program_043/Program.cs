// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[,] DataFilling(){
    int[,] dataForEquation = new int[2,4];
    for (int i = 0; i < dataForEquation.GetLength(0); i++)
    {
        for (int j= 0; j < dataForEquation.GetLength(1); j++)
        {   
            if (j>1) break;
            else if (j==0) System.Console.Write($"Введите b{i+1} - ");
            else System.Console.Write($"Введите k{i+1} - ");
            dataForEquation[i,j] = int.Parse(System.Console.ReadLine()!);
        }
    }
    return dataForEquation;  // возвращает [b1, k1][b2, k2]
}

double[] SelectionOfCoordinates(int[,] array){
    double[] xyReturn = new double[2];
    double x = -100;
    while (true){
        double y1 = Math.Round(array[0,1]*x+array[0,0], 1);
        double y2 = Math.Round(array[1,1]*x+array[1,0], 1);
        if (y1 == y2){
            xyReturn[0] = x;
            xyReturn[1] = y1;
            return xyReturn;
        }
        else {
            x= Math.Round(x+0.1, 1);
        }
        }
    }

int[,] newArray = DataFilling();
double[] coordinatesXY = SelectionOfCoordinates(newArray);

System.Console.WriteLine($"b1 = {newArray[0,0]}, k1 = {newArray[0,1]}, b2 = {newArray[1,0]}, k2 = {newArray[1,1]} -> ({string.Join(';', coordinatesXY)})");
