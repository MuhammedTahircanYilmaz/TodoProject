using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProject.Model;

namespace TodoProject.Repository;

public interface IRepository<TEntity> // <TEntity> yerine koyulan objectler bu interface'i implement eden sınıf ve interfacelerde belirtilerek otomatik olarak koyulur. Aynı functions kullanılan interfacelerde ortak kullanılabilir
    where TEntity : class, new() // TEntity bir sınıf olmak zorunda ve aynı zamanda new lenebilen bir obje olmak zorunda 
{
    List<TEntity> GetAll();

    TEntity GetById(int id);

    TEntity Add(TEntity user);

    TEntity Update(TEntity user);

    TEntity Delete(TEntity user);
}
