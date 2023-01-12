using Core.Entities;
using System;
using System.Linq.Expressions;



namespace Core.DataAccess //core evrensel katmandır. Core kimseye bağımlı değildir.
{
    //generic constraint generic kısıtlaması
    //class: referans tip olabilir anlamına gelir.
    //IEntitiy :Ientity olabilir veya Ientity implemnt eden bir nesne olabilir anlmına gelir.

    public interface IEntityRepository<T> where T : class, IEntity, new()
	{
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //Predickets
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}

