using System;
using Newtonsoft.Json;

public class ListUser
{

	public void Userdata()
	{
        string url = "http://localhost:5000/api/UsersControler/";
        string json = wc.DownloadString(url);
        data = JsonConvert.DeserializeObject<List<User_Model>>(json);
    }
}
