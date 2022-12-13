
class PluginsHolder{
  List<Plugin> plugins = new List<Plugin>();

  public void Add(Plugin p){
    plugins.Add(p);
  } 

  public void Run(ref string text){
    foreach (var p in plugins)
    {
      p.Run(ref text);
    }
  }
}