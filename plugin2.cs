class Plugin2 : Plugin{
  public Plugin2(){
  }
  public override string Run(string text, List<string> args){
    for (int i = 0; i < text.Count()-1; i++)
    {
      if (text.Substring(i, 1) == "\n")
      {
        text = text.Substring(0, i) + "!" + text.Substring(i);
        i += 1;
      }
    }
    text += "!";
  return text;
  }
}