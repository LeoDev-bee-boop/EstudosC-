namespace Concilig.Automacao.Selenium.Model
{
    public struct ColumnItem
    {
        public ColumnItem(string value, string link)
        {
            Value = value;
            Link = link;
        }
        public string Value { get; private set; }
        public string Link { get; private set; }
    }
}
