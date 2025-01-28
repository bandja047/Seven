using Microsoft.AspNetCore.Mvc;

namespace MotherStoreApi.Controllers
{
    public class BaseController<TEntity,TRepository> : ControllerBase
    {
    }
}
