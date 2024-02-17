using AutoMapper;

namespace JWTProject.Service.Mapping
{
    /// <summary>
    /// Memory'e hemen yüklenip gereksiz yer tutmaması amacıyla bu şekilde yazdık.
    /// </summary>
    public static class ObjectMapper
    {
        private static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DtoMapper>();
            });
            return config.CreateMapper();
        });
        public static IMapper Mapper => lazy.Value;
    }
}
