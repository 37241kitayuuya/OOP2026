using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public class Settings {

        private const string FileName = "setting.xml";
        //唯一のSettingオブジェクト
       private static Settings _instance = new Settings();

        //メイン画面に設定した色情報
        public int mainFormBackColor { get; set; }
        = SystemColors.Control.ToArgb();

        public static Settings Instance {
            get { return _instance; }
        }

        //外部からnewできないようにする
        private Settings() { }

        public void Load() {
            if (!File.Exists(FileName))
                return;
            using var reader = XmlReader.Create(FileName);
            var serializer = new XmlSerializer(typeof(SettingsDate));

            if(serializer.Deserialize(reader)is SettingsDate date) {
                mainFormBackColor = date.MainFromBackColor;
            }
        }
        //設定ファイルを保存
        public void Save() {
            var date = new SettingsDate {
                MainFromBackColor = mainFormBackColor
            };


            using var writer = XmlWriter.Create(FileName);
            var serializer = new XmlSerializer(typeof(SettingsDate));
            serializer.Serialize(writer, date);
        }   }

    public class SettingsDate {
        public int MainFromBackColor { get; set; }

        
    }
}
