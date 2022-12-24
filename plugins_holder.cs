
class PluginsHolder
{
  List<Plugin> plugins = new List<Plugin>();
  string _information_for_user = "|Press 0 to enter path | \n|Press 1 to add chars to end of text| \n|Press 2 to add chars to end of every string| \n|Press 3 to colorize text|";
 
  //public
  public string GetInformationForUser(){
    return _information_for_user;
  }
  public void Add(Plugin p){
    plugins.Add(p);
  } 

  public void NewFile(){
    foreach (var p in plugins)
    {
      p.EndJob();
    }
    plugins.Clear();
  }
  public void Clear(){
    foreach (var p in plugins)
    {
      p.EndJob();
    }
  }
  public string Run(string input, string text){

    var info = new PluginInfo(input);

          
    if(info.GetPluginType() == "1"){
      plugins.Add(new Plugin1(info.GetArgs()));
    }
    else if(info.GetPluginType() == "2"){
      plugins.Add(new Plugin2(info.GetArgs()));
    }
    else if(info.GetPluginType() == "3"){
      plugins.Add(new ColorPlugin(info.GetArgs()));
    }
    text = RunPlugins(text);
    return text;
  }

  //private
  string RunPlugins(string text){
    foreach (var p in plugins)
    {
      text = p.Run(text);
    }
    return text;
  }
}