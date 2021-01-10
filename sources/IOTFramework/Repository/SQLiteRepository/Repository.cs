using Microsoft.EntityFrameworkCore;

namespace SQLiteRepository
{
    /// <summary>
    /// 数据仓库
    /// </summary>
    public static class Repository
    {
        /// <summary>
        /// 数据仓库
        /// </summary>
        public class RepositoyContext : DbContext
        {
            /// <summary>
            /// 数据源
            /// </summary>
            /// <example>Data Source=db/blogging.db</example>
            private string dataSource;

            public RepositoyContext(string dataSource) {
                this.dataSource = dataSource;
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
                optionsBuilder.UseSqlite(dataSource);
            }
        }
    }
}
