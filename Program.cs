// метод для вывода запроса в консоль на ввод числа и чтение числа из консоли
int Input(string text){
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

// метод для заполнения переденного массива случайными числами (по умолчанию от -10 до 10)
void SetArray(int[] array, int min_random = -10, int max_random = 10){
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++){
        array[i] = rand.Next(min_random , max_random);
    }
}

// метод для вывода значений элементов массива в консоль
void PrintArray(int[] array){
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
}

void Task41(){
    // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    int num = Input("Введите количество чисел для ввода - ");

    int[] array = new int[num];

    int positiv_num = 0;

    for(int i = 0; i < array.Length; i++){
        array[i] = Input($"Введите {i} элемент массива - ");
        if(array[i] > 0)
            positiv_num++;
    }

    PrintArray(array);
    Console.WriteLine($"В массив введено {positiv_num} положительных чисел");
}

void Task43(){
    // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    // xR = (b2 - b1) / (k1 - k2)
    double b1 = Input("Введите b1 - ");
    double k1 = Input("Введите k1 - ");
    double b2 = Input("Введите b2 - ");
    double k2 = Input("Введите k2 - ");
    
    double xR = (b2 - b1) / (k1 - k2);
    double yR = (k1 * xR) + b1;

    Console.WriteLine($"Точка пересечения прямых [{xR},{yR}]");
}


// метод для вывода меню выбора задач
void Menu() {
    Console.WriteLine("1 - Задача 41");
    Console.WriteLine("2 - Задача 43");

    switch (Input("Введите номер задачи - ")){
        case 1:
            Task41();
            break;
        case 2:
            Task43();
            break;
        default:
            Console.WriteLine("Задачи с таким номером не существует");
            break;
    }
}

Menu();