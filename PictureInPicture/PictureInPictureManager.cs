using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;

namespace PictureInPicture
{
    /// <summary>
    /// 画中画管理类
    /// </summary>
    public class PictureInPictureManager
    {
        /// <summary>
        /// 装置配置
        /// </summary>
        public void LoadConfig()
        {
            PictureInPuctureObjectList.Clear();
            var s = File.ReadAllText("sys.json");
            var jo = JsonConvert.DeserializeObject(s) as JObject;

            var arr = jo["PictureInPicture"] as JArray;
            foreach(JObject jItem in arr)
            {
                var item = new PictureInPuctureObject();
                item.VideoNo = Convert.ToInt32(jItem["VideoNo"]);
                item.Left = Convert.ToInt32(jItem["Left"]);
                item.Top = Convert.ToInt32(jItem["Top"]);
                item.Width = Convert.ToInt32(jItem["Width"]);
                item.Height = Convert.ToInt32(jItem["Height"]);
                PictureInPuctureObjectList.Add(item);
            }
        }

        public void Save()
        {
            var s = File.ReadAllText("sys.json");
            var jo = JsonConvert.DeserializeObject(s) as JObject;

            var arr = jo["PictureInPicture"] as JArray;
            foreach (JObject jItem in arr)
            {
                var VideoNo = Convert.ToInt32(jItem["VideoNo"]);
                var item = GetItemByvideoNo(VideoNo);
                if (item != null)
                {
                    jItem["Left"] = item.Left;
                    jItem["Top"] = item.Top;
                    jItem["Width"] = item.Width;
                    jItem["Height"] = item.Height;
                }
            }

            File.WriteAllText("sys.json", jo.ToString());
        }

        /// <summary>
        /// 更新某个窗口的配置
        /// </summary>
        /// <param name="obj"></param>
        public void Update(PictureInPuctureObject obj)
        {
            var item = WindowList.FirstOrDefault(x => x.VideoNo == obj.VideoNo);
            if (item != null)
            {
                item.Left = obj.Left;
                item.Top = obj.Top;
                item.Width = obj.Width;
                item.Height = obj.Height;
            }
        }
        /// <summary>
        /// 获得某个窗口的配置
        /// </summary>
        /// <param name="videoNo"></param>
        /// <returns></returns>
        public PictureInPuctureObject GetItemByvideoNo(int videoNo)
        {
            return WindowList.FirstOrDefault(x => x.VideoNo == videoNo);
        }

        private List<PictureInPuctureObject> PictureInPuctureObjectList = new List<PictureInPuctureObject>();
        public IEnumerable<PictureInPuctureObject> WindowList { get => PictureInPuctureObjectList; }
    }

    /// <summary>
    /// 画中画窗口定义
    /// </summary>
    public class PictureInPuctureObject
    {
        /// <summary>
        /// 索引号
        /// </summary>
        public int VideoNo { get; set; }
        /// <summary>
        /// 左边距
        /// </summary>
        public int Left { get; set; }
        /// <summary>
        /// 上边距
        /// </summary>
        public int Top { get; set; }
        /// <summary>
        /// 宽度
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// 高度
        /// </summary>
        public int Height { get; set; }
    }
}
