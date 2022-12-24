class Program
{
    static string _text = "";
    static string _file_path = "";
    static PluginsHolder ph = new PluginsHolder();
    static void Main(string[] args)
    {
      OpenFile();
      Console.WriteLine("\n" + _text + "\n");
      string ready_text = "";
      while (true){
        Console.WriteLine(ph.GetInformationForUser());
        string input = Console.ReadLine();
        if (input == "0"){
          OpenFile();
          ph.NewFile();
          ready_text = _text;
        }
        else{
          ready_text = ph.Run(input, _text);
        }
        Console.WriteLine("\n" + ready_text + "\n");
        ph.Clear();
      }
    }

    static void OpenFile(){
      Console.WriteLine("Enter path to file");
      try{
        _file_path = Console.ReadLine();
        _text = System.IO.File.ReadAllText(_file_path);
      }
      catch{
        Console.WriteLine("Incorrect file path");
      }
    }
}
