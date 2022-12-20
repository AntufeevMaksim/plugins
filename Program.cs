class Program
{
    static string _text = "";
    static string _file_path = "";
    static PluginsHolder ph = new PluginsHolder();
    static void Main(string[] args)
    {
      OpenFile();
      Console.WriteLine(_text);
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
        Console.WriteLine(ready_text);
        ph.Clear();
      }
    }

    static void OpenFile(){
      Console.WriteLine("Enter path to file");
      _file_path = Console.ReadLine();
      _text = System.IO.File.ReadAllText(_file_path);
    }
}




// class C{
//   public string s = "123";
// }


// class Program
// {
//     static string _text = "aaa\nbbb\nccc";
//     static C c = new C();
//     static void Main(string[] args)
//     {
//       ChangeClass(c);
//       ChangeText(_text);
//       PluginsHolder ph = new PluginsHolder();
//       ph.Add(new Plugin1());
//       ph.Add(new Plugin2());
      
//       ph.Run(_text);

//       Console.WriteLine(_text);
//     }

//     static void ChangeText(string t){
//       t = "0"; 
//     }

//     static void ChangeClass(C c){
//       c.s = "0";
//     } 
// }
