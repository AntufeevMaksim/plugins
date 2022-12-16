class ColorPlugin : Plugin{
  public ColorPlugin(){
  }
  public override string Run(string text){
    Console.ForegroundColor = ConsoleColor.Red;
  return text;
  }

  public override void EndJob()
  {
    Console.ForegroundColor = ConsoleColor.White;
  }
}