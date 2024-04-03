namespace ATframework3demo.TestEntities
{
    public class Bitrix24Contact
    {
        public Bitrix24Contact(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public string Name { get; set; }
    }
}
