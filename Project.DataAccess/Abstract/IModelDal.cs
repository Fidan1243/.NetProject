using Project.Core.DataAccess;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.DataAccess.Abstract
{
    public class IModelDal: IEntityRepository<Models>
    {
    }
}
