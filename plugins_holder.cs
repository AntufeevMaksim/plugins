
class PluginsHolder{
  List<Plugin> plugins = new List<Plugin>();
  string _information_for_user = "|Press 0 to enter path | \n|Press 1 to Run Plugin1| \n|Press 2 to Run Plugin2| \n|Press 3 to Run Plugin3|";
  public string GetInformationForUser(){
    return _information_for_user;
  }
  public void Add(Plugin p){
    plugins.Add(p);
  } 

  public void Clear(){
    foreach (var p in plugins)
    {
      p.EndJob();
    }
    plugins.Clear();
  }

  public string Run(string input, string text){
          
    if(input == "1"){
      plugins.Add(new Plugin1());
    }
    else if(input == "2"){
      plugins.Add(new Plugin2());
    }
    else if(input == "3"){
      plugins.Add(new ColorPlugin());
    }
    text = RunPlugins(text);
    return text;
  }

  string RunPlugins(string text){
    foreach (var p in plugins)
    {
      text = p.Run(text);
    }
    return text;
  }

  public void EndJob(){
    foreach (var p in plugins)
    {
      p.EndJob();
    }
  }
}