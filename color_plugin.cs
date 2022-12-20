class ColorPlugin : Plugin{

  ConsoleColor color = ConsoleColor.White; //default color
  public ColorPlugin(){
  }
  public override string Run(string text, List<string> args){

    if(args.Count() == 0){
      Console.ForegroundColor = color;
    }
    else if(args[0] == "r"){
      color = ConsoleColor.Red;
    }
    else if(args[0] == "g"){
      color = ConsoleColor.Green;
    }
    else if(args[0] == "b"){
      color = ConsoleColor.Blue;
    }
    else if(args[0] == "w"){
      color = ConsoleColor.White;
    }

    Console.ForegroundColor = color;
    
  return text;
  }

  public override void EndJob()
  {
    Console.ForegroundColor = ConsoleColor.White;
  }
}