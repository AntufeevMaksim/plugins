
class Plugin1 : Plugin{

  string str = "";
  public Plugin1(List<string> args){
    if (args.Count() != 0){
      str = args[0];
    }
  }
  public override string Run(string text){
    text += str;
    return text;
  }
}