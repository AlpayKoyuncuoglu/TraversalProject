using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfFeatureSecondDal:GenericRepository<FeatureSecond>,IFeatureSecondDal
    {
    }
}
