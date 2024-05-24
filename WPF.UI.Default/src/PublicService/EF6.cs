using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PublicService
{
    public class EF6 : DbContext
    {
        //public DbSet<TableSchema> TableSchemas { get; set; }

        public EF6(string connectionString) : base(connectionString)
        {
        }

        /// <summary>
        /// DB 경로 - 예시. @"D:\DB\Default_DB.db"
        /// </summary>
        /// <param name="sDBPath"></param>
        /// <returns></returns>
        public bool DB_Conn(string sDBPath)
        {
            bool result = false;

            // 경로에 값이 null 이거나, 빈공간이 있으면 안된다.
            if (string.IsNullOrEmpty(sDBPath) == false) result = false;
            if (string.IsNullOrWhiteSpace(sDBPath) == false) result = false;

            // 데이터베이스 경로 설정
            var databasePath = sDBPath;

            // 연결 문자열 설정
            var connectionString = $"Data Source={databasePath};Version=3;";

            using (var dbContext = new EF6(connectionString))
            {
                // 데이터베이스 연결 테스트
                dbContext.Database.Connection.Open();

                if (dbContext.Database.Connection.State == System.Data.ConnectionState.Open)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }

    //    /// <summary>
    //    /// args - 테이블명
    //    /// </summary>
    //    /// <param name="arg"></param>
    //    /// <returns></returns>
    //    public bool Modelcs_Create(string[] args)
    //    {
    //        bool result = false;

    //        ////// 경로에 값이 null 이거나, 빈공간이 있으면 안된다.
    //        if (args.Length != 1) result = false;

    //        string currentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    //        string modelsFolderPath = Path.Combine(currentDirectory, "Models");

    //        string tableName = args[0];
    //        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

    //        using (var context = new EF6(connectionString))
    //        {
    //            // 테이블 구조 읽어오기
    //            var tableSchemas = context.TableSchemas.ToList();

    //            // 각 테이블에 대해 모델 클래스 생성
    //            foreach (var tableSchema in tableSchemas)
    //            {
    //                var modelClass = GenerateModelClass(tableSchema.TableName, tableSchema.ColumnName, tableSchema.DataType);

    //                // 모델 클래스를 파일로 저장
    //                result = SaveModelClassToFile(modelClass, $"{tableSchema.TableName}ViewModel.cs", modelsFolderPath);
    //            }
    //        }

    //        return result;
    //    }

    //    static string GenerateModelClass(string tableName, string columnName, string dataType)
    //    {
    //        var sb = new StringBuilder();

    //        sb.AppendLine($"public class {tableName}");
    //        sb.AppendLine("{");
    //        sb.AppendLine($"    public {GetCSharpType(dataType)} {columnName} {{ get; set; }}");
    //        sb.AppendLine("}");

    //        return sb.ToString();
    //    }

    //    static string GetCSharpType(string dataType)
    //    {
    //        switch (dataType)
    //        {
    //            case "int":
    //                return "int";
    //            case "varchar":
    //                return "string";
    //            case "datetime":
    //                return "DateTime";
    //            case "blob":
    //                return "byte[]";
    //            default:
    //                return "object";
    //        }
    //    }

    //    static bool SaveModelClassToFile(string modelClass, string fileName, string folderPath)
    //    {
    //        bool result = false;

    //        // 폴더가 없으면 폴더를 생성
    //        if (!Directory.Exists(folderPath))
    //        {
    //            Directory.CreateDirectory(folderPath);
    //        }

    //        string filePath = Path.Combine(folderPath, fileName);
    //        File.WriteAllText(filePath, modelClass);

    //        if (File.Exists(filePath)) result = true;
    //        else result = false;

    //        return result;
    //    }
    }

    //public class TableSchema
    //{
    //    public int Id { get; set; }
    //    public string TableName { get; set; }
    //    public string ColumnName { get; set; }
    //    public string DataType { get; set; }
    //}
}
