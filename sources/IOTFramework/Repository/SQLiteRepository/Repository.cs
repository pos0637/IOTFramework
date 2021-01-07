using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Data.SQLite;
using System.Data.SQLite.EF6;

namespace SQLiteRepository
{
    /// <summary>
    /// 数据仓库
    /// </summary>
    public static class Repository
    {
        /// <summary>
        /// 数据库配置
        /// </summary>
        private class SQLiteConfiguration : DbConfiguration
        {
            public SQLiteConfiguration() {
                SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
                SetProviderFactory("System.Data.SQLite.EF6", SQLiteProviderFactory.Instance);
                SetProviderServices("System.Data.SQLite", (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices)));
            }
        }

        /// <summary>
        /// 数据仓库
        /// </summary>
        public class RepositoyContext : DbContext
        {
            /// <summary>
            /// 获取数据库连接
            /// </summary>
            /// <param name="path">路径</param>
            /// <returns>数据库连接</returns>
            private static DbConnection GetConnection(string path) {
                var connection = SQLiteProviderFactory.Instance.CreateConnection();
                connection.ConnectionString = $"Data Source={path}";
                return connection;
            }

            public RepositoyContext(string path)
                : base(GetConnection(path), true) {
                DbConfiguration.SetConfiguration(new SQLiteConfiguration());
            }
        }
    }
}
