using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;

namespace NetSatis.Entities.DataAccess
{
    public class StokHareketDAL : EntityRepositoryBase<NetSatisContext, StokHareket, StokHareketValidator>
    {
    }
}