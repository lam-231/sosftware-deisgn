using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLibrary
{
    public class Sword : HeroDecorator
    {
        public Sword(IHero hero) : base(hero) { }

        public override string GetDescription() => base.GetDescription() + " + Sword";
        public override int GetPower() => base.GetPower() + 3;
    }
    public class Armor : HeroDecorator
    {
        public Armor(IHero hero) : base(hero) { }

        public override string GetDescription() => base.GetDescription() + " + Armor";
        public override int GetPower() => base.GetPower() + 5;
    }
    public class Amulet : HeroDecorator
    {
        public Amulet(IHero hero) : base(hero) { }

        public override string GetDescription() => base.GetDescription() + " + Amulet";
        public override int GetPower() => base.GetPower() + 1;
    }
    public class UnbeliveableShit : HeroDecorator
    {
        public UnbeliveableShit(IHero hero) : base(hero) { }

        public override string GetDescription() => base.GetDescription() + " + UnbeliveableShit";
        public override int GetPower() => base.GetPower() + 99999;
    }
}
