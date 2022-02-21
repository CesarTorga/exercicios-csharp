namespace RPG.Entities
{
    public class Bruxo : Hero
    {
        public Bruxo(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public override string Attack()
            {
                return this.Name + " Atacou com sua Águia gigante";
            }
        public string Attack(int Bonus)
        {
            if (Bonus > 7)
            {
                return this.Name + " Explodiu o inimigo com combo de " + Bonus + " pts de caos";
            }
            else
            {
            return this.Name + " Mal arranhou o inimigo com bonus de " + Bonus + " pts de caos";
            }
        }
    }
}