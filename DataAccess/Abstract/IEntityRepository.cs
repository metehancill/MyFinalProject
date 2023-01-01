using System;
using System.Linq.Expressions;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    //generic constraint generic kısıtlaması
    //class: referans tip olabilir anlamına gelir.
    //IENtitiy :Ientity olabilir veya Ientity implemnt eden bir nesne olabilir anlmına gelir.
	public interface IEntityRepository<T> where T :class,IEntity,new()
	{
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //Predickets
        T Get(Expression<Func<T, bool>> filter);
        void All(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}

