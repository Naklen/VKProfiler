using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Net;
using System.Text;

namespace VKProfiler
{
    class Profiler
    {
        const string appID = "7492656";
        public string Token { get; private set; }
        public string UserName { get; private set; }
        public string UserID { get; private set; }
        public bool Autorized { get; private set; } = false;

        public void Autorize(Form2 f)
        {
            Token = "";
            var res = GetToken(f).Split(new char[] { '=', '&' });
            Token = res[1];
            UserID = res[5];
            UserName = GetUserName(UserID);
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

        public ProfileData GetProfileData(string id)
        {
            var request = BuildRequest(id, new string[] { "counters", "bdate", "sex", "city", "photo_200", "status", });
            ProfileData result;
            JObject response;
            Bitmap photo;
            using (var wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                response = JObject.Parse(wc.DownloadString(request));
                if (response.ContainsKey("error") || !(response["response"] as JArray).HasValues)
                {
                    wc.Dispose();
                    return null;
                }
                else
                    photo = new Bitmap(wc.OpenRead(response["response"][0]["photo_200"].ToString())); 

            }
            if (response.ContainsKey("error") || !(response["response"] as JArray).HasValues)
                return null;
            var pData = response["response"][0] as JObject;
            var deactivated = pData.ContainsKey("deactivated");
            bool isClosed;
            if (pData.ContainsKey("is_closed"))
                isClosed = pData["is_closed"].ToString() == "True";
            else 
                isClosed = false;
            var name = pData["first_name"].ToString() + " " + pData["last_name"].ToString();
            string birthday;
            if (pData.ContainsKey("bdate"))
                birthday = "День рождения: " + pData["bdate"].ToString();
            else
                birthday = "День рождения не указан";
            string sex;
            switch (pData["sex"].ToString())
            {
                case "1":
                    sex = "Пол: женский";
                    break;
                case "2":
                    sex = "Пол: мужской";
                    break;
                default:
                    sex = "Пол не указан";
                    break;
            }
            string city;
            if (pData.ContainsKey("city"))
                city = "Город: " + pData["city"]["title"];
            else
                city = "Город не указан";
            string status;
            if (pData.ContainsKey("status"))
                status = "Статус: \"" + pData["status"] + "\"";
            else
                status = "Статус не указан";
            var pc = pData["counters"];
                var counters = new ProfileCounters
                    (
                        pc!= null && pc["friends"] != null ? pc["friends"].ToString() : "-",
                        pc != null && pc["followers"] != null ? pc["followers"].ToString() : "-",
                        pc != null && pc["photos"] != null ? pc["photos"].ToString() : "-",
                        pc != null && pc["videos"] != null ? pc["videos"].ToString() : "-",
                        pc != null && pc["audios"] != null ? pc["audios"].ToString() : "-"
                    );
                result = new ProfileData(name, isClosed, deactivated,  counters, birthday, sex, city, photo, status);
            return result;
        }
    }

    class ProfileData
    {
        public string Name { get; }
        public bool IsClosed { get; }
        public bool Deactiavated { get; }
        public ProfileCounters Counters { get; }
        public string Birthday { get; }
        public string Sex { get; }
        public string City { get; }
        public Bitmap Avatar { get; }
        public string Status { get; }

        public ProfileData(string name, bool isClosed, bool deactivated, ProfileCounters counters, string birthday, string sex, string city, Bitmap avatar, string status)
        {
            Name = name;
            Counters = counters;
            Birthday = birthday;
            Sex = sex;
            City = city;
            Avatar = avatar;
            Status = status;
            IsClosed = isClosed;
            Deactiavated = deactivated;
        }
    }

    class ProfileCounters
    {
        public string FriendsCount { get; }
        public string FollowersCount { get; }
        public string PhotoCount { get; }
        public string VideoCount { get; }
        public string AudioCount { get; }

        public ProfileCounters(string friends, string followers, string photo, string video, string audio)
        {
            FriendsCount = friends;
            FollowersCount = followers;
            PhotoCount = photo;
            VideoCount = video;
            AudioCount = audio;
        }
    }
}
