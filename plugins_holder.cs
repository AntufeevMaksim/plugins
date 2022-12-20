
class PluginsHolder
{
  List<Plugin> plugins = new List<Plugin>();
  string _information_for_user = "|Press 0 to enter path | \n|Press 1 to Run Plugin1| \n|Press 2 to Run Plugin2| \n|Press 3 to Run Plugin3|";
 
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
      plugins.Add(new Plugin1());
    }
    else if(info.GetPluginType() == "2"){
      plugins.Add(new Plugin2());
    }
    else if(info.GetPluginType() == "3"){
      plugins.Add(new ColorPlugin());
    }
    text = RunPlugins(text, info);
    return text;
  }

  //private
  string RunPlugins(string text, PluginInfo info){
    foreach (var p in plugins)
    {
      text = p.Run(text, info.GetArgs());
    }
    return text;
  }

  // PluginInfo ParseInput(string input){
  //   PluginInfo info;
    
  //   int i = input.IndexOf('-');
  //   info.plugin_type = input.Substring(0, i);

  //   string[] m_str = input.Split('-');
  //   info.plugin_type = m_str[0];


  // }
}