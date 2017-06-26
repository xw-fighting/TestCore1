using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dream.Model.Models;
using Dream.IRepository.IReposotories;
using System.Text;

namespace Dream.Web.Api
{
    [Produces("application/json")]
    [Route("api/UserManage/[action]")]
    public class UserManageController : Controller
    {
        public UserManageController(IUserManageInfoRepository userManageInfoRepository)
        {
            UserManageInfoRepository = userManageInfoRepository;
        }
        public IUserManageInfoRepository UserManageInfoRepository { get; set; }

        [HttpGet]
        public List<TestUser> GetAll()
        {
            //return UserManageInfoRepository.QueryWhere(c => true);
            List<TestUser> list = new List<TestUser>();
            list.Add(new TestUser
            {
                Name = "Tiger Nixon",
                Position = "System Architect",
                Salary = "$320,800",
                StartDate = "2011/04/25",
                Office = "Edinburgh",
                Extn = "5421"
            });
            list.Add(new TestUser
            {
                Name = "Tiger Nixon",
                Position = "System Architect",
                Salary = "$320,800",
                StartDate = "2011/04/25",
                Office = "Edinburgh",
                Extn = "5421"
            });
            list.Add(new TestUser
            {
                Name = "Tiger Nixon",
                Position = "System Architect",
                Salary = "$320,800",
                StartDate = "2011/04/25",
                Office = "Edinburgh",
                Extn = "5421"
            });
            list.Add(new TestUser
            {
                Name = "Tiger Nixon",
                Position = "System Architect",
                Salary = "$320,800",
                StartDate = "2011/04/25",
                Office = "Edinburgh",
                Extn = "5421"
            });
            list.Add(new TestUser
            {
                Name = "Tiger Nixon",
                Position = "System Architect",
                Salary = "$320,800",
                StartDate = "2011/04/25",
                Office = "Edinburgh",
                Extn = "5421"
            });
            return list;
        }

        //public static string DataTableToJson(int sEcho, int totalRow, DataTable dt, bool dt_dispose)
        //{
        //    StringBuilder json = new StringBuilder();
        //    json.Append("{\"sEcho\":" + sEcho.ToString() + ",");
        //    json.Append("\"iTotalRecords\":" + totalRow.ToString() + ",");
        //    json.Append("\"iTotalDisplayRecords\":" + totalRow.ToString() + ",");
        //    json.Append("\"aaData\":[");
        //    //json.AppendFormat("{\"sEcho\":{0},\n \"iTotalRecords\":{1},\n \"iTotalDisplayRecords\": {2},\n \"aaData\":[", sEcho, totalRow, totalRow);

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        json.Append("{");
        //        for (int j = 0; j < dt.Columns.Count; j++)
        //        {
        //            json.Append("\"");
        //            json.Append(dt.Columns[j].ColumnName);
        //            json.Append("\":\"");
        //            json.Append(dt.Rows[i][j].ToString());
        //            json.Append("\",");
        //        }
        //        json.Remove(json.Length - 1, 1);
        //        json.Append("},");
        //    }
        //    json.Remove(json.Length - 1, 1);
        //    json.Append("]}");

        //    return json.ToString();
        //}

        public bool Add(UserManageInfo model)
        {
            UserManageInfoRepository.Add(model);
            return true;
        }
        public class TestUser
        {
            public string Name { get; set; }

            public string Position { get; set; }
            public string Salary { get; set; }
            public string StartDate { get; set; }
            public string Office { get; set; }
            public string Extn { get; set; }

        }
    }
}