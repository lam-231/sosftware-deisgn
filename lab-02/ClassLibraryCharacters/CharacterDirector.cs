using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCharacters
{
    public class CharacterDirector
    {
        public Character ConstructHero(ICharacterBuilder builder)
        {
            return builder.SetHeight(1.50)
                          .SetBodyType("Пивний пузик")
                          .SetBeard("Пишна, грязна")
                          .SetHairColor("Каштанове")
                          .SetEyeColor("Карi")
                          .SetClothing("Старе лахмiття")
                          .AddInventoryItem("20-ти кiлограмовий молот")
                          .AddInventoryItem("кухоль")
                          .AddInventoryItem("люлюка")
                          .AddInventoryItem("тютюн")
                          .AddInventoryItem("маленький хоббiт")
                          .AddSpecialAction("Вернув гору")
                          .AddSpecialAction("вмер")
                          .Build();
        }

        public Character ConstructEnemy(ICharacterBuilder builder)
        {
            return builder.SetHeight(2.2)
                          .SetBodyType("Худощавий")
                          .SetBeard("Вiдсутня, як на дупцi немовляти")
                          .SetHairColor("Золотавобiле")
                          .SetEyeColor("Зеленi")
                          .SetClothing("Огрядне зелене непойми що")
                          .AddInventoryItem("Лук")
                          .AddInventoryItem("Меч гоблiна")
                          .AddInventoryItem("Перстень")
                          .AddInventoryItem("Хлiб")
                          .AddSpecialAction("Не допомiг гному")
                          .Build();
        }
    }
}
