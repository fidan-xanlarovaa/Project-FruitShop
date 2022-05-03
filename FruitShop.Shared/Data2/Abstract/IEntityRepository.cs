using FruitShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Shared.Data
{
         //Genericlerin Constreitleri:
        //Where T :struct (value type olmalidir),Where T:class  (reference type olmalidir) , Where T: new() (T default ctor parametrsiz olmalidir) ,
        //Where T : interfacename(Timpliment edilmis olmalidir)
 
    public interface IEntityRepository<T> where T : class, IEntity, new()
                                          //Generic sekilde yazmaq kodumuzu dinamiklesdirir, kod tekrarinin qarsisisni almis oluruq
                                          //Repository nedir? Crud emeliyyatlarimiz olan hisse
                                          //Bunu generic yartmaqimizda meqsed eyni emeliyyatlari tekrar tekrar yazmamaqdi(Getall delete Update add ve s. kimi)
                                          //Bir nov bu da Repositorilerin basesidir
    {
        //Epression<Func<T, bool>> predicate ==== i=>i.Name=name

        //params Expression<Func<T, object>>[] includeProperties === bu joinlerimiz ucundu
        //select * from post p
        //left join comment c on p.id=c.PostId (params yazmaqimizin meqsedi meselen commenti useri includ ele demek ucundu)
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);//asqida predicate=null
         //yazmisiq cunki burda hec bir sert vermeden de datalari getire bilerik amma Get de cemi 1 data gelir deye mecburuq ki data verek id filan ve ya namesi filan
         //olan


        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties); 


        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate); //i.id==4 ___ netice olaraq bize ya True yada false qaytaracaq
        Task<int> CountAsync(Expression<Func<T, bool>> predicate=null); //i.language=="english" ___ Bu da bize say qaytarir

        // crud
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}

/*Async----Asinxron proqramlasdirma
 
 I/O bound-- burda ise network karti, harddisk(hdd),ssd yer alir
 CPU bound--bu prosessordur

 bizim computerde xirda bir clicimiz emeliiyatimiz  bir Task-dir.

 biz request atanda hardware seviyyesende o request ilk once  bizim network kartimizda islenir

 thread-tasklari yerine yetirendi
 
 */