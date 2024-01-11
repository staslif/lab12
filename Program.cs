class Program1
{
    static void Main(string[] args){
        // Запросить у пользователя путь к файлу для чтения
        Console.Write("Введите путь к текстовому файлу: ");
        string filePath = Console.ReadLine();

        // Проверка, существует ли указанный файл
        if (File.Exists(filePath)){
            try{
                // Прочитать содержимое файла
                string fileContent = File.ReadAllText(filePath);

                // Записать содержимое в новый файл в папке с проектом
                string newFilePath = "new_file.txt";
                File.WriteAllText(newFilePath, fileContent);

                Console.WriteLine("Файл успешно записан.");
            }
            catch (Exception ex){
                Console.WriteLine("Ошибка при чтении или записи файла: " + ex.Message);
            }
        }
        else{
            Console.WriteLine("Указанный файл не существует.");
        }}}