using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCharacters
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetHeight(double height);
        ICharacterBuilder SetBodyType(string bodyType);
        ICharacterBuilder SetHairColor(string hairColor);
        ICharacterBuilder SetBeard(string beard);
        ICharacterBuilder SetEyeColor(string eyeColor);
        ICharacterBuilder SetClothing(string clothing);
        ICharacterBuilder AddInventoryItem(string item);
        ICharacterBuilder AddSpecialAction(string action);
        Character Build();
    }
}
