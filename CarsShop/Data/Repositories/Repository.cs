namespace CarsShop.Data.Repositories;

public class Repository<TEntity>(CarsDbContext database)
             : IRepository<TEntity> where TEntity : BaseEntity
{
    private readonly CarsDbContext _database = database;
    private readonly DbSet<TEntity> _dbSet = database.Set<TEntity>();
    public void Add(TEntity entity)
    {
        _dbSet.Add(entity);
        _database.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = _dbSet.FirstOrDefault(x => x.Id == id)!;
        _dbSet.Remove(entity);
        _database.SaveChanges();
    }

    public List<TEntity> GetAll()
    {
        var entities = _dbSet.ToList();
        return entities;
    }

    public TEntity GetById(int id)
    {
        var entity = _dbSet.FirstOrDefault(x=>x.Id== id);
        return entity!;
    }

    public void Update(TEntity entity)
    {
        _dbSet.Update(entity);
        _database.SaveChanges();
    }
}


