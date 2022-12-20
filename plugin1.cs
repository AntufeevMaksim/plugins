
class Plugin1 : Plugin{
  public Plugin1(){
  }
  public override string Run(string text, List<string> args){
    text += "123";
    return text;
  }
}