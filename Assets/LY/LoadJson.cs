using System;
using System.IO;
using LitJson;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
namespace Common{

	public class IJson{
		
		public IJson(){
			
		}

		public static JsonData LoadJsonWithPath(string jsonName){
			#if UNITY_5 || UNITY_EDITOR
			string path = Application.dataPath + "/StreamingAsset/"+jsonName;
			#endif 
			#if UNITY_IOS || UNITY_IPHONE
			string path = Application.persistentDataPath + "/StreamingAsset/"+jsonName;
			#endif
			try{
				if (!File.Exists (path))
					return null;
				StreamReader sr = new StreamReader (path);
				if (sr == null)
					return null;
				String json = sr.ReadToEnd ();
				JsonData data = JsonMapper.ToObject (json);
				sr.Close ();
				sr.Dispose ();
				return data;
			}
			catch(Exception error){
				Debug.LogError (error.Message);
			}
			
			return null;
		}

		public static bool WriteJsonToFile(string fileName, object obj){
			#if UNITY_5 || UNITY_EDITOR
			string path = Application.dataPath + "/StreamingAsset/"+fileName;
			#endif 
			#if UNITY_IOS || UNITY_IPHONE
			string path = Application.persistentDataPath + "/StreamingAsset/"+fileName;
			#endif
			try{
			//找到当前路径
			FileInfo file = new FileInfo(path);
			//判断有没有文件，有则打开文件，，没有创建后打开文件
			StreamWriter sw = file.CreateText();
			//ToJson接口将你的列表类传进去，，并自动转换为string类型
			string json = JsonMapper.ToJson(obj);
			//将转换好的字符串存进文件，
			sw.WriteLine(json);
			//注意释放资源
			sw.Close();
			sw.Dispose();
			}
			catch(Exception error){
				Debug.LogError (error.Message);
				return false;
			}
			#if UNITY_EDITOR
			AssetDatabase.Refresh();
			#endif

			return true;
		}

	}

}
