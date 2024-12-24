# Project-Part-B
ПОСТАНОВКА ЗАДАЧІ

Завдання:
1.	Удосконалити проєкт, скорегував діаграму класів, додавши реалізацію хоча б одним класом будь-якого інтерфейсу(ів) .NET (IClonable, IComparable, IEnumereable тощо).
2.	Передбачити множинну реалізацію інтерфейсів. 
3.	Додати хоча б один абстрактний клас*, від якого успадкувати декілька нових чи вже існуючих класів. 
4.	Передбачити хоча б один варіант реалізації поліморфізму (бажано обидва):
Варіант 1: об’єкти похідного класу обробляються як об’єкти базового класу (в параметрах методів, в колекціях та ін.);
Варіант 2: перевизначення (overriding) успадкованих методів, визначення типу об’єкта під час виконання програми і виклик відповідної реалізації методу. Використання GitHub-репозиторію з коммітами є обов’язковим! Репозиторій повинен мати заповнений Readme.md файл, в який необхідно: 
5.	Скорегувати каркас проєкту
6.	Замінити заглушки в проєкті конкретними реалізаціями методів, властивостей тощо.
7.	Запустити unit-тести, досягти проходження всіх unit-тестів.
8.	Спроєктувати меню для програми, пункти меню мають відповідати предметній області і бути логічними.
9.	Реалізувати основну програму (файл Program.cs) у відповідності до спроєктованого меню.
10.	Виконати функціональне тестування всіх пунктів меню.
11.	Оформити звіт
-	Титульний аркуш
-	Завдання
-	Опис предметної області
-	Діаграма класів
-	Демонстрація реалізації поліморфізму
-	Результати запуску unit-тестів.
-	Результати функціонального тестування
-	Програмний код класів
-	Програмний код основної програми
ВИКОНАННЯ РОБОТИ
1)	Опис класу: 
a)	Перелічення(Enum):
PizzaName – перелік назв піц(Пепероні, Маргарита, Гавайська, 4 Сири, Діабо, Бір-бургер, Бренд шеф 
b)	Класи:
Pizzeria – клас для зберігання даних про піцерію
Person – абстрактний клас, що представляє основу для створення різних працівників.
Pizza – клас для оброблення кожної піци в замовлені
Order – клас для зберігання даних про замовлення в піцерії
Worker – клас для зберігання даних про робітників в піцерії
c)	Інтерфейс:
IInteraction – інтерфейс для змінення статусу та створення замовлення

![ Виявлення та визначення предметної області та зв’язки між ними ](https://github.com/Dmyryi/Project-Part-B/blob/main/Part%20B/1.png)
 
Рисунок 1 – Виявлення та визначення предметної області та зв’язки між ними

![ Детальне проєктування елементів моделі предметної області ](https://github.com/Dmyryi/Project-Part-B/blob/main/Part%20B/2.png)
 
Рисунок 2 – Детальне проєктування елементів моделі предметної області



Worker:
public override void Work(){
Console.WriteLine(${FirstName} is working)
}

![ Демонстрація реалізації поліморфізму для Worker ](https://github.com/Dmyryi/Project-Part-B/blob/main/Part%20B/3.png)
 
Рисунок 3 – Демонстрація реалізації поліморфізму для Worker

![ Результат запуску unit-тестів ](https://github.com/Dmyryi/Project-Part-B/blob/main/Part%20B/4.png)
 
Рисунок 4 – Результат запуску unit-тестів

![ Результат функціонального тестування №1 некоректний вибір в меню ](https://github.com/Dmyryi/Project-Part-B/blob/main/Part%20B/5.png)
 
Рисунок 5 – Результат функціонального тестування №1 некоректний вибір в меню

![ Результат функціонального тестування №2 некоректні данні для створення торгової точки ](https://github.com/Dmyryi/Project-Part-B/blob/main/Part%20B/6.png)
 
Результат 6 – Результат функціонального тестування №2 некоректні данні для створення торгової точки 

![ Результат функціонального тестування №3 створення торгової точки ](https://github.com/Dmyryi/Project-Part-B/blob/main/Part%20B/7.png)
 
Рисунок 7 – Результат функціонального тестування №3 створення торгової точки

![ Результат функціонального тестування №4 некоректні данні створення нового співробітника ](https://github.com/Dmyryi/Project-Part-B/blob/main/Part%20B/8.png)
 
Результат 8 – Результат функціонального тестування №4 некоректні данні створення нового співробітника 

![ Результат функціонального тестування №5 створення нового співробітника ](https://github.com/Dmyryi/Project-Part-B/blob/main/Part%20B/9.png)
 
Результат 9 – Результат функціонального тестування №5 створення нового співробітника

![ Результат функціонального тестування №6 некоректне створення нового замовлення ](https://github.com/Dmyryi/Project-Part-B/blob/main/Part%20B/10.png)
 
Результат 10 – Результат функціонального тестування №6 некоректне створення нового замовлення

![ Результат функціонального тестування №7 створення нового замовлення ](https://github.com/Dmyryi/Project-Part-B/blob/main/Part%20B/11.png)
 
Результат 11 – Результат функціонального тестування №7 створення нового замовлення

![ Результат функціонального тестування №8 перегляд замовлення на конкретній точці ](https://github.com/Dmyryi/Project-Part-B/blob/main/Part%20B/12.png)
 
Результат 12 – Результат функціонального тестування №8 перегляд замовлення на конкретній точці

![ Результат функціонального тестування №9 перегляд працівників на конкретній точці ](https://github.com/Dmyryi/Project-Part-B/blob/main/Part%20B/13.png)
 
Результат 13 – Результат функціонального тестування №9 перегляд працівників на конкретній точці


Посилання на Github:github.com/Dmyryi/Project-Part-B
 
ДОДАТОК
Лістинг програми


Вміст консольного додатку (Pizzeria.cs):
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Part_B
{
    public class Pizzeria
    {
        private int _nextOrderNumber = 1;
        private string _name;
        private string _address;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                    throw new ArgumentException("Ім'я піцерії не може бути порожнім або менше 3 символів!");
                _name = value;
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                    throw new ArgumentException("Адреса піцерії не може бути порожньою або менше 3 символів!");
                _address = value;
            }
        }

        public List<Worker> Workers { get; } = new List<Worker>();
        public List<Order> Orders { get; } = new List<Order>();

        public Dictionary<PizzaName, double> PizzaPrices { get; } = new Dictionary<PizzaName, double>
        {
            { PizzaName.Margherita, 100 },
            { PizzaName.Pepperoni, 120 },
            { PizzaName.Hawaiian, 110 },
            { PizzaName.FourCheese, 140 },
            { PizzaName.Diablo, 150 }
        };

        public Pizzeria()
        {
            Name = "034";
            Address = "Тестова піцерія";
        }

        public Pizzeria(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public int GenerateOrderNumber()
        {
            return _nextOrderNumber++;
        }

        public void AddEmployee(Worker worker)
        {
            if (worker == null)
                throw new ArgumentNullException(nameof(worker), "Worker cannot be null.");
            Workers.Add(worker);
        }

        public void CreateOrder(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order), "Order cannot be null.");
            Orders.Add(order);
        }


        public static Pizzeria Parse(string s)
        {
            string[] parts = s.Split(',');
            if (parts.Length != 2)
                throw new FormatException("Некоректний формат рядка: очікується 2 частинb, розділених символом ';'.");

            try
            {
                string name = parts[0];
                if (string.IsNullOrWhiteSpace(name))
                    throw new FormatException("Назва продукту не може бути порожньою або складатися лише з пробілів.");
string address = parts[1];
                if (string.IsNullOrWhiteSpace(name))
                    throw new FormatException("Назва продукту не може бути порожньою або складатися лише з пробілів.");
                return new Pizzeria(name,address);
            }
            catch (Exception ex)
            {
                throw new FormatException("Помилка під час перетворення рядка в Product.", ex);
            }
        }



        public static bool TryParse(string s, out Pizzeria obj)
        {
            try
            {
                obj = Parse(s);
                return true;
            }
            catch
            {
                obj = null; return false;
            }
        }

    }
}
Вміст класу консольного додатку (Worker.cs):
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Part_B
{
    public class Worker : Person
    {
        public override string FirstName { get; set; }
   
        public Worker(string firstName)
        {
            FirstName = firstName;
           
        }

        public override void Work()
        {
            Console.WriteLine($"{FirstName} is working.");
        }
    }

}

Вміст консольного додатку (Order.cs):
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Part_B
{
    public class Order : IInteraction 
    {
        public int Number { get; set; }
        public string Status { get; set; }
        public List<Pizza> Pizzas { get; set; }

        public Order(int number, string status)
        {
            Number = number;
            Status = status;
            Pizzas = new List<Pizza>();
        }

        public void AddPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
        }

        public void Create()
        {
            Console.WriteLine($"Order {Number} has been created.");
        }

        public void Process()
        {
            Console.WriteLine($"Order {Number} is being processed.");
        }

        public IEnumerator<Pizza> GetEnumerator()
        {
            return Pizzas.GetEnumerator();
        }

       
    }

}
Вміст консольного додатку (Pizza.cs):
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Part_B
{
    public class Pizza : IComparable<Pizza>, ICloneable
    {
        public PizzaName Name { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }

        public Pizza(PizzaName name, string size, double price)
        {
            Name = name;
            Size = size;
            Price = price;
        }

        public int CompareTo(Pizza other)
        {
            return Price.CompareTo(other.Price);
        }

        public object Clone()
        {
            return new Pizza(Name, Size, Price);
        }
    }

}
Вміст консольного додатку(IInteraction.cs)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Part_B
{
    public interface IInteraction
    {
        void Create();
        void Process();
    }
}
Вміст кольного додатку(PizzaName.cs)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_part_B
{
   
        public enum PizzaName
        {
            Margherita,
            Pepperoni,
            Hawaiian,
            FourCheese,
            Diablo
        }
    
}
Вміст консольного додатку(Person.cs)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Part_B
{
    public abstract class Person
    {
        public abstract string FirstName { get; set; }
      

        public abstract void Work();

           }


}

Вміст консольного додатку(Program.cs)
using System;
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
Вміст консольного додатку(IntegrationTest.cs)

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project_Part_B.Tests
{
    [TestClass]
    public class PizzeriaTests
    {
        [TestMethod]
        public void Pizzeria_Creation_With_Valid_Name_And_Address_Should_Succeed()
        {
            // Arrange
            var name = "Test Pizzeria";
            var address = "123 Main St";

            // Act
            var pizzeria = new Pizzeria(name, address);

            // Assert
            Assert.AreEqual(name, pizzeria.Name);
            Assert.AreEqual(address, pizzeria.Address);
        }

        [TestMethod]
        public void Pizzeria_Creation_With_Invalid_Name_Should_ThrowException()
        {
            // Arrange
            var invalidName = "A";
            var address = "123 Main St";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Pizzeria(invalidName, address));
        }

        [TestMethod]
        public void AddEmployee_Should_Add_Worker_To_Workers_List()
        {
            // Arrange
            var pizzeria = new Pizzeria("Pizzeria Test", "123 Main St");
            var worker = new Worker("John");

            // Act
            pizzeria.AddEmployee(worker);

            // Assert
            CollectionAssert.Contains(pizzeria.Workers, worker);
        }

        [TestMethod]
        public void AddEmployee_NullWorker_Should_ThrowException()
        {
            // Arrange
            var pizzeria = new Pizzeria("Pizzeria Test", "123 Main St");

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => pizzeria.AddEmployee(null));
        }

        [TestMethod]
        public void GenerateOrderNumber_Should_Return_Unique_Numbers()
        {
            // Arrange
            var pizzeria = new Pizzeria("Pizzeria Test", "123 Main St");

            // Act
            var order1 = pizzeria.GenerateOrderNumber();
            var order2 = pizzeria.GenerateOrderNumber();

            // Assert
            Assert.AreNotEqual(order1, order2);
        }
    }

    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void Order_Creation_Should_Set_Properties()
        {
            // Arrange
            int number = 1;
            string status = "Pending";

            // Act
            var order = new Order(number, status);

            // Assert
            Assert.AreEqual(number, order.Number);
            Assert.AreEqual(status, order.Status);
        }

        [TestMethod]
        public void AddPizza_Should_Add_Pizza_To_Order()
        {
            // Arrange
            var order = new Order(1, "Pending");
            var pizza = new Pizza(PizzaName.Margherita, "Medium", 100);

            // Act
            order.AddPizza(pizza);

            // Assert
            CollectionAssert.Contains(order.Pizzas, pizza);
        }
    }

    [TestClass]
    public class PizzaTests
    {
        [TestMethod]
        public void Pizza_Clone_Should_Create_Identical_Copy()
        {
            // Arrange
            var pizza = new Pizza(PizzaName.Pepperoni, "Large", 120);

            // Act
            var clone = (Pizza)pizza.Clone();

            // Assert
            Assert.AreEqual(pizza.Name, clone.Name);
            Assert.AreEqual(pizza.Size, clone.Size);
            Assert.AreEqual(pizza.Price, clone.Price);
            Assert.AreNotSame(pizza, clone); // Ensure it's a different object
        }

        [TestMethod]
        public void Pizza_CompareTo_Should_Compare_By_Price()
        {
            // Arrange
            var pizza1 = new Pizza(PizzaName.Margherita, "Medium", 100);
            var pizza2 = new Pizza(PizzaName.Diablo, "Medium", 150);

            // Act
            int comparison = pizza1.CompareTo(pizza2);

            // Assert
            Assert.IsTrue(comparison < 0); // pizza1 is cheaper than pizza2
        }
    }

    [TestClass]
    public class WorkerTests
    {
        [TestMethod]
        public void Worker_Creation_Should_Set_FirstName()
        {
            // Arrange
            string firstName = "Alice";

            // Act
            var worker = new Worker(firstName);

            // Assert
            Assert.AreEqual(firstName, worker.FirstName);
        }
    }
}

