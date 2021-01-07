using Common;
using System;
using System.IO;
using System.Text;
using YamlDotNet.Serialization;

namespace YamlRepository
{
    /// <summary>
    /// 数据仓库
    /// </summary>
    public static class Repository
    {
        /// <summary>
        /// 读取配置
        /// </summary>
        /// <param name="path">路径</param>
        /// <returns>配置</returns>
        public static T LoadConfiguation<T>(string path) {
            try {
                using (var sr = new StreamReader(path, Encoding.UTF8)) {
                    return new Deserializer().Deserialize<T>(sr);
                }
            }
            catch (Exception e) {
                Tracker.LogE(e);
                return default;
            }
        }

        /// <summary>
        /// 保存配置
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="configuration">配置</param>
        public static void SaveConfiguation<T>(string path, T configuration) {
            try {
                using (var sw = new StreamWriter(path, false, Encoding.UTF8)) {
                    var yaml = new Serializer().Serialize(configuration);
                    sw.Write(yaml);
                    sw.Flush();
                }
            }
            catch (Exception e) {
                Tracker.LogE(e);
                throw e;
            }
        }
    }
}
