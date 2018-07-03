using System;
using System.Threading.Tasks;
using static HttpClientSample.Program;

namespace ConsoleApp1
{
    public class View
    {
        public static async Task<bool> ShowAsync()
        {
            Console.WriteLine("Список запросов:\n");
            Console.WriteLine("1. Получить количество комментов под постами конкретного пользователя (по айди) (список из пост-количество)");
            Console.WriteLine("2. Получить список комментов под постами конкретного пользователя (по айди), где body коммента < 50 символов (список из комментов)");
            Console.WriteLine("3. Получить список (id, name) из списка todos которые выполнены для конкретного пользователя (по айди)");
            Console.WriteLine("4. Получить список пользователей по алфавиту (по возрастанию) с отсортированными todo items по длине name (по убыванию)");
            Console.WriteLine("5. Получить структуру (передать Id пользователя в параметры), запрос 5");
            Console.WriteLine("6. Получить структуру (передать Id поста в параметры), запрос 6");
            Console.WriteLine("7. Exit");


            if (int.TryParse(Console.ReadLine(), out var result) && result >= 1 && result <= 7)
            {
                switch (result)
                {
                    case 1:
                        Console.WriteLine("\nPlease, enter Id");
                        if (int.TryParse(Console.ReadLine(), out var id) && id >= 0)
                        {
                            await GetCommentCountAsync(id);
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nPlease, enter Id");
                        if (int.TryParse(Console.ReadLine(), out id) && id >= 0)
                        {
                            await GetCommentList50Async(id);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nPlease, enter Id");
                        if (int.TryParse(Console.ReadLine(), out id) && id >= 0)
                        {
                            await GetTodoListAsync(id);
                        }
                        break;
                    case 4:
                        await GetUserTodoListAsync();
                        break;
                    case 5:
                        Console.WriteLine("\nPlease, enter Id");
                        if (int.TryParse(Console.ReadLine(), out id) && id >= 0)
                        {
                            await GetUserInfo5Async(id);
                        }
                        break;
                    case 6:
                        Console.WriteLine("\nPlease, enter Id");
                        if (int.TryParse(Console.ReadLine(), out id) && id >= 0)
                        {
                            await GetPostInfo6Async(id);
                        }
                        break;
                    case 7: return false;

                }
            }
            else
            {
                Console.WriteLine("\nEntered invalid command");

            }
            Console.WriteLine("\nPress any key");
            Console.ReadKey();
            Console.Clear();

            return true;
        }
    }
}