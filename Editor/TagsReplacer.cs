namespace Guyl.XTags.Editor
{
    using System.IO;
    using UnityEngine;
    using UnityEditor;

    public class TagsReplacer : AssetModificationProcessor
    {
        public static void OnWillCreateAsset(string a_path)
        {
            a_path = a_path.Replace(".meta", "");
            int index = a_path.LastIndexOf(".");
            if (index < 0) return;
            string file = a_path.Substring(index);
            if (file != ".cs") return;
            index = Application.dataPath.LastIndexOf("Assets");
            a_path = Application.dataPath.Substring(0, index) + a_path;
            file = File.ReadAllText(a_path);

            file = file.Replace("#DATE#", System.DateTime.Now.ToString());
            file = file.Replace("#PRODUCTNAME#", PlayerSettings.productName);
            file = file.Replace("#COMPANYNAME", PlayerSettings.companyName);

            File.WriteAllText(a_path, file);
            AssetDatabase.Refresh();
        }
    }
}