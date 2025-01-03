﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace Project_Part_B
{
    internal class Program
    {
        static List<Pizzeria> pizzerias = new List<Pizzeria>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Створити або вибрати піцерію");
                Console.WriteLine("2. Додати працівників");
                Console.WriteLine("3. Створити і обробити замовлення");
                Console.WriteLine("4. Показати замовлення");
                Console.WriteLine("5. Показати працівників");
                Console.WriteLine("6. Завершити роботу");

                Console.Write("Оберіть опцію: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateOrSelectPizzeria();
                        break;

                    case "2":
                        AddEmployees();
                        break;

                    case "3":
                        CreateAndProcessOrder();
                        break;

                    case "4":
                        ShowOrders();
                        break;

                    case "5":
                        ShowEmployees();
                        break;

                    case "6":
                        Console.WriteLine("Завершення роботи... До побачення!");
                        return;

                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }
                Console.WriteLine();
            }
        }

      

        // Метод для создания или выбора пиццерии
       static bool CreateOrSelectPizzeria()
        {
            if (pizzerias.Count == 0)
            {
                while (true)
                {
                   
                        Console.WriteLine("Введіть деталі піцерії (ім'я,адреса):");
                        string input = Console.ReadLine();

                        if (Pizzeria.TryParse(input, out Pizzeria newProd))
                        {
                            pizzerias.Add(newProd);
                            Console.WriteLine("Піцерія створена.");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Помилка вводу даних піцер. Спробуйте ще раз.");
                        }
                 
                }
            }
            else
            {
                Console.WriteLine("Виберіть піцерію зі списку:");
                for (int i = 0; i < pizzerias.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {pizzerias[i].Name} - {pizzerias[i].Address}");
                }

                int selectedPizzeriaIndex;
                if (int.TryParse(Console.ReadLine(), out selectedPizzeriaIndex) && selectedPizzeriaIndex >= 1 && selectedPizzeriaIndex <= pizzerias.Count)
                {
                    var selectedPizzeria = pizzerias[selectedPizzeriaIndex - 1];
                    Console.WriteLine($"Ви вибрали піцерію: {selectedPizzeria.Name} на {selectedPizzeria.Address}");
                }
                else
                {
                    Console.WriteLine("Невірний вибір.");
                }
            }
            return true;
        }

        // Метод для добавления работников
        private static void AddEmployees()
        {
            if (pizzerias.Count == 0)
            {
                Console.WriteLine("Спочатку потрібно створити піцерію.");
                return;
            }

            Console.WriteLine("Оберіть піцерію, для якої додається працівник:");
            for (int i = 0; i < pizzerias.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {pizzerias[i].Name} - {pizzerias[i].Address}");
            }

            int selectedPizzeriaIndex;
            if (!int.TryParse(Console.ReadLine(), out selectedPizzeriaIndex) || selectedPizzeriaIndex < 1 || selectedPizzeriaIndex > pizzerias.Count)
            {
                Console.WriteLine("Невірний вибір.");
                return;
            }

            var selectedPizzeria = pizzerias[selectedPizzeriaIndex - 1];

            while (true)
            {
                try
                {
                    string firstName = GetWorkerFirstName();
                  

                    Worker worker = new Worker(firstName);
                    selectedPizzeria.Workers.Add(worker);
                    Console.WriteLine("Працівника додано.");
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}. Спробуйте ще раз.");
                }
            }
        }

        // Метод для создания и обработки заказа
        private static void CreateAndProcessOrder()
        {
            if (pizzerias.Count == 0)
            {
                Console.WriteLine("Спочатку потрібно створити піцерію.");
                return;
            }

            Console.WriteLine("Оберіть піцерію, для якої створюється замовлення:");
            for (int i = 0; i < pizzerias.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {pizzerias[i].Name} - {pizzerias[i].Address}");
            }

            int selectedPizzeriaIndex;
            if (!int.TryParse(Console.ReadLine(), out selectedPizzeriaIndex) || selectedPizzeriaIndex < 1 || selectedPizzeriaIndex > pizzerias.Count)
            {
                Console.WriteLine("Невірний вибір.");
                return;
            }

            var selectedPizzeria = pizzerias[selectedPizzeriaIndex - 1];

            if (selectedPizzeria.Workers.Count == 0)
            {
                Console.WriteLine("Додайте хоча б одного працівника, перш ніж створювати замовлення.");
                return;
            }

            while (true)
            {
                try
                {
                    var orderNumber = selectedPizzeria.GenerateOrderNumber();
                    var order = new Order(orderNumber, "Очікується");

                    int pizzaCount = GetPizzaCount();

                    for (int i = 0; i < pizzaCount; i++)
                    {
                        Console.WriteLine($"Додавання піци {i + 1} із {pizzaCount}:");
                        var pizzaName = GetPizzaName();
                        var size = GetPizzaSize();

                        if (!selectedPizzeria.PizzaPrices.TryGetValue(pizzaName, out var price))
                        {
                            throw new ArgumentException("Ціна для цієї піци не знайдена. Спробуйте ще раз.");
                        }

                        var pizza = new Pizza(pizzaName, size, price);
                        order.AddPizza(pizza);
                        Console.WriteLine("Піца додана до замовлення.");
                    }

                    selectedPizzeria.CreateOrder(order);
                    order.Process();
                    Console.WriteLine("Замовлення створено і оброблено.");
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}. Спробуйте ще раз.");
                }
            }
        }

        // Метод для отображения заказов
        private static void ShowOrders()
        {
            if (pizzerias.Count == 0)
            {
                Console.WriteLine("Спочатку потрібно створити піцерію.");
                return;
            }

            Console.WriteLine("Оберіть піцерію для перегляду замовлень:");
            for (int i = 0; i < pizzerias.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {pizzerias[i].Name} - {pizzerias[i].Address}");
            }

            int selectedPizzeriaIndex;
            if (!int.TryParse(Console.ReadLine(), out selectedPizzeriaIndex) || selectedPizzeriaIndex < 1 || selectedPizzeriaIndex > pizzerias.Count)
            {
                Console.WriteLine("Невірний вибір.");
                return;
            }

            var selectedPizzeria = pizzerias[selectedPizzeriaIndex - 1];

            if (selectedPizzeria.Orders.Count == 0)
            {
                Console.WriteLine("Замовлень немає.");
            }
            else
            {
                Console.WriteLine("Список замовлень:");
                foreach (var o in selectedPizzeria.Orders)
                {
                    Console.WriteLine($"Замовлення #{o.Number}: {o.Status}, кількість піц: {o.Pizzas.Count}");
                    foreach (var pizza in o.Pizzas)
                    {
                        Console.WriteLine($" - {pizza.Name} ({pizza.Size}) - {pizza.Price:C}");
                    }
                }
            }
        }

        // Метод для отображения сотрудников
        private static void ShowEmployees()
        {
            if (pizzerias.Count == 0)
            {
                Console.WriteLine("Спочатку потрібно створити піцерію.");
                return;
            }

            Console.WriteLine("Оберіть піцерію для перегляду працівників:");
            for (int i = 0; i < pizzerias.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {pizzerias[i].Name} - {pizzerias[i].Address}");
            }

            int selectedPizzeriaIndex;
            if (!int.TryParse(Console.ReadLine(), out selectedPizzeriaIndex) || selectedPizzeriaIndex < 1 || selectedPizzeriaIndex > pizzerias.Count)
            {
                Console.WriteLine("Невірний вибір.");
                return;
            }

            var selectedPizzeria = pizzerias[selectedPizzeriaIndex - 1];

            if (selectedPizzeria.Workers.Count == 0)
            {
                Console.WriteLine("У цієї піццерії немає працівників.");
            }
            else
            {
                Console.WriteLine("Список працівників:");
                foreach (var worker in selectedPizzeria.Workers)
                {
                   worker.Work();
                }
            }
        }
   
        // Метод для ввода данных: имя сотрудника
        private static string GetWorkerFirstName()
        {
            Console.Write("Введіть ім'я працівника: ");
            while (true)
            {
                string firstName = Console.ReadLine();

                // Проверка на пустоту или длину меньше 3 символов
                if (string.IsNullOrEmpty(firstName) || firstName.Length < 3)
                    throw new ArgumentException("Ім'я співробітника не може бути порожнім або менше 3 букв!");

                // Проверка на наличие цифр
                if (Regex.IsMatch(firstName, @"\d"))
                    throw new ArgumentException("я співробітника не може містити цифри!");

                return firstName;
            }
        }

        // Метод для ввода данных: фамилия сотрудника
        private static string GetWorkerLastName()
        {
            Console.Write("Введіть прізвище працівника: ");
            while (true)
            {
                string lastName = Console.ReadLine();

                // Проверка на пустоту или длину меньше 3 символов
                if (string.IsNullOrEmpty(lastName) || lastName.Length < 3)
                    throw new ArgumentException("Прізвище співробітника не може бути порожнім або менше 3 букв!");

                // Проверка на наличие цифр
                if (Regex.IsMatch(lastName, @"\d"))
                    throw new ArgumentException("Прізвище співробітника не може містити цифри!");

                return lastName;
            }
        }

        // Метод для ввода данных: количество пицц в заказе
        private static int GetPizzaCount()
        {
            Console.WriteLine("Скільки піц Ви бажаєте додати?");
            int pizzaCount;
            while (!int.TryParse(Console.ReadLine(), out pizzaCount) || pizzaCount <= 0)
            {
                Console.WriteLine("Некоректна кількість. Спробуйте ще раз.");
            }
            return pizzaCount;
        }

        // Метод для выбора пиццы
        private static PizzaName GetPizzaName()
        {
            Console.WriteLine("Меню піц:");
            var pizzaList = Enum.GetValues(typeof(PizzaName)).Cast<PizzaName>().ToList();
            for (int j = 0; j < pizzaList.Count; j++)
            {
                Console.WriteLine($"{j + 1}. {pizzaList[j]}");
            }

            int pizzaChoice;
            while (!int.TryParse(Console.ReadLine(), out pizzaChoice) || pizzaChoice < 1 || pizzaChoice > pizzaList.Count)
            {
                Console.WriteLine("Неправильний вибір піци. Спробуйте ще раз.");
            }

            return pizzaList[pizzaChoice - 1];
        }

        // Метод для ввода данных: размер пиццы
        private static string GetPizzaSize()
        {
            Console.Write("Введіть розмір (Small, Medium, Large): ");
            string size;
            while ((size = Console.ReadLine()) != "Small" && size != "Medium" && size != "Large")
            {
                Console.WriteLine("Невірний розмір. Спробуйте ще раз.");
            }
            return size;
        }
    }
}
