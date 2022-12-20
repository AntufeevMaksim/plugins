struct PluginInfo
{
  List<string> args;
  string plugin_type;

  public PluginInfo(string input){
    List<string> arr = input.Split('-').ToList();
    plugin_type = arr[0].Trim(); //delete spaces
    args = arr.GetRange(1, arr.Count()-1);
    for(int i = 0; i < args.Count(); i++){
      args[i] = args[i].Trim();
    }
  }
  public string GetPluginType(){
    return plugin_type;
  }

  public List<string> GetArgs(){
    return args;
  }
}
