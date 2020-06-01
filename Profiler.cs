using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKProfiler
{
    class Profiler
    {
        const string appID = "7492656";
        public string Token { get; private set; }
        public string UserName { get; private set; }
        public bool Autorized { get; private set; } = false;

        public void Autorize(Form2 f)
        {
            Token = "";
            var res = GetToken(f).Split(new char[] { '=', '&' });
            Token = res[1];
            UserName = GetUserName(res[5]);
            Autorized = true;
        }

        string GetToken(Form2 f)
        {
            string res;
            while (f.Token == "") { }
            res = f.Token;
            return res;
        }

        public string GetAutorizeURL()
        {
            var sb = new StringBuilder();
            sb.Append("https://oauth.vk.com/authorize?client_id=");
            sb.Append(appID);
            sb.Append("&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends&response_type=token&v=5.107&state=123456");
            return sb.ToString();
        }

        string GetUserName(string id)
        {
            var request = BuildRequest(id, null);
            string result;
            using (var wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var response = wc.DownloadString(request);
                var obj = JObject.Parse(response);
                var fName = obj["response"][0]["first_name"].ToString();
                var lName = obj["response"][0]["last_name"].ToString();
                result = $"{fName} {lName}";
            }
            return result;
        }

        string BuildRequest(string id, string[] fields)
        {
            var sb = new StringBuilder();
            sb.Append("https://api.vk.com/method/users.get?user_ids=");
            sb.Append(id);
            if (fields != null)
            {
                sb.Append("&fields=");
                for (int i = 0; i < fields.Length - 1; i++)
                {
                    sb.Append(fields[i]);
                    sb.Append(",");
                }
                sb.Append(fields[fields.Length - 1]);
            }
            sb.Append("&access_token=");
            sb.Append(Token);
            sb.Append("&v=5.107");
            return sb.ToString();
        }
    }
}
