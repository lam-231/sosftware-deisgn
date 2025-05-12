DRY(Don’t Repeat Yourself)
Цей принцип полягає в уникненні дублювання коду.

Клас [Money](./ShopClassLibrary/Money.cs):
Метод SetMoney використовується в конструкторі, що дозволяє уникнути дублювання логіки ініціалізації.
Метод DecreaseAmount використовує перетворення грошей у копійки для обчислень, що уникнуло б дублювання коду, якби ця логіка була розкидана по інших методах.

Клас [Product](./ShopClassLibrary/Product.cs):
Метод ReducePrice делегує роботу до Price.DecreaseAmount, що дозволяє уникнути дублювання логіки зменшення ціни.

Клас [Reporting](./ShopClassLibrary/Reporting.cs):
Метод InventoryReport використовується для виведення звіту на консоль і в файл, що дозволяє уникнути дублювання коду для створення звіту.


KISS (Keep It Simple, Stupid)
Цей принцип полягає у збереженні коду простим і зрозумілим.

Клас [Money](./ShopClassLibrary/Money.cs):
Метод Display просто виводить значення грошей у форматі XX.YY, що є простим і зрозумілим.
Метод DecreaseAmount має чітку логіку: перетворення у копійки, віднімання та перевірка на достатність коштів.

Клас [Product](./ShopClassLibrary/Product.cs):
Клас містить лише необхідні властивості (Name, Price) та метод ReducePrice, що робить його простим і зрозумілим.

Клас [REporting](./ShopClassLibrary/Reporting.cs):
Метод RegisterIncoming і RegisterOutgoing мають просту логіку: додавання та видалення товарів зі списку.


SOLID
Цей принцип складається з п’яти окремих принципів(у мене використовується три з них, бо у мене відсутні інтерфейси).

Single Responsibility Principle (SRP):
Клас [Money](./ShopClassLibrary/Money.cs): Відповідає лише за роботу з грошовими сумами.
Клас [Product](./ShopClassLibrary/Product.cs): Відповідає лише за опис продукту та його ціну.
Клас [Reporting](./ShopClassLibrary/Reporting.cs): Відповідає лише за ведення обліку товарів на складі
Клас [Warehouse](./ShopClassLibrary/Warehouse.cs): Відповідає лише за зберігання інформації про товар на складі.

Open/Closed Principle (OCP):
Клас [Money](./ShopClassLibrary/Money.cs): Можна розширити, додавши нові методи (наприклад, для додавання грошей), не змінюючи існуючий код.
Клас ProductWithCategory (ProdCategory)[Money](./ShopClassLibrary/Money.cs): Розширює клас Product, додаючи категорію, не змінюючи його основну логіку.

Liskov Substitution Principle (LSP):
Клас [ProductWithCategory](./ShopClassLibrary/ProdCategory.cs): Можна використовувати замість класу Product, оскільки він не порушує його поведінку.
Класи USD, EUR, UAH [Currency](./ShopClassLibrary/Currency.cs): Вони є підкласами Money і можуть використовуватися замість нього.


YAGNI (You Aren’t Gonna Need It)
Цей принцип полягає в тому, щоб не додавати функціональність, яка поки що не потрібна.

Клас [Money](./ShopClassLibrary/Money.cs)): Містить лише необхідні методи для роботи з грошима (SetMoney, Display, DecreaseAmount).
Клас [Product](./ShopClassLibrary/Product.cs): Містить лише необхідні властивості та методи для роботи з продуктами.
Клас [Reporting](./ShopClassLibrary/Reporting.cs): Містить лише необхідні методи для ведення обліку товарів.


Composition Over Inheritance
Цей принцип полягає в тому, що композиція (використання об’єктів) краща за наслідування.
Клас [ProductWithCategory](./ShopClassLibrary/ProdCategory.cs): Використовує композицію через включення класу Product та додавання властивості Category, замість того, щоб створювати складну ієрархію наслідування.



Fail Fast
Цей принцип полягає в тому, щоб виявляти помилки якнайшвидше.

Клас [Money](./ShopClassLibrary/Money.cs):
Метод DecreaseAmount викидає виняток InvalidOperationException, якщо сума для зменшення перевищує поточну суму. Це дозволяє швидко виявити помилку.

Клас [Reporting](./ShopClassLibrary/Reporting.cs):
Метод RegisterOutgoing викидає виняток, якщо товару недостатньо на складі.
