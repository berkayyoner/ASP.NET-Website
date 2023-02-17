using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace ASP.NET_Website.Pages.Form
{
    public class MenuModel : PageModel
    {
		private readonly ILogger<MenuModel> logger;
		public List<Classes.FormInfo> FormInfos = new List<Classes.FormInfo>();
		public MenuModel(ILogger<MenuModel> logger)
		{
			this.logger = logger;
		}
		public void OnGet() // Save the infos into list from DB
		{
			try
			{
				String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=\\ASP.NET Website\\;Integrated Security=True";

				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();
					string query = "select * from Datas";
					SqlCommand cmd = new SqlCommand(query, connection);
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							Classes.FormInfo formInfo = new Classes.FormInfo();
							formInfo.ID = reader.GetInt32(0);
							formInfo.Name = reader.GetString(1);
							formInfo.Surname = reader.GetString(2);
							formInfo.Birthday = reader.GetDateTime(3);
							FormInfos.Add(formInfo);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Exception is " + ex.ToString());
			}
		}
	}
}
