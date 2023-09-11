string[] MakeArray(int num){
    string[] array = new string[num];
    for (int i = 0; i < array.GetLength(0); i++){
        Console.Write($"Введите {i+1}, строку: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] RemakeArray(string[] array){
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        if (array[i].Length <= 3){
            array[count] = array[i];
            count++;
        } 
    }
    string[] newarray = new string[count];
    for (int i = 0; i < count; i++){
        newarray[i] = array[i];
    }
    return newarray;
}

Console.Write("Введите количество строк: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = MakeArray(num);

Console.WriteLine();

Console.Write("Изначальный массив -> ");
for (int i = 0; i < array.GetLength(0); i++){
    Console.Write(array[i]+" ");
}

Console.WriteLine();
Console.WriteLine();
string[] newarray = RemakeArray(array);

Console.Write("Массив из строк, длина которых меньше, либо равна 3 символам -> [");
for (int i = 0; i < newarray.GetLength(0); i++){
    if (i != newarray.GetLength(0)-1) Console.Write(newarray[i]+", ");
    else Console.Write(newarray[i]);
}
Console.Write("]");