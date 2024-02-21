﻿namespace zadacha_8_Shamilova_Hayala
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> valuesOfRowOnChessboard = new Dictionary<char, int>()
            {
                {'a', 1}, {'b', 2}, {'c', 3}, {'d', 4}, {'e', 5}, {'f', 6},{'g', 7}, {'h', 8},
            };
            string error = "Вы ввели некорректные координаты";
            Console.WriteLine("Правило: Необходимо определить являются введенные поля х1у1 и х2у2 полями одного цвета\n");

            try
            {
                int x1 = 0, x2 = 0, y1 = 0, y2 = 0, value, value2;
                Console.WriteLine("Введите координаты поля x1y1 и координаты поля x2y2");
                string input = Console.ReadLine();
                string[] coordinate = input.Split(' ');

                // Проверка на существование в словаре "valuesOfRowOnChessboard" введенных пользователем точек "х1" и "х2".
                // Если существует, то переменным х1 и х2 присваются значения ключей.
                if ((valuesOfRowOnChessboard.TryGetValue(coordinate[0][0], out value)) && (valuesOfRowOnChessboard.TryGetValue(coordinate[1][0], out value2)))
                {
                    x1 = value;
                    x2 = value2;
                }
                else
                {
                    Console.WriteLine(error);
                    return;
                }

                y1 = int.Parse(coordinate[0][1].ToString());
                y2 = int.Parse(coordinate[1][1].ToString());
                GetResultOfGame(x1, x2, y1, y2);
            }
            catch
            {
                Console.WriteLine(error);
            }
        }
        static public void GetResultOfGame(int x1, int x2, int y1, int y2)
        {
            if ((x1 + y1) % 2 == (x2 + y2) % 2)
            {
                Console.WriteLine("Введенные поля являются полями ОДНОГО цвета");
            }
            else
            {
                Console.WriteLine("Введенные поля являются полями РАЗНОГО цвета");
            }
        }
    }
}