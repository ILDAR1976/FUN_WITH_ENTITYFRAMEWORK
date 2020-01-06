namespace Library.DataModel
{
    using System;
    using System.Linq;
    using System.Text;
    using MySql.Data.Entity;
    using System.Data.Entity;
    using System.Threading.Tasks;



    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class LibraryModel : DbContext
    {
        // Контекст настроен для использования строки подключения "LibraryModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Library.LibraryModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "LibraryModel" 
        // в файле конфигурации приложения.
        public LibraryModel()
            : base("name=LibraryModel")
        {
        }

        public virtual DbSet<Book> Books { get; set; }

    }

    
}