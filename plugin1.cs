
class Plugin1 : Plugin{
  public Plugin1(){
  }
  public override string Run(string text){
    text += "123";
    return text;
  }
}