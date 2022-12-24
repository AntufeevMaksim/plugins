class Plugin2 : Plugin{

  string str = "";
  public Plugin2(List<string> args){
    if(args.Count() != 0){
      str = args[0];
    }
  }
  public override string Run(string text){
    for (int i = 0; i < text.Count()-1; i++)
    {
      if (text.Substring(i, 1) == "\n")
      {
        text = text.Substring(0, i) + str + text.Substring(i);
        i += str.Count();
      }
    }
    text += str;
  return text;
  }
}