using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyBlogTask1.Models
{
    public class ArticleContext: DbContext
    {
        public DbSet<Article> Articles { get; set; }

        public DbSet<Review> Reviews { get; set; }
    }
    public class ArticleDbInitializer : DropCreateDatabaseAlways<ArticleContext>
    {
        protected override void Seed(ArticleContext db)
        {
            db.Articles.Add(new Article { Aname="Неприхотливые суккуленты", Adate= new DateTime(2019, 01, 06) , Atext= "Растения, которые входят в группу, объединяемую термином «суккуленты», не связаны между собой общим происхождением, их схожие черты вызваны схожими условиями обитания. Суккуленты есть даже среди таких семейств, как ароидные (замиокулькас), бромелиевые (диккия), виноградовые (циссус четырёхугольный)." });
            db.Articles.Add(new Article { Aname = "Флора Карпат", Adate = new DateTime(2019, 02 , 09), Atext = "Флористичне розмаїття Українських Карпат налічує більше 2000 видів рослин, серед яких багато реліктів, що збереглися тут з минулих геологічних епох. Серед них є багато ендеміків, які ростуть лише в цьому регіоні, альпійських та аркто-альпійських видів, а також рідкісні види представників флори, що занесені до Червоної книги України." });
            db.Reviews.Add(new Review { Rname = "Тарас", Rdate = new DateTime(2019, 01, 20), Rtext = "Классный блог!" });
            db.Reviews.Add(new Review { Rname = "Павел", Rdate = new DateTime(2019, 05, 02), Rtext = "Очень много полезной информации." });

            base.Seed(db);
        }
    }
}