
class Program
{
    static string _text = "aaa\nbbb\nccc";

    static void Main(string[] args)
    {
      PluginsHolder ph = new PluginsHolder();
      ph.Add(new Plugin1());
      ph.Add(new Plugin2());
      
      ph.Run(ref _text);

      Console.WriteLine(_text);
    }
}
