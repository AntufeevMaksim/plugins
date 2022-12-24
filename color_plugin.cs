class ColorPlugin : Plugin{

  ConsoleColor color; //default color
  public ColorPlugin(List<string> args){
    if(args.Count() == 0){
      color = ConsoleColor.White;
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
  }
  public override string Run(string text){
    Console.ForegroundColor = color;
    return text;
  }

  public override void EndJob()
  {
    Console.ForegroundColor = ConsoleColor.White;
  }
}