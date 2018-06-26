using System;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Web;

namespace RDTools.Common
{
    public class AppConfig
    {

        public static string GetAppSetting(string key)
        {
            return GetAppSetting(Application.ExecutablePath, key);
        }

        public static string GetAppSetting(string appPath, string key)
        {
            return GetAppSetting(appPath, key, "1");
        }

        /// <summary>
        /// 设置默认值 add by:tzw@2017.3.8
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defValue"></param>
        /// <returns></returns>
        public static string GetAppDefSetting(string key, string defValue)
        {
            return GetAppSetting(Application.ExecutablePath, key, defValue);
        }
        /// <summary>
        /// 设置默认值和描述 add by:tzw@2017.3.8
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defValue">默认值</param>
        /// <param name="desc">描述</param>
        /// <returns></returns>
        public static string GetAppDefSetting(string key, string defValue, string desc)
        {
            return GetAppSetting(Application.ExecutablePath, key, defValue, desc);
        }

        /// <summary>
        /// add by:tzw@2017.3.8
        /// </summary>
        /// <param name="appPath">路径</param>
        /// <param name="key">key</param>
        /// <param name="defValue">默认值</param>
        /// <returns></returns>
        public static string GetAppSetting(string appPath, string key, string defValue)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(appPath);
            //return config.AppSettings.Settings[key].Value;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(config.FilePath);
            XmlNode xmlNode = xmlDoc.SelectSingleNode("configuration/appSettings");
            if (xmlNode != null)
            {
                XmlElement addElem = (XmlElement)xmlNode.SelectSingleNode("//add[@key='" + key + "']");
                if (addElem != null)
                {
                    return addElem.GetAttribute("value");
                }
                else
                {
                    XmlElement entry = xmlDoc.CreateElement("add");
                    entry.SetAttribute("key", key);
                    entry.SetAttribute("value", defValue);
                    entry.SetAttribute("desc", "");
                    xmlNode.AppendChild(entry);
                    saveConfigDoc(xmlDoc, config.FilePath);
                    return defValue;
                }
            }
            return defValue;
        }

        /// <summary>
        /// add by:tzw@2017.3.8
        /// </summary>
        /// <param name="appPath">路径</param>
        /// <param name="key">key</param>
        /// <param name="defValue">默认值</param>
        /// <param name="desc">描述</param>
        /// <returns></returns>
        public static string GetAppSetting(string appPath, string key, string defValue, string desc)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(appPath);
            //return config.AppSettings.Settings[key].Value;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(config.FilePath);
            XmlNode xmlNode = xmlDoc.SelectSingleNode("configuration/appSettings");
            if (xmlNode != null)
            {
                XmlElement addElem = (XmlElement)xmlNode.SelectSingleNode("//add[@key='" + key + "']");
                if (addElem != null)
                {
                    return addElem.GetAttribute("value");
                }
                else
                {
                    XmlElement entry = xmlDoc.CreateElement("add");
                    entry.SetAttribute("key", key);
                    entry.SetAttribute("value", defValue);
                    entry.SetAttribute("desc", desc);
                    xmlNode.AppendChild(entry);
                    saveConfigDoc(xmlDoc, config.FilePath);
                    return defValue;
                }
            }
            return defValue;
        }

        public static void WriteAppSetting(string appPath, string key, string value)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(appPath);
                config.AppSettings.Settings[key].Value = value;
                config.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GetRdClientManageConfig(string section, string config)
        {
            string applicationDocumentPath = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            if (File.Exists(applicationDocumentPath))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(applicationDocumentPath);
                XmlNode xmlNode = xmlDoc.SelectSingleNode("configuration/" + section);
                if (xmlNode != null)
                {
                    foreach (XmlNode x in xmlNode.ChildNodes)
                    {
                        if (x.Name != "add")
                            continue;
                        if (config == x.Attributes["key"].Value)
                        {
                            return x.Attributes["value"].Value;
                        }
                    }
                }
                else
                {
                    //不存在节点添加节点

                    return "1";
                }
            }
            return "1";
        }

        /// <summary>
        /// 获取entity模型数据库连接
        /// </summary>
        /// <returns></returns>
        public static string DataBaseConnectionString()
        {
            string DataSource = ConfigurationManager.AppSettings["Server"].ToString();
            string DataBase = ConfigurationManager.AppSettings["DataBase"].ToString();
            string UserId = ConfigurationManager.AppSettings["User"].ToString();
            string PassWord = ConfigurationManager.AppSettings["Password"].ToString();
            return string.Concat("data source=" + DataSource + ";initial catalog=" + DataBase + ";persist security info=True;user id=" + UserId + ";password=" + PassWord + ";MultipleActiveResultSets=True;App=EntityFramework");
        }

        #region  程序配置文档增删改查
        /// <summary>
        /// 配置文件类型,是WinForm还是WebForm
        /// </summary>
        public enum ConfigFileType
        {
            WebConfig,
            AppConfig
        }

        /// <summary>
        /// 对AppSettings节点进行增加，删除，修改操作.
        /// </summary>
        public static string docName = String.Empty;
        private static XmlNode node = null;

        /// <summary>
        /// 设置节点的值，若该节点不存在，则创建一个新的节点。默认操作AppConfig
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool SetValue(string key, string value)
        {
            return SetValue(key, value, ConfigFileType.AppConfig);
        }

        /// <summary>
        /// 设置节点的值，若该节点不存在，则创建一个新的节点。
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="cfgType"></param>
        /// <returns></returns>
        public static bool SetValue(string key, string value, ConfigFileType cfgType)
        {
            XmlDocument cfgDoc = new XmlDocument();
            loadConfigDoc(cfgDoc, cfgType);
            // retrieve the appSettings node   
            node = cfgDoc.SelectSingleNode("//appSettings");
            if (node == null)
            {
                throw new InvalidOperationException("appSettings section not found");
            }
            try
            {
                // XPath select setting "add" element that contains this key       
                XmlElement addElem = (XmlElement)node.SelectSingleNode("//add[@key='" + key + "']");
                if (addElem != null)
                {
                    addElem.SetAttribute("value", value);
                }
                // not found, so we need to add the element, key and value   
                else
                {
                    XmlElement entry = cfgDoc.CreateElement("add");
                    entry.SetAttribute("key", key);
                    entry.SetAttribute("value", value);
                    node.AppendChild(entry);
                }
                //save it   
                saveConfigDoc(cfgDoc, docName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string GetValue(string key)
        {
            return GetValue(key, ConfigFileType.AppConfig);
        }
        /// <summary>
        /// 获取节点的值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="cfgType"></param>
        /// <returns></returns>
        public static string GetValue(string key, ConfigFileType cfgType)
        {
            XmlDocument cfgDoc = new XmlDocument();
            loadConfigDoc(cfgDoc, cfgType);
            // retrieve the appSettings node   
            node = cfgDoc.SelectSingleNode("//appSettings");
            if (node == null)
            {
                throw new InvalidOperationException("appSettings section not found");
            }

            // XPath select setting "add" element that contains this key       
            XmlElement addElem = (XmlElement)node.SelectSingleNode("//add[@key='" + key + "']");
            if (addElem != null)
            {
                return addElem.GetAttribute("value");
            }
            else
            {
                XmlElement entry = cfgDoc.CreateElement("add");
                entry.SetAttribute("key", key);
                entry.SetAttribute("value", "1");
                node.AppendChild(entry);
                //save it   
                saveConfigDoc(cfgDoc, docName);
                return "1";
            }
        }

        private static void saveConfigDoc(XmlDocument cfgDoc, string cfgDocPath)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(cfgDocPath, null);
                writer.Formatting = Formatting.Indented;
                cfgDoc.WriteTo(writer);
                writer.Flush();
                writer.Close();
                return;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 移除节点
        /// </summary>
        /// <param name="elementKey"></param>
        /// <param name="cfgType"></param>
        /// <returns></returns>
        public static bool RemoveElement(string elementKey, ConfigFileType cfgType)
        {
            try
            {
                XmlDocument cfgDoc = new XmlDocument();
                loadConfigDoc(cfgDoc, cfgType);
                // retrieve the appSettings node  
                node = cfgDoc.SelectSingleNode("//appSettings");
                if (node == null)
                {
                    throw new InvalidOperationException("appSettings section not found");
                }
                // XPath select setting "add" element that contains this key to remove      
                node.RemoveChild(node.SelectSingleNode("//add[@key='" + elementKey + "']"));
                saveConfigDoc(cfgDoc, docName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 修改节点的值
        /// </summary>
        /// <param name="elementKey"></param>
        /// <param name="cfgType"></param>
        /// <returns></returns>
        public static bool ModifyElement(string elementKey, ConfigFileType cfgType)
        {
            try
            {
                XmlDocument cfgDoc = new XmlDocument();
                loadConfigDoc(cfgDoc, cfgType);
                // retrieve the appSettings node  
                node = cfgDoc.SelectSingleNode("//appSettings");
                if (node == null)
                {
                    throw new InvalidOperationException("appSettings section not found");
                }
                // XPath select setting "add" element that contains this key to remove      
                node.RemoveChild(node.SelectSingleNode("//add[@key='" + elementKey + "']"));
                saveConfigDoc(cfgDoc, docName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static XmlDocument loadConfigDoc(XmlDocument cfgDoc, ConfigFileType cfgType)
        {
            // load the config file   
            if (cfgType == ConfigFileType.AppConfig)
            {
                docName = ((Assembly.GetEntryAssembly()).GetName()).Name;
                docName += ".exe.config";
            }
            else
            {
                docName = HttpContext.Current.Server.MapPath("web.config");
            }
            cfgDoc.Load(docName);
            return cfgDoc;
        }


        #endregion
    }
}
