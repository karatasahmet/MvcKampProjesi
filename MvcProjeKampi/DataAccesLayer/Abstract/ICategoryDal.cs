using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
   public interface ICategoryDal:IRepository<Category>
    {


        ////CRUD
        ////Listeleme
        //List<Category> List();

        ////Ekleme - değer döndermeyeceğinden viod kullanılır.
        //void Insert(Category p);

        ////Güncelleme
        //void Update(Category p);

        ////Silme
        //void Delete(Category p);
    }
}
